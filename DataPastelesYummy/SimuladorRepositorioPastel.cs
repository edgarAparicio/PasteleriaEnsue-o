using EdgarAparicio.PastelesYummy.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class SimuladorRepositorioPastel : IPastel
    {
        private readonly SimuladorRepositorioCategoria categoriaRepositorio = new SimuladorRepositorioCategoria();
        public IEnumerable<Pastel> ObtenerListaPasteles =>

            new List<Pastel>
            {
                new Pastel {PastelId = 1, Nombre="Strawberry Pie", Precio=15.95M, DescripcionCorta="Lorem Ipsum", DescripcionLarga="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Categoria = categoriaRepositorio.ObtenerListaCategorias.ToList()[0],ImagenUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", EnStock=true, PastelSemana=false, ImagenThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                new Pastel {PastelId = 2, Nombre="Cheese cake", Precio=18.95M, DescripcionCorta="Lorem Ipsum", DescripcionLarga="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Categoria = categoriaRepositorio.ObtenerListaCategorias.ToList()[1],ImagenUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", EnStock=true, PastelSemana=false, ImagenThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Pastel { PastelId = 3, Nombre = "Rhubarb Pie", Precio = 15.95M, DescripcionCorta = "Lorem Ipsum", DescripcionLarga = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Categoria = categoriaRepositorio.ObtenerListaCategorias.ToList()[0], ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", EnStock = true, PastelSemana = true, ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" },
                new Pastel { PastelId = 4, Nombre = "Pumpkin Pie", Precio = 12.95M, DescripcionCorta = "Lorem Ipsum", DescripcionLarga = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Categoria = categoriaRepositorio.ObtenerListaCategorias.ToList()[2], ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", EnStock = true, PastelSemana = true, ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" }
            };

        public IEnumerable<Pastel> ObtenerListaPastelesSemana { get; }

        public Pastel ObtenerPastelPorId(int idPastel)
        {
            return ObtenerListaPasteles.FirstOrDefault(p => p.PastelId == idPastel);
        }
    }
}
