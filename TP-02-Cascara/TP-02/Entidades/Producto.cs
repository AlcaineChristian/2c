﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public  enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        protected EMarca marca;
        
        protected string codigoDeBarras;
        
        protected ConsoleColor colorPrimarioEmpaque;
        

        public Producto(EMarca marca,string patente,ConsoleColor colorPrimarioEmpaque)
        {
            this.codigoDeBarras = patente;
            this.marca = marca;
            this.colorPrimarioEmpaque = colorPrimarioEmpaque;

        }

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public abstract short CantidadCalorias { get;  }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public abstract string Mostrar();
        


        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: "+ p.codigoDeBarras);
            sb.AppendLine("\nMARCA          :" + p.marca.ToString());
            sb.AppendLine("\nCOLOR EMPAQUE  : " + p.colorPrimarioEmpaque.ToString());
            sb.AppendLine("\n---------------------");

            return Convert.ToString(sb);
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1.codigoDeBarras == v2.codigoDeBarras);
        }
    }
}
