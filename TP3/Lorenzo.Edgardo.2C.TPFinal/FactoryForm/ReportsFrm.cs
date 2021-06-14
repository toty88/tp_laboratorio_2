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
using System.IO;

namespace FactoryForm
{
    public partial class ReportsFrm : Form
    {
        public ReportsFrm()
        {
            InitializeComponent();
        }

        private void ReportsFrm_Load(object sender, EventArgs e)
        {
            this.txtDefaultFileName.Enabled = false;
            this.rtbProducts.Text = "";
            this.ControlBox = false;
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            this.rtbProducts.Text = Factory.ProductsInfo();
        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            string path = null;
            try
            {
                // Corroboramos que la lista de productos sea mayor a 0
                // Si no lo es, lanzamos excepcion
                if(!(Factory.listaProductos.Count > 0))
                {
                    throw new NoProductCreatedException("Stock is empty, nothing to be serialized\nGo build some");
                }
                
                if (!(string.IsNullOrEmpty(this.txtFIileName.Text)))
                {
                    if(this.txtFIileName.Text.Contains(".xml"))
                    {
                        path = AppDomain.CurrentDomain.BaseDirectory + $"{this.txtFIileName.Text}";
                    }
                    else
                    {
                        path = AppDomain.CurrentDomain.BaseDirectory + $"{this.txtFIileName.Text}.xml";
                    }    
                }
                else
                {
                    path = AppDomain.CurrentDomain.BaseDirectory + "Products.xml";
                }
                Serializator<List<Product>> toXml = new Serializator<List<Product>>();
                toXml.Save(path, Factory.listaProductos);
                MessageBox.Show($"XML file created successfully at {AppDomain.CurrentDomain.BaseDirectory}");
            }
            catch (NoProductCreatedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirm back to Main Menu?", "Back Main Menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK))
            {
                this.Close();
            }
        }
    }
}
