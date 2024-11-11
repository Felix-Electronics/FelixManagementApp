```sql
CREATE DATABASE FelixElectronics;
GO
USE FelixElectronics;
GO

CREATE TABLE Cliente(
	id_cliente INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
	apellido_paterno VARCHAR(50) NOT NULL,
	apellido_materno VARCHAR(50) NOT NULL,
	correo VARCHAR(50) NOT NULL,
	telefono VARCHAR(15) NOT NULL,
);

CREATE TABLE Tecnico(
	id_tecnico INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
	apellido_paterno VARCHAR(50) NOT NULL,
	apellido_materno VARCHAR(50) NOT NULL,
	correo VARCHAR(50) NOT NULL,
	contrasenia VARCHAR(20) NOT NULL
);

CREATE TABLE Orden(
	id_orden INT IDENTITY(1,1) PRIMARY KEY,
	fecha_creacion DATETIME NOT NULL,
	id_cliente INT NOT NULL,
	CONSTRAINT FK_Cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);

CREATE TABLE Equipo(
	id_equipo INT IDENTITY(1,1) PRIMARY KEY,
	marca VARCHAR(20) NOT NULL,
	modelo VARCHAR(20) NOT NULL,
	contrasenia_equipo VARCHAR (20) NULL,
	accesorios VARCHAR(150) NULL,
	problema VARCHAR(150) NOT NULL,
	estatus VARCHAR(20) NOT NULL,
	fecha_entrega DATETIME NULL,
	id_orden INT NOT NULL,
	id_tecnico INT NOT NULL,
	CONSTRAINT FK_Orden FOREIGN KEY (id_orden) REFERENCES Orden(id_orden),
	CONSTRAINT FK_Tenico FOREIGN KEY (id_tecnico) REFERENCES Tecnico(id_tecnico)
);
````
