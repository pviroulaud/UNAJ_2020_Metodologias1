using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public interface Icomparable
    {
        bool sonIguales(Icomparable valor);
        bool EsMayor(Icomparable comparable);
        bool EsMenor(Icomparable comparable);

        void SetStrategy(IstrategyComparacion compara);
    }
}
