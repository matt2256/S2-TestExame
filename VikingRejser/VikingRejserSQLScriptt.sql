USE [master]
GO
/****** Object:  Database [VikingRejser]    Script Date: 17-06-2020 09:59:19 ******/
CREATE DATABASE [VikingRejser]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VikingRejser', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VikingRejser.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VikingRejser_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VikingRejser_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VikingRejser] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VikingRejser].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VikingRejser] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VikingRejser] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VikingRejser] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VikingRejser] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VikingRejser] SET ARITHABORT OFF 
GO
ALTER DATABASE [VikingRejser] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VikingRejser] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VikingRejser] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VikingRejser] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VikingRejser] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VikingRejser] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VikingRejser] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VikingRejser] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VikingRejser] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VikingRejser] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VikingRejser] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VikingRejser] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VikingRejser] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VikingRejser] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VikingRejser] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VikingRejser] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VikingRejser] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VikingRejser] SET RECOVERY FULL 
GO
ALTER DATABASE [VikingRejser] SET  MULTI_USER 
GO
ALTER DATABASE [VikingRejser] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VikingRejser] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VikingRejser] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VikingRejser] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VikingRejser] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VikingRejser', N'ON'
GO
ALTER DATABASE [VikingRejser] SET QUERY_STORE = OFF
GO
USE [VikingRejser]
GO
/****** Object:  Table [dbo].[Kunder]    Script Date: 17-06-2020 09:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kunder](
	[Id] [int] NOT NULL,
	[Navn] [varchar](50) NULL,
	[Adresse] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
	[RejseArrangementer] [varchar](50) NULL,
	[Tilmelding] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rejsearrangementer]    Script Date: 17-06-2020 09:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rejsearrangementer](
	[Id] [int] NOT NULL,
	[Title] [varchar](50) NULL,
	[By] [varchar](50) NULL,
	[Stardato] [datetime] NULL,
	[Slutdato] [datetime] NULL,
	[Pris] [int] NULL,
	[MaxAntal] [varchar](50) NULL,
	[Beskrivelse] [varchar](200) NULL,
	[Tilmelding] [int] NULL,
	[Transportør] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tildmelding]    Script Date: 17-06-2020 09:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tildmelding](
	[Id] [int] NOT NULL,
	[Kunde] [int] NOT NULL,
	[Rejsearrangementer] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transportør]    Script Date: 17-06-2020 09:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transportør](
	[Id] [int] NOT NULL,
	[Navn] [varchar](50) NULL,
	[Adresse] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
	[Bemærkning] [varchar](50) NULL,
	[Rejsearragement] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kunder]  WITH CHECK ADD  CONSTRAINT [FK_Kunder_Tilmelding] FOREIGN KEY([Tilmelding])
REFERENCES [dbo].[Tildmelding] ([Id])
GO
ALTER TABLE [dbo].[Kunder] CHECK CONSTRAINT [FK_Kunder_Tilmelding]
GO
ALTER TABLE [dbo].[Rejsearrangementer]  WITH CHECK ADD  CONSTRAINT [FK_Rejsearrangementer_Tilmelding] FOREIGN KEY([Tilmelding])
REFERENCES [dbo].[Tildmelding] ([Id])
GO
ALTER TABLE [dbo].[Rejsearrangementer] CHECK CONSTRAINT [FK_Rejsearrangementer_Tilmelding]
GO
ALTER TABLE [dbo].[Rejsearrangementer]  WITH CHECK ADD  CONSTRAINT [FK_Rejsearrangementer_Transportør] FOREIGN KEY([Transportør])
REFERENCES [dbo].[Transportør] ([Id])
GO
ALTER TABLE [dbo].[Rejsearrangementer] CHECK CONSTRAINT [FK_Rejsearrangementer_Transportør]
GO
ALTER TABLE [dbo].[Tildmelding]  WITH CHECK ADD  CONSTRAINT [FK_Tildmelding_Kunde] FOREIGN KEY([Kunde])
REFERENCES [dbo].[Kunder] ([Id])
GO
ALTER TABLE [dbo].[Tildmelding] CHECK CONSTRAINT [FK_Tildmelding_Kunde]
GO
ALTER TABLE [dbo].[Tildmelding]  WITH CHECK ADD  CONSTRAINT [FK_Tildmelding_Rejsearragementer] FOREIGN KEY([Rejsearrangementer])
REFERENCES [dbo].[Rejsearrangementer] ([Id])
GO
ALTER TABLE [dbo].[Tildmelding] CHECK CONSTRAINT [FK_Tildmelding_Rejsearragementer]
GO
ALTER TABLE [dbo].[Transportør]  WITH CHECK ADD  CONSTRAINT [FK_Transportør_Rejsearragement] FOREIGN KEY([Rejsearragement])
REFERENCES [dbo].[Rejsearrangementer] ([Id])
GO
ALTER TABLE [dbo].[Transportør] CHECK CONSTRAINT [FK_Transportør_Rejsearragement]
GO
USE [master]
GO
ALTER DATABASE [VikingRejser] SET  READ_WRITE 
GO
