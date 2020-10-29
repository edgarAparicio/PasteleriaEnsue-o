using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Business.Entity.ViewModels;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;

namespace PasteleriaYummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPastel pastelRepositorio;
        public HomeController(IPastel pastel)
        {
            pastelRepositorio = pastel;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PastelesSemana = pastelRepositorio.ObtenerListaPastelesSemana
            };

            return View(homeViewModel);
        }
    }
}
