USE [master]
GO
/****** Object:  Database [scDB]    Script Date: 5.07.2025 22:21:16 ******/
CREATE DATABASE [scDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'scDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\scDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'scDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\scDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [scDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [scDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [scDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [scDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [scDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [scDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [scDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [scDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [scDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [scDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [scDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [scDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [scDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [scDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [scDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [scDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [scDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [scDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [scDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [scDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [scDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [scDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [scDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [scDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [scDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [scDB] SET  MULTI_USER 
GO
ALTER DATABASE [scDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [scDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [scDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [scDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [scDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [scDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [scDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [scDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [scDB]
GO
/****** Object:  Table [dbo].[Kisiler]    Script Date: 5.07.2025 22:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisiler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[adSoyad] [nvarchar](50) NULL,
	[meslek] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 5.07.2025 22:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](50) NULL,
	[parola] [varchar](50) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinavlar]    Script Date: 5.07.2025 22:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinavlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kisiID] [int] NULL,
	[tarih] [date] NULL,
	[puan] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sorular]    Script Date: 5.07.2025 22:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sorular](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[soruMetni] [nvarchar](200) NULL,
	[aSec] [nvarchar](50) NULL,
	[bSec] [nvarchar](50) NULL,
	[cSec] [nvarchar](50) NULL,
	[dSec] [nvarchar](50) NULL,
	[dogruCevap] [nvarchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDers]    Script Date: 5.07.2025 22:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDers](
	[dersKodu] [int] IDENTITY(1,1) NOT NULL,
	[dersAdi] [varchar](50) NULL,
 CONSTRAINT [PK_tblDers] PRIMARY KEY CLUSTERED 
(
	[dersKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOgrenci]    Script Date: 5.07.2025 22:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOgrenci](
	[ogrNo] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[dogumTarih] [date] NULL,
	[adres] [varchar](100) NULL,
	[telefon] [varchar](50) NULL,
	[dersID] [int] NULL,
	[Ortalama] [int] NULL,
 CONSTRAINT [PK_tblOgrenci] PRIMARY KEY CLUSTERED 
(
	[ogrNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kisiler] ON 

INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (1, N'Saliha Şahin', N'Diş Doktoru')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (2, N'mesut şahin', N'Makine Mühendisi')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (3, N'sadık şahin', N'Bilgisayar Mühendisi')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (4, N'Mustafa Yılmaz', N'Yazılım Mühendisi')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (5, N'Burak Kaan', N'Elektrik Elektronik Mühendisi')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (6, N'Beyza Şahin', N'Fizik Tedavi')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (7, N'Elif Şahin', N'Matematik')
INSERT [dbo].[Kisiler] ([ID], [adSoyad], [meslek]) VALUES (8, N'Kerem Oğuzhan', N'Bilgisayar')
SET IDENTITY_INSERT [dbo].[Kisiler] OFF
GO
SET IDENTITY_INSERT [dbo].[Sinavlar] ON 

INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (1, 1, CAST(N'2023-01-01' AS Date), CAST(85 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (2, 2, CAST(N'2023-01-02' AS Date), CAST(90 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (3, 1, CAST(N'2023-01-03' AS Date), CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (4, 1, CAST(N'2023-01-04' AS Date), CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (5, 3, CAST(N'2023-01-04' AS Date), CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (6, 5, CAST(N'2023-01-03' AS Date), CAST(70 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (7, 5, CAST(N'2023-01-04' AS Date), CAST(30 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (8, 2, CAST(N'2023-01-04' AS Date), CAST(60 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (9, 6, CAST(N'2023-01-04' AS Date), CAST(80 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (10, 7, CAST(N'2023-01-04' AS Date), CAST(91 AS Decimal(18, 0)))
INSERT [dbo].[Sinavlar] ([ID], [kisiID], [tarih], [puan]) VALUES (11, 8, CAST(N'2025-06-30' AS Date), CAST(92 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Sinavlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Sorular] ON 

INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (1, N'Başkentimiz neresidir ?', N'Adana', N'Konya', N'İstanbul', N'Ankara', N'D')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (2, N'En fazla nüfüslü ilimiz neresidir ?', N'Ankara', N'Konya', N'İstanbul', N'Karaman', N'C')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (3, N'2 * 3 - 5 + 4 *2 - 1 *5 = ?', N'4', N'5', N'6', N'1', N'A')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (4, N'2+5-3  = ?', N'1', N'2', N'3', N'4', N'D')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (5, N'Bozkırın tezenesi lakaplı rahmetli halk ozanı kimdir?', N'Neşet Ertaş', N'Sibel Can', N'Tarkan', N'Musa Eroğlu', N'A')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (6, N'1071’de yapılan Malazgirt Savaşıyla Anadolu’nun kapılarını Türklere açan Selçuklu Sultanı kimdir?', N'Sultan Alparslan', N'Sultan Alaaddin', N'Sultan Selim', N'Sultan Mustafa', N'A')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (7, N'Türkiye’ de kaç tane coğrafi bölge bulunmaktadır?', N'3', N'5', N'7', N'9', N'C')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (8, N'2 + 2 = 4  İşlemini yapan hangi sayı sistemini kullanmıştır ?', N'2 lik', N'3 lük', N'4 lük', N'5 lik', N'D')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (9, N'Türk tarihinin en ünlü mimarı kimdir?', N'Mimar Kemalettin', N'Mimar Sinan', N'Mimar Hasan', N'Mimar Hüseyin', N'B')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (10, N'İstiklal Şairi olarak anılan şair aşağıdakilerden hangisidir?', N'Yahya Kemal Beyatlı', N'Yakup Kadri Karaosmanoğlu', N'Mehmet Akif Ersoy', N'Ahmet Hamdi Tanpınar', N'C')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (11, N'3*5-4 = ?', N'10', N'11', N'12', N'15', N'B')
INSERT [dbo].[Sorular] ([ID], [soruMetni], [aSec], [bSec], [cSec], [dSec], [dogruCevap]) VALUES (12, N'4 * 2 - 5*1 = ?', N'3', N'4', N'2', N'1', N'A')
SET IDENTITY_INSERT [dbo].[Sorular] OFF
GO
ALTER TABLE [dbo].[Sinavlar]  WITH CHECK ADD FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisiler] ([ID])
GO
ALTER TABLE [dbo].[tblOgrenci]  WITH CHECK ADD  CONSTRAINT [FK_tblOgrenci_tblDers] FOREIGN KEY([dersID])
REFERENCES [dbo].[tblDers] ([dersKodu])
GO
ALTER TABLE [dbo].[tblOgrenci] CHECK CONSTRAINT [FK_tblOgrenci_tblDers]
GO
USE [master]
GO
ALTER DATABASE [scDB] SET  READ_WRITE 
GO
