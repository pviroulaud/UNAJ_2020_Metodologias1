using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public interface Icoleccionable
    {
        int cuantos();
        float minimo();
        float maximo();
        void agregar(Icomparable comparable);

        bool contiene(Icomparable comparable);

        Iiterator createIterator();
    }
}
