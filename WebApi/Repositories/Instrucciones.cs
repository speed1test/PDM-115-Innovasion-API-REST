using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repositories
{
    public class Instrucciones
    {
        public IEnumerable<string> instruccionesEnsalada()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("LICÚA todos los ingredientes y salpimienta.");
            instruccionesList.Add("COLOCA los huevos en un cazo y vierte agua fría hasta cubrirlos.Cocina a fuego medio y cuando suelte el hervor, cuenta 12 minutos.");
            instruccionesList.Add("RETIRA los huevos y colócalos en agua fría. Pela y corta en cuatro.");
            instruccionesList.Add("MEZCLA las hojas de espinaca, la lechuga, el jitomate y los champiñones.");
            instruccionesList.Add("AGREGA el huevo cocido y el aguacate. Mezcla con cuidado.");
            instruccionesList.Add("SIRVE la ensalada con un poco de aderezo y espolvorea el tocino.");
          
            return instruccionesList;
        }
        public IEnumerable<string> instruccionesYogurtConFrutas()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Bueno la preparación es realmente sencilla, coge las frutas y quitales la piel," +
                    " corta en cubitos o rodajas como tu las prefieras.");
            instruccionesList.Add("A continuación en un tazo vierte el yogur de tu elección y añade las frutas," +
                    " para terminar de complementar nuestro rico y nutritivo desayuno saludable,");
            instruccionesList.Add(" añade un la miel y ralladura de limón.");
            instruccionesList.Add("Listo asi de simple, ya esta terminado y podemos comenzar a degustar nuestro desayuno.");
            
            return instruccionesList;
        }
        public IEnumerable<string> instruccionesPancakesDeManzana()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Comienza añadiendo la harina en un recipiente junto al polvo para hornear, añade" +
                    " también la canela, sal e integra bien todo.");
            instruccionesList.Add("Luego añade la vainilla, manzana y ve vertiendo la leche poco a poco, al mismo tiempo" +
                    " mezcla bien todo, deberá quedarte una mezcla homogénea, si notas que esta muy" +
                    " espeso añade mas leche o agua, de lo contrario si notas que quedo" +
                    " muy liquido añade harina.");
            instruccionesList.Add("Calienta una sarten con un chorrito de aceite de oliva, ve añadiendo poco a poco" +
                    " la mezcla, y cocina los pancakes a fuego bajo.");
            instruccionesList.Add("Una vez tengas todos listos, sirve en un plato adornando con las rodajas de" +
                    " banano y trozos de manzana y miel por encima, te aseguro que no quedaras" +
                    " indiferente con el sabor.");

            return instruccionesList;
        }

        public IEnumerable<string> instruccionesPolloAlHornoConPatatas()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Para esta receta de pollo al horno con patatas y cebolla comienza pelando las" +
                    " patatas. Luego cortalas en rodajas algo delgadas y algo gruesas, vamos" +
                    " en termino medio es decir algo como 1 cm o quizá algunos milímetros de" +
                    " mas. Luego colócalos como base en una bandeja de horno.");
            instruccionesList.Add("Haz el mismo procedimiento con las cebollas y al igual que las patatas ponlas" +
                    " como base sobre las patatas, sal pimienta a gusto.");
            instruccionesList.Add("Continuando añade el pollo encima de tu base de patatas y cebolla, añade un vaso" +
                    " ojo un vaso de agua y un chorrito de aceite de oliva, esto nos otorgara" +
                    " un jugo irresistible en nuestro pollo, ademas procurando que el fondo" +
                    " de la bandeja este siempre húmeda para impedir que las patatas se" +
                    " quemen. Añade una pizca de sal y tomillo.");
            instruccionesList.Add("Introduce el pollo dentro el horno a 190°C calor arriba y abajo, y dejamos hornea" +
                    "r un periodo de 30 minutos.");
            instruccionesList.Add("Cuando el pollo este dorado, sácala del horno intenta darle la vuelta" +
                    " y para adentro otra vez, deja cocinar otros 30 minutos y luego estará sácalo.");
            instruccionesList.Add("Ahora si nuestro pollo quedo jugoso, tierno y muy delicioso. Sirve acompañado" +
                    " de la guarnición de patatas y cebolla que con el jugo que soltó" +
                    " el pollo están para chuparse los dedos, buen provecho.");

            return instruccionesList;
        }

        public IEnumerable<string> intruccionesLomitoDeResRelleno()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Comenzamos lavando y cortando los champiñones en trocitos no tan pequeños," +
                    " así mismo hacemos con la cebolla verde y el tocino. En una sarten doramos" +
                    " los tocinos durante 2 minutos, hasta que expulse su propia grasa, en ese" +
                    " momento agregamos champiñones y la cebolla verde, sal pimentamos y reposar.");
            instruccionesList.Add("Cortamos nuestro lomito por la mitad ojo no lo partimos, tan solo le hacemos un" +
                    " corte como si fuese un pan, en la parte del centro introduciremos" +
                    " nuestro sofrito y el queso rallado.");
            instruccionesList.Add("IMPORTANTE: Ve Pre-calentando el horno a 180°");
            instruccionesList.Add("Cerramos el lomito con ayuda de de unos mondadientes. En un sarten añadimos" +
                    " unas gotas de aceite de oliva y freímos nuestro lomo, este paso solo" +
                    " se trata de freír la parte de afuera.");
            instruccionesList.Add("Pela las zanahorias en tiras o en rodajas, como tu prefieras, y las vainitas" +
                    " van enteras. Ahora lo llevamos todo al horno durante unos 40 minutos," +
                    " dependerá de que tan cocido quieres que este el lomito.");
            instruccionesList.Add("Listo!! nuestro lomito relleno esta terminado. Sirve acompañado de" +
                    " unas papas o una guarnición de verduras.");

            return instruccionesList;
        }

        public IEnumerable<string> intruccionesensaladaDebrocoliConPollo()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Como primer paso cortamos en trozos el brocoli, quitamos la piel del tallo y si gustas puedes cocinar el tallo mas cortando en cuadraditos, colocamos en una olla mediana con agua y llevamos a fuego medio, cocina por 15 minutos. Luego escurre el agua y deja enfriar.");
            instruccionesList.Add("Aparte lavamos la pechuga de pollo, cortamos en tiras  o como mas gustes, sazonamos, picamos el ajo finamente, llevamos una sarten a fuego medio con un poco de aceite, una vez que caliente añadimos el ajo y sofreímos por 3 minutos.");
            instruccionesList.Add("Añadimos a la sarten la pechuga de pollo en trozos, freímos por 10 minutos o hasta que quede lista, en el transcurso de sofrito casi al ultimo agrega 3 cucharadas de salsa de soja y tapa la sarten, deja unos minutos para que se mezclen los sabores.");
            instruccionesList.Add("Una vez listo nuestro pollo con su jugo, apagamos el fuego y añadimos el brocoli a la sarten, mezclamos y dejamos 5 minutos tapada la sarten para que se integre el brocoli y le entre ese jugo.");
            instruccionesList.Add("Finalmente lista nuestra comida sirve, decora con semillas de cesamo y disfruta de este platillo riquísimo. Puedes acompañar con arroz blanco o comerla sola.");
            
            return instruccionesList;
        }

        public IEnumerable<string> intruccionesEnsaladaDeLentejas()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Como ya tenemos todas las verduras lavadas, peladas y picadas, vertemos todas en un bol o recipiente de ensaladera.");
            instruccionesList.Add("Agregamos las lentejas ya cocidas a la ensalada, mas el jugo de limón y el aceite.");
            instruccionesList.Add("Por ultimo salpimentamos bien y mezclamos hasta integrar y listo, sirve a gusto esta delicia de comida saludable y nutriente.");
          
            return instruccionesList;
        }
        public IEnumerable<string> intruccionespancakesKeto()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("En un bowl añade esencia de vainilla, leche y los huevos, mezcla bien con una varilla de cocina.");
            instruccionesList.Add("En otro recipiente mezcla los demás ingredientes, polvo para hornear, mantequilla, canela y harina de almendras, integra bien todo y luego ve añadiendo poco a poco esta mezcla a la del bowl con los ingredientes húmedos.");
            instruccionesList.Add("Es importante mezclar bien, por eso se hace poco a poco, cuando tengas todo bien mezclado, en una sartén añade un cubito de mantequilla y deja derretir a fuego lento.");
            instruccionesList.Add("Cuando la mantequilla este derretida ve añadiendo un poco de tu mezcla, para finalmente hacer un pancake keto, deja dorar 2 a 3 minutos por lado. Repite el procedimiento con el resto de mezcla y listo.");
            instruccionesList.Add("Sirve acompañado de miel para endulzar, recuerda que la miel natural es un ingrediente muy saludable y es mucho mejor que consumir azúcar. Que lo disfrutes.");
            
            return instruccionesList;
        }
        public IEnumerable<string> intruccionesArrozintegralconleche()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Vierte la leche en un cazo junto al arroz, cascara de limón (preferiblemente quítale la parte blanca) y una pizca de sal, deja cocinar a fuego medio hasta que llegue a ebullición.");
            instruccionesList.Add("Una vez hervido baja el fuego, remueve poco y siga cocinando durante 30 a 45 minutos mas, si notas que el arroz esta absorbiendo demasiada leche no dudes en añadir mas.");
            instruccionesList.Add("Retira el cazo del fuego y quítale la cascara de limón, luego añade azúcar y vainilla, remueve bien con ayuda de una cuchara de cocina o cuchara de madera.");
            instruccionesList.Add("Lleva el arroz a un recipiente de cristal o uno de plástico, tapa con papel film, trata de que el papel film toque la superficie del arroz integral con leche, deja reposar un lapso de 30 minutos.");
            instruccionesList.Add("Pasado el tiempo llévalo a la congeladora y refrigera un par de horas, pasado ese tiempo estará lista para servir, sirve con una hoja de menta y algunos frutos secos si gustas.");
           
            return instruccionesList;
        }
        public IEnumerable<string> intruccionesTortitasconEspinacasYQueso()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Como primer paso debes poner a hervir agua en una cacerola normal, déjala llegar al punto de ebullición y añade las espinacas previamente picadas, baja el fuego, tapa la cacerola y deja cocer durante 5 minutos");
            instruccionesList.Add("Ahora si escurre el agua del cazo con ayuda de un colador, reservamos. NOTA: Recalcar que debemos procurar escurrir todo el agua.");
            instruccionesList.Add("En una sartén vierte un chorrito de aceite y añade la cebolla, freír por unos 3 a 5 minutos hasta que la misma cambie de color, luego de ello retira del fuego.");
            instruccionesList.Add("En un bol hondo añade los ingredientes es decir; cebolla, espinacas y queso rallado. Ve añadiendo de a poco la harina y mezcla gradualmente.");
            instruccionesList.Add("En otro bol casca los huevos y añade la sal, pimienta y el ajo en polvo, bate bien hasta integrarlos por completo, luego añade esta mezcla a la de espinacas.");
            instruccionesList.Add("Integra bien ambas mezclas hasta obtener una masa.");
            instruccionesList.Add("Ahora si pre calienta un poco de aceite en un sartén, y con ayuda de una bolsa o guantes de cocina ve dándole forma a tus tortitas, freír durante 1 a 2 minutos por lado, notaras cuando este cocida.");
            instruccionesList.Add("Repite el proceso con las demás tortitas." +
                                    "CONSEJO: No es necesario utilizar mucho aceite, es mas procura usar poco para que no sea una comida rebosada y frita por completo.");
            instruccionesList.Add("¡Listo! las tortitas de espinaca con queso están listas para su degustación. Realmente sencillas verdad.");

            return instruccionesList;
        }
        public IEnumerable<string> intruccionesMerluzacongambas()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Comienza añadiendo en un recipiente pequeño aceite, perejil y los ajos, tritura con ayuda de una batidora eléctrica o de mano.");
            instruccionesList.Add("Baña los filetes de merluza con la preparación que de perejil, ajo y aceite, añade sal y pimienta a gusto. Y en una sarten vierte un chorrito de aceite y saltea las merluzas. Reserva cuando termines.");
            instruccionesList.Add("Utiliza la misma sarten para freír las gambas o camarones, previamente peladas. (ojo estas no las bañamos con la preparacion del paso 1)");
            instruccionesList.Add("Una vez que las gambas se doren, añade la mezcla y deja cocinar unos minutos. Si gustas algo de picante no dudes en añadir un poco de guindilla.");
            instruccionesList.Add("Añade los filetes de pescado a la preparación y saltea bien la receta, si gustas en este paso puedes añadir un chorrito de limón para darle un sabor mas peculiar y saludable.");
            instruccionesList.Add("Y listo nuestra receta de merluza con gambas esta terminada y lista para degustar. Buen provecho.");

            return instruccionesList;
        }
        public IEnumerable<string> intruccionesMerluzaalaplancha()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Asegúrate de tener todos los ingredientes a mano con las cantidades exactas, puedes usar merluza congelada que las venden en casi todos los supermercados, si es el caso descongela antes de iniciar la preparación.");
            instruccionesList.Add("En un recipiente añade las cucharas de aceite de oliva, tomillo y claro la ralladura de limón (el limón otorga un sabor exquisito al pescado, siempre le viene bien) mezcla bien y con ayuda de un pincel de cocina, pinta bien los filetes de merluza.");
            instruccionesList.Add("Enciende tu plancha y deja calentar previamente 10 minutos, luego dora los filetes por ambas caras, ayúdate de la espátula para hacer presión y lograr un dorado mas autentico, importante dorar una media de 2 minutos por lado.");
            instruccionesList.Add("Luego retira los filetes, y baña con un poquito de zumo de limón, te aseguro que esta receta te quedara, para chuparse los dedos.");
            instruccionesList.Add("Acompaña con una guarnición de verduras, o una ensalada fitness. Espero que la receta te haya gustado y sobre todo haya sido de tu utilidad.");
            
            return instruccionesList;
        }
        public IEnumerable<string> intruccionesArrozintegralconverduras()
        {
            var instruccionesList = new List<string>();
            instruccionesList.Add("Comienza lavando el arroz integral esto nos ayudara para que obtenga una mejor cocción. Ahora un pequeño truco! en un cazo añade 4 a 5 cucharas de agua y deja hervir, cuando hierva añade el diente de ajo picado y la cebolla, saltea y espera que la cebolla se ponga transparente.");
            instruccionesList.Add("Entonces ahí, añade el arroz y continua salteando durante 2 a 5 minutos como máximo, una vez que el arroz cambie de color añade las 3 tazas de agua y deja cocer.");
            instruccionesList.Add("Cuando el agua del cazo hierba añade los cuadraditos de zanahoria, y luego deja hervir otros 35 a 45 minutos.");
            instruccionesList.Add("Tip: Cuando el arroz integral añade el sal, mas no lo hagas antes ya que puede arruinarnos la cocción.");
            instruccionesList.Add("Bien pasado el tiempo nuestro arroz integral estará listo para servir, acompaña con una guarnición de verduras cocidas, y disfruta de una autentica cena saludable.");

            return instruccionesList;
        }
    }
}
