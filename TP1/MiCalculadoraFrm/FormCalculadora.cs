using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumeroLibrary;
using CalculadoraLibrary;

namespace MiCalculadoraFrm
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo de Instancia que pertenece al boton Operar y que asigna al lblResultado.Text el retorno 
        /// en str del metodo de Clase Operar, perteneciente a la misma Clase.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text)).ToString("#0.00");
        }        
        /// <summary>
        /// Metodo de Instancia que pertenece al boton Limpiar. LLama a this.Limpiar() y habilita o no
        /// el boton Operar teniendo en cuenta si hay texto o no en el Combo Box cmbOperador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }        
        /// <summary>
        /// Metodo de Instancia que pertenece al boton Cerrar y pregunta al usuario si realmente desea salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO DESEA SALIR?", "Cerrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Metodo de Clase que llama al metodo de Clase Operar (perteneciente a la Libreria de Clase Calculadora).
        /// </summary>
        /// <param name="numero1"> Se pasa como param al Constructor de num1 </param>
        /// <param name="numero2"> Se pasa como param al Constructor de num2 </param>
        /// <param name="operador"> Se pasa como param al metodo Operar </param>
        /// <returns> Retorna un double </returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }
        /// <summary>
        /// Metodo de Instancia que limpia las dos text boxes, la casilla label y el Combo Box.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
        }
        /// <summary>
        /// Metodo de Instancia que pertenece al boton Convertir a Binario
        /// Instancia un objeto de tipo Numero y desde el mismo llama al Metodo de Instancia DecimalBinario
        /// de la Clase Numero, le pasa como param el contenido de la casilla label y asigna el resultado a la
        /// misma casilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero n = new Numero();
            this.lblResultado.Text = n.DecimalBinario(this.lblResultado.Text);
        }
        /// <summary>
        /// Metodo de Instancia que pertenece al boton Convertir a Decimal
        /// Instancia un objeto de tipo Numero y desde el mismo llama al Metodo de Instancia BinarioDecimal
        /// de la Clase Numero, le pasa como param el contenido de la casilla label y asigna el resultado a la
        /// misma casilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero n = new Numero();
            this.lblResultado.Text = n.BinarioDecimal(this.lblResultado.Text);
        }
        /// <summary>
        /// Metodo que habilita/deshabilita la txtNumero2 de acuerdo a si txtNumero1 esta vacio o no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            txtNumero2.Enabled = !string.IsNullOrEmpty(txtNumero1.Text);
        }
    }
}
