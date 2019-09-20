using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoTerrestre
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantidadDePuertas;
        public int cantidadPasajeros;

        public Automovil(short cantRuedas, short cantPuertas, short cantMarchas, Colores clr, int cantPasajeros) : base(cantRuedas, cantMarchas, clr)
        {

            this.cantidadPasajeros = cantPasajeros;
            this.cantidadDePuertas = cantPuertas;


        }

    }

}
