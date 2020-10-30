using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasteleriaYummy.Components
{
    public class CategoriaPastelMenu : ViewComponent
    {
        private readonly ICategoria categoriaRepositorio;
        public CategoriaPastelMenu(ICategoria categoria)
        {
            categoriaRepositorio = categoria;
        }

        public IViewComponentResult Invoke()
        {
            var dropDownListCategorias = categoriaRepositorio.ObtenerListaCategorias.OrderBy(o => o.CategoriaNombre);
            return View(dropDownListCategorias);
        }

    }
}
