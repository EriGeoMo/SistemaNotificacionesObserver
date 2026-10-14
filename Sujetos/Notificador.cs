using System.Collections.Generic;
using SistemaNotificacionesObserver.Interfaces;

namespace SistemaNotificacionesObserver.Sujetos
{
    public class Notificador
    {
        // Lista modular para guardar a todos los que quieren recibir alertas
        private List<IObservador> observadores = new List<IObservador>();

        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        // Método que dispara la alerta a todos al mismo tiempo
        public void NotificarCambio(string mensaje)
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar(mensaje);
            }
        }
    }
}