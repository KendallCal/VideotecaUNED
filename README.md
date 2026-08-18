<div align="center">

# 🎬 VideotecaUNED

### Sistema cliente-servidor para gestión de préstamos de películas

Proyecto desarrollado en **C# y .NET**, con comunicación mediante **TCP/IP**, persistencia en **SQL Server** y soporte para múltiples conexiones concurrentes.

<br>

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge\&logo=microsoftsqlserver\&logoColor=white)
![TCP/IP](https://img.shields.io/badge/TCP%2FIP-Networking-0A66C2?style=for-the-badge)

</div>

---

## 📌 Sobre el proyecto

**VideotecaUNED** es una aplicación de escritorio desarrollada como proyecto final del curso de **Programación Avanzada** de la Universidad Estatal a Distancia (UNED), durante el II Cuatrimestre de 2024.

El sistema implementa una arquitectura **cliente-servidor**, donde ambas aplicaciones se comunican mediante el protocolo **TCP**.

El proyecto integra conceptos de programación avanzada como:

* Comunicación en red.
* Arquitectura cliente-servidor.
* Manejo de múltiples conexiones.
* Subprocesamiento múltiple.
* Operaciones CRUD.
* Persistencia de datos.
* Manejo de excepciones.
* Registro de actividad en tiempo real.

---

## 🏗️ Arquitectura

```text
┌──────────────────────┐
│       CLIENTE        │
│                      │
│  Consultas           │
│  Préstamos           │
│  Disponibilidad      │
└──────────┬───────────┘
           │
           │ TCP/IP
           │
┌──────────▼───────────┐
│       SERVIDOR       │
│                      │
│  Lógica de negocio   │
│  Multithreading      │
│  Gestión de datos    │
└──────────┬───────────┘
           │
           │
┌──────────▼───────────┐
│     SQL SERVER       │
│                      │
│  Persistencia        │
│  Consultas y CRUD    │
└──────────────────────┘
```

---

## 💻 Aplicación cliente

La aplicación cliente permite a los usuarios interactuar con el sistema de préstamos.

### Funcionalidades

* Validación de clientes mediante la base de datos.
* Consulta de sucursales disponibles.
* Consulta de películas.
* Solicitud de préstamos.
* Consulta de préstamos realizados.
* Comunicación con el servidor mediante TCP/IP.

<div align="center">

<img src="imagenes/Cliente.png" alt="Aplicación cliente de VideotecaUNED" width="85%">

</div>

---

## 🖥️ Aplicación servidor

El servidor centraliza la lógica de negocio, administra las solicitudes realizadas por los clientes y gestiona la comunicación con la base de datos.

### Funcionalidades

* Manejo de múltiples conexiones mediante **subprocesamiento múltiple**.
* Gestión de solicitudes provenientes de los clientes.
* Operaciones CRUD para:

  * Categorías.
  * Películas.
  * Encargados.
  * Sucursales.
  * Clientes.
* Acceso y actualización de información en SQL Server.
* Bitácora en tiempo real de las actividades realizadas por los clientes.

<div align="center">

<img src="imagenes/Servidor.png" alt="Aplicación servidor de VideotecaUNED" width="85%">

</div>

---

## 🛠️ Tecnologías

| Área          | Tecnología                    |
| ------------- | ----------------------------- |
| Lenguaje      | C#                            |
| Plataforma    | .NET Framework 4.8 / .NET 6.0 |
| Base de datos | SQL Server                    |
| Comunicación  | TCP/IP                        |
| IDE           | Visual Studio Community 2022  |

---

## 🎥 Demostración

El repositorio incluye una demostración del funcionamiento completo del sistema.

▶️ [Ver video de demostración](imagenes/Demo.mp4)

También puedes consultar la carpeta [`imagenes`](imagenes) para ver más capturas del proyecto.

---

## 🚀 Ejecución local

### 1. Clonar el repositorio

```bash
git clone https://github.com/KendallCal/VideotecaUNED.git
```

### 2. Abrir la solución

Abre el proyecto utilizando **Visual Studio Community 2022**.

### 3. Configurar la base de datos

Configura **SQL Server** utilizando el script de base de datos incluido en el proyecto.

### 4. Ejecutar el servidor

Inicia primero la aplicación encargada de recibir las conexiones y gestionar las operaciones del sistema.

### 5. Ejecutar el cliente

Inicia la aplicación cliente y establece la comunicación con el servidor para utilizar las funcionalidades disponibles.

---

## 🎓 Contexto académico

Este proyecto fue desarrollado como parte del curso de **Programación Avanzada de la UNED**.

Más allá de los requisitos académicos, el proyecto permitió aplicar de forma práctica conceptos de:

**programación orientada a objetos · redes · bases de datos · concurrencia · arquitectura cliente-servidor · manejo de excepciones**

---

<div align="center">

### 👨‍💻 Kendall Calderón

[![GitHub](https://img.shields.io/badge/GitHub-KendallCal-181717?style=for-the-badge\&logo=github)](https://github.com/KendallCal)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Kendall_Calderón-0A66C2?style=for-the-badge\&logo=linkedin\&logoColor=white)](https://www.linkedin.com/in/kendallcal/)
[![Portfolio](https://img.shields.io/badge/Portfolio-kendallc.dev-0A66C2?style=for-the-badge\&logo=googlechrome\&logoColor=white)](https://www.kendallc.dev/)

</div>
