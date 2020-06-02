create rule RDestino as(@Destino like '[1-9][0-9][0-9]D')
go
exec sp_addtype 'TDestino','char(4)','not null'
go
exec sp_bindrule 'RDestino','TDestino'
go


create index indprogramacion
on programacion(fecha)
go

create default DEstado as 'P'
go

create rule Restado as(@Estado in ('P','V','A','R','C'))
go
EXEC sp_addtype    'TEstado', 'char(1)','not null'; 

EXEC sp_bindrule  'Restado','TEstado'; 

EXEC sp_bindefault  'DEstado','TEstado'; 


ALTER TABLE vuelo add estado TEstado
go

ALTER TABLE vuelo add tarifa money null
go

INSERT programacion (vuelo, fecha, hora_salida, hora_llegada,piloto)
VALUES --('520', '01/25/99' ,'5:50', '6:32','2222' ),
('520', '30/01/99' ,'12:36', '16:23','3333'),
('618', '02/2/99' ,'10:20', '15:55','2222'),
('705', '03/1/99' ,'16:15', '5:29','1111'),
('705', '03/5/99' ,'22:00', '8:00','1111')
GO

INSERT piloto (licencia ,nombre,horas_vuelo)
values
('1111','Juan Perez','4000'),
('2222','Carlos Mora','5000'), 
('3333','Marta Mena','8000'),
('4444','Jorge Alfaro','2900'),
('5555','Pedro Rojas','2000')
go

INSERT vuelo(vuelo,inicio,final)
values
('520', '1D',  '4D'), 
('618' , '2D',  '4D'), 
('705',  '1D',   '5D'), 
('820',  '3D' , '6D')

INSERT destino(destino,descripcion)
values
('1D',  'San José'), 
('2D',  'Panamá'), 
('3D' , 'Miami'), 
('4D',  'New York'), 
('5D' , 'Londres' ),
('6D',  'Monterreal') 

Insert destino(destino,descripcion)
values
('7D','Paris')

select *from vuelo

UPDATE vuelo set final='7D' where vuelo='705';

UPDATE piloto set horas_vuelo=horas_vuelo+100;

delete piloto where horas_vuelo <3000;

update programacion set piloto='4444' where vuelo ='618';

INSERT programacion (vuelo, fecha, hora_salida, hora_llegada,piloto)
VALUES --('520', '01/25/99' ,'5:50', '6:32','2222' ),
('820', '11/01/13' ,'08:00', '11:45','3333')
go

select* from programacion

update vuelo set final='3D' WHERE FINAL='4D'

CREATE TABLE avion(
	identificador char(15) not null,
	tipo char(5) not null,
	capacidad int not null,
	descripcion varchar(50) not null

);
alter table avion
add constraint pkvuelo
primary key(identificador);

insert avion(identificador, tipo ,capacidad, descripcion)
values
('100','1','600','BOEING 707'),
('101','2','400','Boeing 737'),
('102','1','300','Messerschmitt Me 262'),
('103','2','800','Boeing 747'),
('104','2','234','Ed Force One') 
go

select*from vuelo
alter table vuelo add avion char(15);

update vuelo set avion='100' where vuelo='520';
update vuelo set avion='104' where vuelo='618';
update vuelo set avion='102' where vuelo='705';
update vuelo set avion='103' where vuelo='820';

alter table avion
add constraint fk_vuelo_avion
foreign key  (identificador)
references avion (identificador);

select*from piloto

select licencia,nombre from piloto where nombre like '[Juan]%'

select nombre from piloto where horas_vuelo>3000 order by  nombre asc
select*from vuelo

select vuelo from vuelo where final='4D' order by vuelo asc

select vuelo from vuelo where inicio='1D' and final='4D' OR final='5D'
select vuelo from vuelo where inicio='1D' and final in('4D','5D')

select*from programacion

select distinct (vuelo) from programacion where piloto='1111'
select licencia,nombre from piloto where nombre like '% [M]%'
  
select licencia,nombre from piloto where nombre like '_[a]%'

select avg (horas_vuelo) from piloto

select sum(horas_vuelo) from piloto
select count (nombre) from piloto where horas_vuelo<4000

select max(horas_vuelo) from piloto

select nombre from piloto where horas_vuelo =(select min(horas_vuelo) from piloto)

select avg (horas_vuelo) from piloto where horas_vuelo>3000

select horas_vuelo+1000 from piloto 

select licencia,nombre,horas_vuelo from piloto where nombre  not like '%[o]%'