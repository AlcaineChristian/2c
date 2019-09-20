using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoTerrestre
{
    public class VehiculoTerrestre
    {
        public short cantRuedas;
        public short cantMarchas;
        public Colores clr;
        

        public VehiculoTerrestre(short cantRuedas,short cantMarchas, Colores clr)
        {
            this.cantRuedas = cantRuedas;
            this.cantMarchas = cantMarchas;
            this.clr = clr;
        }
        

    }
}
