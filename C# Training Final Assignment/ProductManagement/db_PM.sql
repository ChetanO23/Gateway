USE [master]
GO
/****** Object:  Database [db_PM]    Script Date: 01-04-2021 23:43:56 ******/
CREATE DATABASE [db_PM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_PM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_PM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_PM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_PM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_PM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_PM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_PM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_PM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_PM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_PM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_PM] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_PM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_PM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_PM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_PM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_PM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_PM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_PM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_PM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_PM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_PM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_PM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_PM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_PM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_PM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_PM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_PM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_PM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_PM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_PM] SET  MULTI_USER 
GO
ALTER DATABASE [db_PM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_PM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_PM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_PM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_PM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_PM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_PM] SET QUERY_STORE = OFF
GO
USE [db_PM]
GO
/****** Object:  Table [dbo].[tbl_Product]    Script Date: 01-04-2021 23:43:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Short_Description] [nvarchar](50) NOT NULL,
	[Long_Description] [nvarchar](50) NULL,
	[Small_ImagePath] [nvarchar](500) NOT NULL,
	[Large_ImagePath] [nvarchar](500) NULL,
 CONSTRAINT [PK_tbl_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 01-04-2021 23:43:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Product] ON 

INSERT [dbo].[tbl_Product] ([Id], [Name], [Category], [Price], [Quantity], [Short_Description], [Long_Description], [Small_ImagePath], [Large_ImagePath]) VALUES (3, N'Apple', N'Fruit', 100, 20, N'Fresh Apple ', N'Kashmiri Apple', N'~/Images/0104202123235428122020173700product-10.jpg', N'~/Images/0104202123235428122020173700product-10.jpg')
INSERT [dbo].[tbl_Product] ([Id], [Name], [Category], [Price], [Quantity], [Short_Description], [Long_Description], [Small_ImagePath], [Large_ImagePath]) VALUES (4, N'Red Chilli', N'Vegetable', 50, 10, N'Spicy ', N'Red Chili', N'~/Images/0104202123253203012021114529product-12.jpg', N'~/Images/0104202123253203012021114529product-12.jpg')
INSERT [dbo].[tbl_Product] ([Id], [Name], [Category], [Price], [Quantity], [Short_Description], [Long_Description], [Small_ImagePath], [Large_ImagePath]) VALUES (5, N'Tomato', N'Vegetable', 100, 10, N'Tomato', N'Healthy Tomato', N'~/Images/0104202123271203012021114610product-1.jpg', N'~/Images/0104202123271203012021114610product-1.jpg')
INSERT [dbo].[tbl_Product] ([Id], [Name], [Category], [Price], [Quantity], [Short_Description], [Long_Description], [Small_ImagePath], [Large_ImagePath]) VALUES (6, N'Juice', N'Drink', 20, 10, N'Mango Juice', N'Mango Juice', N'~/Images/0104202123282003012021114456product-8.jpg', N'~/Images/0104202123282003012021114456product-8.jpg')
INSERT [dbo].[tbl_Product] ([Id], [Name], [Category], [Price], [Quantity], [Short_Description], [Long_Description], [Small_ImagePath], [Large_ImagePath]) VALUES (7, N'Garlic', N'Vegetable', 80, 10, N'Garlic', N'Garlic', N'~/Images/0104202123294403012021114308product-11.jpg', N'~/Images/0104202123294403012021114308product-11.jpg')
INSERT [dbo].[tbl_Product] ([Id], [Name], [Category], [Price], [Quantity], [Short_Description], [Long_Description], [Small_ImagePath], [Large_ImagePath]) VALUES (9, N'Onion', N'Vegetable', 100, 10, N'Onion', N'Onion', N'~/Images/0104202123352803012021114352product-9.jpg', N'~/Images/0104202123352803012021114352product-9.jpg')
SET IDENTITY_INSERT [dbo].[tbl_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_User] ON 

INSERT [dbo].[tbl_User] ([Id], [Email], [Password]) VALUES (1, N'abc@gmail.com', N'Abc@1234')
INSERT [dbo].[tbl_User] ([Id], [Email], [Password]) VALUES (2, N'hichetanmore@gmail.com', N'Chetan@23')
SET IDENTITY_INSERT [dbo].[tbl_User] OFF
GO
USE [master]
GO
ALTER DATABASE [db_PM] SET  READ_WRITE 
GO
