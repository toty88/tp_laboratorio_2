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
            this.rtbProducts.Text = "";
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            foreach (Product item in Factory.listaProductos)
            {
                if (item is Keyboard)
                {
                    this.rtbProducts.Text += "####### KEYBOARD ########\n";
                }
                else
                {
                    this.rtbProducts.Text += "####### NOTEBOOK ########\n";

                }
                this.rtbProducts.Text += item.ToString();
            }
        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Products.xml";
                Serializator<List<Product>> toXml = new Serializator<List<Product>>();
                toXml.Save(path, Factory.listaProductos);
                MessageBox.Show("xml file created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
