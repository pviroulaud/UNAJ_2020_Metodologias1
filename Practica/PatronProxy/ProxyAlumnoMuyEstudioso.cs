using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.PatronProxy
{
    public class ProxyAlumnoMuyEstudioso:Alumno
    {
        PatronDecorator.IcomponenteAlumno al;
        public ProxyAlumnoMuyEstudioso(string n, int d, int l, float p) : base(n, d, l, p)
        {
        }

        public override int responderPregunta(int pregunta)
        {
            if (al == null)
            {
                al = new AlumnoMuyEstudioso(base.getNombre(), base.getDNI(), base.getLegajo(), base.getPromedio());
            }

            return al.responderPregunta(pregunta);
        }
    }
}
