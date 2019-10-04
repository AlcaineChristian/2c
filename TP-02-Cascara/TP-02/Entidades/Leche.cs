using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente, color)
        {
            tipo = ETipo.Entera;
        }
        public Leche(EMarca marca, string patente, ConsoleColor color,ETipo tipo)
            : base(marca, patente, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine("CODIGO DE BARRAS: " + codigoDeBarras);
            sb.AppendLine("MARCA           : " + marca);
            sb.AppendLine("COLOR EMPAQUE   : " + colorPrimarioEmpaque);
            sb.AppendLine("---------------------");
            sb.AppendLine("CALORIAS : "+ CantidadCalorias);
            sb.AppendLine("TIPO : " +tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return Convert.ToString(sb);
        }
    }
}
