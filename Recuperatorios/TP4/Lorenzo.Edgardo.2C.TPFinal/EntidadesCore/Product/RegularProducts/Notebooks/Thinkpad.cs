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
    public class Thinkpad : Notebook
    {
        #region Atributes
        protected int trackpad;
        protected bool hasDockingStation;
        #endregion

        #region Constructores
        public Thinkpad() { }
        public Thinkpad(string model, double price, EScreenSize screenSize = EScreenSize.MediumScreen)
        : base(model, price, screenSize, 1, 1)
        { }
        public Thinkpad(string model, double price, EScreenSize screenSize, int trackpad,
            bool hasDockingStation)
            : this(model, price, screenSize)
        {
            this.Trackpad = trackpad;
            this.HasDockingStation = hasDockingStation;
            this.Speakers = 2;
            this.AddSecondaryMaterials();
        }
        #endregion

        #region Properties
        public override int Serial_Number { get { return base.serialNumber; } set { base.serialNumber = value; } }
        public override string Model { get { return base.model; } set { base.model = value; } }
        public override double Price
        {
            get
            {
                return base.price;
            }
            set
            {
                if (value >= 3300)
                {
                    this.RamModules = 3;
                }
                else
                {
                    this.RamModules = 2;
                }
                base.price = value;
            }
        }
        public override EScreenSize ScreenSize { get { return base.screenSize; } set { base.screenSize = value; } }
        public override int SsdModules { get { return base.ssdModules; } set { base.ssdModules = value; } }
        public override int RamModules { get { return base.ramModules; } set { this.ramModules = value; } }
        public override int Battery { get { return base.battery; } set { base.battery = value; } }
        public override int Speakers
        {
            get
            {
                return base.speakers;
            }
            set
            {
                if ((int)this.ScreenSize == (int)EScreenSize.LargeScreen)
                {
                    this.speakers = value;
                }
                else
                {
                    this.speakers = 1;
                }
            }
        }
        public int Trackpad { get { return this.trackpad; } set { this.trackpad = value; } }
        public bool HasDockingStation
        {
            get { return this.hasDockingStation; }
            set { this.hasDockingStation = value; }
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
            if (!(this.materialsNeeded.ContainsKey(nameof(this.Trackpad))))
            {
                this.materialsNeeded.Add(nameof(this.Trackpad), this.Trackpad);

            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"TrackPad: {this.Trackpad}");
            sb.AppendLine($"Includes Docking Station: {this.HasDockingStation}");
            sb.AppendLine("########################\n");
            return sb.ToString();
        }
        #endregion
    }
}
