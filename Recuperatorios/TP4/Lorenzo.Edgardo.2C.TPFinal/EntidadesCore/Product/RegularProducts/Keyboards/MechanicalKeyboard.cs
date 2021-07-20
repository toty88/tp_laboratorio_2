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
    public class MechanicalKeyboard : Keyboard
    {
        #region Atributes
        protected bool hasBluetooth;
        protected int swtiches;
        protected ESwitchType switchType;
        protected ESwitchColor switchColor;
        #endregion

        #region Constructors
        public MechanicalKeyboard() { }
        public MechanicalKeyboard(string model, double price, EKeyboardSize size)
            : base(model, price, size)
        { }
        public MechanicalKeyboard(string model, double price, EKeyboardSize size,
            bool hasBluetooth, ESwitchColor switchColor)
            : this(model, price, size)
        {
            this.HasBluetooth = hasBluetooth;
            this.CableAmount = 0;
            this.switchColor = switchColor;
            this.AddSecondaryMaterials();
        }
        #endregion

        #region Properties
        public override int Serial_Number
        {
            get { return base.serialNumber; }
            set { base.serialNumber = value; }
        }
        public override string Model
        {
            set { base.model = value; }
            get { return base.model; }
        }
        public override double Price
        {
            set { base.price = value; }
            get { return base.price; }
        }
        public override EKeyboardSize KeyboardSize
        {
            get { return base.keyboardSize; }
            set { base.keyboardSize = value; }
        }
        public override int CableAmount
        {
            get { return base.cableAmount; }
            set
            {
                if (this.HasBluetooth)
                {
                    base.cableAmount = value;
                }
                else
                {
                    base.cableAmount = 1;
                }
            }
        }
        public override int KeyCapsAmount
        {
            get { return (int)this.KeyboardSize; }
            set { this.keyCapsAmount = (int)this.KeyboardSize; }
        }
        public int SwitchesAmount
        {
            get { return (int)this.KeyboardSize; }
            set { this.swtiches = (int)this.KeyboardSize; }
        }
        public ESwitchColor SwtichColor
        {
            get { return this.switchColor; }
            set { this.switchColor = value; }
        }
        public ESwitchType SwitchType
        {
            get { return (ESwitchType)SwtichColor; }
            set { this.switchType = value; }
        }
        public override int Stabilazers
        {
            get { return this.stabilazers; }
            set { this.stabilazers = value; }
        }
        public bool HasBluetooth
        {
            set
            {
                this.hasBluetooth = value;
            }
            get { return this.hasBluetooth; }
        }
        [XmlIgnore]
        public override Dictionary<string, int> MaterialsNeeded
        {
            get
            {
                return this.materialsNeeded;
            }
        }
        #endregion

        #region Methods
        protected override void AddBasicMaterials()
        {
            base.AddBasicMaterials();
        }
        protected override void AddSecondaryMaterials()
        {
            this.AddBasicMaterials();
            if (!this.materialsNeeded.ContainsKey(nameof(this.SwitchesAmount)))
            {

                this.materialsNeeded.Add(nameof(this.SwitchesAmount), this.SwitchesAmount);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Cable Included: {this.CableAmount}");
            sb.AppendLine($"Bluetooth Compatible: {this.HasBluetooth}");
            sb.AppendLine($"Switches Amount: {this.SwitchesAmount}");
            sb.AppendLine($"Swtich Color: {this.SwtichColor}");
            sb.AppendLine($"Switch Type: {this.SwitchType}");
            sb.AppendLine("########################\n");
            return sb.ToString();
        }
        #endregion
    }
}

