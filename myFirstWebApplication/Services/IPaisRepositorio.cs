using myFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstWebApplication.Services
{
    public interface IPaisRepositorio
    {
      List<Pais> ObtenerTodos();
    }
}
