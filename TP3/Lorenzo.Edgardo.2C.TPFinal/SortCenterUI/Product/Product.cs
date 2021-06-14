using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public abstract class Product
    {
        #region Atributes
        protected string model;
        protected double price;
        protected int serialNumber;
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
        public abstract String Model { get; set; }
        public abstract double Price { get; set; }
        public abstract int Serial_Number { get; set; }
        public abstract Dictionary<string, int> MaterialsNeeded { get; }
        #endregion

        #region Overloadings
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
        public static bool operator !=(List<Product> lista, Product p2)
        {
            return !(lista == p2);
        }

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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("######## PRODUCTO ############");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Serial Number: {this.Serial_Number}");
            sb.AppendLine($"Price: {this.Price:C2}");
            return sb.ToString();
        }
        #endregion
    }
}
