
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Pila : Icoleccionable, Iiterable
    {
        private List<Icomparable> lst;
        public Pila()
        {
            lst = new List<Icomparable>();
        }

        

        public List<Icomparable> elementos
        {
            get
            {
                return lst;
            }
        }

        //push
        public void agregar(Icomparable comparable)
        {
            lst.Add(comparable);
        }

        //pop
        public Icomparable extraer()
        {
            Icomparable ret = null;
            if (lst.Count > 0)
            {
                ret = lst[lst.Count - 1];
                lst.RemoveAt(lst.Count - 1);
            }
            return ret;
        }
        public bool contiene(Icomparable comparable)
        {
            foreach (Icomparable V in lst)
            {
                
                if (V.sonIguales(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public int cuantos()
        {
            return lst.Count();
        }

        public float maximo()
        {

            float MAX = int.MinValue;
            foreach (Icomparable V in lst)
            {
                Type t=V.GetType();
                if (t==new Numero(1).GetType())
                {
                    Numero val = (Numero)V;

                    if (val.getValor() > MAX)
                    {

                        MAX = val.getValor();
                    }
                    
                }
                else
                {
                    if (t.BaseType== new Persona("xx", 1).GetType())
                    {
                    Persona valp = (Persona)V;

                        if (valp.getDNI() > MAX)
                        {

                            MAX = valp.getDNI();
                        }

                    }
                    if (t.BaseType == new Vendedor("xx", 1,1).GetType())
                    {
                        Vendedor valv = (Vendedor)V;

                        if (valv.GetBonus() > MAX)
                        {

                            MAX = valv.GetBonus();
                        }
                        
                    }
                }
                
                
                
            }
            return MAX;

        }

        public float minimo()
        {
            float MIN = int.MaxValue;
            foreach (Icomparable V in lst)
            {
                Type t = V.GetType();
                if (t == new Numero(1).GetType())
                {
                    Numero val = (Numero)V;

                    if (val.getValor() < MIN)
                    {

                        MIN = val.getValor();
                    }

                }
                else
                {
                    if (t.BaseType == new Persona("xx", 1).GetType())
                    {
                        Persona valp = (Persona)V;
                        
                        
                            if (valp.getDNI() < MIN)
                            {

                                MIN = valp.getDNI();
                            }
                        
                    }
                    if (t.BaseType == new Vendedor("xx", 1, 1).GetType())
                    {
                        Vendedor valv = (Vendedor)V;

                        if (valv.GetBonus() < MIN)
                        {

                            MIN = valv.GetBonus();
                        }

                    }
                }
            }

           
            return MIN;
        }

        public Iiterator createIterator()
        {
            return new IteratorPila(this);
        }

        
    }
}
