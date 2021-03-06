USE [DbAnVatShop]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[MaBanner] [int] IDENTITY(1,1) NOT NULL,
	[UrlBanner] [nvarchar](max) NULL,
	[NoiDung] [nvarchar](max) NULL,
	[TieuDe] [nvarchar](max) NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[MaBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietGioHang]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietGioHang](
	[MaCtgioHang] [int] IDENTITY(1,1) NOT NULL,
	[MaGioHang] [int] NULL,
	[MaThucDon] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietGioHang] PRIMARY KEY CLUSTERED 
(
	[MaCtgioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaDanhGia] [int] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [int] NULL,
	[MaThucDon] [int] NULL,
	[LoiNhanXet] [nvarchar](max) NULL,
	[NgayDanhGia] [datetime2](7) NULL,
 CONSTRAINT [PK_DanhGia] PRIMARY KEY CLUSTERED 
(
	[MaDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaGioHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NULL,
	[TongCong] [float] NULL,
	[NgayDat] [datetime2](7) NULL,
	[TrangThai] [int] NULL,
	[MaTaiKhoan] [int] NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[MaGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoDt] [nvarchar](max) NULL,
	[MaTaiKhoan] [int] NULL,
	[MaTinhThanh] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiThucDon] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNSX] [int] IDENTITY(1,1) NOT NULL,
	[TenNSX] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaPhanQuyen] [nvarchar](450) NOT NULL,
	[QuyenHan] [nvarchar](max) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaPhanQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiKhoan] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](max) NULL,
	[MaPhanQuyen] [nvarchar](450) NULL,
	[Email] [nvarchar](max) NULL,
	[AnhDaiDien] [nvarchar](max) NULL,
	[DangHoatDong] [int] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[MaThucDon] [int] IDENTITY(1,1) NOT NULL,
	[TenThucDon] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[MaLoai] [int] NULL,
	[Gia] [float] NULL,
	[KhuyenMai] [int] NULL,
	[MoTa] [nvarchar](max) NULL,
	[LuotMua] [int] NULL,
	[LuotXem] [int] NULL,
	[MaNSX] [int] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ThucDon] PRIMARY KEY CLUSTERED 
(
	[MaThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 2019-12-20 21:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[MaTinhThanh] [int] IDENTITY(1,1) NOT NULL,
	[TenTinhThanh] [nvarchar](max) NULL,
 CONSTRAINT [PK_TinhThanh] PRIMARY KEY CLUSTERED 
(
	[MaTinhThanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191216165350_createDb', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217135725_addNhaSanXuat', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191217140052_addBanner', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191218145613_updatedb', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Banner] ON 

INSERT [dbo].[Banner] ([MaBanner], [UrlBanner], [NoiDung], [TieuDe]) VALUES (17, N'slider-image-01.png', N'TỰ HÀO SINH RA TỪ ĐẤT VIỆT, 1999 - HIGHLANDS COFFEE', N'HighLand Coffee ')
INSERT [dbo].[Banner] ([MaBanner], [UrlBanner], [NoiDung], [TieuDe]) VALUES (19, N'slider-image-02.png', N'Tiger Beer và con đường “thương hiệu bia mang đậm bản sắc Châu Á”', N'Bia Tiger')
SET IDENTITY_INSERT [dbo].[Banner] OFF
SET IDENTITY_INSERT [dbo].[ChiTietGioHang] ON 

INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1018, 1010, 37, 2)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1019, 1010, 32, 3)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1020, 1010, 34, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1021, 1011, 32, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1022, 1011, 37, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1023, 1011, 34, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1024, 1012, 37, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1025, 1012, 36, 1)
INSERT [dbo].[ChiTietGioHang] ([MaCtgioHang], [MaGioHang], [MaThucDon], [SoLuong]) VALUES (1026, 1012, 35, 1)
SET IDENTITY_INSERT [dbo].[ChiTietGioHang] OFF
SET IDENTITY_INSERT [dbo].[DanhGia] ON 

INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (1, 2, 8, N'Khá Ngon', CAST(N'2019-10-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (2, 2, 8, N'Ngon Lăms', CAST(N'2019-12-18T23:10:39.0160862' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (21, 2, 8, N'Very Cold', CAST(N'2019-12-18T23:18:38.9149446' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (22, 2, 7, N'Khá Ngon', CAST(N'2019-12-18T23:19:52.0244389' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (23, 2, 7, N'Rất Ngon', CAST(N'2019-12-18T23:19:59.4196802' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (24, 2, 7, N'Được', CAST(N'2019-12-18T23:20:48.0984107' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (25, 2, 7, N'Trận Đz', CAST(N'2019-12-18T23:20:57.1777739' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (26, 2, 7, N'Ok', CAST(N'2019-12-18T23:21:51.5151566' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (27, 2, 8, N'Ok nè', CAST(N'2019-12-18T23:26:58.3749111' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (28, 2, 8, N'Được', CAST(N'2019-12-18T23:27:03.1625295' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (29, 2, 7, N'trannqt', CAST(N'2019-12-20T00:22:55.1222875' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (30, 2, 4, N'Khá Ngon', CAST(N'2019-12-20T13:38:54.3129714' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (31, 2, 4, N'oke e êi', CAST(N'2019-12-20T15:01:30.2455618' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (32, 2, 2, N'oke', CAST(N'2019-12-20T15:04:05.2702787' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (33, 2, 2, N'koe', CAST(N'2019-12-20T15:04:54.9976988' AS DateTime2))
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaTaiKhoan], [MaThucDon], [LoiNhanXet], [NgayDanhGia]) VALUES (34, 2, 36, N'Bao nhiêu 1 thùng?', CAST(N'2019-12-20T19:26:49.4261962' AS DateTime2))
SET IDENTITY_INSERT [dbo].[DanhGia] OFF
SET IDENTITY_INSERT [dbo].[GioHang] ON 

INSERT [dbo].[GioHang] ([MaGioHang], [MaKhachHang], [TongCong], [NgayDat], [TrangThai], [MaTaiKhoan]) VALUES (1010, 11, 111000, CAST(N'2019-12-20T18:39:34.0837689' AS DateTime2), 0, NULL)
INSERT [dbo].[GioHang] ([MaGioHang], [MaKhachHang], [TongCong], [NgayDat], [TrangThai], [MaTaiKhoan]) VALUES (1011, 12, 63000, CAST(N'2019-12-20T19:42:12.1291945' AS DateTime2), 0, 1)
INSERT [dbo].[GioHang] ([MaGioHang], [MaKhachHang], [TongCong], [NgayDat], [TrangThai], [MaTaiKhoan]) VALUES (1012, 13, 46500, CAST(N'2019-12-20T19:43:15.7342131' AS DateTime2), 0, 1)
SET IDENTITY_INSERT [dbo].[GioHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (11, N'Nguyễn Quang Trường Trận', N'nguyenquangtruongtran@gmail.com', N'HCM', N'0234523221', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (12, NULL, NULL, NULL, NULL, 1, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SoDt], [MaTaiKhoan], [MaTinhThanh]) VALUES (13, NULL, NULL, NULL, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiThucDon] ON 

INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (1007, N'Bánh')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (1008, N'Bia')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (1009, N'Nước giải khát')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (1011, N'Kẹo')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (1012, N'Cafe')
SET IDENTITY_INSERT [dbo].[LoaiThucDon] OFF
SET IDENTITY_INSERT [dbo].[NhaSanXuat] ON 

INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1006, N'Coca Cola')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1007, N'Pepsi')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1008, N'7up')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1009, N'Heniken')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1010, N'Tiger')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1011, N'Cafe')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1012, N'Charlie')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1013, N'Bánh Ngọt')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1014, N'NumberOne')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1015, N'Kẹo')
SET IDENTITY_INSERT [dbo].[NhaSanXuat] OFF
INSERT [dbo].[PhanQuyen] ([MaPhanQuyen], [QuyenHan]) VALUES (N'1', N'admin')
INSERT [dbo].[PhanQuyen] ([MaPhanQuyen], [QuyenHan]) VALUES (N'2', N'kh')
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (1, N'admin', N'1', N'1', N'admin@gmail.com', N'none-avatar.jpg', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaPhanQuyen], [Email], [AnhDaiDien], [DangHoatDong]) VALUES (2, N'trannqt', N'1', N'2', N'nguyenquangtruongtran@gmail.com', N'none-avatar.jpg', 1)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
SET IDENTITY_INSERT [dbo].[ThucDon] ON 

INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (17, N'Pepsi', N'637124609087084217637124577539569763timthumb.jpg', 1009, 15000, 0, N'Pepsi 330 ml , lốc 6 lon', NULL, 1, 1007, N'Pepsi là một đồ uống giải khát có gas, lần đầu tiên được sản xuất bởi Bradham. Ông pha chế ra một loại nước uống dễ tiêu làm từ nước cacbonat, đường, vani và một chút dầu ăn dưới tên “Nước uống của Brad" năm 1886.
Pepsi lần đầu tiên sản xuất vào năm 1890 do dược sĩ Caleb Bradham chế ra tại New Bern, Bắc Carolina. Pepsi được đăng ký nhãn hiệu vào ngày 16 tháng 6 năm 1903. Nó đã có nhiều biến thể sản xuất trong những năm qua kể từ năm 1898.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (18, N'Nước Suối NumberOne', N'6371246108844519832.jpg', 1009, 10000, 0, N'500ml/chai ', NULL, 1, 1014, N'Nước tinh khiết Number 1 chai 500ml (thùng 24 chai) được sản xuất với công nghệ hiện đại giúp giữ được hương vị tự nhiên của nước mà không hề chứa bất kì thành phần hóa học nào khác.  Nước tinh khiết giúp loại bỏ các chất thừa cũng như độc tố ra khỏi cơ thể nếu uống đủ nước.  Sản phẩm còn giúp giảm căng thẳng và nuôi dưỡng làn da.  Sản phẩm đóng chai tiện dụng, có thể mang đi học, bổ sung nước khi chơi thể thao bị hụt năng lượng.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (19, N'Number One Chanh', N'6371246116532440032c42c335c221d29380ad50a4783fb7e8.jpg', 1009, 15000, 0, N'330ml', NULL, NULL, 1014, N'Nước tăng lực Number 1 Active hương Chanh Muối chai 500ml 3 loại muối khoáng thiết yếu Na+, K+, Cl- và nguồn năng lượng vừa đủ giúp cơ thể bạn luôn cân bằng.  Vị chanh muối còn cải thiện đường ruột giúp hệ tiêu hóa tốt như ăn không tiêu, ợ chua,....  Number 1  Active chanh muối với tác dụng bù nước và bù khoáng chất cấp thiết rất thích hợp cho những người chơi thể thao, tham dự các hoạt động, làm cho việc ngoài trời hay đề cập cả nhân viên văn phòng đổ nhiều mồ hôi trong thời kỳ khiến cho việc đều mang thể sử dụng nước uống chuyển di này để duy trì sự dẻo dai, dai sức cho thân thể, góp phần nâng cao hiệu quả trong hoạt động hàng ngày.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (20, N'Kẹo Chupa Chups', N'6371246131443861533_-_2019-04-12T131125.842.jpg', 1011, 30000, 0, N'100g
10 que', NULL, NULL, 1015, N'Kẹo mút hương trái cây hỗn hợp Chupa Chups gói 100g bao gồm 5 hương vị hấp dẫn là dâu, cam, dâu sữa, cola và mâm xôi. Những que kẹo nhỏ xinh, chua chua, ngọt ngọt, đậm vị trái cây thơm ngon luôn là loại kẹo ngậm được người lớn lẫn trẻ nhỏ yêu thích.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (21, N'Bánh Richky', N'63712461442422855817.jpg', 1007, 50000, 0, N'Bánh có vị ngọt dịu, giòn tan.  Không chứa phụ gia, không phẩm màu, không hóa chất, an toàn cho sức khỏe của người sử dụng.  Sản xuất tại Việt Nam bởi thương hiệu Richy', NULL, 1, 1013, N'Bánh gạo mật ong Richy 186g là sự kết hợp hài hòa giữa hương thơm dịu ngọt của mật ong và vị thơm ngon từ gạo cao cấp, cho cảm giác ngọt ngào, ngon miệng. Bánh có vị ngọt dịu, giòn tan. Không chứa phụ gia, không phẩm màu, không hóa chất, an toàn cho sức khỏe của người sử dụng. Sản xuất tại Việt Nam bởi thương hiệu Richy')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (22, N'Number One Vàng', N'63712461538956849635a59227825bbdcbec4dea19c77fda1f.jpg', 1009, 15000, 0, N'330ml', NULL, NULL, 1014, N'Nước tăng lực Number 1 với sự kết hợp của Vitamin B3, Taurine, Inositol và Caffein giúp người sử dụng nạp nhanh năng lượng đồng thời duy trì sự tỉnh táo để chinh phục mọi thử thách.  Vitamin B3: Giúp giải phóng năng lượng, chuyển hóa protein và chất béo để tạo ra năng lượng cho cơ thể, đồng thời tăng cường tuần hoàn máu và giảm cholesterol.  Taurine: là một loại acid amin giúp hấp thụ tốt vitamin, điều hòa lượng cholesterol trong máu và hỗ trợ giảm các bệnh lo âu, kém trí nhớ. Caffein: Giúp tăng cường sự tỉnh táo, giảm mệt mỏi.  Inositol: Giảm suy nhược cơ thể và rối loạn tinh thần, giảm cholesterol trong máu, điều hòa lượng estrogel.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (23, N'Coffee Birdy', N'6371246162386803948935039570151_3.jpg', 1012, 13000, 0, N'170ml', NULL, NULL, 1011, N'Cà phê đen Birdy lon 170 ml được sản xuất từ 100% hạt cà phê Robusta Việt thượng hạng mang đến cho bạn một hương vị cà phê mới – đậm đà hơn, sảng khoái hơn, đặc trưng cho phong cách cà phê phù hợp với người Việt Nam.  Với công nghệ sản xuất hiện đại và nguồn nguyên liệu đươc chọn lọc kỹ lưỡng, mỗi lon cà phê Birdy sẽ mang đến cho bạn cảm giác mát lạnh, sảng khoái, nâng cao tinh thần để bắt đầu một ngày làm việc mới với nhiều hứng khởi. Thiết kế lon tiện dụng, bạn có thể mang đi làm hoặc đi du lịch, chỉ cần bật nắp và uống tiết kiệm thời gian pha chế.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (24, N'Coffee HighLand Đen', N'6371246171204339318936079140076-01.JPG', 1012, 15000, 0, N'185ml', NULL, NULL, 1011, N'Cà phê hòa tan Highland chế biến từ những hạt cà phê đã qua tuyển chọn kỹ càng, với công thức pha chế tinh tế, vẫn giữ nguyên hương vị đậm đà, thơm ngon của cà phê nguyên chất.  Sản phẩm được sản xuất khép kín, sản phẩm cũng đạt tiêu chuẩn an toàn thực phẩm, không chứa các hóa chất độc hại ảnh hưởng đến sức khỏe người tiêu dùng.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (25, N'Coffee HighLand Sữa', N'637124617610365271x6m3z9ovtomwc.jpg', 1012, 15000, 0, N'185ml', NULL, NULL, 1011, N'Cà phê sữa hòa tan Highland chế biến từ những hạt cà phê đã qua tuyển chọn kỹ càng, với công thức pha chế tinh tế, vẫn giữ nguyên hương vị đậm đà, thơm ngon của cà phê nguyên chất.  Sản phẩm được sản xuất khép kín, sản phẩm cũng đạt tiêu chuẩn an toàn thực phẩm, không chứa các hóa chất độc hại ảnh hưởng đến sức khỏe người tiêu dùng.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (26, N'coffee NesCafe', N'637124618573410802bcafe-lon-nescafe-180ml-24-1-X7O.jpg', 1012, 15000, 10, N'330ml', NULL, NULL, 1011, N' Mê hoặc từ vẻ bề ngoài, đắm chìm khi thưởng thức, với sự hòa quyện giữa ca cao đặc sánh và bọt sữa béo mịn, Nescafe Dolce Gusto Chococino mang đến cho bạn trải nghiệm hương vị tuyệt vời nhất. Sản phẩm gồm 16 viên: 8 viên bột socola và 8 viên bột sữa với các thành phần được cân chỉnh hoàn hảo, độ ngọt vừa phải, cho vị ngon đúng điệu. ')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (27, N'Bánh KitKat', N'637124619727630651Bánh_Xốp_Phủ_Sôcôla_Nestlé_Kitkat__35g_.jpg', 1007, 25000, 20, N'thanh 17g', NULL, NULL, 1013, N'Đường, sữa bột (sữa bò), bột mì, bơ cacao, cacao khối, chất béo thực vật và dầu thực vật (nhân cây cọ, cây cọ, Illipe, cây hạt mỡ), siro glucose, chất nhũ hoá (322(i), 476), bột cacao, chất ổn định (500ii, 170(i)), muối, hương vani tổng hợp,')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (28, N'Bánh Cosy', N'637124621579957312cosy-banh-quy-marie-450g-2-org.jpg', 1007, 45000, 10, N'gói 144g', NULL, NULL, 1013, N'Bột mì, dầu cọ, đường, dừa sấy nhuyễn (3.5%), chất tạo xốp (503(ii), 500(ii)), muối, hương thực phẩm tổng hợp (dừa, sữa dừa, vani), chất xử lý bột (223, 1101(i)).')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (29, N'Bia Heniken', N'637124622740581288bia-heineken-xanh-lon-330ml.jpg', 1008, 30000, 5, N'lon 330ml', NULL, NULL, 1009, N'Nồng độ cồn 4%, Heineken Silver có hương vị cân bằng hoàn hảo và vị đắng nhẹ mà vẫn giữ trọn nét đặc trưng của Heineken nguyên bản. Nghiên cứu thị trường của thương hiệu này cho thấy khách hàng có nhu cầu thưởng thức Heineken theo nhiều cách, trong nhiều thời điểm hơn. Hiểu tâm lý này, Heineken ra mắt Heineken Silver có vị nhẹ êm dễ uống, đồng thời lưu giữ trọn vẹn hương vị đậm chất.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (30, N'Bánh Chocopie', N'637124623994788810f94ac104b762ee08c717fd472bcab525.jpg', 1007, 60000, 2, N'hộp 396g (12 cái)', NULL, NULL, 1013, N'Bột mì, đường, glucose syrup, shortening thực vật, chất béo thực vật không hydro hoá, isomalto oligo syrup, bột cacao, sữa bột nguyên kem, trứng, chất tạo xốp, đường dextrose, gelatin, muối i-ốt,...')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (31, N'Kẹo Sugood', N'637124625428609990Kẹo_Mềm_Sugus_Hương_Trái_Cây__120g_.jpg', 1011, 50000, 20, N'30 viên', NULL, NULL, 1015, N'Kẹo quế với vị ngọt cay tính nóng, ngoài công dụng cung cấp năng lượng còn tốt cho sức khỏe giảm hôi miệng , thông huyết mạch, tốt cho tim mạch, tăng độ ấm cơ thể phòng cảm gió.

Hương vị quế đặc trưng thơm ngon, rất phù hợp với thời tiết lạnh.

Thành phần kẹo quế melland chiết xuất từ quế 0.1%; hương liệu tổng hợp (quế); đường; xirô; màu Caribbean.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (32, N'CoCa CoLa', N'637124626153748000coca.jpg', 1009, 15000, 0, N'500ml/chai ', 4, NULL, 1006, N'Nước bão hòa CO2, màu thực phẩm, chất điều chỉnh độ axit, chất tạo ngọt tổng hợp, chất bảo quản, hương cola tự nhiên và caffein.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (33, N'7 Up', N'637124626776540900Nuoc-Giai-Khat-Co-Gas-7-Up.jpg', 1009, 15000, 2, N'vị chanh 330ml', NULL, 1, 1008, N'Thành phần Nước bão hòa CO2, đường mía, chất điều chỉnh độ acid, hương chanh tự nhiên...  Hướng dẫn sử dụng Dùng trực tiếp, ngon hơn khi uống lạnh.  Bảo quản Bảo quản nơi khô ráo, thoáng mát. Tránh ánh nắng trực tiếp.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (34, N'Socola Mejji', N'637124628155643792Kẹo_Sôcôla_Meiji_Milk_Chocolate__41g_.jpg', 1011, 30000, 0, N'hộp 120g', 2, NULL, 1012, N'Socola đen Meiji Black Chocolate chắc chắn sẽ đốn tim những tín đồ đam mê socola bởi nó có hương thơm đặc trưng và mùi vị đắng bùi tuyệt hảo từ cacao  nguyên chất.Socola đen Meiji không chỉ thơm ngon mà còn có nhiều lợi ích cho sức khoẻ như tốt cho tim mạch, phòng ngừa bệnh ung thư, giảm cân, tốt cho làn da và vóc dáng,...')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (35, N'Sting Vàng', N'637124629196684115nuoc-tang-luc-sting-vang-lon-3.jpg', 1009, 15000, 5, N'330ml', 1, 1, 1007, N'Nước tăng lực Sting vàng có thành phần tự nhiên kết hợp với hương vị nhân sâm tạo nên mùi vị thơm ngon, sảng khoái. Sản phẩm giúp cơ thể bù đắp nước, bổ sung năng lượng, vitamin C và E, giúp xua tan cơn khát và cảm giác mệt mỏi.  Sản phẩm được sản xuất trên quy trình công nghệ hiện đại, thông qua quy trình kiểm duyệt chặt chẽ và không có đường hóa học, không chứa hóa chất độc hại, đảm bảo an toàn cho người sử dụng.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (36, N'Sting Đỏ', N'637124629489328739P08084_1_l.jpg', 1009, 15000, 5, N'330ml', 1, 4, 1007, N'Nước tăng lực Sting vàng có thành phần tự nhiên kết hợp với hương vị nhân sâm tạo nên mùi vị thơm ngon, sảng khoái. Sản phẩm giúp cơ thể bù đắp nước, bổ sung năng lượng, vitamin C và E, giúp xua tan cơn khát và cảm giác mệt mỏi.  Sản phẩm được sản xuất trên quy trình công nghệ hiện đại, thông qua quy trình kiểm duyệt chặt chẽ và không có đường hóa học, không chứa hóa chất độc hại, đảm bảo an toàn cho người sử dụng.')
INSERT [dbo].[ThucDon] ([MaThucDon], [TenThucDon], [HinhAnh], [MaLoai], [Gia], [KhuyenMai], [MoTa], [LuotMua], [LuotXem], [MaNSX], [Description]) VALUES (37, N'Kẹo Alpenlibe', N'637124630014109129Kẹo-hương-dâu-kem-Alpenliebe-gói-120g.jpg', 1011, 20000, 10, N'gói 227.5g', 4, 1, 1015, N'Đường, si rô glucoza, dầu dừa hydro hóa, gelatin, chất điều chỉnh độ chua (acid citric, acid lactic, acid malic), chất nhũ hoá (monoglycerid của các acid béo, este của sucrose với các acid béo), hương dâu giống tự nhiên, hương nho giống tự nhiên, màu tổng hợp.')
SET IDENTITY_INSERT [dbo].[ThucDon] OFF
SET IDENTITY_INSERT [dbo].[TinhThanh] ON 

INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (1, N'Hồ Chí Minh')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (3, N'Hà Nội')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (1002, N'Bình Định')
SET IDENTITY_INSERT [dbo].[TinhThanh] OFF
ALTER TABLE [dbo].[ChiTietGioHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioHang_GioHang_MaGioHang] FOREIGN KEY([MaGioHang])
REFERENCES [dbo].[GioHang] ([MaGioHang])
GO
ALTER TABLE [dbo].[ChiTietGioHang] CHECK CONSTRAINT [FK_ChiTietGioHang_GioHang_MaGioHang]
GO
ALTER TABLE [dbo].[ChiTietGioHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioHang_ThucDon_MaThucDon] FOREIGN KEY([MaThucDon])
REFERENCES [dbo].[ThucDon] ([MaThucDon])
GO
ALTER TABLE [dbo].[ChiTietGioHang] CHECK CONSTRAINT [FK_ChiTietGioHang_ThucDon_MaThucDon]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_KhachHang_MaKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_KhachHang_MaKhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan_MaTaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan_MaTaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_PhanQuyen_MaPhanQuyen] FOREIGN KEY([MaPhanQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaPhanQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_PhanQuyen_MaPhanQuyen]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_LoaiThucDon_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThucDon] ([MaLoai])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_LoaiThucDon_MaLoai]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_NhaSanXuat_MaNSX] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNSX])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_NhaSanXuat_MaNSX]
GO
