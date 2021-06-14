using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesCore
{
    [Serializable]
    [XmlInclude(typeof(Keyboard))]
    [XmlInclude(typeof(Notebook))]
    public abstract class Product
    {
        #region Atributes
        protected string model;
        protected double price;
        protected int serialNumber;
        [XmlIgnore]
        protected Dictionary<string, int> materialsNeeded;
        #endregion

        #region Constructors
        public Product() 
        {
            materialsNeeded = new Dictionary<string, int>();
        }
        public Product(string model, double price)
            :this()
        {
            this.Model = model;
            this.Price = price;
        }
        #endregion

        #region Properties
        public abstract string Model { get; set; }
        public abstract double Price { get; set; }
        public abstract int Serial_Number { get; set; }
        [XmlIgnore]
        public abstract Dictionary<string, int> MaterialsNeeded { get; }
        #endregion

        #region Overloadings
        /// <summary>
        /// Metodo que corrobora la existencia de un Producto dentro de una lista de Productos
        /// </summary>
        /// <param name="lista">La lista que contiene Productos</param>
        /// <param name="p">El Producto a evaluar</param>
        /// <returns>true si el objeto se encuentra en la lista, false caso contrario</returns>
        public static bool operator ==(List<Product> lista, Product p)
        {
            if(lista.Count > 0)
            {
                foreach(Product item in lista)
                {
                    if(item.GetType() == p.GetType() 
                        && item.Serial_Number == p.Serial_Number
                        && item.Model == p.Model)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que corrobora la existencia de un Producto dentro de una lista de Productos
        /// </summary>
        /// <param name="lista">La lista que contiene Productos</param>
        /// <param name="p">El Producto a evaluar</param>
        /// <returns>true si el objeto NO se encuentra en la lista, false caso contrario</returns>
        public static bool operator !=(List<Product> lista, Product p)
        {
            return !(lista == p);
        }
        /// <summary>
        /// Metodo que agrega un Producto a una lista de Productos, siempre y cuando este no se enuentre en la misma
        /// </summary>
        /// <param name="lista">La lista que contiene Productos</param>
        /// <param name="p">El Producto a evaluar</param>
        /// <returns>true si se agrego OK a la lista, false caso contrario</returns>
        public static bool operator +(List<Product> lista, Product p)
        {
            if(lista != p)
            {
                lista.Add(p);
                return true;
            }
            return false;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Sobrecarga del ToString que imprime informacion del Producto
        /// </summary>
        /// <returns>EL string con la info cargada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Serial Number: {this.Serial_Number}");
            sb.AppendLine($"Price: {this.Price:C2}");
            return sb.ToString();
        }
        #endregion
    }
}
