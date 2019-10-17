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
            if (MEDIDA >= this.Contenido)
            {
                this.Contenido = 0;
            }
            else if (MEDIDA < this.Contenido)
            {
                this.Contenido = this.Contenido - ((MEDIDA * 80) / 100);

            }

            return this.Contenido;
        }
        public override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine("Tipo de botella :" + this.tipo);


            return Convert.ToString(sb);
        }

        
    }
}
