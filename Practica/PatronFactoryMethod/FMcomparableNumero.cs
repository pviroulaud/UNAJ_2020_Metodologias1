using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class FMcomparableNumero : IfabricaDeComparables
    {
        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios ge = new GeneradorDeDatosAleatorios();
            Numero n = new Numero(ge.numeroAleatorio(999));
            return n;
        }

        public Icomparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese un numero:");
            Numero n = new Numero(Convert.ToInt32(Console.ReadLine()));
            return n;
        }
    }
}
