using EdgarAparicio.PastelesYummy.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class DataPedido : IPedido
    {
        private readonly DbContextPasteleriaYummy db;
        private readonly DataCarritoCompras dataCarritoCompras;
        public DataPedido(DbContextPasteleriaYummy dbcontextPasteleriaYummy, DataCarritoCompras carritoCompras)
        {
            db = dbcontextPasteleriaYummy;
            dataCarritoCompras = carritoCompras;

        }

        public void CrearPedido(Pedido pedido)
        {
            pedido.PedidoEntregado = DateTime.Now;

            var articulosCarritoCompras = dataCarritoCompras.ListaArticulosCarritoCompras;
            pedido.PedidoTotal = dataCarritoCompras.ObtenerTotalCarritoCompras();

            pedido.DetallePedido = new List<DetallePedido>();

            foreach (var item in articulosCarritoCompras)
            {
                var detallePedido = new DetallePedido
                {
                    Cantidad = item.Cantidad,
                    PastelId = item.Pastel.PastelId,
                    Precio = item.Pastel.Precio
                };

                pedido.DetallePedido.Add(detallePedido);
            }

            db.Pedidos.Add(pedido);
            db.SaveChanges();

        }
    }
}
