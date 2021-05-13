using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Alumno:Persona, PatronDecorator.IcomponenteAlumno
    {
        int legajo;
        float promedio;

        float calificacion;

        public Alumno(string n,int d,int l,float p) : base(n,d)
        {
            legajo = l;
            promedio = p;
        }

        public virtual int responderPregunta(int pregunta)
        {
            Random rnd = new Random();
            int a=rnd.Next(1, 3);
            return a;
        }
        public string mostrarCalificacion()
        {
            return base.getNombre() + " " + calificacion.ToString();
        }
        public float getCalificacion()
        {
            return calificacion;
        }
        public void setCalificacion(float cal)
        {
            calificacion = cal;
        }
        public int getLegajo()
        {
            return legajo;
        }
        public float getPromedio()
        {
            
            return promedio;
        }
        public override bool sonIguales(Icomparable valor)
        {
            Alumno a = (Alumno)valor;
            return comparacion.esIgual(this,a);
        }

        public override bool EsMayor(Icomparable comparable)
        {
            Alumno a = (Alumno)comparable;
            return comparacion.esMayor(this, a);
        }

        public override bool EsMenor(Icomparable comparable)
        {
            Alumno a = (Alumno)comparable;
            return comparacion.esMenor(this, a);
        }
    }
}
