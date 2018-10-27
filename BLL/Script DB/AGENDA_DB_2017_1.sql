use master
go
create database AGENDA_DB
go
use AGENDA_DB
go
USE [AGENDA_DB]
GO

CREATE TABLE [dbo].[TIPOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

CREATE TABLE [dbo].[LOCALIDADES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CP] [int] NOT NULL,
	[Localidad] [varchar](50) NULL,
 CONSTRAINT [PK_LOCALIDADES] PRIMARY KEY CLUSTERED 
(
	[CP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [AGENDA_DB]
GO

/****** Object:  Table [dbo].[CONTACTOS]    Script Date: 06/03/2017 14:24:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CONTACTOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[CP] [int] NULL,
	[Estado] [bit] NULL,
	[Altura] [numeric](18, 2) NULL,
	[Edad] [smallint] NULL,
	[FechaNacimiento] [smalldatetime] NULL,
	[Foto] [varchar](500) NULL,
 CONSTRAINT [PK_CONTACTOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[CONTACTOS]  WITH CHECK ADD  CONSTRAINT [FK_CONTACTOS_LOCALIDADES] FOREIGN KEY([CP])
REFERENCES [dbo].[LOCALIDADES] ([CP])
GO

ALTER TABLE [dbo].[CONTACTOS] CHECK CONSTRAINT [FK_CONTACTOS_LOCALIDADES]
GO

USE [AGENDA_DB]
GO

/****** Object:  Table [dbo].[TELEFONOS]    Script Date: 06/03/2017 14:25:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TELEFONOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ContactoId] [int] NULL,
	[Telefono] [varchar](50) NULL,
	[IdTipo] [int] NULL,
	[Principal] [bit] NULL,
 CONSTRAINT [PK_TELEFONOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [AGENDA_DB]
GO

/****** Object:  StoredProcedure [dbo].[altaContacto]    Script Date: 06/03/2017 14:25:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[altaContacto]
@nombre varchar(50),
@apellido varchar(50),
@direc varchar(100),
@cp int,
@edad smallint,
@altura numeric(18,2),
@fechaNacimiento smalldatetime,
@foto varchar(500)
as

insert into CONTACTOS output inserted.ID  values (@nombre, @apellido, @direc, @cp, 1, @altura, @edad, @fechaNacimiento, @foto)

GO



insert into LOCALIDADES values (1744, 'Moreno')
insert into LOCALIDADES values (1617, 'Pacheco')
insert into LOCALIDADES values (1644, 'Victoria')

insert into TIPOS values ('Trabajo')
insert into TIPOS values ('Casa')
