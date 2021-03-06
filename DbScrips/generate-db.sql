USE [master]
GO
/****** Object:  Database [Qulix]    Script Date: 05.08.2020 18:25:59 ******/
CREATE DATABASE [Qulix]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Qulix', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Qulix.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Qulix_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Qulix_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Qulix] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Qulix].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Qulix] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Qulix] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Qulix] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Qulix] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Qulix] SET ARITHABORT OFF 
GO
ALTER DATABASE [Qulix] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Qulix] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Qulix] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Qulix] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Qulix] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Qulix] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Qulix] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Qulix] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Qulix] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Qulix] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Qulix] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Qulix] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Qulix] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Qulix] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Qulix] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Qulix] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Qulix] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Qulix] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Qulix] SET  MULTI_USER 
GO
ALTER DATABASE [Qulix] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Qulix] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Qulix] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Qulix] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Qulix] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Qulix] SET QUERY_STORE = OFF
GO
USE [Qulix]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 05.08.2020 18:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyTypeId] [bigint] NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Size] [int] NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyTypes]    Script Date: 05.08.2020 18:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CompanyTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 05.08.2020 18:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyId] [bigint] NULL,
	[PositionId] [bigint] NULL,
	[Surname] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Patronymic] [nvarchar](max) NULL,
	[EmploymentDate] [datetime] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 05.08.2020 18:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CompanyTypes] ON 
GO
INSERT [dbo].[CompanyTypes] ([Id], [Name]) VALUES (3, N'ЗАО')
GO
INSERT [dbo].[CompanyTypes] ([Id], [Name]) VALUES (4, N'ОАО')
GO
SET IDENTITY_INSERT [dbo].[CompanyTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [CompanyId], [PositionId], [Surname], [Name], [Patronymic], [EmploymentDate]) VALUES (85, 0, 0, N'1', N'2', N'3', CAST(N'2020-08-05T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 
GO
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (5, N'Тестировщик')
GO
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (6, N'Разработчик')
GO
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (7, N'Менеджер')
GO
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (8, N'Бизнес-аналитик')
GO
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
USE [master]
GO
ALTER DATABASE [Qulix] SET  READ_WRITE 
GO
