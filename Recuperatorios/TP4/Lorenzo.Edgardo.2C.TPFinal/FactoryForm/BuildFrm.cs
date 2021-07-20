using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EntidadesCore;
using System.Data.SqlClient;

namespace FactoryForm
{
    public partial class BuildFrm : Form
    {
        #region Atributes
        private static string productSelected;
        private bool keyboard = false;
        private bool notebook = false;
        #endregion

        #region Constructor
        public BuildFrm()
        {
            InitializeComponent();
            productSelected = null;
        }
        #endregion

        #region BuildFrm_Load & VolverMenuPrincipal
        private void BuildFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void btnVolerMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea Salir?", "Volver", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                if (keyboard || notebook)
                {
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
        }
        #endregion

        #region Stock Methods
        private void KeyboardRadioButtonSelected(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                foreach (Control item in gpbKeyboards.Controls)
                {
                    if (item is RadioButton)
                    {
                        if (((RadioButton)item).Checked)
                        {
                            productSelected = ((RadioButton)item).Text;
                            switch (((RadioButton)item).Name)
                            {
                                case "rbLeopoldFC980M":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\fullsize\Leopold.png");
                                        break;
                                    }
                                case "rbVarmiloVA108M":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\fullsize\Varmilo.png");
                                        break;
                                    }
                                case "rbVortexTab":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\fullsize\Vortex.png");
                                        break;
                                    }
                                case "rbDuckyShine7":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\fullsize\Ducky.png");
                                        break;
                                    }
                                case "rbVortexRace3":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\tenkeyless\Race3.png");
                                        break;
                                    }
                                case "rbVortexPoker2":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\tenkeyless\Poker2.png");
                                        break;
                                    }
                                case "rbVarmiloVA87M":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\tenkeyless\VarmiloVA87M.png");
                                        break;
                                    }
                                case "rbDuckyOne2":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\tenkeyless\DuckyOne.png");
                                        break;
                                    }
                                case "rbVortexCore":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\smallsize\Core.png");
                                        break;
                                    }
                                case "rbQisanMagicforce":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\smallsize\Qisan.png");
                                        break;
                                    }
                                case "rbOlkbPlank":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\smallsize\Plank.png");
                                        break;
                                    }
                                case "rbYMDK":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\keyboards\smallsize\YMDK.png");
                                        break;
                                    }
                                case "rdbThinkpadT420":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\notebooks\t420.jpg");
                                        break;
                                    }
                                case "rdbThinkpadT430":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\notebooks\t430.jpg");
                                        break;
                                    }
                                case "rdbThinkpadT440":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\notebooks\t440.jpg");
                                        break;
                                    }
                                case "rdbThinkpadT450":
                                    {
                                        this.picBKeyboards.Image = Image.FromFile(path + @"\product_pictures\notebooks\t450.jpg");
                                        break;
                                    }
                            }
                        }
                    }
                }
                this.picBKeyboards.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("ERROR: No se encontro imagen de Producto:" + path, ex.Message);
            }
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            StockFrm formularioStock = new StockFrm();
            formularioStock.ShowDialog();
        }
        private void btnConstruirProducto_Click(object sender, EventArgs e)
        {
            // keyboard data
            string keyboardName = null;
            double keyboardPrice;
            bool priceParse;
            EKeyboardSize keyboardSize;
            bool keyboardCable = true;
            ESwitchColor keyboardSwitchColor;

            // notebook data
            string notebookName;
            double notebookPrice;
            EScreenSize notebookScreenSize;
            int notebookTrackpad;
            bool trackpadParse;
            bool notebookDockStation = true;
            try
            {
                if (productSelected.Length > 0)
                {
                    string file = AppDomain.CurrentDomain.BaseDirectory + @"\ProductList.txt";
                    string[] datos;
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains(productSelected))
                            {
                                if (productSelected.Contains("Thinkpad T420") || productSelected.Contains("Thinkpad T430")
                                    || productSelected.Contains("Thinkpad T440") || productSelected.Contains("Thinkpad T450"))
                                {
                                    datos = line.Split(',');
                                    notebookName = datos[0].ToString();
                                    priceParse = double.TryParse(datos[1], out notebookPrice);
                                    notebookScreenSize = (EScreenSize)Enum.Parse(typeof(EScreenSize), datos[2]);
                                    trackpadParse = int.TryParse(datos[3], out notebookTrackpad);
                                    if (datos[4] == "false")
                                    {
                                        notebookDockStation = false;
                                    }
                                    if (string.IsNullOrEmpty(notebookName) || priceParse == false || trackpadParse == false || (datos[4] != "false" && datos[4] != "true"))
                                    {
                                        throw new DataErrorException("ERROR: No se pudo Construir Producto");
                                    }
                                    Factory.Create = new Thinkpad(notebookName, notebookPrice, notebookScreenSize, notebookTrackpad, notebookDockStation);
                                    notebook = true;
                                }
                                else
                                {
                                    datos = line.Split(',');
                                    keyboardName = datos[0].ToString();
                                    priceParse = double.TryParse(datos[1], out keyboardPrice);
                                    keyboardSize = (EKeyboardSize)Enum.Parse(typeof(EKeyboardSize), datos[2]);
                                    if (datos[3] == "false")
                                    {
                                        keyboardCable = false;
                                    }
                                    keyboardSwitchColor = (ESwitchColor)Enum.Parse(typeof(ESwitchColor), datos[4]);
                                    if (string.IsNullOrEmpty(keyboardName) || priceParse == false || (datos[3] != "false" && datos[3] != "true"))
                                    {
                                        throw new DataErrorException("ERROR: No se pudo Construir Producto");
                                    }
                                    Factory.Create = new MechanicalKeyboard(keyboardName, keyboardPrice, keyboardSize, keyboardCable, keyboardSwitchColor);
                                    keyboard = true;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show($"{productSelected} Construido Exitosamente");
            }
            catch (DataErrorException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"ERROR: No se encuentra listado de Productos. {ex.Message}");
            }
            catch (OutOfStockException ex)
            {
                MessageBox.Show($"ATENCION: Falta Stock para Construir: {productSelected}\n" +
                    $"Cargue mas Stock");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
