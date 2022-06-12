using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repositories
{
    public class Ingredientes
    {
        public IEnumerable<string> ensalada()
        {
            var ensaladaList = new List<string>();
            ensaladaList.Add("4 Huevos");
            ensaladaList.Add("1 taza Hojas de espinaca baby");
            ensaladaList.Add("2 Corazones de Lechuga");
            ensaladaList.Add("1 Jitomate en tiras");
            ensaladaList.Add("1 taza Champiñón fileteados");
            ensaladaList.Add("1 Aguacate en rebanadas");
            ensaladaList.Add("2 tiras Tocino en tiras, frito y picado");

            return ensaladaList;
        }
        public IEnumerable<string> ingredientesYogurtConFrutas()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1 vaso de yogur natural o yogur griego");
            ingredientesList.Add("15 ml de miel");
            ingredientesList.Add("1 unidad de banano");
            ingredientesList.Add("1 unidad de fruta de tu elección");
            ingredientesList.Add("1 cucharada postre de Ralladura de piel de limón");
           
            return ingredientesList;
        }
        public IEnumerable<string> ingredientesPancakesDeMazana()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1 taza de manzana picada (puede ser la roja o verde)");
            ingredientesList.Add("375 gramos de harina de avena");
            ingredientesList.Add("1½ de polvo para hornear");
            ingredientesList.Add("una pizca de sal");
            ingredientesList.Add("250 ml de leche vegetal");
            ingredientesList.Add("1 cucharadita de esencia de vainilla");
            ingredientesList.Add("2 bananos cortados en rodajas");
            ingredientesList.Add("miel a gusto");

            return ingredientesList;
        }

        public IEnumerable<string> ingredientesPolloAlHornoConPatatas()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1 Pollo entero");
            ingredientesList.Add("4 – 5 patatas medianas");
            ingredientesList.Add("4 cebollas");
            ingredientesList.Add("tomillo seco");
            ingredientesList.Add("aceite de oliva");
            ingredientesList.Add("sal y pimienta");
            
            return ingredientesList;
        }
        public IEnumerable<string> ingredientesLomitoDeResRelleno()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("8 champiñones");
            ingredientesList.Add("3 cebollas de verdeo picadas");
            ingredientesList.Add("½ kg kg de lomo");
            ingredientesList.Add("3 tocinos");
            ingredientesList.Add("1 cda cuchara de pimentón");
            ingredientesList.Add("1 cda cuchara de ajo en polvo");
            ingredientesList.Add("1 cda cuchara de provenzal");
            ingredientesList.Add("4 cda cucharas de queso sardo rallado");
            ingredientesList.Add("Sal, pimienta");
            ingredientesList.Add("Aceite de oliva");
            ingredientesList.Add("1 manojo de Vainitas");
            ingredientesList.Add("2 Zanahorias");

            return ingredientesList;
        }

        public IEnumerable<string> ingredientesensaladaDebrocoliConPollo()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1 arbolito de brocoli");
            ingredientesList.Add("1/2 pechuga de pollo");
            ingredientesList.Add("salsa de soja");
            ingredientesList.Add("sal y pimienta a gusto");
            ingredientesList.Add("semillas de cesamo para decorar");
            ingredientesList.Add("2 ajos picados finamente");
            
            return ingredientesList;
        }

        public IEnumerable<string> ingredientesEnsaladaDeLentejas()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1/4 taza de cebolla finamente picada");
            ingredientesList.Add("400 gramos de lentejas cocidas o de lata");
            ingredientesList.Add("1/4 taza de zanahoria finamente picada");
            ingredientesList.Add("1/4 taza de pimiento rojo finamente picado");
            ingredientesList.Add("1/4 taza de pepino finamente picado");
            ingredientesList.Add("1/4 taza de pimiento rojo finamente picado");
            ingredientesList.Add("2 puñados de perejil finamente picado");
            ingredientesList.Add("3 tomates picados");
            ingredientesList.Add("aceite de oliva virgen extra");
            ingredientesList.Add("jugo de 1/2 limón");
            ingredientesList.Add("sal y pimienta  a gusto");
            
            return ingredientesList;
        }
        public IEnumerable<string> ingredientesPancakesketo()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1 taza Harina de almendras");
            ingredientesList.Add("1/2 cucharadita Polvo para hornear");
            ingredientesList.Add("1 cucharadita Canela");
            ingredientesList.Add("2 Huevos");
            ingredientesList.Add("1/2 taza leche (preferiblemente de almendras)");
            ingredientesList.Add("1 pizca de esencia de vainilla");
            ingredientesList.Add("mantequilla a gusto");

            return ingredientesList;
        }
        public IEnumerable<string> ingredientesArrozintegralconleche()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("½ taza de arroz integral");
            ingredientesList.Add("750 ml de leche liquida (2½ tazas)");
            ingredientesList.Add("una pizca de sal");
            ingredientesList.Add("45 gramos de azúcar (preferiblemente morena)");
            ingredientesList.Add("½ cuchara de vainilla");
            ingredientesList.Add("1 trozo de cascara de limón");
            
            return ingredientesList;
        }
        public IEnumerable<string> ingredientesTortitasconEspinacasYQueso()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("200 gramos de queso manchego rallado u otro queso que se funda fácilmente.");
            ingredientesList.Add("500 gramos de espinacas picadas");
            ingredientesList.Add("½ trozo de cebolla picada");
            ingredientesList.Add("2 huevos");
            ingredientesList.Add("1 pizca de ajo en polvo");
            ingredientesList.Add("1 pizca de sal");
            ingredientesList.Add("1 pizca de pimienta");
            ingredientesList.Add("3 cucharadas de harina");
            ingredientesList.Add("2 cucharadas de aceite vegetal");
            ingredientesList.Add("1 litro de agua");

            return ingredientesList;
        }
        public IEnumerable<string> ingredientesMerluzacongambas()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("1 Filetes de merluza (sin huesos)");
            ingredientesList.Add("1 puñado de gambas (o 1 gramo) la cantidad es a gusto");
            ingredientesList.Add("2 dientes de ajo");
            ingredientesList.Add("1 guindilla (Opcional, si gustas de picante)");
            ingredientesList.Add("1 puñado de perejil");
            ingredientesList.Add("60 ml de aceite de oliva");
            ingredientesList.Add("1 pizca de sal");
            
            return ingredientesList;
        }
        public IEnumerable<string> ingredientesMerluzaalaplancha()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("3 Filetes de merluza");
            ingredientesList.Add("½ cucharadita de tomillo");
            ingredientesList.Add("2 cucharas de aceite de oliva");
            ingredientesList.Add("1 cucharada de ralladura de limón");
            ingredientesList.Add("zumo del mismo limón");
            ingredientesList.Add("sal y pimienta a gusto");
           
            return ingredientesList;
        }
        public IEnumerable<string> ingredientesArrozintegralconverduras()
        {
            var ingredientesList = new List<string>();
            ingredientesList.Add("2 tazas de arroz integral");
            ingredientesList.Add("6 tazas de agua");
            ingredientesList.Add("3 cucharadas de cebolla picada");
            ingredientesList.Add("1/2 zanahoria picada en cuadritos");
            ingredientesList.Add("1/2 taza de elote desgranado");
            ingredientesList.Add("1 diente de ajo picando finamente");
            ingredientesList.Add("sal a gusto");
            
            return ingredientesList;
        }
    }
}
