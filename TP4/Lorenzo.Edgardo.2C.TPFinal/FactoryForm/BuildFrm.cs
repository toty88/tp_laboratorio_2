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

namespace FactoryForm
{
    public partial class BuildFrm : Form
    {
        private static string productSelected;
        private bool keyboard = false;
        private bool notebook = false;
        public BuildFrm()
        {
            InitializeComponent();
            productSelected = null;
        }

        private void BuildFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void gpbKeyboards_Enter(object sender, EventArgs e)
        {
            
        }

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
                MessageBox.Show("File not found at:" + path, ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm back to Menu?", "Back Main Menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                == DialogResult.OK)
            {
                if (keyboard || notebook)
                {
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockFrm formularioStock = new StockFrm();
            formularioStock.ShowDialog();
        }

        private void btnBuild_Click(object sender, EventArgs e)
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
                                    if(string.IsNullOrEmpty(notebookName) || priceParse == false || trackpadParse == false || (datos[4] != "false" && datos[4] != "true"))
                                    {
                                        throw new DataErrorException("There was a problem loading Product Data");
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
                                        throw new DataErrorException("There was a problem loading Product Data");
                                    }
                                    Factory.Create = new MechanicalKeyboard(keyboardName, keyboardPrice, keyboardSize, keyboardCable, keyboardSwitchColor);
                                    keyboard = true;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show($"{productSelected} build successfully");
            }
            catch(DataErrorException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Product List not found. Cant build Product");
            }
            catch (OutOfStockException ex)
            {
                MessageBox.Show($"No more stock available to build {productSelected}\n" +
                    $"Go to Stock section");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
