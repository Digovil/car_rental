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

1.  Creación de Base de Datos y Esquema
- Modelo entidad-relación implementado en SQL Server.
- Se incorporaron campos adicionales a las entidades: `id_nombre_entidad` (autoincremental), `created_at` y `updated_at`.

![Modelo entidad-relación](https://github.com/user-attachments/assets/86d958d0-0f06-405d-ae7f-5fd444eb8a66)

#### Consultas Principales
2. **Número de alquileres de un carro desde una fecha específica.**
   - Consulta para contabilizar alquileres usando el campo `PLACA`.
     ![image](https://github.com/user-attachments/assets/51280b53-eae3-4606-87db-65f6a5cff3c1)

3. **Total de saldo en un día específico.**
   - Uso de `SUM` para calcular los resultados filtrados por fecha.
     ![image](https://github.com/user-attachments/assets/611c0679-2d0d-43f9-9e16-f545b11a488b)

4. **Relación entre entidades ALQUILER, CLIENTE y CARRO.**
     ![image](https://github.com/user-attachments/assets/c01f4207-b3d2-4a41-806a-e8d28fb5e777)
   - Uso de `JOIN` sin filtros adicionales.
     ![image](https://github.com/user-attachments/assets/1f45eb3c-1b61-4a3c-84c8-ff776ae4329a)

5. **Clientes que no han alquilado en un período específico.**
   - Selección de cédulas y nombres en un rango de fechas.
     ![image](https://github.com/user-attachments/assets/656ca6c0-bc94-46ef-bc64-bf4bd71111af)
     
6. **Consulta específica en un rango de fecha.**

   - En esta consulta se entiende que se debe realizar a partir de una fecha en adelante, por ende, obtiene información sobre los pagos realizados para alquileres desde el 2 de enero de 2025 en adelante
     ![image](https://github.com/user-attachments/assets/4bb5d53e-8b54-4acb-8b96-2d532c4e8dc2)
     
7. **Consolidados por carro en un tiempo específico.**
   - La consulta proporciona un resumen de los alquileres realizados entre el 2 y el 3 de enero de 2025, agrupados por cada carro. El alias CODCARRO tomó el valor del campo PLACAS.
     ![image](https://github.com/user-attachments/assets/107f0aa1-22c3-41f7-b433-9386a0799c54)

8. **Primer alquiler de un cliente.**
   - Consulta basada en la cédula del cliente como identificador único.
     ![image](https://github.com/user-attachments/assets/2987ad06-5985-4b5e-9f83-88b247063837)

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

