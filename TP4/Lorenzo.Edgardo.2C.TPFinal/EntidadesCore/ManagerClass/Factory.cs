using System;
using System.Collections.Generic;
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
        public  static readonly Materials stock;

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
                catch(OutOfStockException ex)
                {
                    throw new OutOfStockException(ex.Message, ex);
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
        /// <param name="list">La lista donde guardar el ID</param>
        /// <param name="r">La instancia de random</param>
        /// <returns>El ID si se genero con exito, -1 si no</returns>
        private static int GenerateId(List<int> list, Random r)
        {
            int newID = r.Next(0, 10001);
            bool exists = true;
            while(exists)
            {
                exists = false;
                foreach(int item in list)
                {
                    if(item == newID)
                    {
                        exists = true;
                        newID += 1;
                        break;
                    }
                }
            }
            if(!(exists))
            {
                list.Add(newID);
                return newID;
            }
            return -1;
        }

        /// <summary>
        /// Metodo de clase que incrementa el stock de materiales de acuerdo al tipo de producto que recibe por param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Un objeto que tambien tiene un atributo materiales de tipo diccionario</param>
        public static void LoadMoreStock<T>(T obj) where T : Product
        {
            Dictionary<string, int> temp = new Dictionary<string, int>(stock.StockList);
            foreach(string key in temp.Keys)
            {
                foreach(string item in ((T)obj).MaterialsNeeded.Keys)
                {
                    if(key == item)
                    {
                        Thread.Sleep(13);
                        if(obj is Keyboard)
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
        /// <param name="list">La lista donde se guardaran los atributos</param>
        /// <param name="type">El nombre de la Clase</param>
        /// <returns>La lista de atributos</returns>
        public static List<string> GetProperties<T>(List<T> list, string type)
        {
            List<string> properties = new List<string>();
            foreach(T item in list)
            {
                if(item.GetType().Name == type)
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
            foreach(KeyValuePair<string,int> item in stock.StockList)
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
                if(item is Keyboard)
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