using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public static class Factory
    {
        #region Atributes
        public static List<Product> listaProductos;
        private static readonly List<int> listOfProductsID;
        private static readonly Random random;
        public static readonly Materials stock;
        #endregion

        #region Constructor
        static Factory()
        {
            listaProductos = new List<Product>();
            listOfProductsID = new List<int>();
            random = new Random(DateTime.Now.Millisecond);
            stock = Materials.GetStock();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad setter que Crea un producto y lo agrega a la lista, en caso de que haya stock 
        /// y no tenga ID repetido
        /// </summary>
        public static Product Create
        {
            set
            {
                try
                {
                    value.Serial_Number = GenerateId(listOfProductsID, random);
                    if (value.Serial_Number != -1
                        && StockAvailable(value)
                        && listaProductos + value
                        && SubstractMaterials(value))
                    {

                    }
                }
                catch (OutOfStockException ex)
                {
                    throw new OutOfStockException(ex.Message, ex);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo Generic que resta stock del diccionario de materiales de la clase Materials
        /// La clase Factory contiene un atributo de tipo Materials
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Un objeto que tambien tiene un atributo materiales de tipo diccionario</param>
        /// <returns>true si se pudo restar materiales, false caso contrario </returns>
        private static bool SubstractMaterials<T>(T obj) where T : Product
        {
            bool exit = false;
            Dictionary<string, int> temp = new Dictionary<string, int>(stock.StockList);
            foreach (string product_material in ((T)obj).MaterialsNeeded.Keys)
            {
                foreach (string stock_material in temp.Keys)
                {
                    if (stock_material == product_material)
                    {
                        stock.StockList[stock_material] -= ((T)obj).MaterialsNeeded[product_material];
                        exit = true;
                        break;
                    }
                }
            }
            return exit;
        }
        /// <summary>
        /// Metodo Generic que chequea que haya stock disponible para poder crear el objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Un objeto que tambien tiene un atributo materiales de tipo diccionario</param>
        /// <returns></returns>
        static bool StockAvailable<T>(T obj) where T : Product
        {
            bool hasEnoughMaterial = false;
            foreach (string material_item in stock.StockList.Keys)
            {
                foreach (string product_item in ((T)obj).MaterialsNeeded.Keys)
                {
                    if (material_item == product_item)
                    {
                        if (stock.StockList[material_item] >= ((T)obj).MaterialsNeeded[product_item])
                        {
                            hasEnoughMaterial = true;
                            break;
                        }
                        else
                        {
                            throw new OutOfStockException();
                        }
                    }
                }
            }
            return hasEnoughMaterial;
        }
        /// <summary>
        /// Metodo que genera un ID random y lo guarda en una lista de IDs (en caso de que no exista)
        /// </summary>
        /// <param name="list">La lista donde guardar el nuevo ID</param>
        /// <param name="r">La instancia de random</param>
        /// <returns>El ID si se genero con exito, -1 si no</returns>
        private static int GenerateId(List<int> listOfProductsID, Random r)
        {
            int newID = r.Next(0, 10001);
            bool exists;
            try
            {
                /* Obtenemos c/Producto de la tabla de Notebooks & Keyboards*/
                List<Product> notebooksInBD = Factory.GetProductsFromDB("Notebooks");
                List<Product> keyboardsInBD = Factory.GetProductsFromDB("Keyboards");
                /* Obtenemos de c/Producto su ID y lo almacenamos en una List<int>*/
                List<int> productsInBD_IDS = Factory.GetProductsSerialNumber(notebooksInBD);
                productsInBD_IDS.AddRange(Factory.GetProductsSerialNumber(keyboardsInBD));
                /* Ordenamos la lista de IDs interna de Factory y la creada en el paso anterior*/
                productsInBD_IDS.Sort();
                listOfProductsID.Sort();
                /* Comparamos IDs y en caso de existir aumentamos newID en 1. Repetimos*/
                exists = Factory.ContainsID(productsInBD_IDS, ref newID);
                exists = Factory.ContainsID(listOfProductsID, ref newID);
                if (!(exists))
                {
                    listOfProductsID.Add(newID);
                    return newID;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return -1;
        }
        /// <summary>
        /// Metodo que recorre lista de ID y compara contra uno generado con Random
        /// Si se encuentra en la lista, le suma uno
        /// </summary>
        /// <param name="list">La lista de tipo int de IDs</param>
        /// <param name="newID">El ID que se compara contra los IDs de la lista</param>
        /// <returns>True si existe, False si no</returns>
        private static bool ContainsID(List<int> list, ref int newID)
        {
            bool exists = true;
            while (exists)
            {
                exists = list.Contains(newID);
                if(exists)
                    newID += 1;
            }
            return exists;
        }
        /// <summary>
        /// Metodo que guarda en una lista de int los ID de cada Producto dentro de list
        /// </summary>
        /// <param name="list">La lista de Productos</param>
        /// <returns>La lista de int (ids)</returns>
        private static List<int> GetProductsSerialNumber(List<Product> list)
        {
            List<int> productsID = new List<int>();
            foreach(Product item in list)
            {
                productsID.Add(item.Serial_Number);
            }
            return productsID;
        }
        /// <summary>
        /// Metodo que obtiene de la BD los productos de acuerdo a la tabla pasada por param
        /// </summary>
        /// <param name="table">La tabla</param>
        /// <returns>La lista de Productos</returns>
        private static List<Product> GetProductsFromDB(string table)
        {
            List<Product> list;
            try
            {
                list = SQL<Product>.QueryBD($"SELECT * from {table}");
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo de clase que incrementa el stock de materiales de acuerdo al tipo de producto que recibe por param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Un objeto que tambien tiene un atributo materiales de tipo diccionario</param>
        public static void LoadMoreStock<T>(T obj) where T : Product
        {
            Dictionary<string, int> temp = new Dictionary<string, int>(stock.StockList);
            foreach (string key in temp.Keys)
            {
                foreach (string item in ((T)obj).MaterialsNeeded.Keys)
                {
                    if (key == item)
                    {
                        Thread.Sleep(13);
                        if (obj is Keyboard)
                        {
                            stock.StockList[key] += random.Next(17, 53);
                        }
                        else
                        {
                            stock.StockList[key] += random.Next(3, 7);
                        }
                        break;
                    }
                }
            }
        }
        #endregion

        #region Info Methodos
        /// <summary>
        /// Metodo que devuelve una lista de atributos de un objeto segun su Clase
        /// </summary>
        /// <typeparam name="T">La clase del objeto a obtener los atributos</typeparam>
        /// <param name="list">La lista que contiene los objetos</param>
        /// <param name="type">El nombre de la Clase</param>
        /// <returns>La lista de atributos</returns>
        public static List<string> GetProperties<T>(List<T> list, string type)
        {
            List<string> properties = new List<string>();
            foreach (T item in list)
            {
                if (item.GetType().Name == type)
                {
                    foreach (var prop in item.GetType().GetProperties())
                    {
                        properties.Add(prop.Name);
                    }
                    break;
                }
            }
            properties.Remove(properties.Last());
            return properties;
        }
        /// <summary>
        /// Metodo que recorre el diccionario de materiales (stock) y guarda informacion sobre el nombre y la cantidad,
        /// en un string
        /// </summary>
        /// <returns>EL string creado a partir de todos los materiales</returns>
        public static string StockInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***** STOCK DISPONIBLE *****");
            foreach (KeyValuePair<string, int> item in stock.StockList)
            {
                sb.AppendLine($"{item.Key} left: {item.Value}");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que guarda informacion sobre c/producto de la lista de productos en un string
        /// </summary>
        /// <returns>El string creado a partir de los productos </returns>
        public static string ProductsInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product item in listaProductos)
            {
                if (item is Keyboard)
                {
                    sb.AppendLine("\n####### KEYBOARD #######");
                }
                else
                {
                    sb.AppendLine("\n####### NOTEBOOK #######");
                }
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}