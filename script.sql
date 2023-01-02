USE [araç_otopark]
GO
/****** Object:  Table [dbo].[araç_otopark_kaydı]    Script Date: 2.01.2023 17:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[araç_otopark_kaydı](
	[tc] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[parkyeri] [nvarchar](50) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[araçdurumu]    Script Date: 2.01.2023 17:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[araçdurumu](
	[parkyeri] [nvarchar](50) NOT NULL,
	[durumu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[markabilgileri]    Script Date: 2.01.2023 17:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[markabilgileri](
	[marka] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seribilgileri]    Script Date: 2.01.2023 17:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seribilgileri](
	[marka] [nvarchar](50) NULL,
	[seri] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[araç_otopark_kaydı] ([tc], [ad], [soyad], [telefon], [email], [plaka], [marka], [seri], [renk], [parkyeri], [tarih]) VALUES (N'12345678', N'Ali', N'Yılmaz', N'05431234433', N'aliyilmaz@gmail.com', N'64AY20', N'Fiat', N'Megan', N'Gri', N'P-3', N'2.01.2023 01:50:34')
INSERT [dbo].[araç_otopark_kaydı] ([tc], [ad], [soyad], [telefon], [email], [plaka], [marka], [seri], [renk], [parkyeri], [tarih]) VALUES (N'32321211', N'Yarkın', N'Gökpınar', N'05342212111', N'yarkin@gmail.com', N'35YG46', N'Ford', N'Focus', N'Yeşil', N'P-5', N'2.01.2023 02:01:18')
INSERT [dbo].[araç_otopark_kaydı] ([tc], [ad], [soyad], [telefon], [email], [plaka], [marka], [seri], [renk], [parkyeri], [tarih]) VALUES (N'22454734521', N'Osman', N'Kara', N'05432134561', N'osmankara@gmail.com', N'10AA102', N'Fiat', N'Egea', N'Beyaz', N'P-1', N'2.01.2023 16:49:45')
INSERT [dbo].[araç_otopark_kaydı] ([tc], [ad], [soyad], [telefon], [email], [plaka], [marka], [seri], [renk], [parkyeri], [tarih]) VALUES (N'1234567890', N'Ali', N'Yılmaz', N'02123456789', N'alii@gmail.com', N'15UP24', N'Mercedes', N'Benz', N'Siyah', N'P-6', N'2.01.2023 16:53:16')
GO
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-1', N'DOLU')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-2', N'BOŞ')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-3', N'DOLU')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-4', N'BOŞ')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-5', N'DOLU')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-6', N'DOLU')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-7', N'BOŞ')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-8', N'BOŞ')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-9', N'BOŞ')
INSERT [dbo].[araçdurumu] ([parkyeri], [durumu]) VALUES (N'P-10', N'BOŞ')
GO
INSERT [dbo].[markabilgileri] ([marka]) VALUES (N'Fiat')
INSERT [dbo].[markabilgileri] ([marka]) VALUES (N'Ford')
INSERT [dbo].[markabilgileri] ([marka]) VALUES (N'Opel')
INSERT [dbo].[markabilgileri] ([marka]) VALUES (N'Mercedes')
GO
INSERT [dbo].[seribilgileri] ([marka], [seri]) VALUES (N'Fiat', N'Linea')
INSERT [dbo].[seribilgileri] ([marka], [seri]) VALUES (N'Ford', N'Focus')
INSERT [dbo].[seribilgileri] ([marka], [seri]) VALUES (N'Opel', N'Astra')
INSERT [dbo].[seribilgileri] ([marka], [seri]) VALUES (N'Fiat', N'Egea')
INSERT [dbo].[seribilgileri] ([marka], [seri]) VALUES (N'Mercedes', N'Benz')
GO
