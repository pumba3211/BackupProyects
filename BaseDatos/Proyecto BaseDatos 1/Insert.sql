INSERT INTO Persona VALUES('2705250','Ronald','Acuña','Arias','85724776')
INSERT INTO Persona VALUES('207170689','Esteban','Mora','Arias','86729229')
INSERT INTO Persona VALUES('207770689','Fabricio','Corrales','Zuñiga','60669598')
INSERT INTO Persona VALUES('509850356','Patricia','Perez','Soto','202680585')
INSERT INTO Persona VALUES('205850242','Jorge','Rojas','Zuñiga','87859832')


INSERT INTO Cliente VALUES('2705250')
INSERT INTO Cliente VALUES('207170689')
INSERT INTO Cliente VALUES('207770689')

INSERT INTO Empleado VALUES('509850356','300000')
INSERT INTO Empleado VALUES('205850242','500000')

INSERT INTO Provedor VALUES('205850242','HP','22586956','San Jose')
INSERT INTO Provedor VALUES('26968956','Intel','22547210','San Jose')

INSERT INTO producto VALUES('1','Procesador','03/12/2020','50000','15','26968956')
INSERT INTO producto VALUES('2','Computadora','05/8/2016','450000','5','205850242')

INSERT INTO Proforma VALUES('1','207170689','500000','04/12/2013')
INSERT INTO Proforma VALUES('2','2705250','150000','25/11/2013')

INSERT INTO DetalleProforma VALUES('1','2','3','1','50000','Procesador','150000')
INSERT INTO DetalleProforma VALUES('2','1','1','1','50000','Procesador','50000')
INSERT INTO DetalleProforma VALUES('3','1','1','2','450000','Procesador','450000')

INSERT INTO ComprobanteVenta VALUES('1','207170689','05/12/2013','500000','Credito')
INSERT INTO ComprobanteVenta VALUES('2','2705250','06/12/2013','150000','Contado')

INSERT INTO Detalleventa VALUES('1','3','2','1','50000','Procesador','150000')
INSERT INTO Detalleventa VALUES('2','1','1','1','50000','Procesador','50000')
INSERT INTO Detalleventa VALUES('3','1','1','2','450000','Computadora','450000')

INSERT INTO Empresa VALUES('256256558','CompuServiciosRyE','86729229','Venecia')





select distinct cedula,nombre,apellido1,apellido2,telefono
from Persona inner join Cliente on Persona.cedula='207170689'


