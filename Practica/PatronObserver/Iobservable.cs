using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public interface Iobservable
    {
       void notificacion(Iobservador o);
    }
}
