insert into persona values('2705250','Ronald','Acuña','Arias','85724776')
insert into persona values('207170689','Esteban','Mora','Arias','86729229')
insert into persona values('207770689','Fabricio','Corrales','Zuñiga','60669598')
insert into persona values('509850356','Patricia','Perez','Soto','202680585')
insert into persona values('205850242','Jorge','Rojas','Zuñiga','87859832')


insert into cliente values('2705250')
insert into cliente values('207170689')
insert into cliente values('207770689')

insert into empleado values('509850356','300000')
insert into empleado values('205850242','500000')

insert into provedor values('205850242','HP','22586956','San Jose')
insert into provedor values('26968956','Intel','22547210','San Jose')

insert into producto values('1','Procesador','03/12/2020','50000','15','26968956')
insert into producto values('2','Computadora','05/8/2016','450000','5','205850242')

insert into proforma values('1','207170689','500000','04/12/2013')
insert into proforma values('2','2705250','150000','25/11/2013')

insert into detalleproforma values('1','2','3','1','50000','Procesador','150000')
insert into detalleproforma values('2','1','1','1','50000','Procesador','50000')
insert into detalleproforma values('3','1','1','2','450000','Procesador','450000')

insert into comprobanteventa values('1','207170689','05/12/2013','500000','Credito')
insert into comprobanteventa values('2','2705250','06/12/2013','150000','Contado')

insert into detalleventa values('1','3','2','1','50000','Procesador','150000')
insert into detalleventa values('2','1','1','1','50000','Procesador','50000')
insert into detalleventa values('3','1','1','2','450000','Computadora','450000')

insert into empresa values('256256558','CompuServiciosRyE','86729229','Venecia')





select distinct cedula,nombre,apellido1,apellido2,telefono
from persona inner join cliente on persona.cedula='207170689'


