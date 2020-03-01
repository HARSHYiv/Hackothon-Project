DROP;
USE [master]
GO

/****** Object:  Database [404Error_Project_DB]    Script Date: 2020/03/01 04:13:47 ******/
CREATE DATABASE [404Error_Project_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'404Error_Project_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\404Error_Project_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'404Error_Project_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\404Error_Project_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [404Error_Project_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [404Error_Project_DB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET ARITHABORT OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [404Error_Project_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [404Error_Project_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [404Error_Project_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [404Error_Project_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [404Error_Project_DB] SET  MULTI_USER 
GO

ALTER DATABASE [404Error_Project_DB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [404Error_Project_DB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [404Error_Project_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [404Error_Project_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [404Error_Project_DB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [404Error_Project_DB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [404Error_Project_DB] SET  READ_WRITE 
GO

DROP

USE [404Error_Project_DB]
GO

/****** Object:  Table [dbo].[tbl_Faculty]    Script Date: 2020/03/01 04:16:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Faculty](
	[Faculty_ID] [int] IDENTITY(1,1) NOT NULL,
	[Faculty] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Faculty] PRIMARY KEY CLUSTERED 
(
	[Faculty_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

DROP

USE [404Error_Project_DB]
GO

/****** Object:  Table [dbo].[tblAPS_Key]    Script Date: 2020/03/01 04:19:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblAPS_Key](
	[APS_ID] [int] IDENTITY(1,1) NOT NULL,
	[0-29%] [int] NULL,
	[30-39%] [smallint] NOT NULL,
	[40-49%] [smallint] NOT NULL,
	[50-59%] [smallint] NOT NULL,
	[60-69%] [smallint] NOT NULL,
	[70-79%] [smallint] NOT NULL,
	[80-89%] [smallint] NOT NULL,
	[90-100%] [smallint] NULL,
 CONSTRAINT [PK_tblAPS_Key] PRIMARY KEY CLUSTERED 
(
	[APS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


DROP


USE [404Error_Project_DB]
GO

/****** Object:  Table [dbo].[tblCourse]    Script Date: 2020/03/01 04:20:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCourse](
	[Course_ID] [int] IDENTITY(1,1) NOT NULL,
	[University_ID] [int] NOT NULL,
	[Faculty_ID] [int] NOT NULL,
	[Qualification] [nchar](10) NOT NULL,
	[APS] [smallint] NOT NULL,
 CONSTRAINT [PK_tblFaculty] PRIMARY KEY CLUSTERED 
(
	[Course_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

DROP

USE [404Error_Project_DB]
GO

/****** Object:  Table [dbo].[tblJobs]    Script Date: 2020/03/01 04:20:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblJobs](
	[Job_ID] [int] IDENTITY(1,1) NOT NULL,
	[Faculty_ID] [int] NULL,
	[Job_Title] [nvarchar](50) NULL,
	[Job_description] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblJobs] PRIMARY KEY CLUSTERED 
(
	[Job_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


DROP;

USE [404Error_Project_DB]
GO

/****** Object:  Table [dbo].[tblUniversity]    Script Date: 2020/03/01 04:21:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblUniversity](
	[University_ID] [int] IDENTITY(1,1) NOT NULL,
	[APS_ID] [int] NULL,
	[University Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblUniversity] PRIMARY KEY CLUSTERED 
(
	[University_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblUniversity]  WITH CHECK ADD  CONSTRAINT [FK_tblUniversity_tblAPS_Key] FOREIGN KEY([APS_ID])
REFERENCES [dbo].[tblAPS_Key] ([APS_ID])
GO

ALTER TABLE [dbo].[tblUniversity] CHECK CONSTRAINT [FK_tblUniversity_tblAPS_Key]
GO
