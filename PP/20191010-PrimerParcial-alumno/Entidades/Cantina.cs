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
        Cantina singleton;

        public Botella Botellas
        {
            get;
            
        }
        
        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
        }

        public Cantina GetEspacios(int espacios)
        {
            if(this.singleton==null)
            {
                Cantina singleton = new Cantina(0);
            }else if(this.singleton!=null)
            {
                this.espaciosTotales = espacios;
            }



            return this.singleton;
        }
        public static bool operator +(Cantina a, Botella b)
        {
            bool ret = false;
            if(a.botellas.Count < a.espaciosTotales)
            {
                a.botellas.Add(b);
                ret = true;
            }




            return ret;
        }
        

    }
}
