using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Ejercicio
    {
        public string nombre { get; set; }
        public string repeticiones { get; set; }
        public string animacion { get; set; }
        public bool isCompleted { get; set; }
        public bool isSeleted { get; set; }
    }
}
