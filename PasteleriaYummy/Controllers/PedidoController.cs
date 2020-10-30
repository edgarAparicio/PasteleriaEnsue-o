using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Business.Entity;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;

namespace PasteleriaYummy.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedido pedidoRepositorio;
        private readonly DataCarritoCompras carritoComprasRepositorio;

        public PedidoController(IPedido pedido, DataCarritoCompras carritoCompras)
        {
            this.pedidoRepositorio = pedido;
            carritoComprasRepositorio = carritoCompras;
        }
        
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            var items = carritoComprasRepositorio.ObtenerListaArticulosCarritoCompras();
            carritoComprasRepositorio.ListaArticulosCarritoCompras = items;
            if (carritoComprasRepositorio.ListaArticulosCarritoCompras.Count == 0)
            {
                ModelState.AddModelError("", "Tu carrito esta vacio, agrega algunos pasteles");
            }

            if (ModelState.IsValid)
            {
                pedidoRepositorio.CrearPedido(pedido);
                carritoComprasRepositorio.LimpiarCarrito();
                return RedirectToAction("CheckoutCompleto");
            }
            return View(pedido);
        }

        public IActionResult CheckoutCompleto()
        {
            ViewBag.CheckoutCompletoMensaje = "Gracias por tu compra, que disfrutes de los deliciosos pasteles!";
            return View();
        }

    }
}
