using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public class Materials
    {
        #region Atributes
        private static Dictionary<string, int> stockList;
        private static Materials singleton;
        private static Random random;
        #endregion

        #region Constructors
        static Materials()
        {
            stockList = new Dictionary<string, int>();
            random = new Random(DateTime.Now.Millisecond);
        }
        #endregion

        #region Methods & Properties
        /// <summary>
        /// Metodo que instancia un objeto de tipo Materials en caso de que sea null, si no es null devuelve el mismo
        /// objeto
        /// </summary>
        /// <returns>El objeto Materials</returns>
        public static Materials GetStock()
        { 
            if(singleton is null)
            {
                singleton = new Materials();
            }
            return singleton;
        }
        public Dictionary<string,int> StockList
        {
            get { return stockList; }
        }
        

        /// <summary>
        /// Metodo que se utiliza para agregar a la lista de materiales aquellos que no existen (dependiendo
        /// del tipo de producto) y darles un valor (stock) inicial
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Un objeto que tambien tiene un atributo materiales de tipo diccionario</param>
        public void LoadMaterialsNeeded<T>(T obj) where T : Product
        {
            // Cada instancia de tipo Producto contiene una lista: MaterialsNeeded con los materiales base
            // para poder fabricar 1 item del mismo
            foreach (string product_item in ((T)obj).MaterialsNeeded.Keys)
            {
                // stockList es un diccionary de la clase que va a contener todos los materiales y el stock
                // de todos los tipos de Productos
                if(!stockList.ContainsKey(product_item))
                {
                    Thread.Sleep(13);
                    stockList.Add(product_item, random.Next(77,237));
                }
            }
        }
        #endregion
    }
}