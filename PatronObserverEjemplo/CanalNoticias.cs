using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObserverEjemplo
{
    public class CanalNoticias
    {
        private List<ISuscriptor> suscriptores = new List<ISuscriptor>();

        public void Suscribir(ISuscriptor suscriptor)
        {
            suscriptores.Add(suscriptor);
            Console.WriteLine("Un nuevo celular se ha suscrito.");
        }
        public void Desuscribir(ISuscriptor suscriptor)
        {
            suscriptores.Remove(suscriptor);
            Console.WriteLine("Un celular se ha desuscrito.");
        }

        public void NotificarATodos(string mensaje)
        {
            foreach (var suscriptor in suscriptores)
            {
                suscriptor.Actualizar(mensaje);
            }
        }
    }
}