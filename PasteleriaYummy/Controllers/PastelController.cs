using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Business.Entity;
using EdgarAparicio.PastelesYummy.Business.Entity.ViewModels;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

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


        //Se define de mejor manera en el siguiente metodo que ya incluye dropdownlist
        //public ViewResult MostrarListaPasteles()
        //{
        //    //ViewBag.CategoriaActual = "Pasteles de Queso";
        //    //return View(pastelRepositorio.ObtenerListaPasteles);

        //    //Para no pasar un viewbag y un obtenerlistaPasteles, se creo una entidad de vista ViewModel llamado ListaPastelesViewModel
        //    //que contiene las propiedades que se quieren mostar y ahora en la vista ya no espera una entidad pastel sino una listaPastelesViewModel

        //    ListaPastelesViewModels listaPastelesViewModel = new ListaPastelesViewModels();
        //    listaPastelesViewModel.Pasteles = pastelRepositorio.ObtenerListaPasteles;
        //    listaPastelesViewModel.CategoriaActual = "Pasteles de Queso";
        //    return View(listaPastelesViewModel);
        //}

        public ViewResult MostrarListaPasteles(string categoriaNombre)
        {
            IEnumerable<Pastel> listaPasteles;
            string categoriaActual;
            if (string.IsNullOrEmpty(categoriaNombre))
            {
                listaPasteles = pastelRepositorio.ObtenerListaPasteles.OrderBy(o => o.PastelId);
                categoriaActual = "Todos los pasteles";
            }
            else
            {
                listaPasteles = pastelRepositorio.ObtenerListaPasteles
                    .Where(p => p.Categoria.CategoriaNombre == categoriaNombre)
                    .OrderBy(o => o.PastelId);
                categoriaActual = categoriaRepositorio.ObtenerListaCategorias
                    .FirstOrDefault(c => c.CategoriaNombre == categoriaNombre)
                    ?.CategoriaNombre;
            }

            //var listaPastelesViewModel = new ListaPastelesViewModels
            //{
            //    Pasteles = listaPasteles,
            //    CategoriaActual = categoriaActual
            //};
            return View(
                new ListaPastelesViewModels
                {
                    Pasteles = listaPasteles,
                    CategoriaActual= categoriaActual
                });
        }




        public IActionResult Detalles(int id)
        {
            var pastel = pastelRepositorio.ObtenerPastelPorId(id);
            if (pastel == null)
                return NotFound();
            return View(pastel);
        }
    }
}
