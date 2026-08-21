-- PARA CREAR LA BASE DE DATOS

IF DB_ID('GestionEstudiantes') IS NULL
BEGIN
    CREATE DATABASE GestionEstudiantes;
END
GO

USE GestionEstudiantes;
GO

IF OBJECT_ID('dbo.Estudiantes', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Estudiantes
    (
        Id INT IDENTITY(1,1) NOT NULL,
        Carnet NVARCHAR(20) NOT NULL,
        Nombre NVARCHAR(80) NOT NULL,
        Apellidos NVARCHAR(80) NOT NULL,
        Correo NVARCHAR(150) NOT NULL,
        FechaNacimiento DATE NOT NULL,
        Estado NVARCHAR(20) NOT NULL,
        NivelAcademico NVARCHAR(80) NOT NULL,
        FechaRegistro DATETIME2 NOT NULL
            CONSTRAINT DF_Estudiantes_FechaRegistro DEFAULT SYSDATETIME(),

        CONSTRAINT PK_Estudiantes
            PRIMARY KEY (Id),

        CONSTRAINT UQ_Estudiantes_Carnet
            UNIQUE (Carnet),

        CONSTRAINT UQ_Estudiantes_Correo
            UNIQUE (Correo),

        CONSTRAINT CK_Estudiantes_Estado
            CHECK (Estado IN ('Activo', 'Inactivo'))
    );
END
GO