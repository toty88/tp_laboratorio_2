﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructores
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        { }
        #endregion

        #region Propiedades
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get { return ETamanio.Grande; }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
        #endregion

    }
}
