﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        public Snacks(EMarca marca, string patente, ConsoleColor color)
            
        {
        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(Convert.ToString(this));
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return Convert.ToString(sb);
        }
    }
}