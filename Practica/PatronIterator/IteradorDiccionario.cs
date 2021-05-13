using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class IteratorDiccionario : Iiterator
    {
        Diccionario p;
        int indice;
        public IteratorDiccionario(Diccionario diccionario)
        {
            p = diccionario;
            indice = 0;
        }
        public object Current()
        {
            return p.elementos[indice];
        }

        public bool HasNext()
        {
            return indice < p.cuantos();
        }

        public void Next()
        {
            indice++;
        }
    }
}
