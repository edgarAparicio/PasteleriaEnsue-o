using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Business.Entity
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNombre { get; set; }
        public string Descripcion { get; set; }
        public List<Pastel> Pasteles { get; set; }


    }
}
