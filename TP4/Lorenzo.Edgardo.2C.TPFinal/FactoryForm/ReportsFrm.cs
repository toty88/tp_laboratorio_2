using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using EntidadesCore;
using System.IO;

namespace FactoryForm
{
    public delegate void DataBaseDelegate<U>(U obj);
    public partial class ReportsFrm : Form
    {
        #region Atributes
        public Thread callingThread;
        private static int pCount = 0;
        private static Product pFinal;
        private event DataBaseDelegate<Product> DataBaseModified;
        #endregion

        #region Constructor
        public ReportsFrm()
        {
            InitializeComponent();
            DataBaseModified += this.UpdateView;
        }
        #endregion
        
        #region Frm_Load & Back_Click
        private void ReportsFrm_Load(object sender, EventArgs e)
        {
            this.rtbFromDB.Text = "";
            this.ControlBox = false;
            if(pFinal != null)
             this.UpdateView(pFinal);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirm back to Main Menu?", "Back Main Menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK))
            {
                this.Close();
            }
        }
        #endregion

        #region XML Buttons
        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.Title = "Select Directory";
            this.saveFileDialog.FileName = "Choose FileName";
            this.saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            string saveDir = AppDomain.CurrentDomain.BaseDirectory + @"Reports";
            this.saveFileDialog.InitialDirectory = saveDir;
            this.saveFileDialog.RestoreDirectory = true;
            DateTime currentDate;
            try
            {
                if(!(Factory.listaProductos.Count > 0))
                {
                    throw new NoProductCreatedException("Stock is empty, nothing to be serialized\nGo build some");
                }
                if(this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentDate = DateTime.Now;
                    Serializator<List<Product>> toXml = new Serializator<List<Product>>();
                    this.saveFileDialog.FileName = this.saveFileDialog.FileName.Remove(this.saveFileDialog.FileName.Length -4);
                    this.saveFileDialog.FileName += currentDate.ToString("-MMddyyyy_HHmmss")+".xml";
                    if(toXml.SaveXML(this.saveFileDialog.FileName, Factory.listaProductos))
                    {
                        MessageBox.Show($"XML file created successfully at {saveDir}");
                    }
                }
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
        private void btnLoadFromXML_Click(object sender, EventArgs e)
        {
            string path = null;
            List<Product> lista = null;
            this.rtbFromXML.Text = "";
            this.openFileDialog.Title = "Browse XML file";
            this.openFileDialog.FileName = "Choose File";
            this.openFileDialog.Filter = "xml files (*.xml)|*.xml";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                if(File.Exists(path))
                {
                    try
                    {
                        lista = new List<Product>();
                        Serializator<List<Product>> fromXML = new Serializator<List<Product>>();
                        lista = fromXML.OpenXML(path, lista);
                        foreach (Product item in lista)
                            {
                                this.rtbFromXML.Text += item.ToString();
                            }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error while opening XML: " + ex.Message);
                    }
                }
            }
        }
        #endregion
        
        #region DB Buttons
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            string notebookQuery = null;
            string keyboardQuery = null;
            List<string> thinkpadProperties = null;
            List<string> keyboardProperties = null;
            string connectionString = "Data Source=.;Initial Catalog=Products;Integrated Security=True";
            if (Factory.listaProductos.Count > 0)
            {
                if (Factory.listaProductos.ContainsType("Thinkpad")) // metodo de extension
                {
                    thinkpadProperties = Factory.GetProperties(Factory.listaProductos, "Thinkpad");
                    notebookQuery = SQL<Thinkpad>.BuildInsertQuery(thinkpadProperties, "Notebooks");
                }
                if (Factory.listaProductos.ContainsType("MechanicalKeyboard")) // metodo de extension
                {
                    keyboardProperties = Factory.GetProperties(Factory.listaProductos, "MechanicalKeyboard");
                    keyboardQuery = SQL<MechanicalKeyboard>.BuildInsertQuery(keyboardProperties, "Keyboards");
                }
                try
                {
                    List<Product> temp = new List<Product>(Factory.listaProductos);
                    foreach(Product item in temp)
                    {
                        if(item is Thinkpad)
                        {
                            SQL<Thinkpad>.Insert(connectionString, notebookQuery, thinkpadProperties, (Thinkpad)item);
                        }
                        if(item is MechanicalKeyboard)
                        {
                            SQL<MechanicalKeyboard>.Insert(connectionString, keyboardQuery, keyboardProperties, (MechanicalKeyboard)item);
                        }
                        //this.UpdateView(item);
                        DataBaseModified?.Invoke(item);
                        pFinal = item;
                        pCount++;
                        Factory.listaProductos.Remove(item);
                    }
                    MessageBox.Show("Product/s successfully save to DB. Stock emptied");
                }
                catch (InvalidQueryException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Stock is empty, nothing to save on DB\nGo build some");
            }
        }
        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Products;Integrated Security=True";
            List<Product> list = null;
            if (this.rdbNotebooks.Checked)
            {
                list = SQL<Product>.QueryBD(connectionString, "SELECT * from Notebooks");
                this.rdbNotebooks.Checked = false;
            }
            else if(this.rdbKeyboards.Checked)
            {
                list = SQL<Product>.QueryBD(connectionString, "SELECT * from Keyboards");
                this.rdbKeyboards.Checked = false;
            }
            else
            {
                MessageBox.Show("Please Check which table to query");
            }

            if(list != null && list.Count > 0)
            {
                this.rtbFromDB.Text = "";
                foreach (Product item in list)
                {
                    this.rtbFromDB.Text += item.ToString();
                }
            }
        }
        #endregion

        #region DELEGATE-THREADS
        /// <summary>
        /// Metodo que instancia y pone a correr un hilo
        /// </summary>
        /// <param name="obj">El objeto que se le pasa como parametro al metodo del hilo</param>
        private void UpdateView(object obj)
        {
            callingThread = new Thread(new ParameterizedThreadStart(ShowStatistics));
            callingThread.Start(obj);
        }
        /// <summary>
        /// Metodo que actualiza 2 labels del form actual
        /// Aqui se utiliza el InvokeRequired ya que este metodo se esta ejecutando 
        /// desde un hilo != al del form actual
        /// </summary>
        /// <param name="obj">El objeto de tipo producto que contiene el atributo MODEL para modificar label</param>
        private void ShowStatistics(object obj)
        {
            DateTime current;
            current = DateTime.Now;
            Product p = (Product)obj;
            if (this.lblModel.InvokeRequired)
            {
                this.lblModel.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblModel.Text = $"{p.Model} at {current.ToString("HH:mm:ss")}";
                    this.lblCount.Text = pCount.ToString();
                });
            }
            else
            {
                this.lblModel.Text = p.Model;
                this.lblCount.Text = pCount.ToString();
            }
        }
        #endregion
    }
}
