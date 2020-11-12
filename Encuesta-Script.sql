CREATE DATABASE Encuestas

USE [Encuestas]

CREATE TABLE [dbo].[usuario](
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[nombreUsuario] [varchar](100) NULL,
	[clave] [varchar](100) NULL
) ON [PRIMARY]


CREATE TABLE encuesta
(
 nombreEncuesta varchar(100),
 numeroDePreguntas int,
 usuarioEncuesta varchar(100)
) ON [PRIMARY]


CREATE TABLE preguntas
(
 pregunata varchar(200),
 usuarioEncuesta varchar(100)
) ON [PRIMARY]




/*** STORE PROCEDURE *****/


/****** Object:  StoredProcedure [dbo].[spAccesoSistema]    Script Date: 06/11/2020 10:06:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRegistrarUsuario]
(
@prmUser VARCHAR(100),
@prmApellido VARCHAR(100),
@prmUsuario VARCHAR(100),
@prmPass VARCHAR(100)
)
AS
BEGIN 
INSERT INTO usuario 
VALUES (@prmUser , @prmApellido, @prmUsuario, @prmPass)
END




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAccesoSistema]
(
@prmUser VARCHAR(100),
@prmPass VARCHAR(100)
)
AS
BEGIN 
SELECT E.nombreUsuario, E.clave
FROM usuario E
WHERE E.nombreUsuario = @prmUser AND E.clave = @prmPass
END



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRegistrarEncuesta]
(
@prmNombre VARCHAR(100),
@prmNumeroPregunta VARCHAR(100),
@prmUsuarioEncuesta VARCHAR(100)
)
AS
BEGIN 
INSERT INTO encuesta 
VALUES (@prmNombre , @prmNumeroPregunta, @prmUsuarioEncuesta)
END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRegistrarPregunta]
(
@prmPregunta VARCHAR(100),
@prmUsuario VARCHAR(100)
)
AS
BEGIN 
INSERT INTO preguntas 
VALUES (@prmPregunta , @prmUsuario)

