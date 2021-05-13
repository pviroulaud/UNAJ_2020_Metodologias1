using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.PatronDecorator
{
    public class DecoradorNota : DecoradorAlumno
    {
        IcomponenteAlumno alumno;
        public DecoradorNota(Alumno al)
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
            string notaEnLetras = "(CERO)";
            switch ((int)alumno.getCalificacion())
            {
                case 1: notaEnLetras = "(UNO)"; break;
                case 2: notaEnLetras = "(DOS)"; break;
                case 3: notaEnLetras = "(TRES)"; break;
                case 4: notaEnLetras = "(CUATRO)"; break;
                case 5: notaEnLetras = "(CINCO)"; break;
                case 6: notaEnLetras = "(SEIS)"; break;
                case 7: notaEnLetras = "(SIETE)"; break;
                case 8: notaEnLetras = "(OCHO)"; break;
                case 9: notaEnLetras = "(NUEVE)"; break;
                case 10: notaEnLetras = "(DIEZ)"; break;
            }

            return alumno.mostrarCalificacion() + " " +notaEnLetras;
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
