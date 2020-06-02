--Creacion llaves primarias

--Persona
ALTER TABLE Persona
ADD CONSTRAINT pk_Persona
PRIMARY KEY (Cedula);

--Empleado
ALTER TABLE Empleado
ADD CONSTRAINT pk_Empleado
PRIMARY KEY (CedulaEmpleado);

--Cliente
ALTER TABLE cliente
ADD CONSTRAINT pk_cliente
PRIMARY KEY  (CedulaCliente);

--Provedor
ALTER TABLE Provedor
ADD CONSTRAINT pk_Provedor
PRIMARY KEY  (CedulaProvedor);

--Proforma
ALTER TABLE Proforma
ADD CONSTRAINT pk_Proforma
PRIMARY KEY  (NumeroProforma);

--Producto
ALTER TABLE Producto
ADD CONSTRAINT pk_Producto
PRIMARY KEY  (CodProducto);

--Empresa
ALTER TABLE Empresa
ADD CONSTRAINT pk_Empresa
PRIMARY KEY  (CedulaJuridica);

--Detalle venta
ALTER TABLE DetalleVenta
ADD CONSTRAINT pk_DetalleVenta
PRIMARY KEY  (NumeroDetalleVenta);

--Dellate Proforma
ALTER TABLE DetalleProforma
ADD CONSTRAINT pk_DetalleProforma
PRIMARY KEY  (NumeroDetalleProforma);

--Comprobante venta
ALTER TABLE ComprobanteVenta
ADD CONSTRAINT pk_ComprobanteVenta
PRIMARY KEY  (NumeroComprobante);
