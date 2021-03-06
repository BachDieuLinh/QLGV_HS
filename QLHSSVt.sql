USE [master]
GO
/****** Object:  Database [QLY_GV_HS]    Script Date: 12/04/2015 08:46:03 ******/
CREATE DATABASE [QLY_GV_HS] ON  PRIMARY 
( NAME = N'QlyHocSInh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QlyHocSInh.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QlyHocSInh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QlyHocSInh_log.ldf' , SIZE = 5120KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLY_GV_HS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLY_GV_HS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLY_GV_HS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLY_GV_HS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLY_GV_HS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLY_GV_HS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLY_GV_HS] SET ARITHABORT OFF
GO
ALTER DATABASE [QLY_GV_HS] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QLY_GV_HS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLY_GV_HS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLY_GV_HS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLY_GV_HS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLY_GV_HS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLY_GV_HS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLY_GV_HS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLY_GV_HS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLY_GV_HS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLY_GV_HS] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLY_GV_HS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLY_GV_HS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLY_GV_HS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLY_GV_HS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLY_GV_HS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLY_GV_HS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLY_GV_HS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLY_GV_HS] SET  READ_WRITE
GO
ALTER DATABASE [QLY_GV_HS] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLY_GV_HS] SET  MULTI_USER
GO
ALTER DATABASE [QLY_GV_HS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLY_GV_HS] SET DB_CHAINING OFF
GO
USE [QLY_GV_HS]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 12/04/2015 08:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](10) NOT NULL,
	[TENMH] [nvarchar](50) NULL,
 CONSTRAINT [MH_MAMH_PK] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/04/2015 08:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [char](10) NOT NULL,
	[TENLOP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Show_Lop]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TTGD_Show_Lop] 
as
begin
	select MALOP, TENLOP from LOP
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Del_GV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TTGD_Del_GV]  @maLOP char(10),@maGV char(10)
as
begin
	delete from LOP where MALOP=@maLOP and GV=@maGV
end
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MAHS] [char](10) NOT NULL,
	[TENHS] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[GT] [varchar](3) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[MALOP] [char](10) NULL,
 CONSTRAINT [HS_MAHS_PK] PRIMARY KEY CLUSTERED 
(
	[MAHS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MAGV] [char](10) NOT NULL,
	[TENGV] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[GT] [varchar](3) NOT NULL,
	[SDT] [varchar](11) NULL,
	[LUONG] [int] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[MAMH] [char](10) NULL,
	[TENDN] [nvarchar](50) NULL,
	[MATKHAU] [varchar](10) NULL,
 CONSTRAINT [GV_MAGV_PK] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[HS_Upd]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HS_Upd] @maHS char(10),@tenHS nvarchar(50), @ns date, @gt char(3), @diachi nvarchar(50), @maLOP char(10)
as
begin
	update HOCSINH
	set  TENHS=@tenHS,NS=@ns,GT=@gt, DIACHI=@diachi, MALOP=@maLOP
	where  MAHS=@maHS
end
GO
/****** Object:  StoredProcedure [dbo].[HS_Show]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HS_Show]
as
begin
	select * from HOCSINH
end
GO
/****** Object:  StoredProcedure [dbo].[HS_Sea_TenHS]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HS_Sea_TenHS] @tenHS char(10)
as
begin
	select * from HOCSINH where TENHS like N'%'+ @tenHS+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[HS_Sea_MaHS]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HS_Sea_MaHS] @maHS char(10)
as
begin
	select * from HOCSINH where MAHS=@maHS
end
GO
/****** Object:  StoredProcedure [dbo].[HS_Ins]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HS_Ins] @tenHS nvarchar(50), @ns date, @gt char(3), @diachi nvarchar(50), @maLOP char(10)
AS 
BEGIN
	DECLARE @maHS char(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MAHS FROM HOCSINH
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @maHS
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@maHS, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@maHS, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @maHS
END

DECLARE @cdai int
DECLARE @i int
SET @mahs = CAST((@sott + 1) as char(8))
SET @cdai = LEN(@maHS)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @maHS = '0' + @maHS
	SET @i = @i + 1
END
SET @maHS = 'HS' + @maHS

INSERT INTO HOCSINH values (@maHS,@tenHS,@ns,@gt,@diachi,@maLOP)
SELECT @maHS
CLOSE contro
DEALLOCATE contro
END
GO
/****** Object:  StoredProcedure [dbo].[HS_Del]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HS_Del] @maHS char(10)
as
begin
	delete from HOCSINH where MAHS=@maHS
end
GO
/****** Object:  Table [dbo].[GIANGDAY]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIANGDAY](
	[MALOP] [char](10) NOT NULL,
	[MAGV] [char](10) NOT NULL,
 CONSTRAINT [PK_GIANGDAY] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC,
	[MALOP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[GV_Upd]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GV_Upd] @maGV char(10),@tenGV nvarchar(50), @ns date, @gt char(3), @sdt int, @luong int,  @diachi nvarchar(50),@maMH char(10), @tendn nvarchar(50), @mk varchar(10)
as
begin
	update GIAOVIEN
	set TENGV=@tenGV, NS=@ns, GT=@gt, SDT=@sdt, LUONG=@luong, DIACHI=@diachi, MAMH=@maMH, TENDN=@tendn, MATKHAU=@mk
	where MAGV=@maGV
end
GO
/****** Object:  StoredProcedure [dbo].[GV_Show]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Show]
as
begin
	select * from GIAOVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[GV_Sea_TenGV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Sea_TenGV] @tenGV char(10)
as
begin
	select * from GIAOVIEN where TENGV like N'%'+ @tenGV+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[GV_Sea_MaGV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Sea_MaGV] @maGV char(10)
as
begin
	select * from GIAOVIEN where MAGV=@maGV
end
GO
/****** Object:  StoredProcedure [dbo].[GV_Ins]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GV_Ins] @tenGV nvarchar(50), @ns date, @gt varchar(3), @sdt varchar(11), @luong int,  @diachi nvarchar(50),@maMH char(10), @tendn nvarchar(50), @mk varchar(10)
AS 
BEGIN
	DECLARE @maGV char(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MAGV FROM GIAOVIEN
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @maGV
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@maGV, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@maGV, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @maGV
END

DECLARE @cdai int
DECLARE @i int
SET @maGV = CAST((@sott + 1) as char(8))
SET @cdai = LEN(@maGV)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @maGV = '0' + @maGV
	SET @i = @i + 1
END
SET @maGV = 'GV' + @maGV

INSERT INTO GIAOVIEN values ( @maGV,@tenGV,@ns,@gt,@sdt,@luong,@diachi,@maMH,@tendn,@mk)
SELECT @maGV
CLOSE contro
DEALLOCATE contro
END
GO
/****** Object:  StoredProcedure [dbo].[GV_Del]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Del] @maGV char(10)
as
begin
	delete from GIAOVIEN where MAGV=@maGV
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Del_HS]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TTGD_Del_HS]  @maLOP char(10),@maHS char(10)
as
begin
	delete from HOCSINH where MALOP=@maLOP and MAHS=@maHS
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Show_checkGV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TTGD_Show_checkGV] 
as
begin
	select MAGV, TENGV from GIAOVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Ins_HS]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TTGD_Ins_HS] (@tenHS nvarchar(50), @ns date, @gt varchar(3), @diachi nvarchar(50),@maLOP char(10))
as
BEGIN
DECLARE @maHS char(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MAHS FROM HOCSINH
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @maHS
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@maHS, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@maHS, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @maHS
END

DECLARE @cdai int
DECLARE @i int
SET @maHS = CAST((@sott + 1) as char(8))
SET @cdai = LEN(@maHS)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @maHS = '0' + @maHS
	SET @i = @i + 1
END
SET @maHS = 'HS' + @maHS

INSERT INTO HOCSINH values (@maHS,@tenHS,@ns,@gt,@diachi,@maLOP)
SELECT @maHS
CLOSE contro
DEALLOCATE contro
END
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Show_HS]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TTGD_Show_HS] @maLop char(10)
as
begin
	select h.MAHS,h.TENHS, h.NS from LOP l, HOCSINH h where l.MALOP=h.MALOP and l.MALOP=@maLop
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Upd_GV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TTGD_Upd_GV] @maLOP varchar(10),@maGV char(10)
as
begin
	update GIANGDAY
	set MAGV=@maGV
	where MALOP=@maLOP
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Show_GV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TTGD_Show_GV] @maLop char(10)
as
begin
	select l.MALOP,l.TENLOP,gv.MAGV,gv.TENGV from LOP l,GIAOVIEN gv,GIANGDAY gg
	where gg.MAGV=gv.MAGV and gg.MALOP=l.MALOP and gg.MALOP=@maLop 
end
GO
/****** Object:  StoredProcedure [dbo].[TTGD_Ins_GV]    Script Date: 12/04/2015 08:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TTGD_Ins_GV] @maLOP char(10) , @maGV char(10)
as
begin
		insert into GIANGDAY
		values (@maLOP ,@maGV)
end
GO
/****** Object:  Check [HS_GT_CHK]    Script Date: 12/04/2015 08:46:05 ******/
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [HS_GT_CHK] CHECK  (([GT]='NU' OR [GT]='NAM'))
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [HS_GT_CHK]
GO
/****** Object:  Check [GV_GT_CHK]    Script Date: 12/04/2015 08:46:05 ******/
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [GV_GT_CHK] CHECK  (([GT]='NU' OR [GT]='NAM'))
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [GV_GT_CHK]
GO
/****** Object:  ForeignKey [FK_HOCSINH_LOP]    Script Date: 12/04/2015 08:46:05 ******/
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [FK_HOCSINH_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [FK_HOCSINH_LOP]
GO
/****** Object:  ForeignKey [FK_GIAOVIEN_MONHOC]    Script Date: 12/04/2015 08:46:05 ******/
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIAOVIEN_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [FK_GIAOVIEN_MONHOC]
GO
/****** Object:  ForeignKey [FK_GIANGDAY_GIAOVIEN1]    Script Date: 12/04/2015 08:46:05 ******/
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_GIANGDAY_GIAOVIEN1] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GIANGDAY] CHECK CONSTRAINT [FK_GIANGDAY_GIAOVIEN1]
GO
/****** Object:  ForeignKey [FK_GIANGDAY_LOP1]    Script Date: 12/04/2015 08:46:05 ******/
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_GIANGDAY_LOP1] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[GIANGDAY] CHECK CONSTRAINT [FK_GIANGDAY_LOP1]
GO
