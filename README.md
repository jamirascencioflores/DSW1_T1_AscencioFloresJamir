\# Evaluación T1 - Desarrollo de Servicios Web I



\*\*Alumno:\*\* Jamir Ascencio Flores

\*\*Curso:\*\* Desarrollo de Servicios Web I

\[cite\_start]\*\*Sección:\*\* T5GO \[cite: 5]

\*\*ID Estudiante:\*\* \[COLOCA\_AQUI\_TU\_CODIGO]



\## 📋 Descripción del Proyecto

API RESTful desarrollada con \*\*ASP.NET Core\*\* y \*\*Entity Framework Core (Code First)\*\* utilizando \*\*MySQL\*\*. El proyecto implementa la gestión de Cursos y Niveles Académicos, aplicando el \*\*Patrón Repositorio\*\* y cumpliendo con los requisitos de filtrado, paginación y CRUD.



\## 🛠️ Tecnologías Utilizadas

\* .NET 8.0 (ASP.NET Core Web API)

\* Entity Framework Core (MySQL / Pomelo)

\* Patrón de Diseño: Repository Pattern

\* Swagger UI (Documentación)

\* DotNetEnv (Manejo de variables de entorno)



\## 🚀 Instrucciones de Instalación y Ejecución



Siga estos pasos para ejecutar el proyecto correctamente en su entorno local:



\### 1. Configuración de Base de Datos (.env)

El proyecto utiliza un archivo `.env` para la cadena de conexión.

\* \*\*Nota:\*\* El archivo `.env` se ha incluido en el repositorio para facilitar la revisión.

\* Si no lo detecta, cree un archivo llamado `.env` en la raíz con el siguiente contenido:



```env

DB\_SERVER=localhost

DB\_PORT=3306

DB\_DATABASE=DSW1\_T1\_AscencioFlores

DB\_USER=root

DB\_PASSWORD=\[SU\_CONTRASEÑA\_ROOT]

