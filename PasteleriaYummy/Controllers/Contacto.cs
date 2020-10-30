using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PasteleriaYummy.Controllers
{
    public class Contacto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
