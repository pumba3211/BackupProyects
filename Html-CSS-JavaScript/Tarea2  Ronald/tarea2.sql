create database tarea;

use tarea;

create table Agenda(
	cedula varchar(50) Primary KEY not null,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	genero varchar(3) not null,
	correro varchar(5)not null,
	telefono MEDIUMINT 
);