using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Business.Entity
{
    public class ArticuloCarritoCompras
    {
        public int ArticuloCarritoComprasId { get; set; }

        public Pastel Pastel { get; set; }

        public int Cantidad { get; set; }

        public string CarritoComprasId { get; set; }
    }
}
