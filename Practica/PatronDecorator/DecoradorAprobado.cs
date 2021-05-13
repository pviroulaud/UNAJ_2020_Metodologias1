using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.PatronDecorator
{
    public class DecoradorAprobado : DecoradorAlumno
    {
        IcomponenteAlumno alumno;
        public DecoradorAprobado(Alumno al)
        {
            alumno = al;
        }

        public override bool EsMayor(Icomparable comparable)
        {
            return alumno.EsMayor(comparable);
        }

        public override bool EsMenor(Icomparable comparable)
        {
            return alumno.EsMenor(comparable);
        }

        public override float getCalificacion()
        {
            return alumno.getCalificacion();
        }

        public override int getLegajo()
        {
            return alumno.getLegajo();
        }

        public override string getNombre()
        {
            return alumno.getNombre();
        }

        public override float getPromedio()
        {
            return alumno.getPromedio();
        }

        public override string mostrarCalificacion()
        {
            if (alumno.getCalificacion()>6)
            {
                return alumno.mostrarCalificacion() + " APROBADO" ;
            }
            else
            {
                return alumno.mostrarCalificacion() + " DESAPROBADO" ;
            }
            
        }

        public override int responderPregunta(int pregunta)
        {
            return alumno.responderPregunta(pregunta);
        }

        public override void setCalificacion(float cal)
        {
            alumno.setCalificacion(cal);
        }

        public override bool sonIguales(Icomparable valor)
        {
            return alumno.sonIguales(valor);
        }
    }
}
