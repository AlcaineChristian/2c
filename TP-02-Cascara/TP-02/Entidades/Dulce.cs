﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_2018
{
    public class Dulce : Producto
    {
        public Dulce(EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente, color)
        {
        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine("CODIGO DE BARRAS: " +codigoDeBarras );
            sb.AppendLine("MARCA           : "+  marca);
            sb.AppendLine("COLOR EMPAQUE   : " + colorPrimarioEmpaque);
            sb.AppendLine("---------------------");
            sb.AppendLine("CALORIAS : " + CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");


            return Convert.ToString(sb);
        }
    }
}
