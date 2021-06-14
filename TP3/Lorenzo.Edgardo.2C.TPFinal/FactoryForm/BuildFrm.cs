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
        private static string keyboardSelected;
        private bool keyboard = false;
        private bool notebook = false;
        public BuildFrm()
        {
            InitializeComponent();
            keyboardSelected = null;
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
                            keyboardSelected = ((RadioButton)item).Text;
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
                MessageBox.Show("File not found" + path);
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
            if (formularioStock.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Formulario Stock finalizado con exito");
            }
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
                if (keyboardSelected.Length > 0)
                {
                    string file = AppDomain.CurrentDomain.BaseDirectory + @"\ProductList.txt";
                    string[] datos;
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains(keyboardSelected))
                            {
                                if (keyboardSelected.Contains("Thinkpad T420") || keyboardSelected.Contains("Thinkpad T430") 
                                    || keyboardSelected.Contains("Thinkpad T440") || keyboardSelected.Contains("Thinkpad T450"))
                                {
                                    datos = line.Split(',');
                                    notebookName = datos[0];
                                    priceParse = double.TryParse(datos[1], out notebookPrice);
                                    notebookScreenSize = (EScreenSize)Enum.Parse(typeof(EScreenSize), datos[2]);
                                    trackpadParse = int.TryParse(datos[3], out notebookTrackpad);
                                    if (datos[4] == "false")
                                    {
                                        notebookDockStation = false;
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
                                    Factory.Create = new MechanicalKeyboard(keyboardName, keyboardPrice, keyboardSize, keyboardCable, keyboardSwitchColor);
                                    keyboard = true;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show($"{keyboardSelected} build successfully");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Product List not found. Cant build Product");
            }
            catch (OutOfStockException ex)
            {
                MessageBox.Show("No more stock available, please go to Stock section");
            }
        }
    }
}
