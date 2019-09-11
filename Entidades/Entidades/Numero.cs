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
            double suma = 0;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {

                    suma += (int)Math.Pow(2, i);
                }
            }
            ret += suma;

            return ret;
        }

        public string DecimalBinario(double numero)
        {
            string ret = "";
            double num=numero;
            if(numero<0)
            {
                num = numero * -1;
            }
            while (num >= 1)
            {

                if (num % 2 == 0)
                {
                    ret = "0" + ret;
                }
                else
                {
                    ret = "1" + ret;
                }
                num = num / 2;

            }
            return ret;
        }
        public string DecimalBinario(string strNumero)
        {
            string ret = "";
            double numero;
            double.TryParse(strNumero, out numero);
            ret= DecimalBinario(numero);
            return ret;
        }

        public static double operator +(Numero num1,Numero num2)
        {
            return num1 + num2;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1 - num2;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1 * num2;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            return num1 / num2;
        }



    }
}
