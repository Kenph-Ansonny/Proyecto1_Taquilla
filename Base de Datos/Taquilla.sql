use Taquilla;
 
 -- Borrar las tablas
SET FOREIGN_KEY_CHECKS = 0;

-- Genera DROP TABLE para todas las tablas
SET @tables = NULL;
SELECT GROUP_CONCAT('`', table_name, '`') INTO @tables
FROM information_schema.tables 
WHERE table_schema = 'Taquilla';

SET @sql = CONCAT('DROP TABLE IF EXISTS ', @tables);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

SET FOREIGN_KEY_CHECKS = 1;

show tables;
---------------------------------------------------
CREATE TABLE bitacora (
    bitid INT PRIMARY KEY auto_increment,
    bitfecha datetime,
    bitaccion varchar(50),
    usuid int,
    aplid int,
    bitip varchar(60),
    bitnombrepc Varchar(60),
	FOREIGN KEY (usuid) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Plaza (
    ID_Plaza INT PRIMARY KEY,
    Nombre_Plaza VARCHAR(100),
    Departamento VARCHAR(50),
    Zona VARCHAR(20)
);

-- Tabla Cine
CREATE TABLE Cine (
    ID_Cine INT PRIMARY KEY,
    Nombre VARCHAR(100),
    ID_Plaza INT,
    FOREIGN KEY (ID_Plaza) REFERENCES Plaza(ID_Plaza)
);

-- Tabla Proyeccion
CREATE TABLE Proyeccion (
    ID_Proyeccion INT PRIMARY KEY,
    Tipo_de_proyeccion VARCHAR(20)
);

-- Tabla Sala_Proyeccion
CREATE TABLE Sala (
    ID_Sala INT PRIMARY KEY,
    ID_Proyeccion INT,
    FOREIGN KEY (ID_Proyeccion) REFERENCES Proyeccion(ID_Proyeccion)
);


-- Tabla SALA_DE_CINE
CREATE TABLE SALA_DE_CINE (
    ID_SALA_DE_CINE INT PRIMARY KEY,
    ID_Cine INT,
    No_Sala INT,
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

-- Tabla Funcion
CREATE TABLE Funcion (
    ID_Funcion INT PRIMARY KEY,
    Horario VARCHAR(20),
    Fecha DATE,
    ID_Pelicula INT,
    Cantidad_Boletos INT,
    ID_SALA_DE_CINE INT,
    ID_Idioma INT,
    ID_Proyeccion INT,
    FOREIGN KEY (ID_Pelicula) REFERENCES Pelicula(ID_Pelicula),
    FOREIGN KEY (ID_SALA_DE_CINE) REFERENCES SALA_DE_CINE(ID_SALA_DE_CINE),
    FOREIGN KEY (ID_Proyeccion) REFERENCES Proyeccion(ID_Proyeccion),
    FOREIGN KEY (ID_Idioma) REFERENCES Idioma(ID_Idioma)
);

-- Tabla Boleto
CREATE TABLE Boleto (
    ID_Boleto INT PRIMARY KEY,
    ID_Funcion INT,
    Asiento VARCHAR(10),
    Precio DECIMAL(6,2),
    FOREIGN KEY (ID_Funcion) REFERENCES Funcion(ID_Funcion)
);

-- Tabla Genero
CREATE TABLE Genero (
    ID_Genero INT PRIMARY KEY,
    Nombre_Genero VARCHAR(50)
);

-- Tabla Clasificacion_Edad
CREATE TABLE Clasificacion_Edad (
    ID_Clasificacion INT PRIMARY KEY,
    Clasificacion VARCHAR(5),
    Descripcion VARCHAR(100)
);

-- Tabla Idioma
CREATE TABLE Idioma (
    ID_Idioma INT PRIMARY KEY,
    Doblada BIT,
    Subtitulos BIT
);

-- Tabla Pelicula
CREATE TABLE Pelicula (
    ID_Pelicula INT PRIMARY KEY,
    Nombre VARCHAR(100),
    ID_Genero INT,
    ID_Clasificacion INT,
    Sinopsis VARCHAR(255),
    FOREIGN KEY (ID_Genero) REFERENCES Genero(ID_Genero),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificacion_Edad(ID_Clasificacion)
);

-- Tabla Cliente
CREATE TABLE Cliente (
    ID_Cliente INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Correo VARCHAR(100),
    NIT VARCHAR(20)
);

-- Tabla Compra
CREATE TABLE Compra (
    ID_Compra INT PRIMARY KEY,
    ID_Cliente INT,
    Fecha DATE,
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

-- Tabla Detalles_Compra
CREATE TABLE Detalles_Compra (
    ID_Compra INT,
    ID_Boleto INT,
    PRIMARY KEY (ID_Compra, ID_Boleto),
    FOREIGN KEY (ID_Compra) REFERENCES Compra(ID_Compra),
    FOREIGN KEY (ID_Boleto) REFERENCES Boleto(ID_Boleto)
);

-- Tabla Empleado
CREATE TABLE Empleado (
    ID_Empleado INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Cargo VARCHAR(50),
    Salario VARCHAR(20),
    Correo VARCHAR(100),
    ID_Cine INT,
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

-- Tabla Telefono_Empleado
CREATE TABLE Telefono_Empleado (
    ID_Telefono INT PRIMARY KEY,
    Telefono VARCHAR(15),
    ID_Empleado INT,
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

-- Tabla Reporte_Ventas
CREATE TABLE Reporte_Ventas (
    ID_Reporte INT PRIMARY KEY,
    Fecha DATE,
    Total_Ventas DECIMAL(10,2),
    ID_Cine INT,
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

-- Tabla Usuarios
CREATE TABLE Usuarios (
    ID_Usuario INT PRIMARY KEY,
    Nombre_Usuario VARCHAR(50),
    Contrasena VARCHAR(100),
    ID_Cliente INT,
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
	ID_Empleado INT,
	FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado),
	Identificador BIT -- Empleado 1      0 Cliente
);