using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class GeneradorDeDatosAleatorios
    {
        public int numeroAleatorio(int maximo)
        {
            Random rnd = new Random();
            return rnd.Next(0, maximo);
        }
        public string stringAleatorio(int maximoCarateres)
        {
            Random rnd = new Random();
            string ret="";
            for(int n=0;n<maximoCarateres; n++)
            {
                ret += Convert.ToChar(rnd.Next(0, 128));
            }
            return ret;
        }
    }
}
