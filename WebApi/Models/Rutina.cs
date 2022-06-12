using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Rutina
    {
        public string nombre { get; set; }
        public string image { get; set; }
        public IEnumerable<Ejercicio> ejercicios { get; set; }
        public string calorias { get; set; }
        public string duracion { get; set; }
    }
}
