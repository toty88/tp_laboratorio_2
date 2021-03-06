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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            InitFactory();
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                this.picBMainFrm.Image = Image.FromFile(path + @"\MainFrmImage.png");
                this.picBMainFrm.SizeMode = PictureBoxSizeMode.StretchImage;
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Cant load Front image", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void InitFactory()
        {
            Factory.stock.LoadMaterialsNeeded(new Thinkpad("T420", 2000,
                EScreenSize.LargeScreen, 1, false));
            Factory.stock.LoadMaterialsNeeded(new MechanicalKeyboard("Poker3", 1500,
                EKeyboardSize.Tenkeyless, false, ESwitchColor.CherryBlue));
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            StockFrm formularioStock = new StockFrm();
            formularioStock.ShowDialog();
  
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            BuildFrm buildfrm = new BuildFrm();
            if (buildfrm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successful Build", "Product Build", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseFrm warehouseFrm = new WarehouseFrm();
            warehouseFrm.ShowDialog();

        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsFrm reportsFrm = new ReportsFrm();
            if (reportsFrm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Inventory saved successfully");
            }
        }
    }
}
