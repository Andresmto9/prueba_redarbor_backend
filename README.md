# Instrucciones para montar el servicio de la prueba técnica

A continuación se describen los pasos para montar el servicio de la prueba técnica.

## Pasos

1. **Crear la base de datos en SQL Server**  
   Dentro de SQL Server, se debe crear una base de datos con el nombre **DBredarbor**.

2. **Clonar el repositorio**  
   - Crea una carpeta vacía en un directorio de tu elección donde se clonará el repositorio.
   - Abre **Visual Studio** y selecciona la opción **Clonar repositorio**.
   - En el apartado para clonar el repositorio, ingresa la siguiente URL:  
     `https://github.com/Andresmto9/prueba_redarbor_backend.git`.

3. **Cargar las dependencias**  
   Espera a que se carguen todas las dependencias del proyecto.

4. **Ejecutar migraciones**  
   - Una vez cargadas las dependencias, abre la **Consola del Administrador de Paquete** en Visual Studio.
   - En la consola, ejecuta el siguiente comando para aplicar las migraciones ya creadas:  
     `Update-Database`.

5. **Iniciar el servicio**  
   Finalmente, inicia el servicio haciendo clic en el botón **HTTP** en Visual Studio.

¡Listo! El servicio debería estar montado y en funcionamiento.
