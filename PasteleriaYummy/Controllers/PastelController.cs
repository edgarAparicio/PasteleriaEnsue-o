using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Business.Entity.ViewModels;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;

namespace PasteleriaYummy.Controllers
{
    public class PastelController : Controller
    {
        private readonly IPastel pastelRepositorio;
        private readonly ICategoria categoriaRepositorio;

        public PastelController(IPastel pastel, ICategoria categoria)
        {
            pastelRepositorio = pastel;
            categoriaRepositorio = categoria;
        }

        //public IPastel Pastel { get; }
        //public ICategoria Categoria { get; }

        public ViewResult MostrarListaPasteles()
        {
            //ViewBag.CategoriaActual = "Pasteles de Queso";
            //return View(pastelRepositorio.ObtenerListaPasteles);

            //Para no pasar un viewbag y un obtenerlistaPasteles, se creo una entidad de vista ViewModel llamado ListaPastelesViewModel
            //que contiene las propiedades que se quieren mostar y ahora en la vista ya no espera una entidad pastel sino una listaPastelesViewModel

            ListaPastelesViewModels listaPastelesViewModel = new ListaPastelesViewModels();
            listaPastelesViewModel.Pasteles = pastelRepositorio.ObtenerListaPasteles;
            listaPastelesViewModel.CategoriaActual = "Pasteles de Queso";
            return View(listaPastelesViewModel);


        }
    }
}
