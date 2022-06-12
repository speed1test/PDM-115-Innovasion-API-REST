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
    public class RutinasController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Rutina> Get()
        {
            var rutinasList = new List<Rutina>();
            var rutinas = new RutinasRepostory();
            rutinasList.Add(rutinas.abdominales());
            rutinasList.Add(rutinas.pecho());
            rutinasList.Add(rutinas.brazos());
            rutinasList.Add(rutinas.piernas());
            return rutinasList;
        }
    }
}
