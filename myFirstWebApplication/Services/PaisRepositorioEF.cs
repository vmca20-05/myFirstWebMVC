using myFirstWebApplication.Data;
using myFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstWebApplication.Services
{
    public class PaisRepositorioEF : IPaisRepositorio
    {
        public PaisRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public List<Pais> ObtenerTodos()
        {
            return DbContext.Paises.ToList();
        }
    }
}
