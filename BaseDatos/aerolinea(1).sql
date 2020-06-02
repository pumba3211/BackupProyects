create database aerolinea;
go

use aerolinea;
go

create table piloto(
	licencia varchar(20) not null,
	nombre   varchar(100) not null,
	horas_vuelo numeric(10) not null
);

create table vuelo(
	vuelo numeric(10) not null,
	inicio varchar(50) not null,
	final varchar(50) not null,
);

create table programacion(
	vuelo numeric(10) not null,
	fecha datetime not null,
	hora_salida varchar(10) not null,
	hora_llegada varchar(10) not null,
	piloto varchar(20) not null,
);

create table destino(	
	destino varchar(50) not null,
	descripcion varchar(100) not null,
);