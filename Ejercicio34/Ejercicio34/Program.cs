using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculoTerrestre;
namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m = new Moto(2, 5, Colores.Blanco, 660);
            Automovil a = new Automovil(4,4,6,Colores.Negro,5);
            Camion c = new Camion(6, 2, 12, Colores.Gris, 2500);
            Console.WriteLine("Camion {0}  {1}  {2}  {3}  {4}",c.cantRuedas,c.cantidadDePuertas,c.cantMarchas,c.clr,c.pesoCarga);
            Console.WriteLine("Moto {0}  {1}  {2}  {3} ", m.cantRuedas, m.cantMarchas, m.clr, m.cilindrada);
            Console.WriteLine("Automovil {0}  {1}  {2}  {3}  {4}", a.cantRuedas, a.cantidadDePuertas, a.cantMarchas, a.clr, a.cantidadPasajeros);
            Console.ReadKey();


        }
    }
}
