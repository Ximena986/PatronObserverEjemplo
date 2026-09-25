using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObserverEjemplo
{
    public interface ISuscriptor
    {
        void Actualizar(string mensaje);
    }
}