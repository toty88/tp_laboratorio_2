using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using EntidadesCore;

namespace FactoryForm
{
    public partial class MainFrm : Form
    {
        #region Constructor
        public MainFrm()
        {
            InitializeComponent();

            this.lblTitle.Text = " Fabrica de Teclados y Notebooks Lorenzo";
            this.tmrTimer.Interval = 700;
            this.tmrTimer.Tick += new EventHandler(this.Parpadear);
            this.tmrTimer.Start();
        }
        #endregion

        #region MainFrm_Load & Init & Salir & Parpadear
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
                MessageBox.Show("Error al cargar Imagen Principal", ex.Message);
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea Salir?", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {

                this.Close();
            }
        }
        /// <summary>
        /// Manejador del evento Tick del objeto de tipo Timer.
        /// Cambial el color de la etiqueta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void Parpadear(Object sender, EventArgs eventArgs)
        {
            if (this.lblTitle.ForeColor == Color.Transparent)
            {
                this.lblTitle.ForeColor = Color.Red;
            }
            else
            {
                this.lblTitle.ForeColor = Color.Transparent;
            }
        }
        #endregion

        #region Reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportsFrm reportsFrm = new ReportsFrm();
            if (reportsFrm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Inventario guardado con Exito");
            }
        }
        #endregion

        #region Construir Productos
        private void btnConstruirProductos_Click(object sender, EventArgs e)
        {
            BuildFrm buildfrm = new BuildFrm();
            if (buildfrm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Construccion Exitosa", "Construir Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Ver & Cargar Stock
        private void btnVerCargarStock_Click(object sender, EventArgs e)
        {
            StockFrm formularioStock = new StockFrm();
            formularioStock.ShowDialog();
        }
        #endregion

        #region Deposito
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            WarehouseFrm warehouseFrm = new WarehouseFrm();
            warehouseFrm.ShowDialog();
        }
        #endregion
    }
}
