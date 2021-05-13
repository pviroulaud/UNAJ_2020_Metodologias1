
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Diccionario:Icoleccionable, Iiterable
    {
        
        List<ClaveValor> dic = new List<ClaveValor>();
        public List<ClaveValor> elementos
        {
            get
            {
                return dic;
            }
        }

        public void agregar(Icomparable comparable)
        {
            dic.Add(new ClaveValor() { Clave="default",Valor=comparable});
        }

        public void agregarClaveValor(string clave,Icomparable valor)
        {
            dic.Add(new ClaveValor() { Clave = clave, Valor = valor });
        }

        public bool contiene(Icomparable comparable)
        {
            bool ret = false ;
            foreach (ClaveValor item in dic)
            {
                if (item.Valor==comparable)
                {
                    ret = true;  
                }
            }
            return ret;
        }

        public Iiterator createIterator()
        {
            return new IteratorDiccionario(this);
        }

        public int cuantos()
        {
            return dic.Count;
        }

        public float maximo()
        {

            float MAX = int.MinValue;
            foreach (ClaveValor V in dic)
            {
                Type t = V.GetType();
                if (t == new Numero(1).GetType())
                {
                    Numero val = (Numero)V.Valor;

                    if (val.getValor() > MAX)
                    {

                        MAX = val.getValor();
                    }

                }
                else
                {
                    if (t.BaseType == new Persona("xx", 1).GetType())
                    {
                        Persona valp = (Persona)V.Valor;
                        
                        
                            if (valp.getDNI() > MAX)
                            {

                                MAX = valp.getDNI();
                            }
                        
                    }
                    if (t.BaseType == new Vendedor("xx", 1, 1).GetType())
                    {
                        Vendedor valv = (Vendedor)V.Valor;

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
            foreach (ClaveValor V in dic)
            {
                Type t = V.GetType();
                if (t == new Numero(1).GetType())
                {
                    Numero val = (Numero)V.Valor;

                    if (val.getValor() < MIN)
                    {

                        MIN = val.getValor();
                    }

                }
                else
                {
                    if (t.BaseType == new Persona("xx", 1).GetType())
                    {
                        Persona valp = (Persona)V.Valor;
                        
                        
                            if (valp.getDNI() < MIN)
                            {

                                MIN = valp.getDNI();
                            }
                        
                    }
                    if (t.BaseType == new Vendedor("xx", 1, 1).GetType())
                    {
                        Vendedor valv = (Vendedor)V.Valor;

                        if (valv.GetBonus() <MIN)
                        {

                            MIN = valv.GetBonus();
                        }

                    }
                }
            }


            return MIN;
        }

        //public int maximo()
        //{
        //    int MAX = int.MinValue;
        //    foreach (ClaveValor V in dic)
        //    {
        //        //Numero val = (Numero)V;
        //        Persona val = (Persona)V.Valor;
        //        if (val.getDNI() > MAX)
        //        {

        //            MAX = val.getDNI();
        //        }
        //    }
        //    return MAX;
        //}

        //public int minimo()
        //{
        //    int MIN = int.MaxValue;
        //    foreach (ClaveValor V in dic)
        //    {
        //        //Numero val = (Numero)V;
        //        Persona val = (Persona)V.Valor;
        //        if (val.getDNI() < MIN)
        //        {
        //            MIN = val.getDNI();
        //        }
        //    }
        //    return MIN;
        //}

        public Icomparable valorDe(string clave)
        {
            Icomparable ret=null;
            foreach (ClaveValor item in dic)
            {
                if (item.Clave == clave)
                {
                    ret = item.Valor;
                }
            }
            return ret;
        }
    }
}
