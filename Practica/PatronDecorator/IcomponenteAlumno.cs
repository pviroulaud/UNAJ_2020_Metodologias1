using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.PatronDecorator
{
    public interface IcomponenteAlumno
    {
        string getNombre();
        int getLegajo();
        float getPromedio();
        float getCalificacion();
        string mostrarCalificacion();
         int responderPregunta(int pregunta);
        void setCalificacion(float cal);
        bool sonIguales(Icomparable valor);
        bool EsMayor(Icomparable comparable);
        bool EsMenor(Icomparable comparable);
    }
}
