CREATE TABLE Asientos_de_Funcion (
    ID_Asiento int NOT NULL DEFAULT nan,
    ID_Funcion int NOT NULL DEFAULT nan,
    Disponibilidad bit(1) DEFAULT nan,
    PRIMARY KEY (ID_Asiento, ID_Funcion),
    FOREIGN KEY (ID_Asiento) REFERENCES Asientos_de_Sala(ID_Asiento),
    FOREIGN KEY (ID_Funcion) REFERENCES Funcion(ID_Funcion)
);

CREATE TABLE Asientos_de_Sala (
    ID_Asiento int NOT NULL DEFAULT nan,
    No_Asiento varchar(10) DEFAULT 'nan',
    ID_Sala int DEFAULT nan,
    PRIMARY KEY (ID_Asiento),
    FOREIGN KEY (ID_Sala) REFERENCES Sala(ID_Sala)
);

CREATE TABLE Boleto (
    ID_Boleto int NOT NULL DEFAULT nan,
    ID_Asiento int DEFAULT nan,
    ID_Funcion int DEFAULT nan,
    ID_Precio int DEFAULT nan,
    PRIMARY KEY (ID_Boleto),
    FOREIGN KEY (ID_Asiento, ID_Funcion) REFERENCES Asientos_de_Funcion(ID_Asiento, ID_Funcion),
    FOREIGN KEY (ID_Precio) REFERENCES Precio(ID_Precio)
);

CREATE TABLE Cine (
    ID_Cine int NOT NULL DEFAULT nan,
    Nombre varchar(100) DEFAULT 'nan',
    ID_Plaza int DEFAULT nan,
    Cantidad_de_Salas int DEFAULT nan,
    PRIMARY KEY (ID_Cine),
    FOREIGN KEY (ID_Plaza) REFERENCES Plaza(ID_Plaza)
);

CREATE TABLE Clasificacion_Edad (
    ID_Clasificacion int NOT NULL DEFAULT nan,
    Clasificacion varchar(5) DEFAULT 'nan',
    Descripcion varchar(100) DEFAULT 'nan',
    PRIMARY KEY (ID_Clasificacion)
);

CREATE TABLE Cliente (
    ID_Cliente int NOT NULL DEFAULT nan,
    Nombre varchar(50) DEFAULT 'nan',
    Apellido varchar(50) DEFAULT 'nan',
    Correo varchar(100) DEFAULT 'nan',
    NIT varchar(20) DEFAULT 'nan',
    PRIMARY KEY (ID_Cliente)
);

CREATE TABLE Compra (
    ID_Compra int NOT NULL DEFAULT nan,
    Fecha date DEFAULT 'nan',
    ID_Cliente varchar(45) NOT NULL DEFAULT 'nan',
    PRIMARY KEY (ID_Compra),
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

CREATE TABLE Detalles_Compra (
    ID_Compra int NOT NULL DEFAULT nan,
    ID_Boleto int NOT NULL DEFAULT nan,
    PRIMARY KEY (ID_Compra, ID_Boleto),
    FOREIGN KEY (ID_Compra) REFERENCES Compra(ID_Compra),
    FOREIGN KEY (ID_Boleto) REFERENCES Boleto(ID_Boleto)
);

CREATE TABLE Empleado (
    ID_Empleado int NOT NULL DEFAULT nan,
    Nombre varchar(50) DEFAULT 'nan',
    Apellido varchar(50) DEFAULT 'nan',
    Cargo varchar(50) DEFAULT 'nan',
    Salario varchar(20) DEFAULT 'nan',
    Correo varchar(100) DEFAULT 'nan',
    ID_Cine int DEFAULT nan,
    PRIMARY KEY (ID_Empleado),
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine)
);

CREATE TABLE Funcion (
    ID_Funcion int NOT NULL DEFAULT nan,
    Horario varchar(20) DEFAULT 'nan',
    Fecha date DEFAULT 'nan',
    ID_Pelicula int DEFAULT nan,
    Cantidad_Boletos int DEFAULT nan,
    ID_Sala int DEFAULT nan,
    ID_Idioma int DEFAULT nan,
    PRIMARY KEY (ID_Funcion),
    FOREIGN KEY (ID_Pelicula) REFERENCES Pelicula(ID_Pelicula),
    FOREIGN KEY (ID_Sala) REFERENCES Sala(ID_Sala),
    FOREIGN KEY (ID_Idioma) REFERENCES Idioma(ID_Idioma)
);

CREATE TABLE Genero (
    ID_Genero int NOT NULL DEFAULT nan,
    Nombre_Genero varchar(50) DEFAULT 'nan',
    PRIMARY KEY (ID_Genero)
);

CREATE TABLE Idioma (
    ID_Idioma int NOT NULL DEFAULT nan,
    Doblada bit(1) DEFAULT nan,
    Subtitulos bit(1) DEFAULT nan,
    PRIMARY KEY (ID_Idioma)
);

CREATE TABLE Pelicula (
    ID_Pelicula int NOT NULL DEFAULT nan,
    Nombre varchar(100) DEFAULT 'nan',
    ID_Genero int DEFAULT nan,
    ID_Clasificacion int DEFAULT nan,
    Sinopsis varchar(255) DEFAULT 'nan',
    PRIMARY KEY (ID_Pelicula),
    FOREIGN KEY (ID_Genero) REFERENCES Genero(ID_Genero),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificacion_Edad(ID_Clasificacion)
);

CREATE TABLE Plaza (
    ID_Plaza int NOT NULL DEFAULT nan,
    Nombre_Plaza varchar(100) DEFAULT 'nan',
    Departamento varchar(50) DEFAULT 'nan',
    Zona varchar(20) DEFAULT 'nan',
    PRIMARY KEY (ID_Plaza)
);

CREATE TABLE Precio (
    ID_Precio int NOT NULL DEFAULT nan,
    ID_Proyeccion int DEFAULT nan,
    Precio decimal(10,2) DEFAULT nan,
    PRIMARY KEY (ID_Precio),
    FOREIGN KEY (ID_Proyeccion) REFERENCES Proyeccion(ID_Proyeccion)
);

CREATE TABLE Proyeccion (
    ID_Proyeccion int NOT NULL DEFAULT nan,
    Tipo_de_proyeccion varchar(20) DEFAULT 'nan',
    PRIMARY KEY (ID_Proyeccion)
);

CREATE TABLE SALA_DE_CINE (
    ID_Cine int NOT NULL DEFAULT nan,
    No_Sala int DEFAULT nan,
    ID_Sala int NOT NULL DEFAULT nan,
    Capacidad_de_Asientos int DEFAULT nan,
    PRIMARY KEY (ID_Cine, ID_Sala),
    FOREIGN KEY (ID_Cine) REFERENCES Cine(ID_Cine),
    FOREIGN KEY (ID_Sala) REFERENCES Sala(ID_Sala)
);

CREATE TABLE Sala (
    ID_Sala int NOT NULL DEFAULT nan,
    ID_Proyeccion int DEFAULT nan,
    PRIMARY KEY (ID_Sala),
    FOREIGN KEY (ID_Proyeccion) REFERENCES Proyeccion(ID_Proyeccion)
);

CREATE TABLE Telefono_Empleado (
    ID_Telefono int NOT NULL DEFAULT nan,
    Telefono varchar(15) DEFAULT 'nan',
    ID_Empleado int DEFAULT nan,
    PRIMARY KEY (ID_Telefono),
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

CREATE TABLE Usuarios (
    ID_Usuario int NOT NULL DEFAULT nan,
    Nombre_Usuario varchar(50) DEFAULT 'nan',
    Contrasena varchar(100) DEFAULT 'nan',
    ID_Empleado int DEFAULT nan,
    Identificador bit(1) DEFAULT nan,
    ID_Cliente int DEFAULT nan,
    PRIMARY KEY (ID_Usuario),
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado),
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

CREATE TABLE Vista_Peliculas_Taquilleras (
    Pelicula varchar(100) DEFAULT 'nan',
    Anio year DEFAULT nan,
    Mes int DEFAULT nan,
    Semana int DEFAULT nan,
    BoletosVendidos bigint NOT NULL DEFAULT 0.0
);

CREATE TABLE bitacora (
    bitid int NOT NULL DEFAULT nan auto_increment,
    bitfecha datetime DEFAULT 'nan',
    bitaccion varchar(50) DEFAULT 'nan',
    usuid int DEFAULT nan,
    aplid int DEFAULT nan,
    bitip varchar(60) DEFAULT 'nan',
    bitnombrepc varchar(60) DEFAULT 'nan',
    PRIMARY KEY (bitid)
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