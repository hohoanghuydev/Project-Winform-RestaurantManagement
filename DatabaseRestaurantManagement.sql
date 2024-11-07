USE [RestaurantManagementDatabase]
GO
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'LMA001', N'Thức uống')
GO
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'LMA002', N'Tráng miệng')
GO
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'LMA003', N'Thức ăn')
GO
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'LMA004', N'Snack')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA001', N'Lẩu thái', 400000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA002', N'Tôm rang me', 400000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA003', N'Gà bó xôi chiên', 450000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA004', N'Bò né', 300000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA005', N'Lẩu cua đồng', 500000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA006', N'Beer', 300000, N'LMA001')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA007', N'Coca Cola', 250000, N'LMA001')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA008', N'Bánh phồng tôm', 30000, N'LMA004')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA009', N'Bánh phô mai', 20000, N'LMA004')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA010', N'Trái cây thập cẩm', 100000, N'LMA002')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA011', N'Nho mỹ', 150000, N'LMA002')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA012', N'Bánh Flan', 110000, N'LMA002')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA013', N'Rau câu dừa', 80000, N'LMA002')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA014', N'Gỏi cá trích', 120000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA015', N'Mực nướng muối ớt', 200000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA016', N'Gà luộc', 120000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA017', N'Mực chiên nước mắm', 200000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA018', N'Cải thìa xào dầu hào', 50000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA019', N'Mì xào hải sản', 120000, N'LMA003')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGia], [MaLoaiMonAn]) VALUES (N'MA020', N'Mì xào rau cải', 75000, N'LMA003')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B001', N'Bàn 1', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B002', N'Bàn 2', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B003', N'Bàn 3', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B004', N'Bàn 4', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B005', N'Bàn 5', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B006', N'Bàn 6', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B007', N'Bàn 7', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B008', N'Bàn 8', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B009', N'Bàn 9', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B010', N'Bàn 10', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B011', N'Bàn 11', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B012', N'Bàn 12', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B013', N'Bàn 13', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B014', N'Bàn 14', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B015', N'Bàn 15', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B016', N'Bàn 16', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B017', N'Bàn 17', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B018', N'Bàn 18', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B019', N'Bàn 19', N'Trống')
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B020', N'Bàn 20', N'Trống')
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV001', N'123456', N'Lê Văn Thọ', N'Quản lý', 20000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV002', N'123456', N'Nguyễn Thành Nam', N'Nhân viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV003', N'123456', N'Phan Công Tiến', N'Nhân viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV004', N'123456', N'Bùi Tiến Dũng', N'Nhân viên', 7000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV005', N'123456', N'Trần Nhật Anh', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV006', N'123456', N'Cao Tiến Hoàng', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV007', N'123456', N'Võ Văn Vở', N'Nhân viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV008', N'123456', N'Khứa Tóc Dài', N'Nhân viêng', 10000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV009', N'123456', N'Nguyễn Thành Lộc', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV010', N'123456', N'Trần Quang Tiến', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV011', N'123456', N'Hoàng Nam Anh', N'Nhân viên', 7000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV012', N'123456', N'Phạm Nhật Hùng', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV013', N'123456', N'Trần Hải Tùng', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV014', N'123456', N'Hoàng Văn Huy', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV015', N'123456', N'Nguyễn Tiến Thành', N'Nhân viên', 10000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV016', N'123456', N'Trần Tiểu Bình', N'Nhân Viên', 7000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV017', N'123456', N'Lý Hoàng Dũng', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV018', N'123456', N'Trần Hải Khang', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV019', N'123456', N'Hoàng Công Tiến', N'Nhân Viên', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [ChucVu], [Luong]) VALUES (N'NV020', N'123456', N'Trần Thế Quân', N'Nhân Viên', 10000000)
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [MaBan], [NgayLap], [TongTien], [TrangThaiThanhToan]) VALUES (N'HD001', NULL, N'NV001', N'B008', CAST(N'2024-09-02T17:55:59.357' AS DateTime), 300000, N'Đã thanh toán')
GO
INSERT [dbo].[ChiTietHD] ([MaCTHD], [MaMonAn], [MaHD], [SoLuong], [TrangThaiMon], [ThoiGianDatMon], [ThanhTien]) VALUES (N'CTHD001', N'MA006', N'HD001', 1, N'Đã xong', CAST(N'2024-09-02T17:55:59.420' AS DateTime), 300000)
GO
