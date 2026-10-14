namespace SistemaNotificacionesObserver.Interfaces
{
    // Esta interfaz dicta que cualquier clase que quiera ser un observador 
    // DEBE tener un método llamado Actualizar.
    public interface IObservador
    {
        void Actualizar(string mensaje);
    }
}