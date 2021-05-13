using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {

            //Teacher tch = new Teacher();

            //for (int n = 0; n < 10; n++)
            //{
            //    Alumno AL = new Alumno("AL" + n.ToString(), n, n, n);
            //    PatronAdapter.AdapterAlumno ALadaptado = new PatronAdapter.AdapterAlumno(AL);
            //    tch.goToClass(ALadaptado);

            //}
            //for (int n = 10; n < 20; n++)
            //{
            //    Alumno AL = new Alumno("ALmuyEST" + n.ToString(), n, n, n);
            //    PatronAdapter.AdapterAlumno ALmuyEstadaptado = new PatronAdapter.AdapterAlumno(AL);
            //    tch.goToClass(ALmuyEstadaptado);

            //}

            //tch.teachingAClass();

            Teacher tch = new Teacher();

            for (int n = 0; n < 10; n++)
            {
                PatronDecorator.IcomponenteAlumno AL = new Alumno("AL" + n.ToString(), n, n, n);
                AL = new PatronDecorator.DecoradorNombre((Alumno)AL);

                PatronAdapter.AdapterAlumno ALadaptado = new PatronAdapter.AdapterAlumno(AL);
                tch.goToClass(ALadaptado);

            }
            for (int n = 10; n < 20; n++)
            {
                PatronDecorator.IcomponenteAlumno AL = new Alumno("ALmuyEST" + n.ToString(), n, n, n);
                AL = new PatronDecorator.DecoradorNombre((Alumno)AL);

                PatronAdapter.AdapterAlumno ALmuyEstadaptado = new PatronAdapter.AdapterAlumno(AL);

                tch.goToClass(ALmuyEstadaptado);

            }

            tch.teachingAClass();




            Console.WriteLine("Presine ENTER para terminar");
            Console.ReadLine();
        }
        private static void llenar(Icoleccionable coleccion, int opcion)
        {
            IfabricaDeComparables Fabrica;
            Fabrica = new FMcomparableNumero();
            if (opcion==1)
            {
                // numeros
                Fabrica = new FMcomparableNumero();
            }
            else
            {
                if (opcion==2)
                {
                    // alumnos
                    Fabrica = new FMcomparableAlumno();
                }
                if (opcion == 3)
                {
                    // vendedores
                    Fabrica = new FMcomparableVendedor();
                }
            }
            //Practica 3 Ej6
            for (int n=0;n<20;n++)
            {

                Icomparable C = Fabrica.crearAleatorio();
                coleccion.agregar(C);
            }
        }
        private static void informar(Icoleccionable coleccion, int opcion)
        {
            Console.WriteLine("Cuantos: " + coleccion.cuantos());
            Console.WriteLine("Minimo: " + coleccion.minimo());
            Console.WriteLine("Maximo: " + coleccion.maximo());
            IfabricaDeComparables Fabrica;
            if (opcion == 1)
            {
                // numeros
                Fabrica = new FMcomparableNumero();
            }
            else
            {
                // alumnos
                Fabrica = new FMcomparableAlumno();
            }
            Icomparable C = Fabrica.crearPorTeclado();

            if (coleccion.contiene(C))
            {
                Console.WriteLine("El elemento esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento NO esta en la coleccion");
            }
        }

        private static void jornadaDeVentas(Icoleccionable vendedores)
        {
            Iiterator itP = vendedores.createIterator();
            while( itP.HasNext())
            {
                for (int n = 0; n < 20; n++)
                {
                    GeneradorDeDatosAleatorios ge = new GeneradorDeDatosAleatorios();
                    Vendedor v = ((Vendedor)(itP.Current()));
                    int monto = ge.numeroAleatorio(7000);
                    v.venta(monto);

                }
                itP.Next();
            }
            
        }
    }
}
