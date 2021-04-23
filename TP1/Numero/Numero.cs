using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumeroLibrary
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto que setea numero en cero a traves de sobrecarga
        /// </summary>
        public Numero()
            :this(0)
        {
        }
        /// <summary>
        /// Constructor que setea el double recibido por defecto al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor que setea el atributo numero a traves de la propiedad SetNumero
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Propiedad
        /// <summary>
        /// Propiedad que asigna valor al atributo numero despues de haber sido validado
        /// </summary>
        public string SetNumero
        {
            set 
            {
                this.numero = Numero.ValidarNumero(value);
            }
        }
        #endregion

        #region Metodos Estaticos
        /// <summary>
        /// Metodo de Clase que verifica si el param str es un numero y se pueda castear a double
        /// Si la str es un double devuelve el valor casteado
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Retorna el double o cero </returns>
        private static double ValidarNumero(string strNumero)
        {

            strNumero = strNumero.Replace('.', ',');
            bool validadoParse = double.TryParse(strNumero, out double validado);
            if(validadoParse == true)
            {
                return validado;
            }
            return 0;
        }
        /// <summary>
        /// Metodo de Clase que verifica si el param str esta compuesto solo por ceros y unos
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retorna true o false </returns>
        private static bool EsBinario(string binario)
        {
            for (int x = 0; x < binario.Length; x++)
            {
                if (binario[x].Equals('1') == false && binario[x].Equals('0') == false)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Metodos de Conversion
        /// <summary>
        /// Metodo de Instancia que convierte un param str a numero decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retornal el numero como str o Error </returns>
        public string BinarioDecimal(string binario)
        {
            if(Numero.EsBinario(binario))
            {
                double temp = 0;
                double y = binario.Length - 1;
                for (int x = 0; x < binario.Length; x++)
                {
                    if (binario[x].Equals('1'))
                    {
                        temp += Math.Pow(2, y);
                    }
                    y--;
                }
                return temp.ToString();
            }
            return "Valor invalido";
        }
        /// <summary>
        /// Metodo de Instancia que convierte un param str a numero binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Retorna el binario, cero si el str contiene un 0 o Error en caso de no poder
        /// convertir </returns>
        public string DecimalBinario(string numero)
        {
            int binarioSize;
            int num;
            string temp = null;
            /* Nos quedamos con la parte entera */
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i].Equals('.'))
                {
                    break;
                }
                temp += numero[i];
            }
            /* Parseamos la parte entera a int */
            bool numeroParse = int.TryParse(temp, out num);
            /*
             * Convertimos a Binario si el parseo fue exitoso
             * Agregamos padding en caso de que el binario sea menor a 65536
             */
            if(numeroParse)
            {
                num = Math.Abs(num);
                string binario = null;
                int cociente = num;
                while (cociente > 1)
                {
                    if (num % 2 == 0)
                    {
                        binario = '0' + binario;
                    }
                    else
                    {
                        binario = '1' + binario;
                    }
                    num /= 2;
                    cociente /= 2;
                }
                if (num != 0)
                {
                    binario = '1' + binario;
                    /* Chequeamos cuanto se precisa de padding */
                    if ((binario.Length / 8) < 1)
                    {
                        binarioSize = 8 - binario.Length;
                    }
                    else
                    {
                        binarioSize = 16 - binario.Length;
                    }
                    for (int x = 0; x < binarioSize; x++)
                    {
                        binario = "0" + binario;
                    }
                    return binario;
                }
                else
                {
                    return "0";
                }
            }
            return "Valor invalido";
        }
        /// <summary>
        /// Metodo de Instancia que convierte double a binario
        /// Pasa numero como param a BinarioDecimal(string binario)
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Retorna el binario, cero si el str contiene un 0 o Error en caso de no poder
        /// convertir </returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }
        #endregion

        #region SobreCarga operador +
        /// <summary>
        /// Metodo que Sobrecarga el operador + para poder sumar dos instancias de Numero en base a su atributo
        /// double numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retorna un double </returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        #endregion

        #region SobreCarga operador -
        /// <summary>
        /// Metodo que Sobrecarga el operador - para poder restar dos instancias de Numero en base a su atributo
        /// double numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retorna un double </returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        #endregion

        #region SobreCarga operador *
        /// <summary>
        /// Metodo que Sobrecarga el operador * para poder multiplicar dos instancias de Numero en base a su atributo
        /// double numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retorna un double </returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion

        #region SobreCarga operador /
        /// <summary>
        /// Metodo que Sobrecarga el operador / para poder dividir dos instancias de Numero en base a su atributo
        /// double numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retorna un double </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero > 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }
        #endregion
    }

}
