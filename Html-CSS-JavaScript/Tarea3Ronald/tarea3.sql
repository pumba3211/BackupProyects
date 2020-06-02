create database tarea3;

use tarea3;

create table carreras(
	codigo_carrera mediumint auto_increment primary key,
	nombre_carrera varchar(100) not null
);

create table estudiantes(
	cedula mediumint primary key,
	nombre varchar(100) not null,
	apellidos varchar(255) not null,
	email varchar(255) not null,
	codigo_carrera mediumint,
	FOREIGN KEY (codigo_carrera) REFERENCES carreras(codigo_carrera)
);