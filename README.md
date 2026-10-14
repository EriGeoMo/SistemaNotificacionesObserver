# Documentación del Proyecto: Sistema de Notificaciones Patrón Observer

## 1. Enfoque Utilizado
Para el desarrollo del Tema 4 se implementó el patrón de diseño Observer en C#. El objetivo principal es establecer una relación de dependencia de uno a muchos entre un sujeto el publicador y sus observadores los suscriptores. Cuando el sujeto cambia de estado o ejecuta una acción relevante, todos los observadores registrados son notificados automáticamente.

En este sistema:
*   El Sujeto es la clase `Notificador`.
*   Los Observadores son instancias de la clase `Usuario`.
*   La comunicación se logra mediante la interfaz `IObservador`, que obliga a implementar el método `Actualizar()`.

## 2. Decisiones Tomadas y Modularidad
Para cumplir con los criterios de Reutilización y Modularidad y Calidad del Código de la rúbrica, se decidió no agrupar todas las clases en el archivo `Program.cs`. En su lugar, el proyecto se estructuró en carpetas lógicas:

*   **Carpeta `Interfaces`:** Contiene `IObservador.cs`. Al usar una interfaz, aseguramos que el `Notificador` no necesite conocer los detalles de implementación de los usuarios, reduciendo el acoplamiento. Cualquier nueva clase por ejemplo, `SistemaAlerta.cs` o `RegistroLog.cs` puede recibir notificaciones simplemente implementando esta interfaz.
*   **Carpeta `Sujetos`:** Contiene `Notificador.cs`. Esta clase encapsula la lista genérica de observadores y los métodos para suscribir `AgregarObservador`, cancelar suscripción `EliminarObservador` y emitir la alerta iterando sobre la lista `NotificarCambio`.
*   **Carpeta `Observadores`:** Contiene `Usuario.cs`. Esta entidad maneja de forma independiente cómo reaccionar al recibir la notificación a través de la consola.

Esta separación facilita el mantenimiento y permite reutilizar los componentes si el sistema crece en el futuro.

## 3. Instrucciones de Ejecución
1. Asegúrese de tener instalado el SDK de .NET versión 8.0 o superior.
2. Clone el repositorio o descargue los archivos del proyecto.
3. Abra una terminal símbolo del sistema o PowerShell y navegue hasta el directorio raíz del proyecto donde se encuentra el archivo `.csproj`.
4. Ejecute el siguiente comando para compilar y probar la aplicación:
   `dotnet run`
5. El sistema mostrará en consola la simulación de envío de notificaciones a los usuarios suscritos.
