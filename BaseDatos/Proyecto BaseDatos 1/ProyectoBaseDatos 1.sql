CREATE DATABASE CompuserviciosRyE
GO

USE CompuserviciosRyE
GO

CREATE TABLE Persona(
	Cedula VARCHAR(50) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Apellido1 VARCHAR(100) NOT NULL,
	Apellido2 VARCHAR(100) NOT NULL,
	Telefono VARCHAR(15) NOT NULL
)
GO

CREATE TABLE Cliente(
	CedulaCliente VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Empleado(
	CedulaEmpleado VARCHAR(50) NOT NULL,
	Ganancia VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Empresa(
	CedulaJuridica VARCHAR(50) NOT NULL,
	NombreEmpresa VARCHAR(100) NOT NULL,
	Telefono VARCHAR(100) NOT NULL,	
	DireccionEmpresa VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Producto(
	CodProducto VARCHAR(50) NOT NULL,
	NombreProducto VARCHAR(100) NOT NULL,
	FechaVencimiento datetime NOT NULL,
	Precio VARCHAR(50) NOT NULL,
	Cantidad VARCHAR(50) NOT NULL,
	CedulaProveedor VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Provedor(
	CedulaProvedor VARCHAR(50) NOT NULL,
	NombreProveedor VARCHAR(100) NOT NULL,	
	Telefono VARCHAR(50) NOT NULL,
	DireccionProveedor VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Proforma(
	NumeroProforma VARCHAR(50) NOT NULL,
	CedulaCliente VARCHAR(50) NOT NULL,
	ImporteProforma VARCHAR(50) NOT NULL,
	FechaProforma DATETIME NOT NULL
)
GO

CREATE TABLE DetalleProforma(
	NumeroDetalleProforma VARCHAR(50) NOT NULL,
	NumeroProforma VARCHAR(50) NOT NULL,
	CantidadProductos VARCHAR(25) NOT NULL,	
	CodProducto VARCHAR(50) NOT NULL,
	PrecioVenta VARCHAR(100) NOT NULL,
	DetalleProducto VARCHAR(100) NOT NULL,
	Subtotal VARCHAR(100) NOT NULL
)
GO

CREATE TABLE ComprobanteVenta(
	NumeroComprobante VARCHAR(50) NOT NULL,
	CedulaCliente VARCHAR(50) NOT NULL,
	FechaComprabante DATETIME NOT NULL,
	Importe VARCHAR(100) NOT NULL,
	Tipo VARCHAR(100) NOT NULL
)
GO

CREATE TABLE DetalleVenta(
	NumeroDetalleVenta VARCHAR(50) NOT NULL,
	CantidadProductos VARCHAR(50) NOT NULL,
	NumeroComprobante VARCHAR(50) NOT NULL,
	CodProducto VARCHAR(50) NOT NULL,
	Precio VARCHAR(100) NOT NULL,
	DetalleProducto VARCHAR(100) NOT NULL,
	Subtotal VARCHAR(100) NOT NULL,
)
GO