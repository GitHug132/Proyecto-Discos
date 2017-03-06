Proyecto DEW Discos
===================

Somos **Adrián y Pablo** y somos los creadores de esta página web.

Tecnologías Usadas
-------------
Utilizamos el IDE **Visual Studio** como entorno de desarrollo web **ASP.NET MVC y Web Api**. El código fuente que utilizamos es **C#** y el modelo de vistas que nos ofrece **Razor** con sus ficheros **.cshtml** donde podremos agregar código c# a nuestras vistas. 

Además utilizamos el **Entity Framework** para realizar consultas contra la **Base de Datos SQL con LinQ**.

El código cliente se compone de:
>**Cliente:**

> - Jquery
> - JqueryUI
> - Toastr
> - AJAX
> - Google Charts

-------------

Funcionamiento de la pagina web
---------------

>**Barra de Navegación:**

>- Home: Vuelve a la página principal
<br>
>- Top 5: Devuelve una vista con una gráfica de los 5 discos más votados por todos los clientes. Esta gráfica consume del rest /api/TopDiscos
<br>
>- Lista:  Muestra la misma vista pero con un listado de discos donde el usuario podrá puntuar si ya se ha registrado antes en la aplicación
<br>
>- Login: Abre un dialog con un formulario donde el usuario intenta iniciar sesión en la aplicación. Si el nombre de usuario y la contraseña no coincide con ningun registro de la base de datos. El usuario no se logea y por lo tanto no podrá votar canciones 
<br>
>- Register: Abre un dialog con un formulario donde el usuario intenta registrarse en la aplicación. Al registrarse el usuario se logea automáticamente
<br>
>- Logout: Sale de la sesión y te permite volver a hacer login

##Login
---------------
Al hacer login se pude puede apreciar en la parte superior derecha de la pantalla el mensaje "Has iniciado sesión! y debajo aparecerá el nombre del usuario registrado.

Solo se podrá iniciar sesión o registrar cuando el usuario esté en /Pagina/Index. Si el usuario no se ha registrado o hace logout y seguidamente intenta puntuar un disco en la lista. Aparecerá un error en toastr, preguntando si el usuario a iniciado sesión.

Si el usuario no se ha registrado, no aparecerá la opción de "logout"
