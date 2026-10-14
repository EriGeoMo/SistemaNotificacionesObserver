using System;
using SistemaNotificacionesObserver.Sujetos;
using SistemaNotificacionesObserver.Observadores;

namespace SistemaNotificacionesObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creamos el publicador (Sujeto)
            Notificador sistemaNotificaciones = new Notificador();

            // 2. Creamos los suscriptores (Observadores)
            Usuario usuario1 = new Usuario("Erick");
            Usuario usuario2 = new Usuario("Katia");

            // 3. Los suscribimos al sistema de notificaciones
            sistemaNotificaciones.AgregarObservador(usuario1);
            sistemaNotificaciones.AgregarObservador(usuario2);

            // 4. Simulamos un evento que dispara la alerta
            Console.WriteLine("Agregando una nueva tarea al sistema...\n");
            sistemaNotificaciones.NotificarCambio("¡Se ha asignado el Proyecto MVC!");

            // 5. Eliminamos un usuario y volvemos a notificar
            Console.WriteLine("\nKatia se ha dado de baja de las notificaciones...\n");
            sistemaNotificaciones.EliminarObservador(usuario2);
            sistemaNotificaciones.NotificarCambio("¡La fecha de entrega es el viernes!");
        }
    }
}