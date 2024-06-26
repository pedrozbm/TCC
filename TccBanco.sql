USE [master]
GO
/****** Object:  Database [tcc]    Script Date: 26/03/2024 15:58:40 ******/
CREATE DATABASE [tcc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tcc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tcc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tcc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tcc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [tcc] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tcc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tcc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tcc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tcc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tcc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tcc] SET ARITHABORT OFF 
GO
ALTER DATABASE [tcc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tcc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tcc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tcc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tcc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tcc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tcc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tcc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tcc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tcc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [tcc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tcc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tcc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tcc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tcc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tcc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tcc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tcc] SET RECOVERY FULL 
GO
ALTER DATABASE [tcc] SET  MULTI_USER 
GO
ALTER DATABASE [tcc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tcc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tcc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tcc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tcc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tcc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'tcc', N'ON'
GO
ALTER DATABASE [tcc] SET QUERY_STORE = ON
GO
ALTER DATABASE [tcc] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [tcc]
GO
/****** Object:  Table [dbo].[Animais]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animais](
	[ID_Animal] [int] NOT NULL,
	[Nome] [varchar](100) NULL,
	[ID_Raca] [int] NULL,
	[ID_Genero] [int] NULL,
	[Data_Nascimento] [date] NULL,
	[ID_Proprietario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Animal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidades]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidades](
	[ID_Cidade] [int] NOT NULL,
	[Nome_Cidade] [varchar](100) NULL,
	[CEP] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico_Pos]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico_Pos](
	[ID_Pos_Diagnostico] [int] NOT NULL,
	[ID_Inseminacao] [int] NULL,
	[Data_Pos_Diagnostico] [date] NULL,
	[Sucesso_Pos] [bit] NULL,
	[Detalhes_Pos] [varchar](255) NULL,
	[Observacoes_Pos] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Pos_Diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico_Pre]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico_Pre](
	[ID_Pre_Diagnostico] [int] NOT NULL,
	[ID_Inseminacao] [int] NULL,
	[Data_Pre_Diagnostico] [date] NULL,
	[Score_Pre] [bit] NULL,
	[Detalhes_Pre] [varchar](255) NULL,
	[Observacoes_Pre] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Pre_Diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[ID_Estado] [int] NOT NULL,
	[Nome_Estado] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fazendas]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fazendas](
	[ID_Fazenda] [int] NOT NULL,
	[Nome_Fazenda] [varchar](100) NULL,
	[Endereco] [varchar](255) NULL,
	[ID_Cidade] [int] NULL,
	[ID_Estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Fazenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[ID_Genero] [int] NOT NULL,
	[Tipo_Genero] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inseminacoes]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inseminacoes](
	[ID_Inseminacao] [int] NOT NULL,
	[ID_Animal] [int] NULL,
	[Data_Inseminacao] [date] NULL,
	[Metodo_Inseminacao] [varchar](100) NULL,
	[ID_Inseminador] [int] NULL,
	[Observacoes] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Inseminacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inseminadores]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inseminadores](
	[ID_Inseminador] [int] NOT NULL,
	[Nome] [varchar](100) NULL,
	[Especializacao] [varchar](100) NULL,
	[Certificacoes] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Inseminador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proprietarios]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proprietarios](
	[ID_Proprietario] [int] NOT NULL,
	[Nome] [varchar](100) NULL,
	[ID_Fazenda] [int] NULL,
	[Numero_Contato] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Proprietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Racas]    Script Date: 26/03/2024 15:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Racas](
	[ID_Raca] [int] NOT NULL,
	[Nome_Raca] [varchar](100) NULL,
	[Descricao_Raca] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Raca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Animais]  WITH CHECK ADD FOREIGN KEY([ID_Genero])
REFERENCES [dbo].[Generos] ([ID_Genero])
GO
ALTER TABLE [dbo].[Animais]  WITH CHECK ADD FOREIGN KEY([ID_Proprietario])
REFERENCES [dbo].[Proprietarios] ([ID_Proprietario])
GO
ALTER TABLE [dbo].[Animais]  WITH CHECK ADD FOREIGN KEY([ID_Raca])
REFERENCES [dbo].[Racas] ([ID_Raca])
GO
ALTER TABLE [dbo].[Diagnostico_Pos]  WITH CHECK ADD FOREIGN KEY([ID_Inseminacao])
REFERENCES [dbo].[Inseminacoes] ([ID_Inseminacao])
GO
ALTER TABLE [dbo].[Diagnostico_Pre]  WITH CHECK ADD FOREIGN KEY([ID_Inseminacao])
REFERENCES [dbo].[Inseminacoes] ([ID_Inseminacao])
GO
ALTER TABLE [dbo].[Fazendas]  WITH CHECK ADD FOREIGN KEY([ID_Cidade])
REFERENCES [dbo].[Cidades] ([ID_Cidade])
GO
ALTER TABLE [dbo].[Fazendas]  WITH CHECK ADD FOREIGN KEY([ID_Estado])
REFERENCES [dbo].[Estados] ([ID_Estado])
GO
ALTER TABLE [dbo].[Inseminacoes]  WITH CHECK ADD FOREIGN KEY([ID_Animal])
REFERENCES [dbo].[Animais] ([ID_Animal])
GO
ALTER TABLE [dbo].[Inseminacoes]  WITH CHECK ADD FOREIGN KEY([ID_Inseminador])
REFERENCES [dbo].[Inseminadores] ([ID_Inseminador])
GO
ALTER TABLE [dbo].[Proprietarios]  WITH CHECK ADD FOREIGN KEY([ID_Fazenda])
REFERENCES [dbo].[Fazendas] ([ID_Fazenda])
GO
USE [master]
GO
ALTER DATABASE [tcc] SET  READ_WRITE 
GO
