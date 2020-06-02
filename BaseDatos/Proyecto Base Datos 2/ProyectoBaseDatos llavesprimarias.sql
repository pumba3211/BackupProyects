--Creacion llaves primarias

--Persona
alter table persona
add constraint pk_persona
primary key  (cedula);

--Empleado
alter table empleado
add constraint pk_empleado
primary key  (cedula_empleado);

--Cliente
alter table cliente
add constraint pk_cliente
primary key  (cedula_cliente);

--Provedor
alter table provedor
add constraint pk_provedor
primary key  (cedula_provedor);

--Proforma
alter table proforma
add constraint pk_proforma
primary key  (numero_proforma);

--Producto
alter table producto
add constraint pk_producto
primary key  (cod_producto);

--Empresa
alter table empresa
add constraint pk_empresa
primary key  (cedula_juridica);

--Detalle venta
alter table detalleventa
add constraint pk_detalleventa
primary key  (numerodetalleventa);

--Dellate proforma
alter table detalleproforma
add constraint pk_detalleprofromar
primary key  (numerodetalleproforma);

--Comprobante venta
alter table comprobanteventa
add constraint pk_comprobanteventa
primary key  (numerocomprobante);
