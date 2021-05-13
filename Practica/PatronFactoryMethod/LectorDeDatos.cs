using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class LectorDeDatos
    {
        public int NumeroPorTeclado()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                return 0;
            }
            
        }
        public string StringPorTeclado()
        {
            return Console.ReadLine();

        }
    }
}
