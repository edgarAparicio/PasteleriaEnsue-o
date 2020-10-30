using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;
using PasteleriaYummy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasteleriaYummy.Components
{
    public class ResumenTotalCarritoCompras : ViewComponent
    {
        private readonly DataCarritoCompras carritoComprasRepositorio;
        public ResumenTotalCarritoCompras(DataCarritoCompras carritoCompras)
        {
            carritoComprasRepositorio = carritoCompras;
        }

        public IViewComponentResult Invoke()
        {
            var ListaArticulos = carritoComprasRepositorio.ObtenerListaArticulosCarritoCompras();
            carritoComprasRepositorio.ListaArticulosCarritoCompras = ListaArticulos;

            var carritoComprasViewModel = new CarritoComprasViewModel
            {
                DataCarritoCompras = carritoComprasRepositorio,
                TotalCarritoCompras = carritoComprasRepositorio.ObtenerTotalCarritoCompras()
            };
            return View(carritoComprasViewModel);
        }

    }
}
