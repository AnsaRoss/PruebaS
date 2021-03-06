USE [master]
GO
/****** Object:  Database [pruebaSinergia]    Script Date: 29/5/2021 3:37:12 ******/
CREATE DATABASE [pruebaSinergia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pruebaSinergia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pruebaSinergia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pruebaSinergia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pruebaSinergia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [pruebaSinergia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pruebaSinergia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pruebaSinergia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pruebaSinergia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pruebaSinergia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pruebaSinergia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pruebaSinergia] SET ARITHABORT OFF 
GO
ALTER DATABASE [pruebaSinergia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pruebaSinergia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pruebaSinergia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pruebaSinergia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pruebaSinergia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pruebaSinergia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pruebaSinergia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pruebaSinergia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pruebaSinergia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pruebaSinergia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pruebaSinergia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pruebaSinergia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pruebaSinergia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pruebaSinergia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pruebaSinergia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pruebaSinergia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pruebaSinergia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pruebaSinergia] SET RECOVERY FULL 
GO
ALTER DATABASE [pruebaSinergia] SET  MULTI_USER 
GO
ALTER DATABASE [pruebaSinergia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pruebaSinergia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pruebaSinergia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pruebaSinergia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pruebaSinergia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pruebaSinergia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'pruebaSinergia', N'ON'
GO
ALTER DATABASE [pruebaSinergia] SET QUERY_STORE = OFF
GO
USE [pruebaSinergia]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoriaProducto]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriaProducto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](9, 2) NOT NULL,
	[ProductoId] [int] NOT NULL,
	[fechaRegistro] [date] NOT NULL,
 CONSTRAINT [PK_HistoriaProducto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Medida] [varchar](15) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](9, 2) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[ProveedorId] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Ruc] [varchar](13) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](10) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_HistoriaProducto_ProductoId]    Script Date: 29/5/2021 3:37:12 ******/
CREATE NONCLUSTERED INDEX [IX_HistoriaProducto_ProductoId] ON [dbo].[HistoriaProducto]
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_CategoriaId]    Script Date: 29/5/2021 3:37:12 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_CategoriaId] ON [dbo].[Producto]
(
	[CategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ProveedorId]    Script Date: 29/5/2021 3:37:12 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ProveedorId] ON [dbo].[Producto]
(
	[ProveedorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HistoriaProducto] ADD  CONSTRAINT [DF__HistoriaP__Produ__2E1BDC42]  DEFAULT ((0)) FOR [ProductoId]
GO
ALTER TABLE [dbo].[HistoriaProducto] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [DF__Producto__Catego__2C3393D0]  DEFAULT ((0)) FOR [CategoriaId]
GO
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [DF__Producto__Provee__2D27B809]  DEFAULT ((0)) FOR [ProveedorId]
GO
ALTER TABLE [dbo].[HistoriaProducto]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaProducto_Producto_ProductoId] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Producto] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoriaProducto] CHECK CONSTRAINT [FK_HistoriaProducto_Producto_ProductoId]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria_CategoriaId] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria_CategoriaId]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedor_ProveedorId] FOREIGN KEY([ProveedorId])
REFERENCES [dbo].[Proveedor] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedor_ProveedorId]
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultaCategoria]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ConsultaCategoria]
AS
BEGIN
    SET NOCOUNT ON;
 
    SELECT * FROM Categoria;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultaProductos]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ConsultaProductos]
AS
BEGIN
    SET NOCOUNT ON;
 
    select * from Producto
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultaProveedores]    Script Date: 29/5/2021 3:37:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ConsultaProveedores]
AS
BEGIN
    SET NOCOUNT ON;
 
    SELECT * FROM Proveedor;
END
GO
USE [master]
GO
ALTER DATABASE [pruebaSinergia] SET  READ_WRITE 
GO
