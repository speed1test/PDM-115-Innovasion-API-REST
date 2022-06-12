using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class Ejercicios
    {
        public IEnumerable<Ejercicio> abdominales()
        {
            var ejerciciosList = new List<Ejercicio>();
            var ejercicio1 = new Ejercicio();
            var ejercicio2 = new Ejercicio();
            var ejercicio3 = new Ejercicio();
            var ejercicio4 = new Ejercicio();
            var ejercicio5 = new Ejercicio();
            var ejercicio6 = new Ejercicio();
            var ejercicio7 = new Ejercicio();
            var ejercicio8 = new Ejercicio();

            ejercicio1.nombre = "Saltos de tijeras";
            ejercicio1.repeticiones = "00:20";
            ejercicio1.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/saltode.json";
            ejercicio1.isCompleted = false;
            ejercicio1.isSeleted = false;
            ejerciciosList.Add(ejercicio1);

            ejercicio2.nombre = "Crunch Abdominales";
            ejercicio2.repeticiones = "x16";
            ejercicio2.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/crunch_abdominales.json";
            ejercicio2.isCompleted = false;
            ejercicio2.isSeleted = false;
            ejerciciosList.Add(ejercicio2);

            ejercicio3.nombre = "Twist Ruso";
            ejercicio3.repeticiones = "x20";
            ejercicio3.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/twist_ruso.json";
            ejercicio3.isCompleted = false;
            ejercicio3.isSeleted = false;
            ejerciciosList.Add(ejercicio3);

            ejercicio4.nombre = "Escalada de montaña";
            ejercicio4.repeticiones = "x16";
            ejercicio4.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/escalada.json";
            ejercicio4.isCompleted = false;
            ejercicio4.isSeleted = false;
            ejerciciosList.Add(ejercicio4);

            ejercicio5.nombre = "Elevaciones de Piernas";
            ejercicio5.repeticiones = "x16";
            ejercicio5.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/elevaciones_de_piernas.json";
            ejercicio5.isCompleted = false;
            ejercicio5.isSeleted = false;
            ejerciciosList.Add(ejercicio5);

            ejercicio6.nombre = "Toque al Talon";
            ejercicio6.repeticiones = "x20";
            ejercicio6.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/toque_al_talon.json";
            ejercicio6.isCompleted = false;
            ejercicio6.isSeleted = false;
            ejerciciosList.Add(ejercicio6);

            ejercicio7.nombre = "Tablon";
            ejercicio7.repeticiones = "00:20";
            ejercicio7.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/tablon.json";
            ejercicio7.isCompleted = false;
            ejercicio7.isSeleted = false;
            ejerciciosList.Add(ejercicio7);

            ejercicio8.nombre = "Estiramiento de cobra";
            ejercicio8.repeticiones = "00:30";
            ejercicio8.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/esterinamiento_de_cobra.json";
            ejercicio8.isCompleted = false;
            ejercicio8.isSeleted = false;
            ejerciciosList.Add(ejercicio8);

            return ejerciciosList;
        }
        public IEnumerable<Ejercicio> pecho()
        {
            var ejerciciosList = new List<Ejercicio>();
            var ejercicio1 = new Ejercicio();
            var ejercicio2 = new Ejercicio();
            var ejercicio3 = new Ejercicio();
            var ejercicio4 = new Ejercicio();
            var ejercicio5 = new Ejercicio();
            var ejercicio6 = new Ejercicio();
            var ejercicio7 = new Ejercicio();
            var ejercicio8 = new Ejercicio();
            var ejercicio9 = new Ejercicio();

            ejercicio1.nombre = "Saltos de tijeras";
            ejercicio1.repeticiones = "00:30";
            ejercicio1.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/saltode.json";
            ejercicio1.isCompleted = false;
            ejercicio1.isSeleted = false;
            ejerciciosList.Add(ejercicio1);

            ejercicio2.nombre = "Flexiones con Inclinacion";
            ejercicio2.repeticiones = "x6";
            ejercicio2.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_con_inclinacion.json";
            ejercicio2.isCompleted = false;
            ejercicio2.isSeleted = false;
            ejerciciosList.Add(ejercicio2);

            ejercicio3.nombre = "Flexiones";
            ejercicio3.repeticiones = "x4";
            ejercicio3.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones.json";
            ejercicio3.isCompleted = false;
            ejercicio3.isSeleted = false;
            ejerciciosList.Add(ejercicio3);

            ejercicio4.nombre = "Flexiones con Brazos Abiertos";
            ejercicio4.repeticiones = "x4";
            ejercicio4.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_con_brazos_abiertos.json";
            ejercicio4.isCompleted = false;
            ejercicio4.isSeleted = false;
            ejerciciosList.Add(ejercicio4);

            ejercicio5.nombre = "Flexiones con Inclinacion";
            ejercicio5.repeticiones = "x4";
            ejercicio5.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_con_inclinacion.json";
            ejercicio5.isCompleted = false;
            ejercicio5.isSeleted = false;
            ejerciciosList.Add(ejercicio5);

            ejercicio6.nombre = "Triceps en silla";
            ejercicio6.repeticiones = "x4";
            ejercicio6.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/tricep_en_silla.json";
            ejercicio6.isCompleted = false;
            ejercicio6.isSeleted = false;
            ejerciciosList.Add(ejercicio6);

            ejercicio7.nombre = "Flexiones con Apoyo de Rodilla ";
            ejercicio7.repeticiones = "00:30";
            ejercicio7.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_con_apoyo_de_rodillas.json";
            ejercicio7.isCompleted = false;
            ejercicio7.isSeleted = false;
            ejerciciosList.Add(ejercicio7);

            ejercicio8.nombre = "Estiramiento de cobra";
            ejercicio8.repeticiones = "00:30";
            ejercicio8.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/esterinamiento_de_cobra.json";
            ejercicio8.isCompleted = false;
            ejercicio8.isSeleted = false;
            ejerciciosList.Add(ejercicio8);

            ejercicio9.nombre = "Estiramiento de Pecho";
            ejercicio9.repeticiones = "00:30";
            ejercicio9.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_pecho.json";
            ejercicio9.isCompleted = false;
            ejercicio9.isSeleted = false;
            ejerciciosList.Add(ejercicio9);

            return ejerciciosList;
        }
        public IEnumerable<Ejercicio> brazos()
        {
            var ejerciciosList = new List<Ejercicio>();
            var ejercicio1 = new Ejercicio();
            var ejercicio2 = new Ejercicio();
            var ejercicio3 = new Ejercicio();
            var ejercicio4 = new Ejercicio();
            var ejercicio5 = new Ejercicio();
            var ejercicio6 = new Ejercicio();
            var ejercicio7 = new Ejercicio();
            var ejercicio8 = new Ejercicio();
            var ejercicio9 = new Ejercicio();
            var ejercicio10 = new Ejercicio();
            var ejercicio11 = new Ejercicio();
            var ejercicio12 = new Ejercicio();
            var ejercicio13 = new Ejercicio();
            var ejercicio14 = new Ejercicio();
            var ejercicio15 = new Ejercicio();
            var ejercicio16 = new Ejercicio();
            var ejercicio17 = new Ejercicio();
            var ejercicio18 = new Ejercicio();
            var ejercicio19 = new Ejercicio();


            ejercicio1.nombre = "Elevaciones de Brazos";
            ejercicio1.repeticiones = "00:30";
            ejercicio1.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/elevaciones_de_brazos.json";
            ejercicio1.isCompleted = false;
            ejercicio1.isSeleted = false;
            ejerciciosList.Add(ejercicio1);

            ejercicio2.nombre = "Elevaciones Laterales de Brazos";
            ejercicio2.repeticiones = "00:30";
            ejercicio2.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/elevaciones_laterales_de_brazos.json";
            ejercicio2.isCompleted = false;
            ejercicio2.isSeleted = false;
            ejerciciosList.Add(ejercicio2);

            ejercicio3.nombre = "Triceps en Silla";
            ejercicio3.repeticiones = "x16";
            ejercicio3.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/tricep_en_silla.json";
            ejercicio3.isCompleted = false;
            ejercicio3.isSeleted = false;
            ejerciciosList.Add(ejercicio3);

            ejercicio4.nombre = "Circulos con los Brazos";
            ejercicio4.repeticiones = "00:30";
            ejercicio4.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/circulos_con_los_brazos.json";
            ejercicio4.isCompleted = false;
            ejercicio4.isSeleted = false;
            ejerciciosList.Add(ejercicio4);

            ejercicio5.nombre = "Flexiones en Diamante";
            ejercicio5.repeticiones = "x6";
            ejercicio5.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_en_diamante.json";
            ejercicio5.isCompleted = false;
            ejercicio5.isSeleted = false;
            ejerciciosList.Add(ejercicio5);

            ejercicio6.nombre = "Saltos de Tijera";
            ejercicio6.repeticiones = "00:30";
            ejercicio6.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/saltode.json";
            ejercicio6.isCompleted = false;
            ejercicio6.isSeleted = false;
            ejerciciosList.Add(ejercicio6);

            ejercicio7.nombre = "Presiones de Brazos Sobre Pecho";
            ejercicio7.repeticiones = "00:30";
            ejercicio7.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/presiones_de_brazos_sobre_pecho.json";
            ejercicio7.isCompleted = false;
            ejercicio7.isSeleted = false;
            ejerciciosList.Add(ejercicio7);

            ejercicio8.nombre = "Flexiones de biceps izquierdo con pierna como barra";
            ejercicio8.repeticiones = "x8";
            ejercicio8.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_de_biceps_izquierdo_con_pierna.json";
            ejercicio8.isCompleted = false;
            ejercicio8.isSeleted = false;
            ejerciciosList.Add(ejercicio8);

            ejercicio9.nombre = "Flexiones de biceps derecho con pierna como barra";
            ejercicio9.repeticiones = "x8";
            ejercicio9.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_de_biceps_derecho.json";
            ejercicio9.isCompleted = false;
            ejercicio9.isSeleted = false;
            ejerciciosList.Add(ejercicio9);

            ejercicio10.nombre = "Placha Diagonal";
            ejercicio10.repeticiones = "x10";
            ejercicio10.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/plancha_diagonal.json";
            ejercicio10.isCompleted = false;
            ejercicio10.isSeleted = false;
            ejerciciosList.Add(ejercicio10);

            ejercicio11.nombre = "Puñetazos";
            ejercicio11.repeticiones = "00:30";
            ejercicio11.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/punetazos.json";
            ejercicio11.isCompleted = false;
            ejercicio11.isSeleted = false;
            ejerciciosList.Add(ejercicio11);

            ejercicio12.nombre = "Flexiones";
            ejercicio12.repeticiones = "x10";
            ejercicio12.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones.json";
            ejercicio12.isCompleted = false;
            ejercicio12.isSeleted = false;
            ejerciciosList.Add(ejercicio12);

            ejercicio13.nombre = "Flexiones de biceps derecho con pierna como barra";
            ejercicio13.repeticiones = "x8";
            ejercicio13.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_de_biceps_derecho.json";
            ejercicio13.isCompleted = false;
            ejercicio13.isSeleted = false;
            ejerciciosList.Add(ejercicio13);

            ejercicio14.nombre = "Inchworms";
            ejercicio14.repeticiones = "x8";
            ejercicio14.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/inchworms.json";
            ejercicio14.isCompleted = false;
            ejercicio14.isSeleted = false;
            ejerciciosList.Add(ejercicio14);

            ejercicio15.nombre = "Flexiones en la Pared";
            ejercicio15.repeticiones = "x12";
            ejercicio15.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_en_la_pared.json";
            ejercicio15.isCompleted = false;
            ejercicio15.isSeleted = false;
            ejerciciosList.Add(ejercicio15);

            ejercicio16.nombre = "Estiramiento de triceps izquierdo";
            ejercicio16.repeticiones = "00:30";
            ejercicio16.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_triceps_izquierdo.json";
            ejercicio16.isCompleted = false;
            ejercicio16.isSeleted = false;
            ejerciciosList.Add(ejercicio16);

            ejercicio17.nombre = "Estiramiento de triceps derecho";
            ejercicio17.repeticiones = "00:30";
            ejercicio17.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_triceps_derecho.json";
            ejercicio17.isCompleted = false;
            ejercicio17.isSeleted = false;
            ejerciciosList.Add(ejercicio17);

            ejercicio18.nombre = "Estiramiento de biceps en pie brazo izquierdo";
            ejercicio18.repeticiones = "00:30";
            ejercicio18.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_biceps_en_pie_brazo_izquierdo.json";
            ejercicio18.isCompleted = false;
            ejercicio18.isSeleted = false;
            ejerciciosList.Add(ejercicio18);

            ejercicio19.nombre = "Estiramiento de biceps en pie brazo derecho";
            ejercicio19.repeticiones = "00:30";
            ejercicio19.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_biceps_en_pie_brazo_derecho.json";
            ejercicio19.isCompleted = false;
            ejercicio19.isSeleted = false;
            ejerciciosList.Add(ejercicio19);

            return ejerciciosList;
        }

        public IEnumerable<Ejercicio> piernas()
        {
            var ejerciciosList = new List<Ejercicio>();
            var ejercicio1 = new Ejercicio();
            var ejercicio2 = new Ejercicio();
            var ejercicio3 = new Ejercicio();
            var ejercicio4 = new Ejercicio();
            var ejercicio5 = new Ejercicio();
            var ejercicio6 = new Ejercicio();
            var ejercicio7 = new Ejercicio();
            var ejercicio8 = new Ejercicio();
            var ejercicio9 = new Ejercicio();
            var ejercicio10 = new Ejercicio();
            var ejercicio11 = new Ejercicio();
            var ejercicio12 = new Ejercicio();
            var ejercicio13 = new Ejercicio();
            var ejercicio14 = new Ejercicio();
            var ejercicio15 = new Ejercicio();
            var ejercicio16 = new Ejercicio();
            


            ejercicio1.nombre = "Salto Lateral";
            ejercicio1.repeticiones = "00:30";
            ejercicio1.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/salto_lateral.json";
            ejercicio1.isCompleted = false;
            ejercicio1.isSeleted = false;
            ejerciciosList.Add(ejercicio1);

            ejercicio2.nombre = "Squats";
            ejercicio2.repeticiones = "x12";
            ejercicio2.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/squats.json";
            ejercicio2.isCompleted = false;
            ejercicio2.isSeleted = false;
            ejerciciosList.Add(ejercicio2);

            ejercicio3.nombre = "Levantamiento de Pierna Lateral Izquierda";
            ejercicio3.repeticiones = "x12";
            ejercicio3.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/levantamiento_de_pierna_lateral_izquierda.json";
            ejercicio3.isCompleted = false;
            ejercicio3.isSeleted = false;
            ejerciciosList.Add(ejercicio3);

            ejercicio4.nombre = "Levantamiento de Pierna Lateral Derecha";
            ejercicio4.repeticiones = "x12";
            ejercicio4.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/levantamiento_de_pierna_lateral_derecha.json";
            ejercicio4.isCompleted = false;
            ejercicio4.isSeleted = false;
            ejerciciosList.Add(ejercicio4);

            ejercicio5.nombre = "Estocada Hacia Atras";
            ejercicio5.repeticiones = "x14";
            ejercicio5.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estocada_hacia_atras.json";
            ejercicio5.isCompleted = false;
            ejercicio5.isSeleted = false;
            ejerciciosList.Add(ejercicio5);

            ejercicio6.nombre = "Donkey Kicks Izquierdo";
            ejercicio6.repeticiones = "x16";
            ejercicio6.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/donkey_kicks_izquierdo.json";
            ejercicio6.isCompleted = false;
            ejercicio6.isSeleted = false;
            ejerciciosList.Add(ejercicio6);

            ejercicio7.nombre = "Donkey Kicks Derecho";
            ejercicio7.repeticiones = "x16";
            ejercicio7.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/donkey_kicks_derecha.json";
            ejercicio7.isCompleted = false;
            ejercicio7.isSeleted = false;
            ejerciciosList.Add(ejercicio7);

            ejercicio8.nombre = "Estiramiento de cuadriceps izquierdo con pared";
            ejercicio8.repeticiones = "00:30";
            ejercicio8.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_cuadriceps_izquierdo_con_pared.json";
            ejercicio8.isCompleted = false;
            ejercicio8.isSeleted = false;
            ejerciciosList.Add(ejercicio8);

            ejercicio9.nombre = "Estiramiento de cuadriceps derecho con pared";
            ejercicio9.repeticiones = "00:30";
            ejercicio9.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_cuadriceps_derecho_con_pared.json";
            ejercicio9.isCompleted = false;
            ejercicio9.isSeleted = false;
            ejerciciosList.Add(ejercicio9);

            ejercicio10.nombre = "Estiramiento de rodilla izquierda al pecho";
            ejercicio10.repeticiones = "00:30";
            ejercicio10.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_rodilla_izquierda_al_pecho.json";
            ejercicio10.isCompleted = false;
            ejercicio10.isSeleted = false;
            ejerciciosList.Add(ejercicio10);

            ejercicio11.nombre = "Estiramiento de rodilla derecha al pecho";
            ejercicio11.repeticiones = "00:30";
            ejercicio11.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_rodilla_derecha_al_pecho.json";
            ejercicio11.isCompleted = false;
            ejercicio11.isSeleted = false;
            ejerciciosList.Add(ejercicio11);

            ejercicio12.nombre = "Levantamiento de pantorrilla con pared";
            ejercicio12.repeticiones = "x12";
            ejercicio12.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/levantamientos_de_pantorrilla_con_pared.json";
            ejercicio12.isCompleted = false;
            ejercicio12.isSeleted = false;
            ejerciciosList.Add(ejercicio12);

            ejercicio13.nombre = "Levantamiento de patorrilla con sentadilla de sumo en pared";
            ejercicio13.repeticiones = "x12";
            ejercicio13.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/levantamientos_de_pantorrillas_con_sentadilla_sumo.json";
            ejercicio13.isCompleted = false;
            ejercicio13.isSeleted = false;
            ejerciciosList.Add(ejercicio13);

            ejercicio14.nombre = "Estiramiento de pantorrilla izquierda";
            ejercicio14.repeticiones = "00:30";
            ejercicio14.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_pantorrilla_izquierda.json";
            ejercicio14.isCompleted = false;
            ejercicio14.isSeleted = false;
            ejerciciosList.Add(ejercicio14);

            ejercicio15.nombre = "Flexiones en la Pared";
            ejercicio15.repeticiones = "00:30";
            ejercicio15.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/flexiones_en_la_pared.json";
            ejercicio15.isCompleted = false;
            ejercicio15.isSeleted = false;
            ejerciciosList.Add(ejercicio15);

            ejercicio16.nombre = "Estiramiento de pantorrilla derecha";
            ejercicio16.repeticiones = "00:30";
            ejercicio16.animacion = "https://coolhouse.life/wp-content/uploads/2021/12/estiramiento_de_patorrilla_derecha";
            ejercicio16.isCompleted = false;
            ejercicio16.isSeleted = false;
            ejerciciosList.Add(ejercicio16);

            return ejerciciosList;
        }
    }
}
