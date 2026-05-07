CREATE TABLE [dbo].[usuario]
(
	[id_usuario] INT NOT NULL PRIMARY KEY identity,
	[nombre_usuario] VARCHAR(50) NOT NULL,
	[password_usuario] VARCHAR(50) NOT NULL
)
GO