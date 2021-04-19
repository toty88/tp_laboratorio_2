using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumeroLibrary;

namespace CalculadoraLibrary
{
    public static class Calculadora
    {
        /// <summary>
        /// Metodo de Clase que en base a un operador recibido (+, -, *, /) realiza la operacion entre dos instancias
        /// de la Clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="operador"> El operador aritmetico </param>
        /// <returns> Retorna un double </returns>
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double resultado = 0;
            bool operacionParse;
            operacionParse = char.TryParse(operador, out char operacion);
            switch (Calculadora.ValidarOperador(operacion))
            {
                case "+":
                    {
                        resultado = n1 + n2;
                    }
                    break;
                case "-":
                    {
                        resultado = n1 - n2;
                    }
                    break;
                case "*":
                    {
                        resultado = n1 * n2;
                    }
                    break;
                case "/":
                    {
                        resultado = n1 / n2;
                    }
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Metodo de Clase que valida un param de tipo char
        /// </summary>
        /// <param name="operador"> El operador a validar </param>
        /// <returns> Retorna el param si fue validado, caso contrario retorna la str "+" </returns>
        private static string ValidarOperador(char operador)
        {
            if(operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                return "+";
            }
            return operador.ToString();
        }
    }
}
