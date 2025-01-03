# Documentación del Proyecto - Car Rental

Este repositorio contiene la solución de un proyecto orientado al desarrollo de software. El trabajo se dividió en dos áreas principales:

1. **Base de Datos**: Diseño y desarrollo de un modelo entidad-relación y consultas SQL avanzadas.
2. **Programación Backend/Frontend**: Desarrollo de un aplicativo de escritorio funcional en C# .NET Framework.

Las herramientas empleadas incluyen SQL Server para la base de datos y C# para el desarrollo del aplicativo.

---

## Estructura del directorio de bases de datos

```text
car_rental_db
|
├── backup
|    └── 2025_01_02_0001_car_rental_db.sql
├── queries
|    ├── 2025_01_01_0000_records.sql
|    └── 2025_01_01_0001_queries.sql
└── schema
     ├── 2025_01_01_0000_create_database.sql
     ├── 2025_01_01_0001_create_tables.sql
     └── 2025_01_01_0002_create_relationships.sql
```

### Directorios Principales de la base de datos:
- **backup/**: Contiene el archivo SQL con el código completo del schema y los queries.
- **queries/**: Incluye scripts para consultas específicas e inserciones.
- **schema/**: Archivos para la creación de la base de datos, tablas y relaciones.

---

## Desarrollo del Proyecto

### 1. Base de Datos

#### Creación de Base de Datos y Esquema
- Modelo entidad-relación implementado en SQL Server.
- Se incorporaron campos adicionales a las entidades: `id_nombre_entidad` (autoincremental), `created_at` y `updated_at`.

![Modelo entidad-relación](https://github.com/user-attachments/assets/86d958d0-0f06-405d-ae7f-5fd444eb8a66)

#### Consultas Principales
1. **Número de alquileres de un carro desde una fecha específica.**
   - Consulta para contabilizar alquileres usando el campo `PLACA`.
2. **Total de saldo en un día específico.**
   - Uso de `SUM` para calcular los resultados filtrados por fecha.
3. **Relación entre entidades ALQUILER, CLIENTE y CARRO.**
   - Uso de `JOIN` sin filtros adicionales.
4. **Clientes que no han alquilado en un período específico.**
   - Selección de cédulas y nombres en un rango de fechas.
5. **Primer alquiler de un cliente.**
   - Consulta basada en la cédula del cliente como identificador único.

#### Scripts Relevantes
- `2025_01_01_0001_queries.sql`: Consultas detalladas.
- `2025_01_01_0000_records.sql`: Datos iniciales de prueba.

---

### 2. Programación Backend/Frontend

#### Aplicativo de Escritorio
Desarrollado en C# .NET Framework, cuenta con las siguientes características:

1. **Vista con información de la consulta 1.4.**
   - Tabla que muestra los registros relacionados mediante un sidebar con opciones.

   ![Vista de la consulta 1.4](https://github.com/user-attachments/assets/90782246-cb57-4389-9e23-52590e0ef1a7)

2. **Filtro por fecha inicial y final de alquiler.**
   - Actualización dinámica de la información mostrada en la tabla.

   ![Filtro por fechas](https://github.com/user-attachments/assets/31804282-4f47-4053-b69e-b66c75373577)

3. **Vista de alquileres por día y por mes.**
   - Actualización automática cada minuto para mostrar datos en tiempo real.

   ![Vista de alquileres por tiempo](https://github.com/user-attachments/assets/0a3366bd-cbcc-4c0e-a471-f91501b4653e)
---


## Instrucciones de Uso

### Requisitos
- **SQL Server**: Para la configuración y ejecución de la base de datos.
- **Visual Studio 2022**: Para compilar y ejecutar el aplicativo de escritorio.

### Pasos
1. Correr la base de datos utilizando el script situado en el directorio `backup/`.
2. Configurar y ejecutar el aplicativo de escritorio desde el proyecto C#.

### Aplicativo Funcionando
![Ejecución del aplicativo](https://github.com/user-attachments/assets/131b6bd8-742b-4bdf-977c-e07409c56eb3)

