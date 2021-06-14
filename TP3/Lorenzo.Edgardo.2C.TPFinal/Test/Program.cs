using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCore;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // ATENCION - LA MAYORIA DE LA PRUEBAS QUE RESULTAN SIN STOCK ES DEBIDO A LOS TECLADOS QUE CONSUMEN
            // MUCHAS KEYCAPS Y MUCHOS SWTICHES, TENER EN CUENTA Y AGREGAR STOCK CONTINUO PARA PROBAR
            bool sinStock = false;
            // creamos una lista con 2 objetos. 
            List<Product> list = new List<Product>();
            MechanicalKeyboard p1 = new MechanicalKeyboard("Poker3", 1500, EKeyboardSize.Tenkeyless, true, ESwitchColor.CherryBlue);
            Thinkpad p2 = new Thinkpad("T420", 2000, EScreenSize.LargeScreen, 1, true);
            list.Add(p1);
            list.Add(p2);
            // Cargamos el diccionario de materiales (de la clase Materials) con los nombres de los
            // atributos de c/tipo de objeto y un valor random
            Factory.stock.LoadMaterialsNeeded(p1);
            Factory.stock.LoadMaterialsNeeded(p2);
            // Aumentamos el stock que se necesita para crear c/producto
            Factory.LoadMoreStock(p1);
            Factory.LoadMoreStock(p2);
            // Mostramos Stock Inicial
            Console.WriteLine("Consulto Stock (1) \n\n"+Factory.StockInfo());
            try
            {
                // Intentamos agregar 2 productos
                // Cuando se testea agregar productos ESTAR atentos al LoadMoreStock y su random interno
                // si es muy chico habra que llamarlo varias veces
                // A modo de prueba se puede cambiar su random a uno mayor
                Factory.Create = new Thinkpad("T420", 2500, EScreenSize.MediumScreen, 1, true);
                Factory.Create = new MechanicalKeyboard("Poker3", 1500, EKeyboardSize.Tenkeyless, false, ESwitchColor.CherryBlue);
                Console.WriteLine("Primeros 2 productos (1) \n\n" + Factory.ProductsInfo() + "\n\n");
            }
            catch(OutOfStockException ex)
            {
                Console.WriteLine($"No hay stock suficiente (1) ", ex.Message);
                
            }
            try
            {
                Factory.Create = new MechanicalKeyboard("Qisan Magicforce", 1150, EKeyboardSize.Small, true, ESwitchColor.GateronClear);
                Factory.Create = new MechanicalKeyboard("Das Keyboard 100", 1790, EKeyboardSize.Small, false, ESwitchColor.GateronBrown);
                Console.WriteLine("Se agregan 2 productos mas (2) \n\n" + Factory.ProductsInfo() + "\n\n");
            }
            catch (OutOfStockException ex)
            {
                Console.WriteLine("No hay stock suficiente (2) ", ex.Message);
                sinStock = true;
            }

            if(sinStock)
            {
                Factory.LoadMoreStock(p1);
            }
            try
            {
                Factory.Create = new MechanicalKeyboard("Das Keyboard 100", 2655, EKeyboardSize.FullSize, false, ESwitchColor.CherryRed);
                Factory.Create = new Thinkpad("T430", 2500, EScreenSize.LargeScreen, 1, true);
                Console.WriteLine("Se agregan mas productos (3) \n\n" + Factory.ProductsInfo() + "\n\n");
            }
            catch (OutOfStockException ex)
            {
                Console.WriteLine("Te quedaste sin stock (3) ", ex.Message);

            }

            Console.WriteLine("Consulto Stock (2) \n\n" + Factory.StockInfo());

            //PROBAMOS SERIALIZACION
            try
            {
                // Corroboramos que la lista de productos sea mayor a 0
                // Si no lo es, lanzamos excepcion
                if (!(Factory.listaProductos.Count > 0))
                {
                    throw new NoProductCreatedException("Stock is empty, nothing to be serialized\nGo build some");
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "ProductsList.xml";
                Serializator<List<Product>> toXml = new Serializator<List<Product>>();
                toXml.Save(path, Factory.listaProductos);
                Console.WriteLine($"XML file created successfully at {AppDomain.CurrentDomain.BaseDirectory}");
            }
            catch (NoProductCreatedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
