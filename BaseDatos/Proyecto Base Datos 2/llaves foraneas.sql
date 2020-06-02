--creacion de llaves foraneas
--cliente
alter table cliente
add constraint fk_cliente
foreign key  (cedula_cliente)
references persona (cedula);

--empleado
alter table empleado
add constraint fk_empleado
foreign key  (cedula_empleado)
references persona (cedula);

--producto
alter table producto
add constraint fk_producto
foreign key  (cedula_proveedor)
references provedor (cedula_provedor);

--proforma
alter table proforma
add constraint fk_cedula_cliente
foreign key  (cedula_cliente)
references cliente (cedula_cliente);

--comprobante venta	
alter table comprobanteventa
add constraint fk_comprobante_venta
foreign key  (cedula_cliente)
references cliente (cedula_cliente);

--Detalle Venta
alter table detalleventa
add constraint fk_detalleventa_producto
foreign key  (cod_producto)
references producto (cod_producto);
alter table detalleventa
add constraint fk_detalleventa_comprobanteventa
foreign key  (numerocomprobante)
references comprobanteventa(numerocomprobante);

--Detalle Proforma
alter table detalleproforma
add constraint fk_detalleproforma_producto
foreign key  (cod_producto)
references producto (cod_producto);
alter table detalleproforma
add constraint fk_detalleproforma_proforma
foreign key  (numero_proforma)
references proforma(numero_proforma);




