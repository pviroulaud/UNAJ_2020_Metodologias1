using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class AlumnoMuyEstudioso:Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, int l, float p):base( n,  d,  l,  p)
        {

        }
        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
