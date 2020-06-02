--creacion de llaves foraneas
--Cliente
ALTER TABLE Cliente
ADD CONSTRAINT fk_Cliente
FOREIGN KEY  (CedulaCliente)
REFERENCES persona (Cedula)
GO

--Empleado
ALTER TABLE Empleado
ADD CONSTRAINT fk_Empleado
FOREIGN KEY  (CedulaEmpleado)
REFERENCES persona (Cedula)
GO

--Producto
ALTER TABLE Producto
ADD CONSTRAINT fk_Producto
FOREIGN KEY  (CedulaProveedor)
REFERENCES Provedor (CedulaProvedor)
GO

--Proforma
ALTER TABLE Proforma
ADD CONSTRAINT fk_CedulaCliente
FOREIGN KEY  (CedulaCliente)
REFERENCES Cliente (CedulaCliente)
GO

--Comprobante Venta	
ALTER TABLE ComprobanteVenta
ADD CONSTRAINT fk_ComprobanteVenta
FOREIGN KEY  (CedulaCliente)
REFERENCES Cliente (CedulaCliente)
GO

--Detalle Venta
ALTER TABLE DetalleVenta
ADD CONSTRAINT fk_DetalleVentaProducto
FOREIGN KEY  (CodProducto)
REFERENCES Producto (CodProducto)
GO

ALTER TABLE DetalleVenta
ADD CONSTRAINT fk_DetalleVentaComprobanteVenta
FOREIGN KEY  (NumeroComprobante)
REFERENCES ComprobanteVenta(NumeroComprobante)
GO

--Detalle Proforma
ALTER TABLE DetalleProforma
ADD CONSTRAINT fk_DetalleProformaProducto
FOREIGN KEY  (CodProducto)
REFERENCES Producto (CodProducto)
GO

ALTER TABLE DetalleProforma
ADD CONSTRAINT fk_DetalleProformaProforma
FOREIGN KEY  (NumeroProforma)
REFERENCES Proforma(NumeroProforma)
GO



