# Log dot Net

### Descripción
Esta pequeña solución ejemplifica como utilizar log4net en un proyecto de consola C# (.net 4.5).
Se maneja a manera de compomponente para un posible cambio de libreria o agregar funcionalidades sin afectar el proyecto principal.

### Uso
- Agregamos el proyecto "Log" a nuestra solución.
- Restauramos los paquetes NuGet.
- Insertamos las llamadas al componente Log.
- F5

```
private void method()
{
  Log.Operatios.Info("Hi info", MethodBase.GetCurrentMethod().Name);
}

// 2019-10-27 18:40:31,135 INFO - method - Hi info
```