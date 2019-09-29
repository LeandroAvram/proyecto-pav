USE [db_Hotel]
GO
/****** Object:  Database [db_Hotel]    Script Date: 28/09/2019 20:29:56 ******/
CREATE DATABASE [db_Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [db_Hotel] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_Hotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [db_Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_Hotel] SET QUERY_STORE = OFF
GO
USE [db_Hotel]
GO
/****** Object:  Table [dbo].[T_Categoria_Habitacion]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Categoria_Habitacion](
	[id_cat_habitacion] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_T_Categoria_Habitacion] PRIMARY KEY CLUSTERED 
(
	[id_cat_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Cliente]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Cliente](
	[id_cliente] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[id_tipo_documento] [int] NOT NULL,
	[nro_documento] [varchar](50) NOT NULL,
	[id_vehiculo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Estado_Habitacion]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Estado_Habitacion](
	[id_estado_habitacion] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Estado_Reserva]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Estado_Reserva](
	[id_estado_reserva] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Estado_Reserva] PRIMARY KEY CLUSTERED 
(
	[id_estado_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Habitacion]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Habitacion](
	[id_habitacion] [int] NOT NULL,
	[nro_habitacion] [int] NOT NULL,
	[id_tipo_habitacion] [int] NOT NULL,
	[id_cat_habitacion] [int] NOT NULL,
	[piso] [int] NOT NULL,
	[id_estado_habitacion] [int] NOT NULL,
 CONSTRAINT [PK_T_Estado_Habitacion] PRIMARY KEY CLUSTERED 
(
	[id_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Reserva]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Reserva](
	[id_reserva] [int] NOT NULL,
	[id_tipo_reserva] [int] NOT NULL,
	[id_habitacion] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_estado_reserva] [int] NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[fecha_egreso] [date] NOT NULL,
	[cant_persona] [int] NOT NULL,
 CONSTRAINT [PK_T_Reserva] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Rol]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Rol](
	[id_rol] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Tipo_Documento]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Tipo_Documento](
	[id_tipo_documento] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Tipo_Documento] PRIMARY KEY CLUSTERED 
(
	[id_tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Tipo_Habitacion]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Tipo_Habitacion](
	[id_tipo_habitacion] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [numeric](18, 0) NULL,
 CONSTRAINT [PK_T_Tipo_Habitacion] PRIMARY KEY CLUSTERED 
(
	[id_tipo_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Tipo_Reserva]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Tipo_Reserva](
	[id_tipo_reserva] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Tipo_Reserva] PRIMARY KEY CLUSTERED 
(
	[id_tipo_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Usuario]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[id_rol] [int] NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_T_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Vehiculo]    Script Date: 28/09/2019 20:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Vehiculo](
	[id_vehiculo] [int] NOT NULL,
	[dominio] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [db_Hotel] SET  READ_WRITE 
GO
