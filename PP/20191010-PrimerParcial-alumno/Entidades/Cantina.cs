using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        List<Botella> botellas;
        int espaciosTotales;
        static Cantina singleton;

        public Botella Botellas
        {
            get;
            set;
        }

        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
        }

       public static Cantina GetEspacios(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(10);
            }
            else 
            {
               singleton.espaciosTotales = espacios;
            }



            return singleton;
        }
        public static bool operator +(Cantina a, Botella b)
        {
            bool ret = false;
            if (a.botellas.Count < a.espaciosTotales)
            {
                a.botellas.Add(b);
                ret = true;
            }




            return ret;
        }


    }
}
