using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class comparaPorLegajo : IstrategyComparacion
    {
        public bool esIgual(Icomparable alumno1, Icomparable alumno2)
        {
            return ((Alumno)(alumno1)).getLegajo() == ((Alumno)(alumno2)).getLegajo();
        }


        public bool esMayor(Icomparable alumno1, Icomparable alumno2)
        {
            return ((Alumno)(alumno1)).getLegajo() > ((Alumno)(alumno2)).getLegajo();
        }

        public bool esMenor(Icomparable alumno1, Icomparable alumno2)
        {
            return ((Alumno)(alumno1)).getLegajo() < ((Alumno)(alumno2)).getLegajo();
        }
    }
}
