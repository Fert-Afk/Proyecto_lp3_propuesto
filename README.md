# Proyecto propuesto (WinForm)

El proyecto consiste en la simulación de un programa de Gestión de ventas. Cuenta con servicios de registro de productos, distribuidores, clientes, marcas y usuarios. Tiene implementado una capa de Inicio de Sesión y validaciones básicas. También tiene implementado una capa de conexión a una base de datos SQL en el motor SQLServer.

#### Colaboradores

- Jhen

- Justing

- Eduardo

- Gianluigi

- Daniel



### Clonación del repositorio

- Inicia GIT en la carpeta donde se alojará el repositorio.

- Coloca en la consola de GIT lo siguiente.

```

git clone https://github.com/Fert-Afk/Proyecto\_lp3\_propuesto

```

- Una vez clonado correctamente el repositorio, para trabajar sin complicaciones y sin afectar al proyecto, se requiere trabajar en una rama por cada cambio que deseas realizar.

```

git branch "Nombre de tu rama"

```

- Para combinar la rama con tu cambio realizado, primero cambia a la rama principal u otra rama que estés utilizando como principal:

```

git checkout main

```

 luego haz merge de la rama secundaria:

```

git merge rama_cambio

```

- GIT te marcará los archivos con conflictos y puedas resolverlo, procura no forzar el merge a menos que sea necesario. Pide o busca ayuda.



### Acceder a la base de datos

###### Local

En la carpeta "ArchivoBD" se encuentra el archivo que contiene la base de datos.

- Una vez clonado el repositorio, abre el archivo .sql donde se encuentra el script de la base de datos, modifica si es necesario para una correcta ejecución.
- Cambia la cadena de conexión en el proyecto en el archivo "AccesoBaseDatos", con tu base de datos que creaste a partir del script.


###### Remoto
Para conectar a la base de dato de forma remota se explica en el siguiente video: [Habilitar conexión remota](https://youtu.be/wVNPjDeZOhA?si=r8ANs02gO1XchwmM "Habilitar conexión remota"). Una vez con todo habilitado, se requiere la [descarga e instalación de Taiscale](https://tailscale.com/download "descarga e instalación de Tailscale"), es una plataforma que nos ayudará a conectarnos a una misma red y acceder a una misma IP, funcionará como túnel para poder entrar de forma segura a nuestra Base de datos. Con la correcta instalación e inicio de sesión, al propietario de la maquina donde se aloja la BD solicitar la invitación al grupo de la maquina y así poder acceder. Luego, con el rol de administrador asignado por el propietario, copiar el IP proporcionado y añadir ',1433' (el puerto para acceder a la base de datos, sin espacio antes de la coma), seleccionar la Autenticación de SQL Server y copiar las credenciales personales creadas por el propietario que se le proporcionará.

###### Remoto
Para conectar a la base de dato de forma remota se explica en el siguiente video: [Habilitar conexion remota](http://https://youtu.be/wVNPjDeZOhA?si=r8ANs02gO1XchwmM "Habilitar conexion remota"). Una vez con todo habilitado, se requiere la [descarga e instalación de Taiscale](http://https://tailscale.com/download "descarga e instalación de Taiscale"), es una plataforma que nos ayudará a conextarnos a una misma red y acceder a una misma IP, funcionará como tunel para poder entrar de forma segura a nuestra Base de datos. Con la correcta instalación e inicio de sesión, al propietario de la maquina donde se aloja la BD solitar la invitación al grupo de la maquina y así poder acceder. Luego, con el rol de administrador asignado por el propietario, copiar el IP proporcionado y añadir ',1433' (el puerto para acceder a la base de datos, sin espacio antes de la coma), seleccionar la Autenticación de SQL Server y copiar las credenciales personales creadas por el propietario que se le proporcionará.
