use master
go

drop database CabinasRonald
go

create database CabinasRonald
go

use CabinasRonald
go

create table Cabina(
	numeroCabina int not null,
	Espacio int not null,
	Disponible int not null
	)

go
Create table Cliente(
	CedulaCliente varchar(30) not null,
	Nombre varchar(30) not null,
	Apellidos varchar(60) not null,
	Empresa varchar(30),
	Freecuente int
	)
	go


Create table Reservacion(
	NumeroReservacion int identity not null,
	numeroCabina int not null,
	CedulaCliente varchar(30) not null,
	Fecha date not null
	)
	go

create table Pago(
	NumeroPago int identity not null,
	NumeroReservacion int not null,
	TotalDePaGO int not null,
	Fecha date not null
	)
	go

alter table Cabina add constraint Pk_Cabina primary key(numeroCabina)
go

alter table Cliente add constraint Pk_Cliente primary key (CedulaCliente)
go

alter table Reservacion add constraint  fk_Cabina foreign key(numeroCabina)  References Cabina(numeroCabina)
go

alter table Reservacion add constraint  fk_Cliente foreign key(CedulaCliente)  References Cliente(CedulaCliente)
go

alter table Reservacion add constraint PK_Reservacion primary key(NumeroReservacion)
go
 
alter table Pago add constraint Pk_Pago primary key(NumeroPago)
go

alter table PAGO add constraint Fk_Reservacion  foreign key(NumeroReservacion) References Reservacion(NumeroReservacion)
go
 

insert into Cliente (CedulaCliente,Nombre,Apellidos,Empresa,Freecuente) values('207050250','Ronald','Acuña Arias','Propia','0')
go

update Cliente set nombre='Pumba' where CedulaCliente='207050250'
go

select * from Cliente
select * from Reservacion where Fecha='01/12/2017';

