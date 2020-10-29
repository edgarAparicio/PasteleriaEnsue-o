using EdgarAparicio.PastelesYummy.Business.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class DataCarritoCompras
    {
        private readonly DbContextPasteleriaYummy db;

        public string IdCarritoCompras { get; set; }

        public List<ArticuloCarritoCompras> ListaArticulosCarritoCompras { get; set; }
        public DataCarritoCompras(DbContextPasteleriaYummy dbContextPasteleriaYummy)
        {
            db = dbContextPasteleriaYummy;
        }


        public static DataCarritoCompras MostrarCarrito(IServiceProvider proveedorServicios)
        {
            ISession sesion = proveedorServicios.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = proveedorServicios.GetService<DbContextPasteleriaYummy>();

            string idCarrito = sesion.GetString("IdCarrito")
                ?? Guid.NewGuid().ToString();

            sesion.SetString("IdCarrito", idCarrito);

            return new DataCarritoCompras(context) { IdCarritoCompras = idCarrito };
        }

        public void AgregarAlCarrito(Pastel pastel, int cantidad)
        {
            var articulo = db.ArticulosCarritoCompras.SingleOrDefault(
                s => s.Pastel.PastelId == pastel.PastelId && s.CarritoComprasId == IdCarritoCompras);

            if (articulo == null)
            {
                articulo = new ArticuloCarritoCompras
                {
                    CarritoComprasId = IdCarritoCompras,
                    Pastel = pastel,
                    Cantidad = 1
                };
                db.ArticulosCarritoCompras.Add(articulo);
            }
            else
            {
                articulo.Cantidad++;
            }
            db.SaveChanges();
        }

        public int RetirarDeCarrito(Pastel pastel)
        {
            var articulo = db.ArticulosCarritoCompras.SingleOrDefault(
                s => s.Pastel.PastelId == pastel.PastelId && s.CarritoComprasId == IdCarritoCompras);

            var cantidadLocal = 0;

            if(articulo != null)
            {
                if(articulo.Cantidad > 1)
                {
                    articulo.Cantidad--;
                    cantidadLocal = articulo.Cantidad;
                }
                else
                {
                    db.ArticulosCarritoCompras.Remove(articulo);
                }
            }
            db.SaveChanges();
            return cantidadLocal;
        }

        public List<ArticuloCarritoCompras> ObtenerListaArticulosCarritoCompras()
        {
            return ListaArticulosCarritoCompras ?? (ListaArticulosCarritoCompras = db.ArticulosCarritoCompras
                .Where(c => c.CarritoComprasId == IdCarritoCompras)
                .Include(s => s.Pastel)
                .ToList());
        }

        public void LimpiarCarrito()
        {
            var articulosCarrito = db.ArticulosCarritoCompras.Where(c => c.CarritoComprasId == IdCarritoCompras);
            db.ArticulosCarritoCompras.RemoveRange(articulosCarrito);
            db.SaveChanges();
        }

        public decimal ObtenerTotalCarritoCompras()
        {
            var total = db.ArticulosCarritoCompras.
                Where(c => c.CarritoComprasId == IdCarritoCompras)
                .Select(s => s.Pastel.Precio * s.Cantidad)
                .Sum();
            return total;
        }



    }
}
