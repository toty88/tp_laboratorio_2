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
    [XmlInclude(typeof(Thinkpad))]
    public abstract class Notebook : Product
    {
        #region Atributes
        protected int ssdModules;
        protected int ramModules;
        protected int speakers;
        protected int battery;
        protected EScreenSize screenSize;
        #endregion

        #region Constructors
        public Notebook() 
        { }
        public Notebook(string model, double price, EScreenSize screenSize,
            int ssdModules, int battery)
        : base(model, price)
        {
            this.screenSize = screenSize;
            this.ssdModules = ssdModules;
            this.battery = battery;
        }
        #endregion

        #region Properties
        public abstract EScreenSize ScreenSize { get; set; }
        public abstract int SsdModules { get; set; }
        public abstract int RamModules { get; set; }
        public abstract int Speakers { get; set; }
        public abstract int Battery { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo que agrega al diccionario de materiales el NOMBRE de la propiedad y la cantidad de dicha propiedad
        /// la cantidad representa CUANTO se necesita de dicha propiedad para poder crear el objeto.
        /// </summary>
        protected virtual void AddBasicMaterials()
        {
            if ((!this.materialsNeeded.ContainsKey(nameof(this.SsdModules)))
                && !this.materialsNeeded.ContainsKey(nameof(this.RamModules))
                && !this.materialsNeeded.ContainsKey(nameof(this.Speakers)))
            {
                this.materialsNeeded.Add(nameof(this.SsdModules), this.SsdModules);
                this.materialsNeeded.Add(nameof(this.RamModules), this.RamModules);
                this.materialsNeeded.Add(nameof(this.Speakers), this.Speakers);

            }
        }
        /// <summary>
        /// Metodo exactamente igual a AddBasicMaterials() y que se sobreescribe en las clases hijas.
        /// Sirve para agregar materiales NO BASE, nuevos materiales que pueden llegar a necesitar diferentes tipos
        /// de productos.
        /// </summary>
        protected virtual void AddSecondaryMaterials() { }
        
        /// <summary>
        /// Sobrecarga del ToString que imprime informacion de la Notebook
        /// </summary>
        /// <returns>EL string con la info cargada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Screen Size: {this.ScreenSize.ToString()}");
            sb.AppendLine($"SSD Modules: {this.SsdModules}");
            sb.AppendLine($"RAM Modules: {this.RamModules}");
            sb.AppendLine($"Speakers : {this.Speakers}");
            sb.AppendLine($"Battery Modules: {this.Battery}");
            return sb.ToString();
        }
        #endregion
    }
}
