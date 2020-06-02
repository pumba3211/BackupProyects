create database CompuserviciosRyE

create table persona(
	cedula varchar(50) not null,
	nombre varchar(100) not null,
	apellido1 varchar(100) not null,
	apellido2 varchar(100) not null,
	telefono varchar(15) not null
)
create table cliente(
	cedula_cliente varchar(50) not null
)
create table empleado(
	cedula_empleado varchar(50) not null,
	ganancia varchar(100) not null
)
create table empresa(
	cedula_juridica varchar(50) not null,
	nombre_empresa varchar(100) not null,
	telefono varchar(15) not null,	
	direccion_empresa varchar(100) not null
)
create table producto(
	cod_producto varchar(50) not null,
	nombre_producto varchar(100) not null,
	fecha_vencimiento datetime not null,
	precio varchar(50) not null,
	cantidad varchar(50) not null,
	cedula_proveedor varchar(50) not null
)
create table provedor(
	cedula_provedor varchar(50) not null,
	nombre_proveedor varchar(100) not null,	
	telefono varchar(50) not null,
	direccion_proveedor varchar(100) not null
)
create table proforma(
	numero_proforma varchar(50) not null,
	cedula_cliente varchar(50) not null,
	importe_proforma varchar(50) not null,
	fecha_proforma date not null
)
create table detalleproforma(
	numerodetalleproforma varchar(50) not null,
	numero_proforma varchar(50) not null,
	cantidad_productos varchar(25) not null,	
	cod_producto varchar(50) not null,
	precio_venta varchar(100) not null,
	detalle_producto varchar(100) not null,
	subtotal varchar(100) not null
	
)
create table comprobanteventa(
	numerocomprobante varchar(50) not null,
	cedula_cliente varchar(50) not null,
	fecha_comprabante date not null,
	importe varchar(100) not null,
	tipo varchar(100) not null
)
create table detalleventa(
	numerodetalleventa varchar(50) not null,
	cantidad_productos varchar(50) not null,
	numerocomprobante varchar(50) not null,
	cod_producto varchar(50) not null,
	precio varchar(100) not null,
	detalleproducto varchar(100) not null,
	subtotal varchar(100) not null,
)