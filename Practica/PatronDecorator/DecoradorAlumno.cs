using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.PatronDecorator
{
    public abstract class DecoradorAlumno : IcomponenteAlumno
    {
        public abstract bool EsMayor(Icomparable comparable);
        public abstract bool EsMenor(Icomparable comparable);
        public abstract float getCalificacion();
        public abstract int getLegajo();
        public abstract string getNombre();
        public abstract float getPromedio();
        public abstract string mostrarCalificacion();
        public abstract int responderPregunta(int pregunta);
        public abstract void setCalificacion(float cal);
        public abstract bool sonIguales(Icomparable valor);
    }
}
