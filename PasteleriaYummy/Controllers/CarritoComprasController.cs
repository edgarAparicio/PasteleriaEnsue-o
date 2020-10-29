using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;

namespace PasteleriaYummy.Controllers
{
    public class CarritoComprasController : Controller
    {
        private readonly IPastel pastelRepositorio;
        private readonly DataCarritoCompras carritoComprasRepositorio;
        public CarritoComprasController(IPastel pastel, DataCarritoCompras carritoCompras)
        {
            pastelRepositorio = pastel;
            carritoComprasRepositorio = carritoCompras;
        }

        //public ViewResult Index()
        //{
        //    var articulos = carritoComprasRepositorio.ObtenerListaArticulosCarritoCompras();
        //    carritoComprasRepositorio.ListaArticulosCarritoCompras = articulos;

        //    var carritoComprasViewModel = new CarritoComprasViewModel
        //    {

        //    };



        //}
    }
}
