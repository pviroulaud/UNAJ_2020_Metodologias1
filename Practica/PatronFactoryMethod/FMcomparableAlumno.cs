using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class FMcomparableAlumno : IfabricaDeComparables
    {
        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios ge = new GeneradorDeDatosAleatorios();
            Alumno a = new Alumno(ge.stringAleatorio(3), ge.numeroAleatorio(8), ge.numeroAleatorio(4), ge.numeroAleatorio(2));
            return a;
        }

        public Icomparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese un nombre");
            string n = Console.ReadLine();
            Console.WriteLine("Ingrese DNI");
            string d = Console.ReadLine();
            Console.WriteLine("Ingrese legajo");
            string l = Console.ReadLine();
            Console.WriteLine("Ingrese promedio");
            string p = Console.ReadLine();
            Alumno a = new Alumno(n,Convert.ToInt32(d), Convert.ToInt32(l), Convert.ToInt32(p));
            return a;
        }
    }
}
