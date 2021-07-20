using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using EntidadesCore;

namespace FactoryForm
{
    public partial class StockFrm : Form
    {
        static DataTable dt = new DataTable();
        private List<Product> productsToLoad;
        List<string> nameList;
        List<int> valueList;
        public StockFrm()
        {
            InitializeComponent();
            productsToLoad = new List<Product>();
        }
        private void StockFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                this.picBStockFrm.Image = Image.FromFile(path + @"\StockFrmImage.jpg");
                this.picBStockFrm.SizeMode = PictureBoxSizeMode.StretchImage;
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("ERROR: No se puede cargar imagen", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.chartStock.BackColor = Color.Transparent;
            this.chartStock.ChartAreas[0].BackColor = Color.Transparent;
            productsToLoad.Add(new Thinkpad("T420", 2000, EScreenSize.LargeScreen, 1, false));
            productsToLoad.Add(new MechanicalKeyboard("Poker3", 1500, EKeyboardSize.Tenkeyless, true, ESwitchColor.CherryBlue));
            this.ControlBox = false;
            this.UpdateChart();
        }
        private void UpdateChart()
        {
            nameList = Factory.stock.StockList.Keys.ToList();
            valueList = Factory.stock.StockList.Values.ToList();
            for (int i = 0; i < nameList.Count; i++)
            {
                chartStock.Series["Stock"].Points.AddXY(nameList[i], valueList[i]);
            }
        }
        private void btnAgregarStockInsumosTeclados_Click(object sender, EventArgs e)
        {
            Factory.LoadMoreStock(productsToLoad[1]);
            chartStock.Series[0].Points.Clear();
            UpdateChart();
        }
        private void btnAgregarStockInsumosNotebooks_Click(object sender, EventArgs e)
        {
            Factory.LoadMoreStock(productsToLoad[0]);
            chartStock.Series[0].Points.Clear();
            UpdateChart();
        }
        private void btnAgregarStockInsumosProductos_Click(object sender, EventArgs e)
        {
            Factory.LoadMoreStock(productsToLoad[0]);
            Factory.LoadMoreStock(productsToLoad[1]);
            chartStock.Series[0].Points.Clear();
            UpdateChart();
        }
        private void btnVolerMenuPrincipal_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro desea Salir?", "Volver", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
