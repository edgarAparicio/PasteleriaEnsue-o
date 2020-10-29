using EdgarAparicio.PastelesYummy.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
   public interface IPastel
    {
        IEnumerable<Pastel> ObtenerListaPasteles { get; }
        IEnumerable<Pastel> ObtenerListaPastelesSemana { get; }
        Pastel ObtenerPastelPorId(int idPastel);
    }
}
