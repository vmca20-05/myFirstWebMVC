using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstWebApplication.Models
{
    public class Pais
    {
        public Pais() { }

        public Pais(string pNombre)
        {
            this.Nombre = pNombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
