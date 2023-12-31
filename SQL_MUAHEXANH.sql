USE [MUAHEXANH]
GO
/****** Object:  User [2]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [2] FOR LOGIN [gv02] WITH DEFAULT_SCHEMA=[2]
GO
/****** Object:  User [5]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [5] FOR LOGIN [quangvanchuan] WITH DEFAULT_SCHEMA=[5]
GO
/****** Object:  User [ADMINTY]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [ADMINTY] FOR LOGIN [ADMINTY] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [DP]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [DP] FOR LOGIN [DP] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [DT]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [DT] FOR LOGIN [DT] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [HTKN]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N17DCCN022  ]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [N17DCCN022  ] FOR LOGIN [SV] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N21DCVT055]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE USER [N21DCVT055] FOR LOGIN [lyhongphuc] WITH DEFAULT_SCHEMA=[N21DCVT055]
GO
/****** Object:  DatabaseRole [ADMIN]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE ROLE [ADMIN]
GO
/****** Object:  DatabaseRole [DoiTruong]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE ROLE [DoiTruong]
GO
/****** Object:  DatabaseRole [GiamSat]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE ROLE [GiamSat]
GO
/****** Object:  DatabaseRole [SinhVien]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE ROLE [SinhVien]
GO
ALTER ROLE [GiamSat] ADD MEMBER [2]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [2]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [2]
GO
ALTER ROLE [db_datareader] ADD MEMBER [2]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [2]
GO
ALTER ROLE [GiamSat] ADD MEMBER [5]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [5]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [5]
GO
ALTER ROLE [db_datareader] ADD MEMBER [5]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [5]
GO
ALTER ROLE [ADMIN] ADD MEMBER [ADMINTY]
GO
ALTER ROLE [db_owner] ADD MEMBER [ADMINTY]
GO
ALTER ROLE [DoiTruong] ADD MEMBER [DP]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DP]
GO
ALTER ROLE [DoiTruong] ADD MEMBER [DT]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DT]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [SinhVien] ADD MEMBER [N17DCCN022  ]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N17DCCN022  ]
GO
ALTER ROLE [SinhVien] ADD MEMBER [N21DCVT055]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N21DCVT055]
GO
ALTER ROLE [db_owner] ADD MEMBER [ADMIN]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DoiTruong]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [GiamSat]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GiamSat]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GiamSat]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GiamSat]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SinhVien]
GO
/****** Object:  Schema [2]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE SCHEMA [2]
GO
/****** Object:  Schema [5]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE SCHEMA [5]
GO
/****** Object:  Schema [N21DCVT055]    Script Date: 7/16/2023 7:16:04 PM ******/
CREATE SCHEMA [N21DCVT055]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_NhomGV_NhomSV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[udf_NhomGV_NhomSV]
(@idGV INT, @idNha INT)

RETURNS INT

AS

BEGIN	
	IF EXISTS (SELECT * FROM GiangVien Where IdGV = @idGV AND IdNhomGV IS NULL)
		RETURN -2

	DECLARE @idXa INT
	SET @idxa = (SELECT IdXa FROM NhomGV WHERE IdNhom = (SELECT IdNhomGV FROM GiangVien WHERE IdGV = @IdGV))

	IF @idNha NOT IN (SELECT idNha FROM NhaDan WHERE idAp IN (SELECT idAp FROM AP WHERE idXa = @idXa))
		RETURN -1

	RETURN 0
END;
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[IdGV] [nchar](12) NOT NULL,
	[Ho] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
	[Email] [nchar](50) NULL,
	[ChucVu] [nvarchar](20) NULL,
	[IdKhoa] [int] NOT NULL,
	[IdNhomGV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_dsTaoLoginGV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--view cua sinh vien va giam sat
	CREATE view [dbo].[v_dsTaoLoginGV] as 
	select GiangVien.IdGV,GiangVien.Ho +' '+GiangVien.Ten as HoTen from GiangVien where GiangVien.IdGV not in(
	select name from sys.sysusers)
	
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MSSV] [nchar](12) NOT NULL,
	[Ho] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
	[Email] [nchar](50) NULL,
	[ChucVu] [nvarchar](20) NULL,
	[IdKhoa] [int] NOT NULL,
	[IdNhomSV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_dsTaoLoginSV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE view [dbo].[v_dsTaoLoginSV] as 
	select SinhVien.MSSV,SinhVien.Ho +' '+ SinhVien.Ten as HoTen from SinhVien where SinhVien.MSSV not in(
	select name from sys.sysusers)
GO
/****** Object:  Table [dbo].[Ap]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ap](
	[IdAp] [int] NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[IdXa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[IdCV] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[ThoiGian] [int] NOT NULL,
	[KhoiLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTCV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTCV](
	[IdCT] [int] NOT NULL,
	[NgayBD] [date] NOT NULL,
	[NgayKT] [date] NOT NULL,
	[IdCV] [int] NOT NULL,
	[IdAp] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBA_Logins]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBA_Logins](
	[login] [nvarchar](64) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[is_disabled] [bit] NOT NULL,
	[login_type] [nvarchar](13) NULL,
	[public] [bit] NOT NULL,
	[sysadmin] [bit] NOT NULL,
	[securityadmin] [bit] NOT NULL,
	[serveradmin] [bit] NOT NULL,
	[setupadmin] [bit] NOT NULL,
	[processadmin] [bit] NOT NULL,
	[diskadmin] [bit] NOT NULL,
	[dbcreator] [bit] NOT NULL,
	[bulkadmin] [bit] NOT NULL,
	[##MS_ServerStateReader##] [bit] NOT NULL,
	[##MS_ServerStateManager##] [bit] NOT NULL,
	[##MS_DefinitionReader##] [bit] NOT NULL,
	[##MS_DatabaseConnector##] [bit] NOT NULL,
	[##MS_DatabaseManager##] [bit] NOT NULL,
	[##MS_LoginManager##] [bit] NOT NULL,
	[##MS_SecurityDefinitionReader##] [bit] NOT NULL,
	[##MS_PerformanceDefinitionReader] [bit] NOT NULL,
	[##MS_ServerSecurityStateReader##] [bit] NOT NULL,
	[##MS_ServerPerformanceStateReade] [bit] NOT NULL,
	[data_collection_timestamp] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaBan]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaBan](
	[IdDB] [int] NOT NULL,
	[Ten] [nvarchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[IdKT] [int] IDENTITY(1,1) NOT NULL,
	[DanhHieu] [nvarchar](30) NULL,
	[MSSV] [nchar](12) NULL,
 CONSTRAINT [PK__KhenThuo__B773D19DADD8C80A] PRIMARY KEY CLUSTERED 
(
	[IdKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[IdKhoa] [int] NOT NULL,
	[Ten] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaDan]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaDan](
	[IdNha] [int] NOT NULL,
	[SoNha] [nvarchar](20) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
	[ChuHo] [nvarchar](50) NOT NULL,
	[IdAp] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomGV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomGV](
	[IdNhom] [int] NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[IdXa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomSV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSV](
	[IdNhom] [int] NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[IdNha] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PCCV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCCV](
	[IdPC] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [date] NOT NULL,
	[Buoi] [nvarchar](10) NOT NULL,
	[DanhGia] [int] NULL,
	[IdCT] [int] NULL,
	[IdNhomSV] [int] NULL,
	[IdNhomGV] [int] NULL,
 CONSTRAINT [PK__PCCV__B7703B3E4D919077] PRIMARY KEY CLUSTERED 
(
	[IdPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xa]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xa](
	[IdXa] [int] NOT NULL,
	[Ten] [nvarchar](35) NOT NULL,
	[IdDB] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (1, N'Khu phố 1', 1)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (2, N'Khu phố 2', 1)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (3, N'Khu phố 3', 2)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (4, N'Khu Phố 7', 19774)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (5, N'Khu Phố 7', 19774)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (6, N'Khu Phố 3', 7)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (7, N'Khu Phố 1', 14560)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (8, N'Khu Phố 2', 14560)
INSERT [dbo].[Ap] ([IdAp], [Ten], [IdXa]) VALUES (9, N'Khu Phố 2', 13384)
GO
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (1, N'Dọn Dẹp', 90, 1)
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (2, N'Sơn Tường', 180, 2)
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (3, N'Dạy Học', 90, 1)
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (4, N'Xây Nhà', 240, 3)
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (5, N'Trồng Cây', 120, 2)
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (6, N'Quản Lý Giao Thông', 75, 1)
INSERT [dbo].[CongViec] ([IdCV], [Ten], [ThoiGian], [KhoiLuong]) VALUES (7, N'Test', 90, 2)
GO
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (1, CAST(N'2023-07-01' AS Date), CAST(N'2023-07-05' AS Date), 1, 3)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (2, CAST(N'2023-07-01' AS Date), CAST(N'2023-07-08' AS Date), 1, 2)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (3, CAST(N'2023-07-01' AS Date), CAST(N'2023-07-05' AS Date), 2, 2)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (4, CAST(N'2023-07-02' AS Date), CAST(N'2023-07-08' AS Date), 3, 1)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (5, CAST(N'2023-07-02' AS Date), CAST(N'2023-07-05' AS Date), 4, 2)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (6, CAST(N'2023-07-02' AS Date), CAST(N'2023-07-02' AS Date), 5, 2)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (7, CAST(N'2023-07-02' AS Date), CAST(N'2023-07-02' AS Date), 5, 3)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (8, CAST(N'2023-07-03' AS Date), CAST(N'2023-07-07' AS Date), 6, 1)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (9, CAST(N'2023-07-02' AS Date), CAST(N'2023-07-05' AS Date), 3, 2)
INSERT [dbo].[CTCV] ([IdCT], [NgayBD], [NgayKT], [IdCV], [IdAp]) VALUES (10, CAST(N'2023-07-02' AS Date), CAST(N'2023-07-06' AS Date), 4, 1)
GO
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'sa', CAST(N'2003-04-08T09:10:35.460' AS DateTime), 0, N'SQL_LOGIN', 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'HAJKU206\ADMIN', CAST(N'2023-03-02T16:50:13.317' AS DateTime), 0, N'WINDOWS_LOGIN', 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'distributor_admin', CAST(N'2023-03-27T21:59:36.460' AS DateTime), 0, N'SQL_LOGIN', 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'DT', CAST(N'2023-06-17T22:13:34.677' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'DP', CAST(N'2023-06-17T22:30:22.000' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'SV', CAST(N'2023-06-17T22:33:12.683' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'ADMINTY', CAST(N'2023-06-17T23:23:00.407' AS DateTime), 0, N'SQL_LOGIN', 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'HTKN', CAST(N'2023-06-18T11:44:06.590' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'gv02', CAST(N'2023-06-21T16:32:48.003' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'hale123', CAST(N'2023-06-21T23:10:13.103' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'quangvanchuan', CAST(N'2023-06-30T15:56:04.690' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'ngocdung001', CAST(N'2023-07-09T17:08:42.317' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
INSERT [dbo].[DBA_Logins] ([login], [created_date], [is_disabled], [login_type], [public], [sysadmin], [securityadmin], [serveradmin], [setupadmin], [processadmin], [diskadmin], [dbcreator], [bulkadmin], [##MS_ServerStateReader##], [##MS_ServerStateManager##], [##MS_DefinitionReader##], [##MS_DatabaseConnector##], [##MS_DatabaseManager##], [##MS_LoginManager##], [##MS_SecurityDefinitionReader##], [##MS_PerformanceDefinitionReader], [##MS_ServerSecurityStateReader##], [##MS_ServerPerformanceStateReade], [data_collection_timestamp]) VALUES (N'nvh', CAST(N'2023-07-09T17:44:59.480' AS DateTime), 0, N'SQL_LOGIN', 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2023-07-10T16:38:11.900' AS DateTime))
GO
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (1, N'Quận Ba Đình')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (2, N'Quận Hoàn Kiếm')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (3, N'Quận Tây Hồ')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (350, N'Huyện Kim Bảng')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (370, N'Thành phố Tam Điệp')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (375, N'Huyện Yên Khánh')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (405, N'Huyện Đông Sơn')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (407, N'Thị xã Nghi Sơn')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (474, N'Thành phố Huế')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (753, N'Huyện Đất Đỏ')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (860, N'Huyện Tam Bình')
INSERT [dbo].[DiaBan] ([IdDB], [Ten]) VALUES (872, N'Huyện Tháp Mười')
GO
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'1           ', N'Nguyễn Văn', N'Hiếu', N'0258741372', N'nvhieu@ptithcm.edu.vn                             ', NULL, 1, 1)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'10          ', N'Trần Minh', N'Đức', N'0365214789', NULL, NULL, 2, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'11          ', N'Lê Thị', N'Thu', N'0915367824', NULL, NULL, 2, 2)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'12          ', N'Phan Văn', N'Long', N'0987451230', NULL, NULL, 2, 2)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'13          ', N'Nguyễn Hoàng', N'Mai', N'0938102467', NULL, NULL, 2, 2)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'14          ', N'Võ Đức', N'Tuấn', N'0853196740', NULL, NULL, 2, 2)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'15          ', N'Nguyễn Minh', N'Hoàng', N'0964872309', NULL, NULL, 2, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'16          ', N'Nguyễn Thị Mỹ', N'Linh', N'0938102467', NULL, NULL, 2, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'17          ', N'Võ Công', N'Huy', N'0523147765', NULL, NULL, 2, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'18          ', N'Hoàng Trung', N'Nam', N'0331547763', NULL, NULL, 2, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'19          ', N'Lê Minh', N'Tuấn', N'0987554632', NULL, NULL, 2, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'2           ', N'Hoang Van', N'Phuc', N'0585141369', N'hvphuc@ptithcm.edu.vn                             ', NULL, 1, 1)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'20          ', N'Nguyễn Hoàng', N'Long', N'0452169377', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'21          ', N'Phạm Thu', N'Hiềnnnnn', N'0364789214', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'22          ', N'Phan Quốc', N'Việt', N'0278111247', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'23          ', N'Lê Ngọc', N'Quang', N'0531489632', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'24          ', N'Hoàng Thị Thùy', N'Hương', N'0351789923', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'25          ', N'Diệp Trần Minh', N'Quân', N'0699652214', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'26          ', N'Lâm Ngọc Bảo', N'Anh', N'0528971235', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'27          ', N'Bùi Thiện', N'Nghĩa', N'0612359842', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'28          ', N'Văn Hoàng', N'Tuấn', N'0932667231', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'29          ', N'Lê Hoài', N'An', N'0986331277', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'3           ', N'Le Ngoc', N'Khoa', N'0365244789', N'                                                  ', NULL, 1, 2)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'30          ', N'Võ Lê Tuyết', N'Nhi', N'0714332698', NULL, NULL, 3, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'31          ', N'Lê Nguyễn Thảo', N'Nguyên', N'0523982277', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'32          ', N'Quách Hoàng', N'Khiêm', N'0321587623', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'33          ', N'Võ Thu', N'Hằng', N'0652874139', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'34          ', N'Trần Đức', N'Trí', N'0396320808', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'35          ', N'Lê Trung', N'Hòa', N'0741156328', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'36          ', N'Bùi Lê Anh', N'Thư', N'0698523149', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'37          ', N'Lê', N'Hoàng', N'0202358987', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'38          ', N'Phạm Duy', N'Thịnh', N'0986352147', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'39          ', N'Đinh Anh', N'Tuấn', N'0352147523', NULL, NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'4           ', N'Tran Ngoc', N'Anh', N'0352147896', N'                                                  ', N'Đội Trưởng', 1, 1)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'40          ', N'Lý Phúc', N'Minh', N'0589632235', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'41          ', N'Phan Kiều', N'My', N'0985214632', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'42          ', N'Nguyễn Đức', N'Phú', N'0632147852', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'43          ', N'Lê Anh', N'Thư', N'0987454982', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'44          ', N'Dương Bảo', N'Trân', N'0983214572', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'45          ', N'Nguyễn Hoàng Minh', N'Thông', N'0352147412', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'46          ', N'Bùi Anh', N'Tú', N'0341785521', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'47          ', N'Nguyễn Khánh', N'Vy', N'0412214587', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'48          ', N'Ninh Bảo', N'Hân', N'0412235874', NULL, NULL, 5, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'49          ', N'Đặng Ngọc Lan', N'Anh', N'0963321235', NULL, NULL, 1, 1)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'5           ', N'Quan Van', N'Chuan', N'0935214782', N'                                                  ', NULL, 1, 1)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'50          ', N'Nguyễn Ngọc', N'Khoa', N'0741221456', NULL, NULL, 1, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'51          ', N'Châu Hân', N'Hoa', N'0632852147', NULL, NULL, 1, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'52          ', N'Tô Phú', N'Thịnh', N'0323256841', NULL, NULL, 1, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'6           ', N'Trần', N'Đoàn Hoàng Minh', N'0265311458', N'tdhminh@ptithcm.edu.vn                            ', NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'7           ', N'Lê', N'Thị Ngọc Dung', N'0214136854', N'                                                  ', N'Đội Phó', 1, 3)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'8           ', N'Tôn Thất', N'Ngọc', N'0398201920', N'ntthat22@ptithcm.edu.vn                           ', NULL, 4, NULL)
INSERT [dbo].[GiangVien] ([IdGV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomGV]) VALUES (N'9           ', N'Nguyễn Thị', N'Kim', N'0973829101', NULL, NULL, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[KhenThuong] ON 

INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (1, N'Tốt', N'N17DCCN022  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (2, N'Tốt', N'N18DCCN033  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (3, N'Xuất sắc', N'N18DCDT024  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (4, N'Tốt', N'N18DCVT031  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (5, N'Xuất sắc', N'N19DCCN025  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (6, N'Xuất sắc', N'N19DCKT033  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (7, N'Xuất sắc', N'N19DCQT120  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (8, N'Xuất sắc', N'N20DCCN056  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (9, N'Tốt', N'N20DCDT001  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (10, N'Tốt', N'N20DCDT003  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (11, N'Xuất sắc', N'N20DCDT005  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (12, N'Xuất sắc', N'N20DCDT029  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (13, N'Xuất sắc', N'N20DCKT021  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (14, N'Xuất sắc', N'N20DCQT064  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (15, N'Tốt', N'N20DCVT062  ')
INSERT [dbo].[KhenThuong] ([IdKT], [DanhHieu], [MSSV]) VALUES (16, N'Tốt', N'N20DCVT111  ')
SET IDENTITY_INSERT [dbo].[KhenThuong] OFF
GO
INSERT [dbo].[Khoa] ([IdKhoa], [Ten]) VALUES (1, N'Công Nghệ Thông Tin')
INSERT [dbo].[Khoa] ([IdKhoa], [Ten]) VALUES (4, N'Điện Tử')
INSERT [dbo].[Khoa] ([IdKhoa], [Ten]) VALUES (2, N'Kế Toán')
INSERT [dbo].[Khoa] ([IdKhoa], [Ten]) VALUES (3, N'Marketing')
INSERT [dbo].[Khoa] ([IdKhoa], [Ten]) VALUES (5, N'Viễn Thông')
GO
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (1, N'25/57', N'0147852369', N'Hoàng Văn Phúc', 2, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (2, N'14/23/4', N'0123456789', N'Chu Đình Nghiêm', 3, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (3, N'2/6', N'0365412789', N'Lê Thị Lợi', 2, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (4, N'7', N'0258963147', N'Nguyễn Hoàng Mai', 1, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (5, N'73/6', N'0356321478', N'Lê Minh Bình', 1, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (6, N'233/47/1', N'0168147523', N'Trần Danh Trung', 2, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (7, N'33/14/7', N'0365221432', N'Lê Minh Trung', 2, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (8, N'14', N'0635221458', N'Đinh Lê Bảo Huy', 3, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (9, N'34/8', N'0365214785', N'Nguyễn Lê Vy', 3, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (10, N'5/21', N'0584123652', N'Kiều Phan', 2, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (11, N'3', N'0214995673', N'Đào Duy Tân', 3, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (12, N'143/25', N'0362514523', N'Đinh Xuân Việt', 4, 0)
INSERT [dbo].[NhaDan] ([IdNha], [SoNha], [SDT], [ChuHo], [IdAp], [TrangThai]) VALUES (13, N'14', N'0214258932', N'Trần Quang Bảy', 5, 0)
GO
INSERT [dbo].[NhomGV] ([IdNhom], [Ten], [IdXa]) VALUES (1, N'Nhóm 1', 1)
INSERT [dbo].[NhomGV] ([IdNhom], [Ten], [IdXa]) VALUES (2, N'Nhóm 2', 3)
INSERT [dbo].[NhomGV] ([IdNhom], [Ten], [IdXa]) VALUES (3, N'Nhóm 3', 4)
INSERT [dbo].[NhomGV] ([IdNhom], [Ten], [IdXa]) VALUES (4, N'Nhóm 4', 2)
INSERT [dbo].[NhomGV] ([IdNhom], [Ten], [IdXa]) VALUES (5, N'Nhóm 5', 11)
GO
INSERT [dbo].[NhomSV] ([IdNhom], [Ten], [IdNha]) VALUES (1, N'Nhóm 1', 1)
INSERT [dbo].[NhomSV] ([IdNhom], [Ten], [IdNha]) VALUES (2, N'Nhóm 2', 2)
INSERT [dbo].[NhomSV] ([IdNhom], [Ten], [IdNha]) VALUES (3, N'Nhóm 3', 3)
INSERT [dbo].[NhomSV] ([IdNhom], [Ten], [IdNha]) VALUES (4, N'Nhóm 4', 3)
INSERT [dbo].[NhomSV] ([IdNhom], [Ten], [IdNha]) VALUES (5, N'Nhóm 5', 2)
INSERT [dbo].[NhomSV] ([IdNhom], [Ten], [IdNha]) VALUES (6, N'Nhóm 6', 4)
GO
SET IDENTITY_INSERT [dbo].[PCCV] ON 

INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (2, CAST(N'2023-07-03' AS Date), N'Sang', 4, 1, 1, 1)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (3, CAST(N'2023-07-03' AS Date), N'Chieu', 10, 2, 1, 1)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (4, CAST(N'2023-07-03' AS Date), N'Sang', 8, 2, 2, 2)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (6, CAST(N'2023-07-03' AS Date), N'Sang', 10, 3, 3, 2)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (9, CAST(N'2023-07-03' AS Date), N'Chieu', 10, 3, 2, 2)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (10, CAST(N'2023-07-04' AS Date), N'Sang', 8, 4, 4, 3)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (11, CAST(N'2023-07-04' AS Date), N'Chieu', 6, 4, 3, 4)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (12, CAST(N'2023-07-03' AS Date), N'Sang', 10, 1, 4, 2)
INSERT [dbo].[PCCV] ([IdPC], [Ngay], [Buoi], [DanhGia], [IdCT], [IdNhomSV], [IdNhomGV]) VALUES (13, CAST(N'2023-07-05' AS Date), N'Sang', 10, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[PCCV] OFF
GO
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N17DCCN022  ', N'Đoàn', N'Văn Kiên', N'0325114789', N'n17dccn022@student.ptithcm.edu.vn                 ', NULL, 1, 1)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N18DCCN033  ', N'Trần', N'Thị Dung', N'0654123987', N'n18dccn033@student.ptithcm.edu.vn                 ', NULL, 1, 1)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N18DCDT024  ', N'Nguyễn', N'Đình Phong', N'0654154874', N'n18dcdt024@student.ptithcm.edu.vn                 ', NULL, 4, 2)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N18DCVT031  ', N'Cái', N'Đặng Bình Minh', N'0263521485', N'n18dcvt031@student.ptithcm.edu.vn                 ', NULL, 5, 3)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N19DCCN025  ', N'Trần', N'Thị Thu Trang', N'0365212365', N'n19dccn025@student.ptithcm.edu.vn                 ', NULL, 1, 4)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N19DCKT033  ', N'Nguyễn', N'Ngọc Anh Thư', N'0351472225', N'n19dckt033@student.ptithcm.edu.vn                 ', NULL, 2, 2)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N19DCQT120  ', N'Tạ', N'Đình Phước', N'0987214635', N'n19dcqt120@student.ptithcm.edu.vn                 ', NULL, 3, 4)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCCN056  ', N'Hoàng', N'Văn Phúc', N'0325987145', N'n20dccn056@student.ptithcm.edu.vn                 ', NULL, 1, 2)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCCN070  ', N'Đinh Văn', N'Ty', N'0347985274', N'n20dccn070@student.ptithcm.edu.vn                 ', NULL, 1, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCDT001  ', N'Thủy', N'Vân Anh', N'0534684846', N'n20dcdt001@student.ptithcm.edu.vn                 ', NULL, 4, 1)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCDT003  ', N'Lý', N'Hoàng Trâm Anh', N'0851366524', N'n20dcdt003@student.ptithcm.edu.vn                 ', NULL, 4, 3)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCDT005  ', N'Trần', N'Ngọc Thúy An', N'0246786435', N'n20dcdt005@student.ptithcm.edu.vn                 ', NULL, 4, 2)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCDT029  ', N'Hà', N'Lê', N'0551239746', N'n20dcdt029@student.ptithcm.edu.vn                 ', NULL, 4, 4)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCKT021  ', N'Lê', N'Ngọc Tuấn Kiệt', N'0259412365', N'n20dckt021@student.ptithcm.edu.vn                 ', NULL, 2, 4)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCQT064  ', N'Lê', N'Hoàng Minh', N'0152639847', N'n20dcqt064@student.ptithcm.edu.vn                 ', NULL, 3, 2)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCVT062  ', N'Trịnh', N'Thanh Bình', N'0365221445', N'n20dcvt062@student.ptithcm.edu.vn                 ', NULL, 5, 3)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N20DCVT111  ', N'Đào', N'Ngọc Kiên', N'0152468233', N'n20dcvt111@student.ptithcm.edu.vn                 ', NULL, 5, 1)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N21DCCN032  ', N'Châu', N'Đoàn Phát', N'0369544128', N'n21dccn032@student.ptithcm.edu.vn                 ', NULL, 1, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N21DCDT012  ', N'Phạm', N'Nguyễn Hải Trường', N'0632145879', N'n21dcdt012@student.ptithcm.edu.vn                 ', NULL, 4, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N21DCKT001  ', N'Phạm', N'Hoàng Mạnh', N'0321589647', N'n21dckt001@student.ptithcm.edu.vn                 ', NULL, 2, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N21DCQT002  ', N'Trần', N'Khánh Linh', N'0326987444', N'n21dcqt002@student.ptithcm.edu.vn                 ', NULL, 3, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N21DCVT021  ', N'Nguyễn', N'Thanh Nhàn', N'0321554899', N'n21dcvt021@student.ptithcm.edu.vn                 ', NULL, 5, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N21DCVT055  ', N'Lý', N'Hồng Phúc', N'0352146289', N'n21dcvt055@student.ptithcm.edu.vn                 ', NULL, 5, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N22DCCN111  ', N'Lê', N'Văn Phúc', N'0741598236', N'n22dccn111@student.ptithcm.edu.vn                 ', NULL, 1, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N22DCDT033  ', N'Phan', N'Văn Đức', N'0963122478', N'n22dcdt033@student.ptithcm.edu.vn                 ', NULL, 4, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N22DCKT001  ', N'Nguyễn', N'Hoàng Anh', N'0352147859', N'n22dckt001@student.ptithcm.edu.vn                 ', NULL, 2, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N22DCQT022  ', N'Ngô', N'Quang Sang', N'0658932147', N'n22dcqt022@student.ptithcm.edu.vn                 ', NULL, 3, NULL)
INSERT [dbo].[SinhVien] ([MSSV], [Ho], [Ten], [SDT], [Email], [ChucVu], [IdKhoa], [IdNhomSV]) VALUES (N'N22DCVT009  ', N'Ngô', N'Minh Đức', N'0587493332', N'n22dcvt009@student.ptithcm.edu.vn                 ', NULL, 5, NULL)
GO
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (1, N'Phường Phúc Xá', 1)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (2, N'Phường Trúc Bạch', 1)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (3, N'Phường Cống Vị', 1)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (4, N'Phường Liễu Giai', 1)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (5, N'Phường Nguyễn Trung Trực', 1)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (6, N'Phường Quán Thánh', 1)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (7, N'Phường Phúc Tân', 2)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (8, N'Phường Đồng Xuân', 2)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (9, N'Phường Hàng Mã', 2)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (10, N'Phường Hàng Buồm', 2)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (11, N'Phường Phú Thượng', 3)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (12, N'Phường Nhật Tân', 3)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (13, N'Phường Tứ Liên', 3)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (14, N'Phường Quảng An', 3)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (13384, N'Thị trấn Quế', 350)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (14560, N'Thị trấn Yên Ninh', 375)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (19774, N'Phường Kim Long', 474)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (30049, N'Xã Tân Kiều', 872)
INSERT [dbo].[Xa] ([IdXa], [Ten], [IdDB]) VALUES (30055, N'Xã Mỹ Quý', 872)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_CongViec_Ten]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[CongViec] ADD  CONSTRAINT [UC_CongViec_Ten] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_CTCV_IdCV_IdAp]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[CTCV] ADD  CONSTRAINT [UC_CTCV_IdCV_IdAp] UNIQUE NONCLUSTERED 
(
	[IdCV] ASC,
	[IdAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhenThuo__6CB3B7F8CAC60ACF]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[KhenThuong] ADD  CONSTRAINT [UQ__KhenThuo__6CB3B7F8CAC60ACF] UNIQUE NONCLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Khoa__C451FA837F999240]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[Khoa] ADD UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_NhomGV_Ten]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[NhomGV] ADD  CONSTRAINT [UC_NhomGV_Ten] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_NhomGV_Xa]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[NhomGV] ADD  CONSTRAINT [UC_NhomGV_Xa] UNIQUE NONCLUSTERED 
(
	[IdXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_NhomSV_Ten]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[NhomSV] ADD  CONSTRAINT [UC_NhomSV_Ten] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_PCCV_Ngay_Buoi_IdNhomSV]    Script Date: 7/16/2023 7:16:04 PM ******/
ALTER TABLE [dbo].[PCCV] ADD  CONSTRAINT [UC_PCCV_Ngay_Buoi_IdNhomSV] UNIQUE NONCLUSTERED 
(
	[Ngay] ASC,
	[Buoi] ASC,
	[IdNhomSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CongViec] ADD  DEFAULT ((1)) FOR [KhoiLuong]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [public]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [sysadmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [securityadmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [serveradmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [setupadmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [processadmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [diskadmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [dbcreator]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [bulkadmin]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_ServerStateReader##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_ServerStateManager##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_DefinitionReader##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_DatabaseConnector##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_DatabaseManager##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_LoginManager##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_SecurityDefinitionReader##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_PerformanceDefinitionReader]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_ServerSecurityStateReader##]
GO
ALTER TABLE [dbo].[DBA_Logins] ADD  DEFAULT ((0)) FOR [##MS_ServerPerformanceStateReade]
GO
ALTER TABLE [dbo].[NhaDan] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[Ap]  WITH CHECK ADD FOREIGN KEY([IdXa])
REFERENCES [dbo].[Xa] ([IdXa])
GO
ALTER TABLE [dbo].[CTCV]  WITH CHECK ADD FOREIGN KEY([IdAp])
REFERENCES [dbo].[Ap] ([IdAp])
GO
ALTER TABLE [dbo].[CTCV]  WITH CHECK ADD FOREIGN KEY([IdCV])
REFERENCES [dbo].[CongViec] ([IdCV])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([IdKhoa])
REFERENCES [dbo].[Khoa] ([IdKhoa])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([IdNhomGV])
REFERENCES [dbo].[NhomGV] ([IdNhom])
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK__KhenThuong__MSSV__5CD6CB2B] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SinhVien] ([MSSV])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK__KhenThuong__MSSV__5CD6CB2B]
GO
ALTER TABLE [dbo].[NhaDan]  WITH CHECK ADD FOREIGN KEY([IdAp])
REFERENCES [dbo].[Ap] ([IdAp])
GO
ALTER TABLE [dbo].[NhomGV]  WITH CHECK ADD FOREIGN KEY([IdXa])
REFERENCES [dbo].[Xa] ([IdXa])
GO
ALTER TABLE [dbo].[NhomSV]  WITH CHECK ADD FOREIGN KEY([IdNha])
REFERENCES [dbo].[NhaDan] ([IdNha])
GO
ALTER TABLE [dbo].[PCCV]  WITH CHECK ADD  CONSTRAINT [FK__PCCV__IdCT__60A75C0F] FOREIGN KEY([IdCT])
REFERENCES [dbo].[CTCV] ([IdCT])
GO
ALTER TABLE [dbo].[PCCV] CHECK CONSTRAINT [FK__PCCV__IdCT__60A75C0F]
GO
ALTER TABLE [dbo].[PCCV]  WITH CHECK ADD  CONSTRAINT [FK__PCCV__IdNhomGV__619B8048] FOREIGN KEY([IdNhomGV])
REFERENCES [dbo].[NhomGV] ([IdNhom])
GO
ALTER TABLE [dbo].[PCCV] CHECK CONSTRAINT [FK__PCCV__IdNhomGV__619B8048]
GO
ALTER TABLE [dbo].[PCCV]  WITH CHECK ADD  CONSTRAINT [FK__PCCV__IdNhomSV__628FA481] FOREIGN KEY([IdNhomSV])
REFERENCES [dbo].[NhomSV] ([IdNhom])
GO
ALTER TABLE [dbo].[PCCV] CHECK CONSTRAINT [FK__PCCV__IdNhomSV__628FA481]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([IdKhoa])
REFERENCES [dbo].[Khoa] ([IdKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([IdNhomSV])
REFERENCES [dbo].[NhomSV] ([IdNhom])
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD FOREIGN KEY([IdDB])
REFERENCES [dbo].[DiaBan] ([IdDB])
GO
ALTER TABLE [dbo].[PCCV]  WITH CHECK ADD  CONSTRAINT [CK__PCCV__DanhGia__66603565] CHECK  (([DanhGia]>=(1) AND [DanhGia]<=(10)))
GO
ALTER TABLE [dbo].[PCCV] CHECK CONSTRAINT [CK__PCCV__DanhGia__66603565]
GO
/****** Object:  StoredProcedure [dbo].[GetLoginsData]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetLoginsData]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @role       NVARCHAR(32)
	DECLARE @login      NVARCHAR(64)
	DECLARE @sqlCommand NVARCHAR(MAX)

	DROP TABLE IF EXISTS DBA_Logins

	SET @sqlCommand = '
	CREATE TABLE DBA_Logins(
		[login]	  NVARCHAR(64) NOT NULL,
		[created_date] DATETIME NOT NULL,
		[is_disabled]  BIT NOT NULL,
		[login_type]   NVARCHAR(13)
		'

	DECLARE roles_cursor CURSOR FOR 
	SELECT name
	FROM sys.server_principals
	WHERE type = 'R'

	OPEN roles_cursor

	FETCH NEXT FROM roles_cursor INTO @role

	WHILE @@FETCH_STATUS = 0   
	BEGIN  
		SET @sqlCommand += ',['+@role+'] BIT DEFAULT 0 NOT NULL'
		
		FETCH NEXT FROM roles_cursor INTO @role 
	END 

	SET @sqlCommand += ',[data_collection_timestamp] DATETIME NOT NULL)'

	CLOSE roles_cursor  

	DEALLOCATE roles_cursor

	EXEC(@sqlCommand)

	INSERT INTO DBA_Logins ([login],[created_date],[is_disabled],[login_type],[public],[data_collection_timestamp])
	SELECT [name],[create_date],[is_disabled],[type_desc],1,GETDATE()
	FROM sys.server_principals
	WHERE type IN ('S','U') AND ([name] NOT LIKE '%##MS_%' AND [name] NOT LIKE '%NT %')

	DECLARE roles_cursor CURSOR FOR 
	SELECT    sp.name,ISNULL(SUSER_NAME(srm.role_principal_id),'public') AS 'server_role'
    FROM      sys.server_principals sp
    LEFT JOIN sys.server_role_members srm ON sp.name = SUSER_NAME(srm.member_principal_id)
    WHERE     sp.type IN ('S','U') AND (sp.[name] NOT LIKE '%##MS_%' AND sp.[name] NOT LIKE '%NT %')

	OPEN roles_cursor

	FETCH NEXT FROM roles_cursor INTO @login,@role

	WHILE @@FETCH_STATUS = 0   
	BEGIN  
		SET @sqlCommand = '
		UPDATE DBA_Logins SET ['+@role+'] = 1 WHERE [login] = '+CHAR(39)+@login+CHAR(39)+'
		'
		EXEC(@sqlCommand)

		FETCH NEXT FROM roles_cursor INTO @login,@role
	END 

	CLOSE roles_cursor  

	DEALLOCATE roles_cursor
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP_GV]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP_GV]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
if @TENUSER Like 'n__dc%'
begin 
 SELECT USERNAME = @TENUSER, 
   HOTEN = (SELECT HO + ' '+ TEN FROM SinhVien WHERE MSSV = @TENUSER),
   TENNHOM = NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
end;
else 
begin 
SELECT USERNAME = @TENUSER, 
   HOTEN = (SELECT Ho + ' '+ Ten FROM GiangVien WHERE IdGV = @TENUSER),
   TENNHOM = NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

end;
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_account]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_account] @username NVARCHAR(10), @login_name NVARCHAR(15)
AS
BEGIN
	DECLARE @sql1 NVARCHAR(MAX)
	DECLARE @sql2 NVARCHAR(MAX)

	SET @sql1 = N'DROP USER ' + QUOTENAME(TRIM(@username))
	SET @sql2 = N'DROP LOGIN ' + QUOTENAME(TRIM(@login_name))

	IF NOT EXISTS (SELECT * FROM sys.sysusers WHERE name = TRIM(@username)) RETURN

	EXEC sp_executesql @sql1
	EXEC sp_executesql @sql2
END
GO
/****** Object:  StoredProcedure [dbo].[sp_differentialbackup]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_differentialbackup] (@path varchar(1000),@filename varchar(100))
as  
begin  
set @path = @path+'\' + @filename + '.dif';  
BEGIN TRY
	BACKUP DATABASE MUAHEXANH to DISK=@path
	WITH DIFFERENTIAL 
END TRY
BEGIN CATCH
	RETURN -1;
END CATCH
end  
GO
/****** Object:  StoredProcedure [dbo].[sp_fullbackup]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_fullbackup] (@path varchar(1000),@filename varchar(100))
as  
begin  
set @path = @path+'\' + @filename + '.bak';  
BEGIN TRY
	BACKUP DATABASE MUAHEXANH to DISK=@path; 
END TRY
BEGIN CATCH
	RETURN -1;
END CATCH
end  
GO
/****** Object:  StoredProcedure [dbo].[sp_getlogins]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getlogins]
as
	EXEC GetLoginsData
	SELECT login,username=NAME,created_date,is_disabled FROM DBA_Logins,sys.sysusers
	where sysadmin='0' and login != 'htkn' and sid = SUSER_SID(login)


GO
/****** Object:  StoredProcedure [dbo].[sp_khenthuong_sv]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--view 
-- Danh sách sinh viên có điểm trung bình đánh giá >= 7 
-- Danh sách sinh viên này sẽ được ghi nhận khen thưởng.
CREATE proc [dbo].[sp_khenthuong_sv] AS 
begin
IF object_id('tempdb.dbo.#KhenThuong') is null
begin
create table #KhenThuong(
	MSSV Nchar(12),
	HoTen nvarchar(50),
	TenKhoa nvarchar(50),
	SoLuongViec int,
	TongDiemDG int,
	XepLoai nvarchar(10)
)
end
truncate table #KhenThuong
insert into #KhenThuong
	select sv.MSSV,HoTen=sv.ho +' '+sv.Ten, khoa.Ten TenKhoa,SoLuongViec, DG as TongDiemDG, 
	case
		when DG/SoLuongViec = 9 or DG/SoLuongViec = 10 then N'Xuất sắc'
		when DG/SoLuongViec = 8 then N'Tốt'
	else N'Khá'
	end as XepLoai
	from SinhVien as sv,(
SElECT IdNhomSV,COUNT(IdNhomSv) as SoLuongViec, SUm(PCCV.DanhGia) as DG
FROM PCCV
group by IdNhomSV
HAVING SUM(PCCV.DanhGia)/COUNT(IdNhomSv) >= 7
) as T,Khoa
where sv.IdNhomSV = T.IdNhomSV and sv.IdKhoa = Khoa.IdKhoa 
order by DG/SoLuongViec DESC
select * from #KhenThuong order by TongDiemDG/SoLuongViec DESC
begin tran
begin try
	truncate table KhenThuong
	insert into KhenThuong (DanhHieu,MSSV)
	select XepLoai,MSSV from #KhenThuong
	COMMIT TRAN
end try
begin catch 
	rollback tran
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_kiem_tra_idcv_trung]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CReate proc [dbo].[sp_kiem_tra_idcv_trung](@idcv int)
as
begin
	select IdCV from CongViec where IdCV = @idcv
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ap_cong_viec]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_ap_cong_viec]
@IdCV int
as
begin
	select IdCT, Ap.Ten, tenxa=xa.Ten, tendiaban = diaban.Ten
	from xa, diaban,
	(select IdCT, Ap.Ten, IdXa
	from CTCV, Ap
	where ctcv.IdCV = @IdCV
	and ctcv.IdAp=Ap.IdAp) ap
	where ap.IdXa = xa.IdXa and diaban.IdDB = xa.IdDB
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_chua_pccv_theo_idct_ngay_buoi]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_chua_pccv_theo_idct_ngay_buoi](@idct int, @ngay date, @buoi nvarchar(10), @idxa int)
as
begin
	select IdNhom, Ten, SoNha from NhomSV, NhaDan 
	where IdNhom not in
	(select IdNhomSV from pccv where IdCT = @idct and Ngay = @ngay and Buoi = @buoi) and NhomSV.IdNha = NhaDan.IdNha
	and NhaDan.IdNha in (select IdNha from NhaDan where idap in
	(select idap from Ap where IdXa = @idxa))
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ctcv_theomacv]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_ctcv_theomacv]
@IdCV int
as
begin
select IdCT, NgayBD, NgayKT, Ten from CTCV, ap where IdCV  = @IdCV and ctcv.IdAp = ap.IdAp
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ds_nhom_chua_co_viec]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_ds_nhom_chua_co_viec]
@IdCT int, @Buoi nvarchar(10), @Ngay date
as
begin

SELECT IdNhom
from NhomSV  where IdNhom not in (select IdNhomSV
FROM PCCV WHERE PCCV.IdCT  = @IdCT and PCCV.Buoi=@Buoi AND PCCV.Ngay=@Ngay )
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ds_nhom_da_co_viec]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_ds_nhom_da_co_viec]
@IdCT int, @Buoi nvarchar(10), @Ngay date
as
begin

 select IdNhomSV
FROM PCCV WHERE PCCV.IdCT  = @IdCT and PCCV.Buoi=@Buoi AND PCCV.Ngay=@Ngay 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_idCT]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_idCT]
@IdCV int
as
begin
select IdCT
from CTCV
where ctcv.IdCV = @IdCV

end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_pccv_theo_idct_ngay_buoi]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_pccv_theo_idct_ngay_buoi](@idct int, @ngay date, @buoi nvarchar(10))
as
begin
	--declare @ngaybd date, @ngaykt date
	--select @ngaybd = NgayBD, @ngaykt= NgayKT from CTCV where IdCT = @idct
	--if (@ngay < @ngaybd or @ngay > @ngaykt)
	--begin
	--	declare @message nvarchar(100) = N'Ngày phân công phải nằm phạm vi từ ngày ' + CONVERT(nvarchar(10), @ngaybd, 103)+ N' đến ngày ' +  CONVERT(nvarchar(10), @ngaykt, 103)
	--	raiserror(@message,16,1)
	--	return
	--end
		
	select IdNhom, Ten, SoNha from NhomSV, NhaDan 
	where IdNhom in
	(select IdNhomSV from pccv where IdCT = @idct and Ngay = @ngay and Buoi = @buoi) and NhomSV.IdNha = NhaDan.IdNha
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_tenxa_tendiaban]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_lay_tenxa_tendiaban]
@IdGV nchar(12)
as
begin
select Xa.IdXa, Xa.Ten as TenXa, Xa.IdDB, DiaBan.Ten as TenDB
from Xa, DiaBan,NhomGV
where nhomGV.IdNhom= (select IdNhomGV from GiangVien where GiangVien.IdGV=@IdGV)
and NhomGV.IdXa=Xa.IdXa
and DiaBan.IdDB=Xa.IdDB

end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_xa_dia_ban]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_xa_dia_ban]
@IdGV nchar(12)
as
begin
select Ap.Ten as TenAp, Ap.IdAp, Xa.IdXa, Xa.Ten as TenXa, Xa.IdDB, DiaBan.Ten as TenDB
from Xa, DiaBan,NhomGV,Ap
where nhomGV.IdNhom= (select IdNhomGV from GiangVien where GiangVien.IdGV=@IdGV)
and NhomGV.IdXa=Xa.IdXa
and DiaBan.IdDB=Xa.IdDB 
end

GO
/****** Object:  StoredProcedure [dbo].[SP_NHADAN]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_NHADAN]
@IdGV NCHAR(12)
AS
BEGIN
	declare @idxa int
	select @idxa = (select IdXa from NhomGV where IdNhom = (select IdNhomGV from GiangVien where IdGV = @IdGV))

	select IdNha, ThongTin = ChuHo + ' - ' +  SDT
	from NhaDan where IdAp IN (Select IdAp from Xa where IdXa = @idxa) and TrangThai = 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'MUAHEXANH'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'GiamSat' 
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[sp_xephang_sv]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_xephang_sv]
AS
select sv.MSSV,hoten=sv.ho +' '+sv.Ten, khoa.Ten TenKhoa,SoLuongViec
from SinhVien as sv,(
SElect IdNhomSV,COUNT(IdNhomSv) as SoLuongViec
FROM PCCV
group by IdNhomSV) as T,Khoa
where sv.IdNhomSV = T.IdNhomSV and sv.IdKhoa = Khoa.IdKhoa
order by SoLuongViec DESC

GO
/****** Object:  Trigger [dbo].[trg_themCongViec]    Script Date: 7/16/2023 7:16:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_themCongViec] on [dbo].[CongViec]
instead of insert
as
begin
	declare @idcv int = (select max(idcv) from CongViec)
	set @idcv += 1
	insert into CongViec
	select @idcv, Ten, ThoiGian, KhoiLuong from inserted
end
GO
ALTER TABLE [dbo].[CongViec] ENABLE TRIGGER [trg_themCongViec]
GO
/****** Object:  Trigger [dbo].[after_GiangVien_update]    Script Date: 7/16/2023 7:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CReate TRIGGER [dbo].[after_GiangVien_update] ON [dbo].[GiangVien] AFTER UPDATE
AS
BEGIN
	DECLARE @username NCHAR(10)
	DECLARE @login_name NCHAR(15)
	DECLARE @cv1 NVARCHAR(20)
	DECLARE @cv2 NVARCHAR(20)

	SET @cv1 = (SELECT ChucVu FROM inserted)
	SET @cv2 = (SELECT ChucVu FROM deleted)

	IF (ISNULL(@cv1, '') <> ISNULL(@cv2, ''))
		IF (@cv1 LIKE N'Đội%' AND @cv2 LIKE N'Đội%')
			RETURN
		ELSE
			PRINT('DELETE')
	ELSE
		RETURN
	
	SET @username = (SELECT IdGV FROM inserted)

	SET @login_name = (SELECT sys.syslogins.name from sys.sysusers
						join sys.syslogins
						on sys.sysusers.sid = sys.syslogins.sid
						where sys.sysusers.name = @username)
	
	SELECT @username, @login_name

	EXEC sp_delete_account @username, @login_name
END
GO
ALTER TABLE [dbo].[GiangVien] ENABLE TRIGGER [after_GiangVien_update]
GO
/****** Object:  Trigger [dbo].[lay_ngay_lam_viec]    Script Date: 7/16/2023 7:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[lay_ngay_lam_viec] 
   ON  [dbo].[PCCV]
   for insert  

 as
	IF @@ROWCOUNT = 0 
		RETURN
	declare @ngaybd date, @ngaykt date, @ngay date
   select @ngaybd = NgayBD, @ngaykt= NgayKT from CTCV, inserted  where ctcv.IdCT =inserted.IdCT
   select @ngay=Ngay  from inserted
	if (@ngay < @ngaybd or @ngay > @ngaykt)
	begin
		declare @message nvarchar(100) = N'Ngày phân công phải nằm phạm vi từ ngày ' + CONVERT(nvarchar(10), @ngaybd, 103)+ N' đến ngày ' +  CONVERT(nvarchar(10), @ngaykt, 103)
			raiserror(@message,16,1)
			ROLLBACK TRANSACTION;  
			return
	end
GO
ALTER TABLE [dbo].[PCCV] ENABLE TRIGGER [lay_ngay_lam_viec]
GO
/****** Object:  Trigger [dbo].[trg_kiemTraNgayPhanCong]    Script Date: 7/16/2023 7:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_kiemTraNgayPhanCong] on [dbo].[PCCV]
for insert
as
begin
	declare @ngaybd date, @ngaykt date, @ngay date
	select @ngaybd = ct.NgayBD, @ngaykt = ct.NgayKT, @ngay = Ngay from inserted, CTCV ct where inserted.IdCT = ct.IdCT
	if (@ngay < @ngaybd or @ngay > @ngaykt)
	begin
		declare @cmd nvarchar(max) = N'Ngày phân công phải nằm trong phạm vi từ ngày ' + CONVERT(nvarchar(10),@ngaybd,103) + N' đến ngày ' +  CONVERT(nvarchar(10),@ngaykt,103)
		--print @cmd
		raiserror(@cmd,16,1)
		rollback
		return
	end
end
GO
ALTER TABLE [dbo].[PCCV] ENABLE TRIGGER [trg_kiemTraNgayPhanCong]
GO
