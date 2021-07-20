using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesCore;

namespace FactoryForm
{
    public partial class WarehouseFrm : Form
    {
        DataTable dt;
        public WarehouseFrm()
        {
            InitializeComponent();
            dt = new DataTable();
            
        }
        private void WarehouseFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbProduct.SelectedItem.ToString() == "Keyboard")
                {
                    List<MechanicalKeyboard> meks = new List<MechanicalKeyboard>();

                    foreach (Product item in Factory.listaProductos)
                    {
                        if (item is Keyboard && item is MechanicalKeyboard)
                        {
                            meks.Add((MechanicalKeyboard)item);
                        }
                    }
                    dataGridView1.DataSource = meks;
                    dataGridView1.Columns["CableAmount"].HeaderText = "Cable";
                    dataGridView1.Columns["KeyboardSize"].HeaderText = "Size";
                    dataGridView1.Columns["HasBluetooth"].HeaderText = "Bluetooth";
                    dataGridView1.Columns["KeyCapsAmount"].HeaderText = "Keycaps QTY";
                    dataGridView1.Columns["SwitchesAmount"].HeaderText = "Switches QTY";
                    dataGridView1.Columns["Stabilazers"].HeaderText = "Stabilizers";
                    dataGridView1.Columns["SwtichColor"].HeaderText = "Switch Color";
                    dataGridView1.Columns["SwitchType"].HeaderText = "Switch Type";
                }
                else if(cmbProduct.SelectedItem.ToString() == "Notebook")
                {
                    List<Thinkpad> thinkpads = new List<Thinkpad>();
                    foreach (Product item in Factory.listaProductos)
                    {
                        if (item is Notebook && item is Thinkpad)
                        {
                            thinkpads.Add((Thinkpad)item);
                        }
                    }
                    dataGridView1.DataSource = thinkpads;
                    dataGridView1.Columns["ScreenSize"].HeaderText = "Screen Size";
                    dataGridView1.Columns["RamModules"].HeaderText = "RAM QTY";
                    dataGridView1.Columns["SsdModules"].HeaderText = "SSD QTY";
                    dataGridView1.Columns["HasDockingStation"].HeaderText = "Docking Station";
                }
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns["MaterialsNeeded"].Visible = false;
                dataGridView1.Columns["Serial_Number"].Width = 50;
                dataGridView1.Columns["Serial_Number"].HeaderText = "S/N";
                dataGridView1.Columns["Price"].Width = 100;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("ERROR: No se pudo cargar Informacion de Productos.", ex.Message);
            }
        }
        private void btnVolerMenuPrincipal_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro desea Salir?", "Volver", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK))
            {
                this.Close();
            }
        }
    }
}
