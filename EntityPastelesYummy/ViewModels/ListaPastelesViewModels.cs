using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Business.Entity.ViewModels
{
    public class ListaPastelesViewModels
    {
        public IEnumerable<Pastel> Pasteles { get; set; }

        public string CategoriaActual { get; set; }
    }
}
