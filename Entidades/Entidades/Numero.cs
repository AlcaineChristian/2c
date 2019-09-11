using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            double.TryParse(strNumero, out this.numero);
        }



        private static double ValidarNumero(string strNumero)
        {
            double ret = 0;

            return ret;
        }

        public string BinarioDecimal(string binario)
        {
            string ret = "";
            return ret;
        }

        public string DecimalBinario(double numero)
        {
            string ret = "";
            return ret;
        }
        public string DecimalBinario(string strNumero)
        {
            string ret = "";
            return ret;
        }




    }
}
