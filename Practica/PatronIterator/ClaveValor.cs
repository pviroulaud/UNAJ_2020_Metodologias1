using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class ClaveValor
    {
        public string Clave { get; set; }

        public Icomparable Valor { get; set; }

        public override string ToString()
        {
            return $"Clave:{Clave}, Valor:{Valor}";
        }
    }
}
