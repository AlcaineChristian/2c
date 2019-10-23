using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public Botella(int capacidad, int contenido, string marca)
        {
            this.capacidadML = capacidad;
            if (contenido > capacidad)
            {
                this.contenidoML = capacidad;
            }
            else
            {
                this.contenidoML = contenido;
            }

            this.marca = marca;
        }

        public enum Tipo
        {
            Plastico, Vidrio
        }

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }
        public int PorcentajeContenido
        {
            get
            {
                return ((this.contenidoML * 100) / this.capacidadML);
            }
        }

        public int Contenido { get; set; }

        public abstract int ServirMedida();

        public virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad : {0}Ml" + this.capacidadML);
            sb.AppendLine("Contenido : {0}Ml" + this.contenidoML);
            sb.AppendLine("Marca :" + this.marca);



            return Convert.ToString(sb);
        }
        public override string ToString()
        {
            return GenerarInforme();
        }

        

        
    }
}
