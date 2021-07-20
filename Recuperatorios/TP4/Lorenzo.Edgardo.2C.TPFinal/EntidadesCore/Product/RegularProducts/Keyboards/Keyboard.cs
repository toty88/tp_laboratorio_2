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
    [XmlInclude(typeof(MechanicalKeyboard))]
    public abstract class Keyboard : Product
    {
        #region Atributes
        protected EKeyboardSize keyboardSize;
        protected int keyCapsAmount;
        protected int stabilazers;
        protected int cableAmount;

        #endregion

        #region Constructors
        public Keyboard() { }
        public Keyboard(string model, double price, EKeyboardSize size)
            : base(model, price)
        {
            this.keyboardSize = size;
            this.SetStabilazers();

        }
        #endregion

        #region Properties
        public abstract int KeyCapsAmount { get; set; }
        public abstract EKeyboardSize KeyboardSize { get; set; }
        public abstract int Stabilazers { get; set; }
        public abstract int CableAmount { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo Virtual que agrega al diccionario de materiales el NOMBRE de la propiedad y la cantidad de dicha propiedad
        /// la cantidad representa CUANTO se necesita de dicha propiedad para poder crear el objeto.
        /// </summary>
        protected virtual void AddBasicMaterials()
        {
            if ((!this.materialsNeeded.ContainsKey(nameof(this.KeyCapsAmount)))
                && !this.materialsNeeded.ContainsKey(nameof(this.CableAmount))
                && !this.materialsNeeded.ContainsKey(nameof(this.Stabilazers)))
            {
                this.materialsNeeded.Add(nameof(this.KeyCapsAmount), this.KeyCapsAmount);
                this.materialsNeeded.Add(nameof(this.CableAmount), this.CableAmount);
                this.materialsNeeded.Add(nameof(this.Stabilazers), this.Stabilazers);
            }
        }
        /// <summary>
        /// Metodo exactamente igual a AddBasicMaterials() y que se sobreescribe en las clases hijas.
        /// Sirve para agregar materiales NO BASE, nuevos materiales que pueden llegar a necesitar diferentes tipos
        /// de productos.
        /// </summary>
        protected virtual void AddSecondaryMaterials() { }
        /// <summary>
        /// Metodo que asigna un valor a la cantidad de Estabilizadores, de acuerdo al size del Teclado.
        /// </summary>
        private void SetStabilazers()
        {
            switch (this.KeyboardSize)
            {
                case EKeyboardSize.Small:
                    {
                        this.stabilazers = 2;
                        break;
                    }
                case EKeyboardSize.Tenkeyless:
                    {
                        this.stabilazers = 8;
                        break;
                    }
                default:
                    {
                        this.stabilazers = 9;
                        break;
                    }
            }
        }
        /// <summary>
        /// Sobrecarga del ToString que imprime informacion del Teclado
        /// </summary>
        /// <returns>EL string con la info cargada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Keyboard Size: {this.KeyboardSize.ToString()}");
            sb.AppendLine($"Keycaps Amount: {this.KeyCapsAmount}");
            sb.AppendLine($"Stabilazers Needed: {this.Stabilazers}");
            return sb.ToString();
        }
        #endregion
    }
}
