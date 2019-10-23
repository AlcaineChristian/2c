using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        const int MEDIDA = 330;
        Tipo tipo;
        public Cerveza(int capacidad, int contenido, string marca)
            : base(capacidad, contenido, marca)
        {
            this.tipo = Tipo.Vidrio;

        }
        public Cerveza(int capacidad, int contenido, string marca, Tipo tipo)
            : base(capacidad, contenido, marca)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int medida2;

            if (Cerveza.MEDIDA <= this.Contenido)
            {
                medida2 = (Cerveza.MEDIDA * 80) / 100;
            }
            else
            {
                medida2 = this.Contenido;
            }

            this.Contenido -= medida2;

            return medida2;
        }
        public override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine("Tipo de botella :" + this.tipo);


            return Convert.ToString(sb);
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

    }
}
