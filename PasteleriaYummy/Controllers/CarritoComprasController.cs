using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PasteleriaYummy.ViewModels;

namespace PasteleriaYummy.Controllers
{
    [Authorize]
    public class CarritoComprasController : Controller
    {
        private readonly IPastel pastelRepositorio;
        private readonly DataCarritoCompras carritoComprasRepositorio;
        public CarritoComprasController(IPastel pastel, DataCarritoCompras carritoCompras)
        {
            pastelRepositorio = pastel;
            carritoComprasRepositorio = carritoCompras;
        }

        public ViewResult Index()
        {
            var articulos = carritoComprasRepositorio.ObtenerListaArticulosCarritoCompras();
            carritoComprasRepositorio.ListaArticulosCarritoCompras = articulos;

            var carritoComprasViewModel = new CarritoComprasViewModel
            {
                DataCarritoCompras = carritoComprasRepositorio,
                TotalCarritoCompras = carritoComprasRepositorio.ObtenerTotalCarritoCompras()
            };

            return View(carritoComprasViewModel);
        }

        public RedirectToActionResult AgregarArticuloCarritoCompras(int idPastel)
        {
            var pastelSeleccionado = pastelRepositorio.ObtenerListaPasteles.FirstOrDefault(p => p.PastelId == idPastel);
            if(pastelSeleccionado != null)
            {
                carritoComprasRepositorio.AgregarAlCarrito(pastelSeleccionado, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RetirarArticuloCarritoCompras(int idPastel)
        {
            var pastelSeleccionado = pastelRepositorio.ObtenerListaPasteles.FirstOrDefault(p => p.PastelId == idPastel);
            if(pastelSeleccionado != null)
            {
                carritoComprasRepositorio.RetirarDeCarrito(pastelSeleccionado);
            }
            return RedirectToAction("Index");
        }

    }
}
