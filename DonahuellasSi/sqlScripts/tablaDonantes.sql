CREATE TABLE [dbo].[donante]
(
	[id_donante] INT NOT NULL PRIMARY KEY identity,
	[nombre_donante] VARCHAR(100) NOT NULL,
	[telefono_donante] VARCHAR(20) NOT NULL,
	[rut_donante] VARCHAR(12) NOT NULL

)
GO