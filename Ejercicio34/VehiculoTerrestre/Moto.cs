using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoTerrestre
{
    public class Moto : VehiculoTerrestre
    {

        public short cilindrada;
        public Moto(short cantRuedas, short cantMarchas, Colores clr, short cc) : base(cantRuedas, cantMarchas, clr)
        {

            this.cilindrada = cc;


        }



    }
}
