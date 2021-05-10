﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {

        #region Constructores
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        { }
        #endregion

        #region Propiedades
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get { return ETamanio.Chico; }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO: {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
        #endregion



    }
}
