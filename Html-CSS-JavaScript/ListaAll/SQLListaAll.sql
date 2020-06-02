create database listaall;

use listaall;

create table usuarios(
	username varchar(100) Primary Key,
	pass varchar(250) not null,
	usuario_imagen mediumblob
);
create table categorias(
	id_categoria bigint Primary Key not null,
	descripcion_categoria varchar(100) not null
);
create table listas(
	id_lista bigint AUTO_INCREMENT PRIMARY KEY,
	titulo_lista varchar(250) not null,
	username varchar(100) not null,
	creat_at datetime not null,
	id_categoria bigint not null,
	Foreign Key (username) REFERENCES usuarios(username),
	Foreign Key (id_categoria) REFERENCES categorias(id_categoria)
);
create table lista_complement(
	id_complement bigint AUTO_INCREMENT PRIMARY KEY,
	id_lista bigint not null,
	numero_lista bigint not null,
	descripcion_complemento varchar(250),
	Foreign Key (id_lista) REFERENCES listas(id_lista)
);
create table favoritos(
	id_favorito bigint auto_increment primary key,
	username varchar(100),
	id_lista bigint,
	Foreign Key (username) REFERENCES usuarios(username),
	Foreign Key (id_lista) REFERENCES listas(id_lista)
);

create table puntos_lista(
	id_lista bigint,
	puntos mediumint,
	Foreign Key (id_lista) REFERENCES listas(id_lista)
);