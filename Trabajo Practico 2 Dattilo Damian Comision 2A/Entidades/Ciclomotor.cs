﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) :base(chasis, marca, color) { }

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CICLOMOTOR");
            sb.AppendLine($"MARCA : {this.marca.ToString()}");
            sb.AppendLine($"CHASIS : {this.chasis}");
            sb.AppendLine($"COLOR : {this.color.ToString()}");
            sb.AppendLine($"TAMAÑO : {this.Tamanio.ToString()}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
