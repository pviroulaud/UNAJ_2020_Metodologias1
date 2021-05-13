using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Persona:Icomparable
    {
        string nombre;
        int dni;
        protected IstrategyComparacion comparacion;
        public Persona(string n,int d)
        {
            nombre = n;
            dni = d;
            comparacion = new comparaPorDNI();
        }
        

        public string getNombre()
        {
            return nombre;
        }
        public int getDNI()
        {
            return dni;
        }

        public virtual bool sonIguales(Icomparable valor)
        {
            return comparacion.esIgual(this,valor);
        }

        public virtual bool EsMayor(Icomparable comparable)
        {
            return comparacion.esMayor(this, comparable);
        }

        public virtual bool EsMenor(Icomparable comparable)
        {
            return comparacion.esMenor(this, comparable);
        }



        public void SetStrategy(IstrategyComparacion compara)
        {
            comparacion = compara;
        }
    }
}
