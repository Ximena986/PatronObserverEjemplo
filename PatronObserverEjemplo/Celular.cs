using System;
using System.Collections.Generic;
using System.Text;


namespace PatronObserverEjemplo
{
    public class Celular : ISuscriptor
    {
        public string Nombre { get; set; }

        public Celular(string nombre)
        {
            Nombre = nombre;
        }

        public void Actualizar(string mensaje)
        {
            Console.WriteLine($"[Notificación para {Nombre}]: {mensaje}");
        }
    }
}