using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.PatronAdapter
{
    public class AdapterAlumno : Student
    {
        PatronDecorator.IcomponenteAlumno al;
        public AdapterAlumno(PatronDecorator.IcomponenteAlumno estudiante) 
        {
            al = estudiante;
        }

        public bool equals(Student student)
        {
            return al.getNombre() == student.getName();
        }

        public string getName()
        {
            return al.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return false;
        }

        public bool lessThan(Student student)
        {
            return false;
        }

        public void setScore(int score)
        {
            al.setCalificacion(score);
        }

        public string showResult()
        {
            return al.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return al.responderPregunta(question);
        }
    }
}
