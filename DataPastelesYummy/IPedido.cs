using EdgarAparicio.PastelesYummy.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public interface IPedido
    {
        void CrearPedido(Pedido pedido);
    }
}
