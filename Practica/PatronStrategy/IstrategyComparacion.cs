using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public interface IstrategyComparacion
    {
        bool esIgual(Icomparable alumno1, Icomparable alumno2);
        bool esMayor(Icomparable alumno1, Icomparable alumno2);
        bool esMenor(Icomparable alumno1, Icomparable alumno2);
    }
}
