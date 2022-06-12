using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class RutinasRepostory
    {
        public Rutina abdominales()
        {
            var rutina = new Rutina();
            var ejericios =new Ejercicios();

            rutina.nombre = "Abdominales";
            rutina.image = "https://coolhouse.life/wp-content/uploads/2021/12/abdominales1.png";
            rutina.ejercicios = ejericios.abdominales();
            rutina.calorias = "150";
            rutina.duracion = "6";

            return rutina;
        }

        public Rutina pecho()
        {
            var rutina = new Rutina();
            var ejericios = new Ejercicios();

            rutina.nombre = "Pecho";
            rutina.image = "https://coolhouse.life/wp-content/uploads/2021/12/pecho.png";
            rutina.ejercicios = ejericios.pecho();
            rutina.calorias = "250";
            rutina.duracion = "15";

            return rutina;
        }

        public Rutina brazos()
        {
            var rutina = new Rutina();
            var ejericios = new Ejercicios();

            rutina.nombre = "Brazos";
            rutina.image = "https://coolhouse.life/wp-content/uploads/2021/12/brazo.png";
            rutina.ejercicios = ejericios.brazos();
            rutina.calorias = "350";
            rutina.duracion = "25";

            return rutina;
        }

        public Rutina piernas()
        {
            var rutina = new Rutina();
            var ejericios = new Ejercicios();

            rutina.nombre = "Piernas";
            rutina.image = "https://coolhouse.life/wp-content/uploads/2021/12/piernas.png";
            rutina.ejercicios = ejericios.piernas();
            rutina.calorias = "450";
            rutina.duracion = "20";

            return rutina;
        }
    }
}
