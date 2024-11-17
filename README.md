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
	id_cliente INT NOT NULL,
	CONSTRAINT FK_Orden FOREIGN KEY (id_orden) REFERENCES Orden(id_orden),
	CONSTRAINT FK_Tenico FOREIGN KEY (id_tecnico) REFERENCES Tecnico(id_tecnico),
	CONSTRAINT FK_ClienteEquipo FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);

GO
-- Inserciones para Cliente
INSERT INTO Cliente (nombre, apellido_paterno, apellido_materno, correo, telefono)
VALUES 
('Juan', 'Pérez', 'López', 'juan.perez@gmail.com', '5551234567'),
('María', 'González', 'Hernández', 'maria.gonzalez@gmail.com', '5559876543'),
('Carlos', 'Ramírez', 'Martínez', 'carlos.ramirez@gmail.com', '5551112233');
GO
-- Inserciones para Técnico
INSERT INTO Tecnico (nombre, apellido_paterno, apellido_materno, correo, contrasenia)
VALUES 
('Laura', 'Fernández', 'Sánchez', 'laura.fernandez@gmail.com', 'password123'),
('Pedro', 'Gómez', 'Rojas', 'pedro.gomez@gmail.com', 'securepass');
GO
-- Inserciones para Orden
INSERT INTO Orden (fecha_creacion, id_cliente)
VALUES 
(GETDATE(), 1), -- Orden de Juan
(GETDATE(), 2), -- Orden de María
(GETDATE(), 3); -- Orden de Carlos
GO
-- Inserciones para Equipo
INSERT INTO Equipo (marca, modelo, contrasenia_equipo, accesorios, problema, estatus, fecha_entrega, id_orden, id_tecnico, id_cliente)
VALUES 
('HP', 'Pavilion 15', NULL, 'Cargador original', 'No enciende', 'Pendiente', NULL, 1, 1, 1), -- Orden de Juan, técnico Laura
('Dell', 'Inspiron 14', 'abcd1234', 'Mouse y cargador', 'Pantalla rota', 'En reparación', GETDATE() + 5, 2, 2, 2), -- Orden de María, técnico Pedro
('Lenovo', 'ThinkPad X1', NULL, 'Cargador', 'Batería dañada', 'Reparado', GETDATE(), 3, 1, 3); -- Orden de Carlos, técnico Laura

````
