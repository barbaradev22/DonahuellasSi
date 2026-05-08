CREATE TABLE [dbo].[aporte]
(
	[id] INT NOT NULL PRIMARY KEY identity,
	[id_proyecto] INT NOT NULL,
	[id_donante] INT NOT NULL,
	[cantidad_donada] INT NOT NULL,
	[fecha_aporte] DATETIME2 NOT NULL DEFAULT GETDATE()
)
GO