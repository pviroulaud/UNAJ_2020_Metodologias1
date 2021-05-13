using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class FMcomparableVendedor : IfabricaDeComparables
    {
        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios ge = new GeneradorDeDatosAleatorios();
            Vendedor a = new Vendedor(ge.stringAleatorio(3), ge.numeroAleatorio(8), ge.numeroAleatorio(4));
            return a;
        }

        public Icomparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese un nombre");
            string n = Console.ReadLine();
            Console.WriteLine("Ingrese DNI");
            string d = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo Basico");
            string s = Console.ReadLine();
            Vendedor a = new Vendedor(n, Convert.ToInt32(d), Convert.ToInt32(s));
            return a;
        }
    }
}
