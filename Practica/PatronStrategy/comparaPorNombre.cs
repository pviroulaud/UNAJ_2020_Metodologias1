using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class comparaPorNombre : IstrategyComparacion
    {
        public bool esIgual(Icomparable persona1, Icomparable persona2)
        {
            return ((Alumno)(persona1)).getNombre() == ((Alumno)(persona2)).getNombre();
        }


        public bool esMayor(Icomparable persona1, Icomparable persona2)
        {
            return false;
        }

        public bool esMenor(Icomparable persona1, Icomparable persona2)
        {
            return false;
        }
    }
}
