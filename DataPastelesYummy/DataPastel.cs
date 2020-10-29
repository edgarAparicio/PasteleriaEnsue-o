using EdgarAparicio.PastelesYummy.Business.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class DataPastel : IPastel
    {
        private readonly DbContextPasteleriaYummy db;
        public DataPastel(DbContextPasteleriaYummy dbContextPasteleriaYummy)
        {
            db = dbContextPasteleriaYummy;
        }

        public IEnumerable<Pastel> ObtenerListaPasteles 
        {
            get
            {
                return db.Pasteles.Include(p => p.Categoria);
            }
        }

        public IEnumerable<Pastel> ObtenerListaPastelesSemana 
        {
            get
            {
                return db.Pasteles.Include(p => p.Categoria)
                    .Where(c => c.PastelSemana);
            }            
        }

        public Pastel ObtenerPastelPorId(int idPastel)
        {
            return db.Pasteles.FirstOrDefault(p => p.PastelId == idPastel);
        }
    }
}
