using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Business.Entity
{
    public class DetallePedido
    {
        public int DetallePedidoId { get; set; }

        public int PedidoId { get; set; }

        public int PastelId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public Pastel Pastel { get; set; }

        public Pedido Pedido { get; set; }
    }
}
