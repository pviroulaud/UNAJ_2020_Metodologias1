using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Vendedor: Persona,Iobservable
    {
        float sueldoBasico;
        float bonus;
        public Vendedor(string nom,int dni,float s): base (nom,dni)
        {
            sueldoBasico = s;
            bonus = 1;
        }
        public float GetSueldo()
        {
            return sueldoBasico;
        }
        public float GetBonus()
        {
            return bonus;
        }
        public void venta(float monto)
        {
            Console.WriteLine("Monto de la venta: " + monto.ToString());
        }
        public void aumentaBonus()
        {
            bonus += 0.1f;

        }
        public override bool sonIguales(Icomparable valor)
        {
            return bonus == ((Vendedor)valor).GetBonus();
        }

        public void notificacion(Iobservador o)
        {
            throw new NotImplementedException();
        }
    }
}
