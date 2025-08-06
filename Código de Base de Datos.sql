CREATE TABLE Asientos_de_Funcion (
    ID_Asiento int NOT NULL,
    ID_Funcion int NOT NULL,
    Disponibilidad bit,
    FOREIGN KEY (ID_Asiento) REFERENCES Asientos_de_Sala(ID_Asiento),
    FOREIGN KEY (ID_Funcion) REFERENCES Funcion(ID_Funcion)
);

CREATE TABLE Asientos_de_Sala (
    ID_Asiento int NOT NULL,
    No_Asiento varchar(10),
    ID_Sala int,
    PRIMARY KEY (ID_Asiento),
    FOREIGN KEY (ID_Sala) REFERENCES Sala(ID_Sala)
);

CREATE TABLE Boleto (
    ID_Boleto int NOT NULL,
    ID_Asiento int,
    ID_Funcion int,
    ID_Precio int,
    PRIMARY KEY (ID_Boleto),
    FOREIGN KEY (ID_Asiento) REFERENCES Asientos_de_Funcion(ID_Asiento),
    FOREIGN KEY (ID_Funcion) REFERENCES Asientos_de_Funcion(ID_Funcion),
    FOREIGN KEY (ID_Precio) REFERENCES Precio(ID_Precio)
);

CREATE TABLE Cine (
    ID_Cine int NOT NULL,
    Nombre varchar(100),
    ID_Plaza int,
    Cantidad_de_Salas int,
    PRIMARY KEY (ID_Cine),
    FOREIGN KEY (ID_Plaza) REFERENCES Plaza(ID_Plaza)
);

CREATE TABLE Clasificacion_Edad (
    ID_Clasificacion int NOT NULL,
    Clasificacion varchar(5),
    Descripcion varchar(100),
    PRIMARY KEY (ID_Clasificacion)
);

CREATE TABLE Cliente (
    ID_Cliente int NOT NULL,
    Nombre varchar(50),
    Apellido varchar(50),
    Correo varchar(100),
    NIT varchar(20),
    PRIMARY KEY (ID_Cliente)
);

CREATE TABLE Compra (
    ID_Compra int NOT NULL,
    ID_Cliente int,
    Fecha date,
    PRIMARY KEY (ID_Compra),
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

CREATE TABLE Prueba (
    ID_Compra int NOT NULL,
    ID_Boleto int NOT NULL,
    FOREIGN KEY (ID_Compra) REFERENCES Compra(ID_Compra),
    FOREIGN KEY (ID_Boleto) REFERENCES Boleto(ID_Boleto)
);

CREATE TABLE Empleado (
    ID_Empleado int NOT NULL,
    Nombre varchar(50),
    Apellido varchar(50),
    Cargo varchar(50),
    Salario varchar(20),
    Correo varchar(100),
    ID_Cine int,
    PRIMARY KEY (ID_Empleado),
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

CREATE TABLE Funcion (
    ID_Funcion int NOT NULL,
    Horario varchar(20),
    Fecha date,
    ID_Pelicula int,
    Cantidad_Boletos int,
    ID_Sala int,
    ID_Idioma int,
    PRIMARY KEY (ID_Funcion),
    FOREIGN KEY (ID_Sala) REFERENCES Sala(ID_Sala),
    FOREIGN KEY (ID_Pelicula) REFERENCES Pelicula(ID_Pelicula),
    FOREIGN KEY (ID_Idioma) REFERENCES Idioma(ID_Idioma)
);

CREATE TABLE Genero (
    ID_Genero int NOT NULL,
    Nombre_Genero varchar(50),
    PRIMARY KEY (ID_Genero)
);

CREATE TABLE Idioma (
    ID_Idioma int NOT NULL,
    Doblada bit(1),
    Subtitulos bit(1),
    PRIMARY KEY (ID_Idioma)
);

CREATE TABLE Pelicula (
    ID_Pelicula int NOT NULL,
    Nombre varchar(100),
    ID_Genero int,
    ID_Clasificacion int,
    Sinopsis varchar(255),
    PRIMARY KEY (ID_Pelicula),
    FOREIGN KEY (ID_Genero) REFERENCES Genero(ID_Genero),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificacion_Edad(ID_Clasificacion)
);

CREATE TABLE Plaza (
    ID_Plaza int NOT NULL,
    Nombre_Plaza varchar(100),
    Departamento varchar(50),
    Zona varchar(20),
    PRIMARY KEY (ID_Plaza)
);

CREATE TABLE Precio (
    ID_Precio int NOT NULL,
    ID_Proyeccion int,
    Precio decimal(10,2),
    PRIMARY KEY (ID_Precio),
    FOREIGN KEY (ID_Proyeccion) REFERENCES Proyeccion(ID_Proyeccion)
);

CREATE TABLE Proyeccion (
    ID_Proyeccion int NOT NULL,
    Tipo_de_proyeccion varchar(20),
    PRIMARY KEY (ID_Proyeccion)
);

CREATE TABLE Reporte_Ventas (
    ID_Reporte int NOT NULL,
    Fecha date,
    Total_Ventas decimal(10,2),
    ID_Cine int,
    PRIMARY KEY (ID_Reporte),
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

CREATE TABLE SALA_DE_CINE (
    ID_Cine int,
    No_Sala int,
    ID_Sala int,
    Capacidad_de_Asientos int,
	FOREIGN KEY (ID_Sala) REFERENCES Sala(ID_Sala),
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

CREATE TABLE Sala (
    ID_Sala int NOT NULL,
    ID_Proyeccion int,
    PRIMARY KEY (ID_Sala),
    FOREIGN KEY (ID_Proyeccion) REFERENCES Proyeccion(ID_Proyeccion)
);

CREATE TABLE Telefono_Empleado (
    ID_Telefono int NOT NULL,
    Telefono varchar(15),
    ID_Empleado int,
    PRIMARY KEY (ID_Telefono),
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

CREATE TABLE Usuarios (
    ID_Usuario int NOT NULL,
    Nombre_Usuario varchar(50),
    Contrasena varchar(100),
    ID_Cliente int,
    ID_Empleado int,
    Identificador bit,
    PRIMARY KEY (ID_Usuario),
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

CREATE TABLE Vista_Peliculas_Taquilleras (
    Pelicula varchar(100),
    Anio year,
    Mes int,
    Semana int,
    BoletosVendidos bigint NOT NULL
);

CREATE TABLE bitacora (
    bitid int NOT NULL,
    bitfecha datetime,
    bitaccion varchar(50),
    usuid int,
    aplid int,
    bitip varchar(60),
    bitnombrepc varchar(60),
    PRIMARY KEY (bitid),
    FOREIGN KEY (usuid) REFERENCES Usuarios(ID_Usuario)
);

CREATE VIEW Vista_Peliculas_Taquilleras AS
SELECT 
    P.Nombre            AS Pelicula,
    YEAR(F.Fecha)       AS Anio,
    MONTH(F.Fecha)      AS Mes,
    WEEK(F.Fecha, 1)    AS Semana,
    COUNT(B.ID_Boleto)  AS BoletosVendidos
FROM 
    Boleto B
    INNER JOIN Funcion F          ON B.ID_Funcion = F.ID_Funcion
    INNER JOIN Pelicula P         ON F.ID_Pelicula = P.ID_Pelicula
    INNER JOIN Detalles_Compra DC ON B.ID_Boleto = DC.ID_Boleto
    INNER JOIN Compra C           ON DC.ID_Compra = C.ID_Compra
GROUP BY 
    P.Nombre, 
    YEAR(F.Fecha), 
    MONTH(F.Fecha), 
    WEEK(F.Fecha, 1)
ORDER BY 
    BoletosVendidos DESC;