USE [master]
GO
/****** Object:  Database [QuanLyNhaSach]    Script Date: 08-Dec-20 10:53:42 AM ******/
CREATE DATABASE [QuanLyNhaSachV2] 
GO
USE [QuanLyNhaSachV2]
GO

/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaSach] [char](10) NOT NULL,
	[MaHD] [char](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_SachHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GianHang]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GianHang](
	[MaGH] [char](10) NOT NULL,
	[TenGH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_GianHang] PRIMARY KEY CLUSTERED 
(
	[MaGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[NgayXuatHoaDon] [date] NULL,
	[TongTien] [float] NULL,
	[LoaiHoaDon] [nvarchar](30) NULL,
	[MaNV] [char](10) NOT NULL,
	[MaKH] [char](10) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NamSinh] [date] NULL,
	[DoiTuong] [nvarchar](30) NULL,
	[SDT] [char](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](10) NOT NULL,
	[TenNXB] [nvarchar](50) NOT NULL,
	[SDT] [char](10) NOT NULL,
	[SoFax] [char](10) NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[CMND] [char](12) NULL,
	[SDT] [char](13) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaGH] [char](10) NULL,
	[MaQL] [char](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[TheLoai] [nvarchar](30) NULL,
	[GiaBan] [float] NULL,
	[TenNXB] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[NgayXuatBan] [date] NULL,
	[NgayNhap] [date] NULL,
	[GiamGia] [int] NULL,
	[MaNV] [char](10) NOT NULL,
	[MaGH] [char](10) NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 08-Dec-20 10:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_SachHoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_HoaDon_SachHoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Sach_SachHoaDon] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_Sach_SachHoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_HoaDon] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KhachHang_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_HoaDon] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_NhanVien_HoaDon]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_GianHang_NhanVien] FOREIGN KEY([MaGH])
REFERENCES [dbo].[GianHang] ([MaGH])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_GianHang_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_QuanLy_NhanVien] FOREIGN KEY([MaQL])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_QuanLy_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_GianHang_Sach] FOREIGN KEY([MaGH])
REFERENCES [dbo].[GianHang] ([MaGH])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_GianHang_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Sach] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_NhanVien_Sach]
GO

CREATE TABLE PhieuNhap(
	MaPN char(10) primary key constraint PK_MaPN not null,
	MaNV char(10) not null constraint FK_NhanVien_PhieuNhap foreign key (MaNV) references NhanVien(MaNV) ,
	MaSach char(10) not null constraint FK_Sach_PhieuNhap foreign key (MaSach) references Sach(MaSach),
	MaNCC char(10) not null constraint FK_NhaCungCap_PhieuNhap foreign key (MaNCC) references NhaCungCap(MaNCC),
	SoLuong int not null,
	NgayNhap date not null,
	GiaNhap int ,
	TheLoai char(10) not null
)
GO


--use _Tempt
--Drop database QuanLyNhaSachV2
