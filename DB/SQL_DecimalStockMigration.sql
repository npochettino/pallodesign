ALTER TABLE VentaItems
ALTER COLUMN Cantidad decimal(18,2);

ALTER TABLE StockArticuloSucursal
ALTER COLUMN StockActual decimal(18,2);

ALTER TABLE Articulos
ALTER COLUMN StockMinimo decimal(18,2);

ALTER TABLE Articulos
ALTER COLUMN StockMaximo decimal(18,2);

ALTER TABLE Clientes
ADD Referencia nvarchar(max) NULL;

ALTER TABLE Proveedores
ADD Referencia nvarchar(max) NULL;

ALTER TABLE Proveedores
ALTER COLUMN Bis bit NULL;

ALTER TABLE Clientes
ALTER COLUMN Bis bit NULL;

ALTER TABLE MovimientosEfectivo
ADD FormaDePagoID int not null,
FOREIGN KEY(FormaDePagoID) REFERENCES FormasDePago(Id);

CREATE TABLE Cheques (
    Id int NOT NULL PRIMARY KEY,
    Numero nvarchar(max) NOT NULL,
    Banco nvarchar(max) NOT NULL,
	FechaVencimiento datetime,
	Monto decimal(18,2),
	Firmante nvarchar(max),
	Cobrado bit	
);

/***************/
ALTER TABLE [dbLasChulas].[dbo].[Cheques]
DROP CONSTRAINT PK__Cheques__3214EC07729D4F0A

alter table  [dbLasChulas].[dbo].[Cheques]
drop column Id

alter table  [dbLasChulas].[dbo].[Cheques]
add Id int primary key IDENTITY(1, 1) NOT NULL