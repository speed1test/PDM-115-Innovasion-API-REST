using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class RecetasRepository
    {
        public Receta ensalada()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Ensaladada de huevo y aguacate";
            receta.image = "https://www.cocinavital.mx/wp-content/uploads/2017/09/ensaladahuevo.jpg";
            receta.temPreparacion = "45 min";
            receta.porciones = "6";
            receta.calorias = "240";
            receta.ingredientes = ingredientes.ensalada();
            receta.instrucciones = instrucciones.instruccionesEnsalada();
            receta.categoria = "Ensaladas";
            return receta;
        }

        public Receta Yogurtconfrutas()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Yogurt con frutas";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/yogurt-con-frutas.jpg";
            receta.temPreparacion = "3 min";
            receta.porciones = "2";
            receta.calorias = "213";
            receta.ingredientes = ingredientes.ingredientesYogurtConFrutas();
            receta.instrucciones = instrucciones.instruccionesYogurtConFrutas();
            receta.categoria = "Postres";

            return receta;
        }
        public Receta PancakesdeManzana()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Pancakes de Manzana";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/pancakes-de-manzana.jpg";
            receta.temPreparacion = "3 min";
            receta.porciones = "2";
            receta.calorias = "213";
            receta.ingredientes = ingredientes.ingredientesPancakesDeMazana();
            receta.instrucciones = instrucciones.instruccionesPancakesDeManzana();
            receta.categoria = "Desayunos";

            return receta;
        }
        public Receta Polloalhornoconpatatas()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Pollo al horno con patatas";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/pollo-al-horno-con-patatas-y-cebolla.jpg";
            receta.temPreparacion = "70 min";
            receta.porciones = "4";
            receta.calorias = "210";
            receta.ingredientes = ingredientes.ingredientesPolloAlHornoConPatatas();
            receta.instrucciones = instrucciones.instruccionesPolloAlHornoConPatatas();
            receta.categoria = "Carnes y aves";

            return receta;
        }
        public Receta Lomitoderesrelleno()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Lomito de res relleno";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/06/lomito-de-res-relleno-1024x561.jpg";
            receta.temPreparacion = "55 min";
            receta.porciones = "4";
            receta.calorias = "386";
            receta.ingredientes = ingredientes.ingredientesLomitoDeResRelleno();
            receta.instrucciones = instrucciones.intruccionesLomitoDeResRelleno();
            receta.categoria = "Carnes y aves";

            return receta;
        }
        public Receta ensaladaDebrocoliConPollo()  
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Ensalada de Brocoli con Pollo";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/Webp.net-resizeimage-18.jpg";
            receta.temPreparacion = "30 min";
            receta.porciones = "2";
            receta.calorias = "185";
            receta.ingredientes = ingredientes.ingredientesensaladaDebrocoliConPollo();
            receta.instrucciones = instrucciones.intruccionesensaladaDebrocoliConPollo();
            receta.categoria = "Ensaladas";

            return receta;
        }

        public Receta ensaladaDeLentejas()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Ensalada de Lentejas";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2021/03/ensalada-de-lentejas.jpg";
            receta.temPreparacion = "15 min";
            receta.porciones = "4";
            receta.calorias = "130";
            receta.ingredientes = ingredientes.ingredientesEnsaladaDeLentejas();
            receta.instrucciones = instrucciones.intruccionesEnsaladaDeLentejas();
            receta.categoria = "Ensaladas";

            return receta;
        }
        public Receta Pancakesketo()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Pancakes keto";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/pancakes-keto.jpg";
            receta.temPreparacion = "21 min";
            receta.porciones = "8";
            receta.calorias = "86";
            receta.ingredientes = ingredientes.ingredientesPancakesketo();
            receta.instrucciones = instrucciones.intruccionespancakesKeto();
            receta.categoria = "Desayunos";

            return receta;
        }
        public Receta Arrozintegralconleche()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Arroz integral con leche";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/arroz-integral-con-leche.jpg";
            receta.temPreparacion = "55 min";
            receta.porciones = "4";
            receta.calorias = "213";
            receta.ingredientes = ingredientes.ingredientesArrozintegralconleche();
            receta.instrucciones = instrucciones.intruccionesArrozintegralconleche();
            receta.categoria = "Desayunos";

            return receta;
        }
        public Receta TortitasconEspinacasyQueso()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Tortitas con Espinacas y Queso";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2021/08/tortitas-de-espinacas.jpg";
            receta.temPreparacion = "20 min";
            receta.porciones = "12";
            receta.calorias = "139";
            receta.ingredientes = ingredientes.ingredientesTortitasconEspinacasYQueso();
            receta.instrucciones = instrucciones.intruccionesTortitasconEspinacasYQueso();
            receta.categoria = "Vegetarianas";

            return receta;
        }
        public Receta Merluzacongambas()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Merluza con gambas";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/merluza-con-gambas.jpg";
            receta.temPreparacion = "25 min";
            receta.porciones = "3";
            receta.calorias = "210";
            receta.ingredientes = ingredientes.ingredientesMerluzacongambas();
            receta.instrucciones = instrucciones.intruccionesMerluzacongambas();
            receta.categoria = "Mariscos";

            return receta;
        }
        public Receta Merluzaalaplancha()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Merluza a la plancha";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/merluza-a-la-plancha.jpg";
            receta.temPreparacion = "20 min";
            receta.porciones = "3";
            receta.calorias = "86";
            receta.ingredientes = ingredientes.ingredientesMerluzaalaplancha();
            receta.instrucciones = instrucciones.intruccionesMerluzaalaplancha();
            receta.categoria = "Mariscos";

            return receta;
        }
        public Receta Arrozintegralconverduras()
        {
            var receta = new Receta();
            var ingredientes = new Ingredientes();
            var instrucciones = new Instrucciones();
            receta.nombre = "Arroz integral con verduras";
            receta.image = "https://recetitasfit.com/wp-content/uploads/2020/07/arroz-integral-con-verduras.jpg";
            receta.temPreparacion = "45 min";
            receta.porciones = "6";
            receta.calorias = "178";
            receta.ingredientes = ingredientes.ingredientesArrozintegralconverduras();
            receta.instrucciones = instrucciones.intruccionesArrozintegralconverduras();
            receta.categoria = "Vegetarianas";

            return receta;
        }
    }
    
}

