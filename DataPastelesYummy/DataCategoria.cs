using EdgarAparicio.PastelesYummy.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class DataCategoria : ICategoria
    {
        private readonly DbContextPasteleriaYummy db;
        public DataCategoria(DbContextPasteleriaYummy dbContextPasteleriaYummy)
        {
            db = dbContextPasteleriaYummy;
        }

        public IEnumerable<Categoria> ObtenerListaCategorias => db.Categorias;
    }
}
