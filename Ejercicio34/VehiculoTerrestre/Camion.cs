using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoTerrestre
{
    public class Camion : VehiculoTerrestre
    {

        public int pesoCarga;
        public short cantidadDePuertas;

        public Camion(short cantRuedas, short cantPuertas, short cantMarchas, Colores clr, int peso) : base(cantRuedas, cantMarchas, clr)
        {

            this.pesoCarga = peso;
            this.cantidadDePuertas = cantPuertas;


        }


    }
}
