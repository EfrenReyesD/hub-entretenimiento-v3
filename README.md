# hub-entretenimiento-v3
Proyecto de entretenimiento visualizador de Series y Peliculas, El FrondEnd realizado con angular 18, el BackEnd con .net 8 y con base de datos en sql server.
Este proyecto está diseñado para proporcionar una plataforma donde los usuarios pueden:

Registrar y autenticar sus cuentas.
Explorar una colección de películas y series.
Añadir películas y series a su lista de favoritos.
Ver detalles de cada película o serie.
#### Objetivo
Desarrollar una aplicación web completa que permita a los usuarios:

Registrar y autenticar cuentas: Los usuarios pueden crear una cuenta, iniciar sesión y acceder a la plataforma de manera segura utilizando autenticación basada en JWT (JSON Web Tokens).

*Explorar una biblioteca de contenido:*

- Películas y Series: Los usuarios pueden navegar a través de una lista de películas y series disponibles en la plataforma. Cada elemento de la lista presenta información relevante como el título, la descripción, la fecha de lanzamiento, y la imagen de portada.
Gestionar favoritos:

- Agregar a Favoritos: Los usuarios pueden marcar películas y series como favoritas. Esta funcionalidad permite a los usuarios mantener una lista personalizada de contenido que desean seguir o ver más adelante.
- Eliminar de Favoritos: Los usuarios también pueden quitar elementos de su lista de favoritos.
- Visualizar detalles: Los usuarios pueden ver detalles adicionales de las películas y series seleccionadas, como la sinopsis completa y otros atributos relevantes.
#### Nombre
Desarrollado por: Efren Reyes Dimas

#### Evidencia
![image](https://github.com/user-attachments/assets/8c716e2a-a8fa-436d-ae43-6e2c9b4c55e8)
![image](https://github.com/user-attachments/assets/89d3ca00-9d4c-487c-91de-51c5e1b87b85)
![image](https://github.com/user-attachments/assets/3da767ac-2334-421d-b774-ea50b9ba0828)
![image](https://github.com/user-attachments/assets/c16d4770-175e-4ab9-8710-86d4ab6f6fbd)
![image](https://github.com/user-attachments/assets/1befa606-7e2a-4f67-99d8-6bde499a3b6e)
![image](https://github.com/user-attachments/assets/fc3381ba-333d-42f6-a7ef-4714ecf803ff)
![image](https://github.com/user-attachments/assets/429d914d-b075-4012-89a5-8e1204def183)
![image](https://github.com/user-attachments/assets/49c1d748-43be-4e88-863f-1f662ae9ad47)


#### Instrucciones de uso
- Configuracion inicial
  para el proyecto backend una vez que lo tengas en tu local no olvides crear el entorno de variables, en este caso para la conexion a la base de datos
```bash
DB_SERVER=db_server
DB_NAME=name_databasea
DB_USER=your_user_database
DB_PASSWORD=your_pass_DB
```
las variables las utilizaras en el archivo program.cs
- Una vez que levantes en backend, prueba con el frondEnd, en el frond deberas poner atencion cual es el dominio o puerto en el que corre ya que ese sera configurado en el archivo backend program.cs esto se trata de permisos CORS

#### Descripción de desarrollo
Este proyecto es una plataforma de entretenimiento que permite a los usuarios explorar una amplia gama de películas y series, así como agregar sus títulos favoritos a una lista personal. El desarrollo del proyecto se enfocó en crear una aplicación robusta, escalable y fácil de usar, utilizando tecnologías modernas tanto en el backend como en el frontend.

### Tecnologías Utilizadas

1. **Backend:**

   - **.NET 8:** Utilizado para construir una API RESTful que maneja la lógica de negocio, autenticación y autorización, y la interacción con la base de datos.
   - **Entity Framework Core:** Se empleó como ORM (Object-Relational Mapper) para interactuar con la base de datos SQL Server, facilitando la gestión de entidades como `Users`, `Movies`, `Series`, y `Favorites`.
   - **JWT (JSON Web Tokens):** Implementado para manejar la autenticación basada en tokens, asegurando que solo los usuarios autenticados puedan acceder a ciertas funcionalidades como agregar películas a favoritos.

2. **Frontend:**

   - **Angular 18:** El framework principal utilizado para construir una interfaz de usuario dinámica y responsiva. Angular se eligió por su robustez en la creación de aplicaciones de una sola página (SPA) y su ecosistema maduro.
   - **Bootstrap 5:** Utilizado para el diseño y la creación de una interfaz de usuario moderna y amigable. Bootstrap proporcionó una base sólida para asegurar que la aplicación fuera responsive y accesible en dispositivos de todos los tamaños.
   - **JWT-decode:** Una librería utilizada en el frontend para decodificar el token JWT y extraer la información del usuario, como su ID, que es necesario para realizar acciones como agregar películas a favoritos.

### Proceso de Desarrollo

El desarrollo del proyecto se llevó a cabo en varias etapas clave:

1. **Planeación y Diseño:**
   
   - Se comenzó con la definición de la arquitectura del sistema, incluyendo la estructura de la base de datos, las relaciones entre entidades y los endpoints de la API.
   - También se diseñó la estructura de carpetas del frontend para facilitar la escalabilidad y mantenibilidad del proyecto.

2. **Desarrollo del Backend:**

   - Se implementaron las entidades principales (`User`, `Movie`, `Series`, `Favorite`) y se configuró la base de datos utilizando Entity Framework Core.
   - Se añadieron los controladores necesarios para manejar las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) y se implementaron mecanismos de autenticación con JWT para proteger los endpoints.
   - Se realizaron pruebas unitarias y de integración para asegurar que la lógica de negocio funcionara correctamente.

3. **Desarrollo del Frontend:**

   - Se desarrollaron los componentes principales de la interfaz, incluyendo páginas para el registro, inicio de sesión, listado de películas y series, y gestión de favoritos.
   - Se integró el frontend con el backend a través de servicios HTTP, manejando correctamente la autenticación y autorización con JWT.
   - Se realizaron ajustes en el diseño utilizando Bootstrap para asegurar una experiencia de usuario agradable y responsiva.

4. **Integración y Pruebas:**

   - Se llevó a cabo la integración del frontend y backend, asegurando que todas las funcionalidades funcionaran de manera coherente.
   - Se realizaron pruebas end-to-end para verificar el correcto funcionamiento de la aplicación desde la perspectiva del usuario final.

5. **Despliegue:**

   - La aplicación fue preparada para su despliegue en un entorno de producción, incluyendo la configuración de variables de entorno y la optimización del rendimiento.


#### Reporte de code-coverage y reporte de testing

![image](https://github.com/user-attachments/assets/3449e564-29a9-43c8-a9b5-0158ef3a22f1)
![image](https://github.com/user-attachments/assets/7b90c942-9875-4f01-8e49-8711b817d5da)


#### Diagrama de entidad Relacion

![image](https://github.com/user-attachments/assets/9a468b90-3d7d-43ba-9287-fe5df53feb23)

#### Mejoras Futuras
- Agregar funcionalidad para configuraciones del usuario
- Ordenas las peliculas y series por genero
- realizar base de datos para los poster y perfiles de los usuarios ya que en la de sql server solo se agregar la URL

#### Documentación de API - Swagger
![image](https://github.com/user-attachments/assets/8b1434af-da74-45f3-8429-cddbf1a17aba)

#### Implementacion Docker y Kubernetes


- Estructura de carpetas
  como ya se tenia por separado el frontEnd y el backEnd, en ellas se crean los archivos de configuracion Dockerfile. posterior se agrega una carpeta llamada kubernetes donde se configuraran los servicios pods
  ![image](https://github.com/user-attachments/assets/03a2c72e-10ba-4983-b1af-e29ef14f5dc7)


- Dockerfile del BackEnd
![image](https://github.com/user-attachments/assets/5599800a-cac3-4ca9-a6f7-7d5e62b34819)
- Dockerfile del FrontEnd
![image](https://github.com/user-attachments/assets/b79cd8ec-6503-460f-ad8a-240333a3c88e)
- En la carpeta Kubernetes se agregan los archivos -yaml para la configuracion de kubernetes, se realizo con minikube por tratarse de local
  ![image](https://github.com/user-attachments/assets/8905984f-c99d-4b4c-ab22-f66f6b34fa33)
- Finalmente se crean los pods y servicios tanto para el frontEnd como para el BackEnd
- ![image](https://github.com/user-attachments/assets/5d1c2192-ce34-46de-9b0d-faba7b2ba2ed)



#### Problemas conocidos
- Desconocimiento de uso de TOKEN JWT para mantener sesion abierta en el navegador por cierto tiempo
- Falta de organizacion y estructuracion para el desarrollo del proyecto, que cada vez va mejorando

#### Retrospectiva

##### ¿Qué hice bien?
- Arriesgarme a realizar proyecto tras proyecto, no me salia varias veces tenia que volver a crear un nuevo proyecto

##### ¿Qué no salio bien?
- No se alcanzo a obtener el token y a traves del el, el ID del User para agregar a favoritos las peliculas
- Falto el apartado de configuraciones que puede realizar el usuario


##### ¿Qué puedo hacer diferente?
- Plantear mejor el proyecto
- seguir estudiando y realizando proyectos que solo asi se aprende


