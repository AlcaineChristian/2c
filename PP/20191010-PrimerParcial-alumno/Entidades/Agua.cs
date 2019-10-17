using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Entidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400;
        public Agua(int capacidad, int contenido, string marca)
            : base(capacidad, contenido, marca)
        {

        }

        public override int ServirMedida()
        {
            if (MEDIDA >= this.Contenido)
            {
                this.Contenido = 0;
            }
            else if (MEDIDA < this.Contenido)
            {
                this.Contenido = this.Contenido - MEDIDA;

            }

            return this.Contenido;
        }
        public int ServirMedida(int medida)
        {
            if (medida >= this.Contenido)
            {
                this.Contenido = 0;
            }
            else if (medida < this.Contenido)
            {
                this.Contenido = this.Contenido - medida;

            }

            return this.Contenido;
        }

        public override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.GenerarInforme());



            return Convert.ToString(sb);
        }



    }
}
