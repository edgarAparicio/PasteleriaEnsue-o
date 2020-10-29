using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Business.Entity
{
    public class Pastel
    {
        public int PastelId { get; set; }
        public string Nombre { get; set; }
        public string DescripcionCorta { get; set; }
        public string DescripcionLarga { get; set; }
        public string InformacionAllergy { get; set; }
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
        public string ImagenThumbnailUrl { get; set; }
        public bool PastelSemana { get; set; }
        public bool EnStock { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
