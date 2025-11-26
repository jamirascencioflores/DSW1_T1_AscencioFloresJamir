# Evaluación T1 - Desarrollo de Servicios Web I

**Alumno:** Jamir Ascencio Flores
**Curso:** Desarrollo de Servicios Web I
**Sección:** T5GO
**ID Estudiante:** I202412703

## 📋 Descripción del Proyecto
API RESTful desarrollada con **ASP.NET Core** y **Entity Framework Core (Code First)** utilizando **MySQL**. El proyecto implementa la gestión de Cursos y Niveles Académicos, aplicando el **Patrón Repositorio** y cumpliendo con los requisitos de filtrado, paginación y CRUD.

## 🛠️ Tecnologías Utilizadas
* .NET 8.0 (ASP.NET Core Web API)
* Entity Framework Core (MySQL / Pomelo)
* Patrón de Diseño: Repository Pattern
* Swagger UI (Documentación)
* DotNetEnv (Manejo de variables de entorno)

## 🚀 Instrucciones de Instalación y Ejecución

Siga estos pasos para ejecutar el proyecto correctamente en su entorno local:

### 1. Configuración de Base de Datos (.env)
El proyecto utiliza un archivo `.env` para la cadena de conexión.
* **Nota:** El archivo `.env` se ha incluido en el repositorio para facilitar la revisión.
* Si no lo detecta, cree un archivo llamado `.env` en la raíz con el siguiente contenido:

```env
DB_SERVER=localhost
DB_PORT=3306
DB_DATABASE=DSW1_T1_AscencioFlores
DB_USER=root
DB_PASSWORD=[SU_CONTRASEÑA_ROOT]
```

### 2. Generar la Base de Datos (Migraciones)
Abra la consola de administración de paquetes (o terminal) en la raíz del proyecto y ejecute:

```env
Update-Database
```
Esto creará la base de datos DSW1_T1_AscencioFlores y las tablas necesarias en su MySQL.

### 3. Carga de Datos Iniciales (IMPORTANTE) ⚠️
Dado que el sistema requiere Niveles Académicos existentes para poder registrar cursos, es necesario ejecutar el script SQL adjunto.

 * 1. Abra MySQL Workbench.
 * 2. Abra el archivo script_datos_iniciales.sql ubicado en la raíz de este repositorio.
 * 3. Ejecute el script para insertar los niveles (Pregrado, Postgrado, Extensión).

### 4. Ejecución
Ejecute el proyecto desde Visual Studio (F5). Se abrirá automáticamente Swagger UI.


