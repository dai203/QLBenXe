-- Khởi Tạo CSDL
-- BẢNG NGƯỜI DÙNG
CREATE DATABASE QLBENXE
USE QLBENXE

CREATE TABLE NGUOIDUNG
(
	MAND VARCHAR(20) primary key, 
	TENND NVARCHAR(50),
	DIACHI NVARCHAR(200),
	SDT VARCHAR(20),
	MATK VARCHAR(20) FOREIGN KEY REFERENCES TAIKHOAN(MATK),
	tien float
)
-- BẢNG QUẢN LÝ
CREATE TABLE QUANLY (
	MAQL VARCHAR(20) PRIMARY KEY,
	TENQL NVARCHAR(100),
	DIACHI NVARCHAR(200),
	SDT VARCHAR(20)
)
-- BẢNG XE
CREATE TABLE XE (
	MAXE VARCHAR(20) PRIMARY KEY,
	SOCHO NVARCHAR(50),
	TENXE NVARCHAR(100),
	LOAIXE NVARCHAR(100),
	BIENSO NVARCHAR(100),
	THOIGIANDICHUYEN NVARCHAR(100),
	TENNGUOILAI NVARCHAR(100),
	SDTNGUOILAI VARCHAR(20)
)
-- BẢNG VÉ
CREATE TABLE VE (
	MAVE VARCHAR(20) PRIMARY KEY,
	TENVE NVARCHAR(200),
	LOAIVE NVARCHAR(200),
	GIAVE FLOAT,
	MAXE VARCHAR(20) FOREIGN KEY REFERENCES XE(MAXE)
)
-- BẢNG TÀI KHOẢN
CREATE TABLE TAIKHOAN(
	MATK VARCHAR(20) PRIMARY KEY,
	TENTK NVARCHAR(200),
	MATKHAU NVARCHAR(200)
)
-- BẢNG MUA
CREATE TABLE MUA (
	MAND VARCHAR(20) FOREIGN KEY REFERENCES NGUOIDUNG(MAND),
	MAVE VARCHAR(20) FOREIGN KEY REFERENCES VE(MAVE),
	PRIMARY KEY (MAND, MAVE)
)
-- BẢNG QUẢN QL VÉ
CREATE TABLE QLVE (
	MAQL VARCHAR (20) FOREIGN KEY REFERENCES QUANLY(MAQL), 
	MAVE VARCHAR(20) FOREIGN KEY REFERENCES VE(MAVE)
	PRIMARY KEY (MAQL, MAVE)
)
-- BẢNG QUẢN LÝ NGƯỜI DÙNG
CREATE TABLE QLND (
	MAND VARCHAR(20) FOREIGN KEY REFERENCES NGUOIDUNG(MAND),
	MAQL VARCHAR(20) FOREIGN KEY REFERENCES QUANLY (MAQL)
	PRIMARY KEY (MAND, MAQL)
)
-- BẢNG QUẢN LÝ XE
CREATE TABLE QLXE(
	MAQL VARCHAR(20) FOREIGN KEY REFERENCES QUANLY (MAQL), 
	MAXE VARCHAR(20) FOREIGN KEY REFERENCES XE(MAXE),
	PRIMARY KEY (MAQL, MAXE)
)
-- BẢNG QUẢN LÝ TÀI KHOẢN
CREATE TABLE QLTK
(
	MATK VARCHAR(20) FOREIGN KEY REFERENCES TAIKHOAN(MATK),
	MAQL VARCHAR(20) FOREIGN KEY REFERENCES QUANLY(MAQL),
	PRIMARY KEY (MATK, MAQL)
)
use QLBENXE
ALTER TABLE VE ADD MAXE VARCHAR(20) FOREIGN KEY REFERENCES XE(MAXE)
SELECT * FROM VE
ALTER TABLE NGUOIDUNG ADD MATK VARCHAR(20) FOREIGN KEY REFERENCES TAIKHOAN(MATK)
SELECT * FROM NGUOIDUNG
-- Các thủ tục 
-- Đăng Ký Tài Khoản
create proc dboDangKyTaiKhoan 
@maTK varchar(20), @tenTK nvarchar(50), @matKhau nvarchar(50)
as
begin
	insert into TAIKHOAN (MATK, TENTK, MATKHAU) values (@maTK, @tenTK, @matKhau);
end

-- Lấy Mã Tài Khoản 
create proc dboLayMaTaiKhoan 
@tenTK nvarchar(50), @matKhau nvarchar(50)
as 
begin
	select MATK from TAIKHOAN where TENTK = @tenTK and MATKHAU = @matKhau
end

-- Lấy Tài Khoản
create proc dboLayTenTaiKhoan 
as
begin
	select TENTK from TAIKHOAN
end

-- Đăng Ký Thông Tin Người Dùng
create proc dboDangKyThongTinNguoiDung
@maND varchar(20), @tenNguoiDung nvarchar(50), @diaChi nvarchar(200), @sdt varchar(20), @maTK varchar(20) , @Tien float
as 
begin
	insert into NGUOIDUNG values (@maND, @tenNguoiDung, @diaChi, @sdt, @maTK, @Tien);
end

-- Lấy Mã TK 
create proc dboLayMaTK
as
begin
	select MATK from TAIKHOAN
end

-- Lấy Mã ND
create proc dboLayMaNguoiDung
as
begin
	select MAND from NGUOIDUNG
end

-- Quên Mật Khẩu
create proc dboQuenMatKhau
@tenTK nvarchar(50)
as
begin
	select MATKHAU from TAIKHOAN where TENTK = @tenTK
end

-- Quản Lý Thêm Tài Khoản
create proc dboQLThemTaiKhoan
@maTK varchar(20), @tenTK nvarchar(50), @matKhau nvarchar(50)
as 
begin
	insert into TAIKHOAN values (@maTK, @tenTK, @matKhau);
end

-- Quản lý sửa Tài Khoản
create proc dboQLSuaTaiKhoan 
@maTK varchar(20), @tenTK nvarchar(50), @matKhau nvarchar(50)
as 
begin
	update TAIKHOAN set TENTK = @tenTK, MATKHAU = @matKhau where MATK = @maTK
end
-- Quản lý xóa tài khoản
create proc dboQLXoaTaiKhoan
@maTK varchar(20)
as
begin
	delete TAIKHOAN where MATK = @maTK
end
-- Quản lý tìm kiếm tài khoản
create proc dboTimKiemTaiKhoan
@tenTK nvarchar(50)
as 
begin
	select * from TAIKHOAN where TENTK like @tenTK
end

-- Hiển Thị Thông Tin Sản Phẩm
create proc dboHienThiThongTin
as
begin
	select * from TAIKHOAN
end

-- Xóa Người Dùng Hỗ Trợ Khi Xóa Tài Khoản
create proc dboXoaNguoiDung
@maTK varchar(20)
as
begin
	delete NGUOIDUNG where MATK = @maTK
end
select * from NGUOIDUNG
-- Nhóm chức năng của xe
-- Thêm Xe
create proc dboThemXe
@maXe varchar(20), @soCho nvarchar(20), @TenXe nvarchar(50), @loaiXe nvarchar(50), @bienSo nvarchar(50), 
@thoiGianDiChuyen varchar(50), @tenNguoiLai nvarchar(50), @sdtNguoiLai varchar(20)
as 
begin
	insert into XE values (@maXe, @soCho, @TenXe, @loaiXe, @bienSo, @thoiGianDiChuyen, @tenNguoiLai, @sdtNguoiLai)
end
-- Sửa Xe
create proc dboSuaXe 
@maXe varchar(20), @soCho nvarchar(20), @TenXe nvarchar(50), @loaiXe nvarchar(50), @bienSo nvarchar(50), 
@thoiGianDiChuyen varchar(50), @tenNguoiLai nvarchar(50), @sdtNguoiLai varchar(20)
as 
begin
	update XE set SOCHO = @soCho, TENXE = @TenXe, LOAIXE = @loaiXe, BIENSO = @bienSo, THOIGIANDICHUYEN = @thoiGianDiChuyen, 
	TENNGUOILAI = @tenNguoiLai, SDTNGUOILAI = @sdtNguoiLai where MAXE = @maXe
end
-- Xóa Xe
create proc dboXoaXe
@maXe varchar(20)
as
begin
	delete xe where MAXE = @maXe
end
-- Xoa Ve
create proc dboXoaVe
@maXe varchar(20)
as
begin
	delete VE where MAXE = @maXe
end

-- Tìm Kiếm Xe
create proc dboTimKiemXe
@tenXe nvarchar(50)
as 
begin
	select * from XE where TENXE like @tenXe or LOAIXE like @tenXe
end

-- Hien Thi Thong Tin
create proc dboHienThiXe
as
begin
	select * from XE
end
-- Chức năng quản lý vé

-- Thêm Vé
create proc dboThemVe
@maVe varchar(20), @tenVe nvarchar(50), @loaiVe nvarchar(50), @giaVe float, @maXe varchar(20)
as 
begin
	insert into VE values (@maVe, @tenVe, @loaiVe, @giaVe, @maXe);
end

-- Sửa Xe
create proc dboSuaVe
@maVe varchar(20), @tenVe nvarchar(50), @loaiVe nvarchar(50), @giaVe float, @maXe varchar(20)
as 
begin
	update VE set TENVE = @tenVe, LOAIVE = @loaiVe, GIAVE = @giaVe, MAXE = @maXe where MAVE = @maVe
end

-- Tìm Kiếm Vé
create proc dboTimKiemVE
@tenVe nvarchar(50)
as 
begin
	select * from VE where TENVE like @tenVe or LOAIVE like @tenVe
end

-- Hien Thi Vé
create proc dboHienThiVe
as
begin
	select * from VE
end
-- Lấy mã vé
create proc dboLayMaVe
as
begin
	select MAVE from VE
end
-- Lấy Mã Xe
create proc dboLayMaXe
as
begin
	select MAXE from XE
end

-- Xóa Vé Đã Mua
create proc dboXoaVeDaMua
@maVe varchar(20)
as
begin
	delete VE where MAVE = @maVe
end

-- Quản Lý Người Dùng

-- Thêm Người Dùng
create proc dboThemNguoiDung
@maNguoiDung varchar(20), @tenNguoiDung nvarchar(50), @DiaChi nvarchar(200), @sdt varchar(20), @maTK varchar(20),
@Tien float
as 
begin
	insert into NGUOIDUNG values (@maNguoiDung, @tenNguoiDung, @DiaChi, @sdt, @maTK, @Tien);
end

-- Sửa Người dùng
create proc dboSuaNguoiDung
@maNguoiDung varchar(20), @tenNguoiDung nvarchar(50), @DiaChi nvarchar(200), @sdt varchar(20), @maTK varchar(20),
@Tien float
as 
begin
	update NGUOIDUNG set TENND = @tenNguoiDung, DIACHI = @DiaChi, SDT = @sdt, MATK = @maTK, tien = @Tien where MAND = @maNguoiDung
end

-- Xóa Người Dùng
create proc dboQLXoaNguoiDung
@maNguoiDung varchar(20)
as
begin
	delete NGUOIDUNG where MATK = @maNguoiDung
end
select * from NGUOIDUNG
-- Xóa Các Vé Đã Mua
create proc dboXoaVeNguoiDungDaMua
@maNguoiDung varchar(20)
as
begin
	delete MUA where MAND = @maNguoiDung
end
-- Tìm Kiếm Vé
create proc dboTimKiemNguoiDung
@tenNguoiDung nvarchar(50)
as 
begin
	select * from NGUOIDUNG where TENND like @tenNguoiDung
end
-- Hien Thi Người Dùng
create proc dboHienThiNguoiDung
as
begin
	select * from NGUOIDUNG
end
-- Lấy mã người dùng
create proc dboGetMaNguoiDung
as
begin 
	select MAND from NGUOIDUNG
end
-- Các chức năng của người dùng
 -- Người dùng lấy mật khẩu
 create proc dboGetMatKhau
 as
 begin
	select MATKHAU from TAIKHOAN
 end
 -- Lấy mã tài khoản
 create proc dboNguoiDungLayMaTK
 @tenTK nvarchar(100), @matKhau nvarchar(100)
  as
  begin
		select MATK from TAIKHOAN where TENTK = @tenTK and MATKHAU = @matKhau
  end
-- Lấy Thông Tin Người Dùng Qua Mã TK
create proc dboLayMaThongTinTK
@maTK varchar(20)
as
begin
	select TENND, DIACHI, SDT, MAND from NGUOIDUNG where MATK = @maTK
end
-- Cập Nhật Thông Tin Người Dùng
create proc dboCapNhatThongTin 
@tenND nvarchar(200), @diaChi nvarchar(200), @sdt varchar(20), @maND varchar(20)
as
begin
	update NGUOIDUNG set TENND = @tenND, DIACHI = @diaChi, SDT  = @sdt where MAND = @maND
end
-- Lấy Mã Người Dùng Từ Mã TK
create proc dboLayMaNguoiDungTuMaTK
@maTK varchar(20)
as 
begin
	select MAND from NGUOIDUNG where MATK = @maTK
end
create proc dboQLXoaNguoiDung
@maNguoiDung varchar(20)
as
begin
	delete NGUOIDUNG where MAND = @maNguoiDung
end

-- Người Dùng Mua Vé
create proc dboMuaVe 
@maVe varchar(20), @maND varchar(20)
as
begin
	insert into MUA values(@maND, @maVe)
end
-- Hiển Thị Vé Người Dùng Đó Mua
create proc dboHienThiVeNguoiDungDoMua 
@maND varchar(20)
as
begin
	select VE.MAVE ,TENVE, LOAIVE, GIAVE, TENXE, LOAIXE, SOCHO, BIENSO, THOIGIANDICHUYEN, TENNGUOILAI, SDTNGUOILAI from VE, MUA, XE where VE.MAVE = MUA.MAVE and MUA.MAND = @maND and XE.MAXE = VE.MAXE
end
-- Người Dùng Không Mua Vé Này Nữa
create proc dboNguoiDungBoKhongMuaVe
@maND varchar(20), @maVe varchar(20)
as 
begin
	delete MUA where MAVE = @maVe and MAND = @maND
end
-- Quản Lý Tạo Báo Cáo
create proc dboBaoCaoNguoiDungMuaVe 
as
begin
	select TENND, DIACHI, SDT, TENVE, GIAVE from NGUOIDUNG, MUA, VE, XE where NGUOIDUNG.MAND = MUA.MAND and VE.MAVE = MUA.MAVE and VE.MAXE = XE.MAXE
end
select * from TAIKHOAN