using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class comparaPorDNI : IstrategyComparacion
    {
        public bool esIgual(Icomparable persona1, Icomparable persona2)
        {
            return ((Persona)(persona1)).getDNI() == ((Persona)(persona2)).getDNI();
        }


        public bool esMayor(Icomparable persona1, Icomparable persona2)
        {
            return ((Persona)(persona1)).getDNI() > ((Persona)(persona2)).getDNI();
        }

        public bool esMenor(Icomparable persona1, Icomparable persona2)
        {
            return ((Persona)(persona1)).getDNI() < ((Persona)(persona2)).getDNI();
        }
    }
}
