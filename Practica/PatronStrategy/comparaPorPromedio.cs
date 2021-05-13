using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class comparaPorPromedio : IstrategyComparacion
    {
        public bool esIgual(Icomparable alumno1, Icomparable alumno2)
        {
            return ((Alumno)(alumno1)).getPromedio() == ((Alumno)(alumno2)).getPromedio();
        }


        public bool esMayor(Icomparable alumno1, Icomparable alumno2)
        {
            return ((Alumno)(alumno1)).getPromedio() > ((Alumno)(alumno2)).getPromedio();
        }

        public bool esMenor(Icomparable alumno1, Icomparable alumno2)
        {
            return ((Alumno)(alumno1)).getPromedio() < ((Alumno)(alumno2)).getPromedio();
        }
    }
}
