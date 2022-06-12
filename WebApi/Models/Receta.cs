using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Receta
    {
       public string nombre { get; set; }
       public string image { get; set; }
       public string temPreparacion { get; set; }
       public string porciones { get; set; }
       public string calorias { get; set; }
       public IEnumerable<string> ingredientes { get; set; }
       public IEnumerable<string> instrucciones { get; set; }
       public string categoria { get; set; }

    }
}
