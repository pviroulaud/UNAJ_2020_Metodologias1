using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Numero : Icomparable
    {
        private int valor;
        public Numero(int v)
        {
            valor = v;
        }

        public bool EsMayor(Icomparable comparable)
        {
            Numero a = (Numero)comparable;
            return a.getValor() > valor;
        }

        public bool EsMenor(Icomparable comparable)
        {
            Numero a = (Numero)comparable;
            return a.getValor() < valor;
        }

        public int getValor()
        {
            return valor;
        }

        public void SetStrategy(IstrategyComparacion compara)
        {
            throw new NotImplementedException();
        }

        public bool sonIguales(Icomparable valor)
        {
            Numero a = (Numero)valor;
            return a.getValor() == this.valor;
        }

       
    }
}
