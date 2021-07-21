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
        private Thread callingThread;
        private static int productsSentToDB_Counter = 0;
        private static DateTime timeStampProductWasSentToDB;
        private static Product finalProductSentToDB;
        private event DataBaseDelegate<List<Product>> DataBaseModified;
        private event DataBaseDelegate<Product> SetInitialLabel;
        #endregion

        #region Constructor
        public ReportsFrm()
        {
            InitializeComponent();
            DataBaseModified += this.UpdateView;
            SetInitialLabel += this.UpdateView;
        }
        #endregion

        #region Frm_Load & VolerMenuPrincipal_Click
        private void ReportsFrm_Load(object sender, EventArgs e)
        {
            this.rtbFromDB.Text = "";
            this.ControlBox = false;
            this.lblCount.Font = new Font("Arial", 28, FontStyle.Regular);
            if (finalProductSentToDB != null)
                this.SetInitialLabel?.Invoke(finalProductSentToDB);
        }
        private void btnVolerMenuPrincipal_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro desea Salir?", "Volver", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK))
            {
                if (!(this.callingThread is null) && this.callingThread.IsAlive)
                    this.callingThread.Abort();
                this.Close();
            }
        }
        #endregion

        #region XML Buttons
        private void btnGuardarXML_Click(object sender, EventArgs e)
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
                if (!(Factory.listaProductos.Count > 0))
                {
                    throw new NoProductCreatedException("ATENCION: No existen Productos en Stock\nCONSTRUI Algunos!!!!");
                }
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentDate = DateTime.Now;
                    Serializator<List<Product>> toXml = new Serializator<List<Product>>();
                    this.saveFileDialog.FileName = this.saveFileDialog.FileName.Remove(this.saveFileDialog.FileName.Length - 4);
                    this.saveFileDialog.FileName += currentDate.ToString("-MMddyyyy_HHmmss") + ".xml";
                    if (toXml.SaveXML(this.saveFileDialog.FileName, Factory.listaProductos))
                    {
                        MessageBox.Show($"Archivo creado con EXITO. Leelo desde el boton CARGAR DESDE XML");
                    }
                }
            }
            catch (NoProductCreatedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullPathException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCargarDeXML_Click(object sender, EventArgs e)
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
                try
                {
                    if (File.Exists(path))
                    {
                        lista = new List<Product>();
                        Serializator<List<Product>> fromXML = new Serializator<List<Product>>();
                        lista = fromXML.OpenXML(path, lista);
                        foreach (Product item in lista)
                        {
                            this.rtbFromXML.Text += item.ToString();
                        }
                    }
                }
                catch(NullPathException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while opening XML: " + ex.Message);
                }
            }
        }
        #endregion

        #region Base de Datos Buttons
        private void btnGuardarEnBase_Click(object sender, EventArgs e)
        {
            string notebookQuery = null;
            string keyboardQuery = null;
            List<string> thinkpadProperties = null;
            List<string> keyboardProperties = null;
            if (Factory.listaProductos.Count > 0)
            {
                try
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
                    foreach (Product item in Factory.listaProductos)
                    {
                        if (item is Thinkpad)
                        {
                            SQL<Thinkpad>.Insert(notebookQuery, thinkpadProperties, (Thinkpad)item);
                        }
                        if (item is MechanicalKeyboard)
                        {
                            SQL<MechanicalKeyboard>.Insert(keyboardQuery, keyboardProperties, (MechanicalKeyboard)item);
                        }
                    }
                    List<Product> temp = new List<Product>(Factory.listaProductos);
                    DataBaseModified?.Invoke(temp);
                    MessageBox.Show("Producto/s Enviados a BD con EXITO. Se vacia Stock!");
                }
                catch (InvalidQueryException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ATENCION: No existen Productos en Stock\nCONSTRUI Algunos!!!!");
            }
        }
        private void btnConsultarBase_Click(object sender, EventArgs e)
        {
            List<Product> list = null;
            try
            {
                if (this.rdbNotebooks.Checked)
                {
                    list = SQL<Product>.QueryBD("SELECT * from Notebooks");
                    this.rdbNotebooks.Checked = false;
                    if (list.Count == 0)
                        MessageBox.Show("ATENCION: No exiten Productos en la Tabla Notebooks", "Consultar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (this.rdbKeyboards.Checked)
                {
                    list = SQL<Product>.QueryBD("SELECT * from Keyboards");
                    this.rdbKeyboards.Checked = false;
                    if (list.Count == 0)
                        MessageBox.Show("ATENCION: No exiten Productos en la Tabla Keyboards", "Consultar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ATENCION: Elegir una Tabla!!!", "Consultar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (!(list is null) && list.Count > 0)
                {
                    this.rtbFromDB.Text = "";
                    foreach (Product item in list)
                    {
                        this.rtbFromDB.Text += item.ToString();
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"ERROR DE CONEXION A BASE DE DATOS: {ex.Message}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DELEGATE-THREADS
        /// <summary>
        /// Manejador subscripto al evento DataBaseModified, que instancia y pone a correr un hilo
        /// </summary>
        /// <param name="obj">El objeto que se le pasa como parametro al metodo del hilo</param>
        private void UpdateView(object obj)
        {
            callingThread = new Thread(new ParameterizedThreadStart(ShowStatistics));
            callingThread.Name = "Actualizar Labels";
            callingThread.Start(obj);
        }
        /// <summary>
        /// Metodo que define que tipo de object llega por parametro. Si es de tipo List<Product>, lo castea, la recorre y por cada
        /// Producto llama al UpdateLabel. Si es de tipo Product, lo castea y llama al UpdateLabel
        /// </summary>
        /// <param name="obj">Un objeto de tipo List<Product> o un objeto de tipo Product</param>
        private void ShowStatistics(object obj)
        {
            if (obj is List<Product>)
            {
                timeStampProductWasSentToDB = DateTime.Now;
                List<Product> list = (List<Product>)obj;
                foreach(Product product in list)
                {
                    this.UpdateLabel(product);
                    finalProductSentToDB = product;
                    productsSentToDB_Counter++;
                    Factory.listaProductos.Remove(product);
                    Thread.Sleep(1500);
                }
            }
            else if(obj is Product)
            {
                this.UpdateLabel((Product)obj);
            }
        }
        /// <summary>
        /// Aqui se utiliza el InvokeRequired ya que este metodo se esta ejecutando 
        /// desde un hilo != al del form actual y se necesita actualizar una etiqueta que no le pertenece al hilo.
        /// </summary>
        /// <param name="product">El objeto de tipo producto que contiene el atributo MODEL para modificar label</param>
        private void UpdateLabel(Product product)
        {
            if (this.lblModel.InvokeRequired)
            {
                this.lblModel.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblModel.Text = $"#Modelo:\n{product.Model}\n#S/N:\n{product.Serial_Number}\n#Hora:\n{timeStampProductWasSentToDB.ToString("HH:mm")}";
                    this.lblCount.Text = productsSentToDB_Counter.ToString();
                });
            }
            else
            {
                this.lblModel.Text = product.Model;
                this.lblCount.Text = productsSentToDB_Counter.ToString();
            }
        }
        #endregion
    }
}
