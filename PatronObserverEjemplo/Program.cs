using System;

namespace PatronObserverEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            CanalNoticias miCanal = new CanalNoticias();

            Celular celularMaria = new Celular("Celular de María");
            Celular celularEstiven = new Celular("Celular de Estiven");

            miCanal.Suscribir(celularMaria);
            miCanal.Suscribir(celularEstiven);

            miCanal.NotificarATodos("¡Nuevo video subido al canal!");

            Console.WriteLine("\n(Juan cancela su suscripción)");
            miCanal.Desuscribir(celularEstiven);

            miCanal.NotificarATodos("¡Transmisión en directo ahora mismo!");

            Console.ReadKey();
        }
    }
}