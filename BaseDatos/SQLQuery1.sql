CREATE DATABASE Practica
GO

USE Practica
GO

CREATE TABLE Personas(
  Cedula CHAR(11) NOT NULL, --  NOT NULL permite que el campo nunca se cree vacio
  Nombre VARCHAR(50) NOT NULL,
  ApellIdo VARCHAR(50) NOT NULL,
  ApellIdo2 VARCHAR(50) NOT NULL,
  Correo CHAR(100) NOT NULL,
  Telefono CHAR(9),
  Direccion VARCHAR(200) NOT NULL
)
GO

ALTER TABLE Personas ADD FechaNacimiento DATETIME NOT NULL --agrega un nuevo atributo a la tabla que ya existe
GO

ALTER TABLE Personas ADD CONSTRAINT pk_CedulaPersona PRIMARY KEY(Cedula)
GO

ALTER TABLE Personas ADD Prueba VARCHAR(10)
GO

ALTER TABLE Personas ALTER COLUMN Prueba CHAR(12) NOT NULL
GO

ALTER TABLE Personas DROP COLUMN Prueba
GO

CREATE TABLE Estudiantes ( 
  Cedula CHAR (11) NOT NULL, 
  Carne int NOT NULL, 
  Nombre VARCHAR (50) 
) 
GO 

ALTER TABLE Estudiantes ADD CONSTRAINT pk_CedulaEstudiantes PRIMARY KEY (Cedula) 
GO 

ALTER TABLE Estudiantes ADD CONSTRAINT fk_CedulaEstudiantes FOREIGN KEY (Cedula) REFERENCES Personas 
GO 

ALTER TABLE Estudiantes ADD CONSTRAINT inqCarneEstudiantes UNIQUE (Carne) 
GO 

ALTER TABLE Profesores ADD CONSTRAINT fk_ProfesorPersona FOREIGN KEY(Cedula) REFERENCES Persona
GO

CREATE TABLE Profesores ( 
  Cedula CHAR (11) NOT NULL, 
  Especialidad VARCHAR (50) NOT NULL 
) 
GO 

ALTER TABLE Profesores ADD CONSTRAINT pk_CedulaProfesores PRIMARY KEY (Cedula) 
GO 
 
CREATE TABLE Carrera ( 
  -- IdENTITY(1,1) Inicia el Identificador en 1 y aumenta automáticamente el valor en 1 
  IdCarrera int IdENTITY(1,1) NOT NULL, 
  Nombre VARCHAR (50) NOT NULL, 
  CONSTRAINT pk_IdCarrera PRIMARY KEY (IdCarrera) 
) 
GO 

ALTER TABLE Carrera ADD CONSTRAINT pk_IdCarrera PRIMARY KEY (IdCarrera) 
GO

CREATE TABLE Programas(
 IdPrograma INT IdENTITY(1,1) NOT NULL,
 Fecha DATETIME NOT NULL,
 Estado CHAR(1) NOT NULL,
)
GO

ALTER TABLE Programas ADD CONSTRAINT pk_Programas PRIMARY KEY(IdPrograma)
GO

CREATE TABLE Cursos(
 Codigo CHAR(8) NOT NULL,
 Cedula CHAR(11) NOT NULL,
 Nombre VARCHAR(50) NOT NULL,
 IdPrograma int NOT NULL,
 Creditos int NULL,
 Tipo VARCHAR(20) NOT NULL,
 Periodo VARCHAR(35) NOT NULL,
 Fecha DATETIME NOT NULL,
 Estado CHAR(1) NOT NULL
)
GO

ALTER TABLE Cursos ADD CONSTRAINT pk_Curso PRIMARY KEY(Codigo)
GO

ALTER TABLE Cursos ADD CONSTRAINT fk_Profesores  FOREIGN KEY (Cedula) REFERENCES Profesores
GO

ALTER TABLE Cursos ADD CONSTRAINT fk_Cursos FOREIGN KEY (IdPrograma) REFERENCES Programas
GO

CREATE TABLE Contenidos(
	IdContenido CHAR(12) NOT NULL,
	IdCurso CHAR(8) NOT NULL,
	Contenido VARCHAR(50) NOT NULL,
 )
 GO

 ALTER TABLE Contenidos ADD CONSTRAINT pk_Contenidos PRIMARY KEY(IdContenido)
 GO

 ALTER TABLE Contenidos ADD CONSTRAINT fk_CursoContenido FOREIGN KEY(IdCurso) REFERENCES Cursos
 GO

 CREATE TABLE Grupo ( 
  IdGrupo CHAR(15) NOT NULL, 
  IdCurso CHAR(8) NOT NULL,
  NumeroGrupo CHAR(5) NOT NULL,
) 
GO 

ALTER TABLE Grupo ADD CONSTRAINT pk_Grupo PRIMARY KEY(IdGrupo)
GO

ALTER TABLE Grupo ADD CONSTRAINT fk_CursoGrupo FOREIGN KEY(IdCurso) REFERENCES Cursos
GO
 
CREATE TABLE GrupoEstudiante ( 
  IdGrupo CHAR(15) NOT NULL, 
  Carne CHAR(11) NOT NULL,
  Nota float NOT NULL,
  Estado CHAR(1) NOT NULL,
) 
GO 

ALTER TABLE GrupoEstudiante ADD CONSTRAINT pk_GrupoEstudianteGrupo PRIMARY KEY(IdGrupo,Carne)
GO

ALTER TABLE GrupoEstudiante ADD CONSTRAINT fk_GrupoEstudianteGrupo FOREIGN KEY(IdGrupo) REFERENCES Grupo
GO

ALTER TABLE GrupoEstudiante ADD CONSTRAINT fk_GrupoEstudianteCarnet FOREIGN KEY(Carne) REFERENCES Estudiantes
GO

