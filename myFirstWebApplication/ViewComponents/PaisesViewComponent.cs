using Microsoft.AspNetCore.Mvc;
using myFirstWebApplication.Models;
using myFirstWebApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstWebApplication.ViewComponents
{
    public class PaisesViewComponent:ViewComponent
    {
        public PaisesViewComponent(IPaisRepositorio repositorioPais) {

            RepositorioPais = repositorioPais;
        }

        public IPaisRepositorio RepositorioPais { get; }

        public IViewComponentResult Invoke() {

            List<Pais> paises = RepositorioPais.ObtenerTodos();

            return View(paises);
        }
    }
}
