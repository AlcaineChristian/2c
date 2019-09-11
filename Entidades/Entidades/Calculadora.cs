using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar(Numero num1,Numero num2, string operador)
        {
            double ret = 0;
            switch(ValidarOperador(operador))
            {
                case "+":
                    ret = num1 + num2;
                    break;
                case "-":
                    ret = num1 - num2;
                    break;
                case "*":
                    ret = num1 * num2;
                    break;
                case "/":
                    ret = num1 / num2;
                    break;
                
            }


            return ret;
        }
        public string ValidarOperador(string operador)
        {
            string ret = "";
            switch (operador)
            {
                case "+":
                    ret = "+";
                    break;
                case "-":
                    ret = "-";
                    break;
                case "*":
                    ret = "*";
                    break;
                case "/":
                    ret = "/";
                    break;
                default:
                    ret = "+";
                    break;

            }

            return ret;
        }


    }
}
