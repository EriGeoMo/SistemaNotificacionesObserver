using System;
using SistemaNotificacionesObserver.Interfaces;

namespace SistemaNotificacionesObserver.Observadores
{
    public class Usuario : IObservador
    {
        private string nombre;

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        public void Actualizar(string mensaje)
        {
            Console.WriteLine($"[Notificación para {nombre}]: {mensaje}");
        }
    }
}