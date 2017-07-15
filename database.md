use QLTP
go
create table DangKi( MaDK nvarchar(10),HoTen nvarchar(50),DiaChi nvarchar(50),Email nvarchar(50),SDT nvarchar(20));
use QLTP
go
create table KhachHang( HoTen nvarchar(50),DiaChi nvarchar(50),SDT nvarchar(20),MaPhong nvarchar(10),NgayThue date,NgayTra date);
use QLTP
go
create table Phong( MaPhong nvarchar(10),TinhTrang nvarchar(50),GiaPhong int,LoaiPhong nvarchar(50));