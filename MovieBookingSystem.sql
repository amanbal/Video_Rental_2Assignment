USE [master]
GO
/****** Object:  Database [MovieBookngSystem]    Script Date: 28/02/2021 7:53:07 PM ******/
CREATE DATABASE [MovieBookngSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieBookngSystem_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MovieBookngSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MovieBookngSystem_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MovieBookngSystem.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MovieBookngSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieBookngSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieBookngSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieBookngSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieBookngSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MovieBookngSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieBookngSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieBookngSystem] SET  MULTI_USER 
GO
ALTER DATABASE [MovieBookngSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieBookngSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieBookngSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieBookngSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieBookngSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MovieBookngSystem] SET QUERY_STORE = OFF
GO
USE [MovieBookngSystem]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 28/02/2021 7:53:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[VideoName] [varchar](50) NULL,
	[BookingDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 28/02/2021 7:53:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 28/02/2021 7:53:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Point] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Copies] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingID], [CustomerName], [VideoName], [BookingDate], [ReturnDate]) VALUES (3, N'lomn', N'poop', N'2/11/2021', N'28/02/2021')
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([CustomerID], [Name], [Age], [Contact]) VALUES (1, N'lomn', N'23', N'6487995')
INSERT [dbo].[customer] ([CustomerID], [Name], [Age], [Contact]) VALUES (3, N'John', N'20', N'64985989')
SET IDENTITY_INSERT [dbo].[customer] OFF
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([MovieID], [Name], [Point], [Year], [Copies], [Cost], [Genre]) VALUES (1, N'Kanu', N'12', N'2020', N'4', N'5', N'hres')
SET IDENTITY_INSERT [dbo].[Movie] OFF
USE [master]
GO
ALTER DATABASE [MovieBookngSystem] SET  READ_WRITE 
GO
