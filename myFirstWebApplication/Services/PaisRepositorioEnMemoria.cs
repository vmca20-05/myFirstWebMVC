using myFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstWebApplication.Services
{
    public class PaisRepositorioEnMemoria : IPaisRepositorio
    {

        public List<Pais> ObtenerTodos()
        {
            List<Pais> paises = new List<Pais>() {
                new Pais("Canada"),
                new Pais("Estados Unidos"),
                new Pais("Rusia"),
                new Pais("Japon")};

            return paises;
        }

    }
}
