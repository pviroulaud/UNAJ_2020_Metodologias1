using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Gerente: Persona, Iobservador
    {
        Icoleccionable mejores;
        public Gerente(string nom,int dni):base(nom,dni)
        {
            mejores = new Pila();
        }

        public void agregarObservador(Iobservable o)
        {
            mejores.agregar((Vendedor)o);
        }

        public void cerrar()
        {
            Iiterator itP = mejores.createIterator();
            while( itP.HasNext())
            {
                Vendedor v = (Vendedor)itP.Current();
                Console.WriteLine(v.getNombre() + "  -> BONUS= " + v.GetBonus());
                itP.Next();
            }
        }

        public void notificar()
        {
            throw new NotImplementedException();
        }

        

        public void venta( float monto,Vendedor vendedor)
        {
            if(monto>5000)
            {
                vendedor.aumentaBonus();
                if(!mejores.contiene(vendedor))
                {
                    mejores.agregar(vendedor);
                }
            }
        }
    }
}
