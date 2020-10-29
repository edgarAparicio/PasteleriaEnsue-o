using EdgarAparicio.PastelesYummy.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class SimuladorRepositorioCategoria : ICategoria
    {
        public IEnumerable<Categoria> ObtenerListaCategorias =>
            new List<Categoria>
            {
                new Categoria{CategoriaId=1, CategoriaNombre="Fruit pies", Descripcion="All-fruity pies"},
                new Categoria{CategoriaId=2, CategoriaNombre="Cheese cakes", Descripcion="Cheesy all the way"},
                new Categoria{CategoriaId=3, CategoriaNombre="Seasonal pies", Descripcion="Get in the mood for a seasonal pie"}
            };
    }
}
