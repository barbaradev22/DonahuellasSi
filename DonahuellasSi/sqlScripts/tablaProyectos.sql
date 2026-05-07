CREATE TABLE [dbo].[proyecto]
(
	[id_proyecto] INT NOT NULL PRIMARY KEY identity,
	[nombre_proyecto] VARCHAR(100) NOT NULL,
	[descripcion_proyecto] VARCHAR(255) NOT NULL,
	[monto_donado] INT NOT NULL
)
GO
