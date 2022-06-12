using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetasController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Receta> Get()
        {
            var recetasList = new List<Receta>();
            var recetas = new RecetasRepository();
            recetasList.Add(recetas.Yogurtconfrutas());
            recetasList.Add(recetas.ensalada());
            recetasList.Add(recetas.PancakesdeManzana());
            recetasList.Add(recetas.Polloalhornoconpatatas());
            recetasList.Add(recetas.Lomitoderesrelleno());
            recetasList.Add(recetas.ensaladaDeLentejas());
            recetasList.Add(recetas.ensaladaDebrocoliConPollo());
            recetasList.Add(recetas.Pancakesketo());
            recetasList.Add(recetas.TortitasconEspinacasyQueso());
            recetasList.Add(recetas.Arrozintegralconleche());
            recetasList.Add(recetas.Merluzacongambas());
            recetasList.Add(recetas.Merluzaalaplancha());
            recetasList.Add(recetas.Arrozintegralconverduras());
            return recetasList;
        }
    }
}
