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
            /*
             * 
             * 
             *              PROBAMOS CREACION DE PRODUCTOS Y EXCEPCIONES
             * 
             * 
             */

            // ATENCION - LA MAYORIA DE LA PRUEBAS QUE RESULTAN SIN STOCK ES DEBIDO A LOS TECLADOS QUE CONSUMEN
            // MUCHAS KEYCAPS Y MUCHOS SWTICHES, TENER EN CUENTA Y AGREGAR STOCK CONTINUO PARA PROBAR
            bool sinStock = false;
            // creamos 2 objetos. 
            MechanicalKeyboard p1 = new MechanicalKeyboard("Poker3", 1500, EKeyboardSize.Tenkeyless, true, ESwitchColor.CherryBlue);
            Thinkpad p2 = new Thinkpad("Thinkpad T420", 2000, EScreenSize.LargeScreen, 1, true);
            // Cargamos el diccionario de materiales (de la clase Materials) con los nombres de los
            // atributos de c/tipo de objeto y un valor random
            Factory.stock.LoadMaterialsNeeded(p1);
            Factory.stock.LoadMaterialsNeeded(p2);
            // Aumentamos el stock que se necesita para crear c/producto
            LoadStock(p1, p2);
            // Mostramos Stock Inicial
            CheckStock(1);
            try
            {
                // Intentamos agregar 2 productos
                // Cuando se testea agregar productos ESTAR atentos al LoadMoreStock y su random interno
                // si es muy chico habra que llamarlo varias veces
                // A modo de prueba se puede cambiar su random a uno mayor
                Factory.Create = new Thinkpad("Thinkpad T420", 2500, EScreenSize.MediumScreen, 1, true);
                Factory.Create = new MechanicalKeyboard("Poker3", 1500, EKeyboardSize.Tenkeyless, false, ESwitchColor.CherryBlue);
                Console.WriteLine("Se agregan 2 productos (1)" + Factory.ProductsInfo());
            }
            catch (OutOfStockException ex)
            {
                sinStock = true;
                Console.WriteLine($"No hay stock suficiente (1) ", ex.Message);

            }
            try
            {
                Factory.Create = new MechanicalKeyboard("Qisan Magicforce", 1150, EKeyboardSize.Small, true, ESwitchColor.GateronClear);
                Factory.Create = new MechanicalKeyboard("Das Keyboard 100", 1790, EKeyboardSize.Small, false, ESwitchColor.GateronBrown);
                Console.WriteLine("Se agregan 2 productos (2)" + Factory.ProductsInfo());
            }
            catch (OutOfStockException ex)
            {
                sinStock = true;
                Console.WriteLine("No hay stock suficiente (2) ", ex.Message);
            }

            if (sinStock)
            {
                LoadStock(p1, p2);
                sinStock = false;
            }
            CheckStock(2);
            try
            {
                Factory.Create = new MechanicalKeyboard("Das Keyboard 100", 2655, EKeyboardSize.FullSize, false, ESwitchColor.CherryRed);
                Factory.Create = new Thinkpad("Thinkpad T430", 2500, EScreenSize.LargeScreen, 1, true);
                Console.WriteLine("Se agregan 2 productos (3)" + Factory.ProductsInfo());
            }
            catch (OutOfStockException ex)
            {
                Console.WriteLine("Te quedaste sin stock (3) ", ex.Message);

            }
            CheckStock(3);

            /*
             * 
             * 
             *              PROBAMOS SERIALIZACION
             * 
             * 
             */
            Console.WriteLine("\n@@@@@@ SE PRUEBA SERIALIZACION @@@@@\n");
            try
            {
                // Corroboramos que la lista de productos sea mayor a 0
                // Si no lo es, lanzamos excepcion
                DateTime currentDate = new DateTime();
                currentDate = DateTime.Now;
                if (!(Factory.listaProductos.Count > 0))
                {
                    throw new NoProductCreatedException("Stock is empty, nothing to be serialized\nGo build some");
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "ProductsList - " + currentDate.ToString("-MMddyyyy_HHmmss") + ".xml";
                Serializator<List<Product>> toXml = new Serializator<List<Product>>();
                toXml.SaveXML(path, Factory.listaProductos);
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
            if (sinStock)
            {
                LoadStock(p1, p2);
                sinStock = false;
            }
            CheckStock(4);
            try
            {
                Factory.Create = new MechanicalKeyboard("Das Keyboard 100", 2655, EKeyboardSize.FullSize, false, ESwitchColor.CherryRed);
                Factory.Create = new Thinkpad("Thinkpad T430", 2500, EScreenSize.LargeScreen, 1, true);
                Factory.Create = new Thinkpad("Thinkpad T450", 3500, EScreenSize.LargeScreen, 1, true);
                Console.WriteLine("Se agregan 2 productos (4)" + Factory.ProductsInfo());
            }
            catch (OutOfStockException ex)
            {
                sinStock = true;
                Console.WriteLine("Te quedaste sin stock (4) ", ex.Message);

            }
            CheckStock(5);

            /*
             * 
             * 
             *              PROBAMOS GUARDAR EN DB
             * 
             * 
             */
            Console.WriteLine("\n@@@@@@ SE PRUEBA BASE DATOS @@@@@\n");
            string notebookQuery = null;
            string keyboardQuery = null;
            List<string> thinkpadProperties = null;
            List<string> keyboardProperties = null;
            if (Factory.listaProductos.Count > 0)
            {
                if (Factory.listaProductos.ContainsType("Thinkpad")) // metodo de extension
                {
                    thinkpadProperties = Factory.GetProperties(Factory.listaProductos, "Thinkpad");
                    notebookQuery = SQL<Thinkpad>.BuildInsertQuery(thinkpadProperties, "Notebooks");
                }
                if (Factory.listaProductos.ContainsType("MechanicalKeyboard")) // metodo de extension
                {
                    keyboardProperties = Factory.GetProperties(Factory.listaProductos, "MechanicalKeyboard");
                    keyboardQuery = SQL<MechanicalKeyboard>.BuildInsertQuery(keyboardProperties, "Keyboards");
                }
                try
                {
                    List<Product> temp = new List<Product>(Factory.listaProductos);
                    foreach (Product item in temp)
                    {
                        if (item is Thinkpad)
                        {
                            SQL<Thinkpad>.Insert(notebookQuery, thinkpadProperties, (Thinkpad)item);
                        }
                        if (item is MechanicalKeyboard)
                        {
                            SQL<MechanicalKeyboard>.Insert(keyboardQuery, keyboardProperties, (MechanicalKeyboard)item);
                        }
                        Factory.listaProductos.Remove(item);
                    }
                    Console.WriteLine("Product/s successfully save to DB. Stock emptied");
                }
                catch (InvalidQueryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Stock is empty, nothing to save on DB\nGo build some");
            }

            /*
             * 
             * 
             *              PROBAMOS CONSULTAS BD
             * 
             * 
             */

            Console.WriteLine("\n@@@@@@ SE PRUEBA CONSULTAS A DATOS @@@@@\n");
            List<Product> listN = null;
            List<Product> listK = null;

            try
            {
                listN = SQL<Product>.QueryBD("SELECT * from Notebooks");
                listK = SQL<Product>.QueryBD("SELECT * from Keyboards");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("\n@@@@@@ TABLA: NOTEBOOKS @@@@@\n");
                if (listN != null && listN.Count > 0)
                {
                    foreach (Product item in listN)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                Console.WriteLine("\n@@@@@@ TABLA: TECLADOS @@@@@\n");
                if (listK != null && listK.Count > 0)
                {
                    foreach (Product item in listK)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("OJO, LISTA NULA. CHEQUEAR" + ex.Message);
            }


            Console.WriteLine("FINAL DE LA CLASE TEST");
            Console.ReadKey();
        }


        /*
         * 
         * METODOS STATICOS DE AYUDA
         * 
         */

        public static void LoadStock(MechanicalKeyboard m, Thinkpad t)
        {
            for (int i = 0; i < 10; i++)
            {
                Factory.LoadMoreStock(t);
                Factory.LoadMoreStock(m);
            }
        }

        private static void CheckStock(int n)
        {
            Console.WriteLine("\n##################################");
            Console.WriteLine("##################################");
            Console.WriteLine($"@@@@ CONSULTA DE STOCK N: {n} @@@@");
            Console.WriteLine(Factory.StockInfo());
            Console.WriteLine("##################################");
            Console.WriteLine("##################################\n");
        }
    }
}
