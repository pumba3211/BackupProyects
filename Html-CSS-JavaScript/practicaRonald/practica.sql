create database practica;

use practica;

create table provincias(
	id_provincia BIGINT AUTO_INCREMENT PRIMARY KEY,
	nombre_provincia varchar(40)
);

Insert into provincias(nombre_provincia) values ('San Jose');
Insert into provincias(nombre_provincia) values ('Alajuela');
Insert into provincias(nombre_provincia) values ('Heredia');
Insert into provincias(nombre_provincia) values ('Cartago');
Insert into provincias(nombre_provincia) values ('Puntarenas');
Insert into provincias(nombre_provincia) values ('Guanacaste');
Insert into provincias(nombre_provincia) values ('Limon');

create table usuarios(
	id_usuario BIGINT AUTO_INCREMENT PRIMARY KEY,
	nombre_usuario varchar(100),
	email varchar(100)
);

create table usuario_provincia(
	id_usuario BIGINT,
	id_provincia BIGINT,
	FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
	FOREIGN KEY (id_provincia) REFERENCES provincias(id_provincia)
);

select * from usuarios where id_usuario='1';
SELECT c.nombre_usuario,c.email,a.id_provincia,a.nombre_provincia FROM provincias AS a,usuario_provincia AS b,usuarios as c WHERE c.id_usuario='9' AND a.id_provincia=b.id_provincia;