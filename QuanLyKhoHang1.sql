create database QuanLyChucVu
use QuanLyChucVu

create table ChucVu(
	MaChucVu nvarchar(3) primary key,
	TenChucVu nvarchar(30) not null unique,
	MucLuong decimal(10,2) not null check(MucLuong > 0),
	PhuCap decimal(10,2) not null check(PhuCap > 0)
);

create table NhanVien(
	MaNhanVien nvarchar(5) primary key,
	HoTen nvarchar(30) not null,
	MaChucVu nvarchar(3) not null,
	NgayVaoLam date not null,
	foreign key (MaChucVu) references ChucVu(MaChucVu)
);

create table KhoHang(
	MaKhoHang nvarchar(3) primary key,
	TenKhoHang nvarchar(30) not null unique,
	DiaChi nvarchar(100) not null,
	MaNhanVienPhuTrach nvarchar(5) not null,
	foreign key(MaNhanVienPhuTrach) references NhanVien(MaNhanVien)
);

-- Insert data into ChucVu table
INSERT INTO ChucVu (MaChucVu, TenChucVu, MucLuong, PhuCap) VALUES 
('CV1', 'Director', 30000.00, 5000.00),
('CV2', 'Department Head', 20000.00, 3000.00),
('CV3', 'Employee', 15000.00, 2000.00),
('CV4', 'Accountant', 18000.00, 2500.00),
('CV5', 'Security', 12000.00, 1500.00);

-- Insert data into NhanVien table
INSERT INTO NhanVien (MaNhanVien, HoTen, MaChucVu, NgayVaoLam) VALUES 
('NV001', 'John Doe', 'CV1', '2020-01-15'),
('NV002', 'Jane Smith', 'CV2', '2021-03-20'),
('NV003', 'Robert Brown', 'CV3', '2022-07-10'),
('NV004', 'Emily Davis', 'CV4', '2019-11-25'),
('NV005', 'Michael Johnson', 'CV5', '2023-05-30');

-- Insert data into KhoHang table
INSERT INTO KhoHang (MaKhoHang, TenKhoHang, DiaChi, MaNhanVienPhuTrach) VALUES 
('K01', 'Hanoi Warehouse', '123 ABC Street, Hanoi', 'NV001'),
('K02', 'Danang Warehouse', '456 DEF Street, Danang', 'NV002'),
('K03', 'HCMC Warehouse', '789 GHI Street, Ho Chi Minh City', 'NV003'),
('K04', 'Haiphong Warehouse', '135 JKL Street, Haiphong', 'NV004'),
('K05', 'Cantho Warehouse', '246 MNO Street, Cantho', 'NV005');

--Cau 1
create procedure XoaChucVu
	@MaChucVu nvarchar(3)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from ChucVu where MaChucVu = @MaChucVu);
	if @Dem = 0
		set @Loi = N'Ma chuc vu khong ton tai';

	set @Dem = (select count(*) from NhanVien where MaChucVu = @MaChucVu);
	if @Dem > 0
		set @Loi = N'Khong the xoa do lien ket voi bang NhanVien';

	if @Loi = ' '
		 delete from ChucVu
		 where MaChucVu = @MaChucVu;
	else
		raiserror(@Loi, 16, 1)
end

exec XoaChucVu @MaChucVu = N'CV5';

--Cau 2
create function TimKiemNhanVien(@TuKhoa nvarchar(40))
returns table
as return
(
select 
	nv.MaNhanVien,
	nv.HoTen,
	cv.TenChucVu,
	nv.NgayVaoLam
from NhanVien nv
inner join ChucVu cv on nv.MaChucVu = cv.MaChucVu
where nv.MaNhanVien like '%' + @TuKhoa + '%'
	or nv.HoTen like '%' + @TuKhoa + '%'
	or cv.TenChucVu like '%' + @TuKhoa + '%'
);

select * from TimKiemNhanVien(N'S');

--Cau 3
create procedure ThemKhoHang
	@MaKhoHang nvarchar(3),
	@TenKhoHang nvarchar(30),
	@DiaChi nvarchar(100),
	@MaNhanVienPhuTrach nvarchar(5)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' '

	set @Dem = (select count(*) from KhoHang where MaKhoHang = @MaKhoHang)
	if @Dem > 0
		set @Loi = N'Ma kho hang da ton tai';

	set @Dem = (select count(*) from KhoHang where TenKhoHang = @TenKhoHang)
	if @Dem > 0
		set @Loi = N'Ten kho hang da ton tai';

	if @Loi = ' '
		insert into KhoHang(MaKhoHang, TenKhoHang, DiaChi, MaNhanVienPhuTrach)
		values (@MaKhoHang, @TenKhoHang, @DiaChi, @MaNhanVienPhuTrach);
	else
		raiserror(@Loi, 16, 1);
end

EXEC ThemKhoHang 
    @MaKhoHang = N'K06', 
    @TenKhoHang = N'Kho A', 
    @DiaChi = N'123 Đường ABC, Quận 1, TP HCM', 
    @MaNhanVienPhuTrach = N'NV001';

create procedure SuaKhoHang
	@MaKhoHang nvarchar(3),
	@TenKhoHang nvarchar(30),
	@DiaChi nvarchar(100),
	@MaNhanVienPhuTrach nvarchar(5)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' '

	set @Dem = (select count(*) from KhoHang where MaKhoHang = @MaKhoHang)
	if @Dem = 0
		set @Loi = N'Ma kho hang khong ton tai';

	set @Dem = (select count(*) from KhoHang where TenKhoHang = @TenKhoHang and MaKhoHang != MaKhoHang)
	if @Dem > 0
		set @Loi = N'Ten kho hang da ton tai';

	if @Loi = ' '
		update KhoHang
		set TenKhoHang = @TenKhoHang, DiaChi = @DiaChi, MaNhanVienPhuTrach = @MaNhanVienPhuTrach
		where MaKhoHang = @MaKhoHang
	else
		raiserror(@Loi, 16, 1);
end

drop procedure SuaKhoHang

-- Giả sử bạn muốn sửa kho hàng với mã 'K01'
EXEC SuaKhoHang 
    @MaKhoHang = N'K01', 
    @TenKhoHang = N'Kho B', 
    @DiaChi = N'456 Đường XYZ, Quận 2, TP HCM', 
    @MaNhanVienPhuTrach = N'NV002';

create procedure XoaKhoHang
	@MaKhoHang nvarchar(3)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from KhoHang where MaKhoHang = @MaKhoHang)
	if @Dem = 0
		set @Loi = N'Ma kho hang khong ton tai';

	if @Loi = ' '
		delete from KhoHang where MaKhoHang = @MaKhoHang;
	else
		raiserror(@Loi, 16, 1);
end


create function TimKiemKhoHang(@TuKhoa nvarchar(40))
returns table
as return
(
	select 
		kh.MaKhoHang,
		kh.TenKhoHang,
		kh.DiaChi,
		kh.MaNhanVienPhuTrach
	from KhoHang kh
	inner join NhanVien nv on kh.MaNhanVienPhuTrach = nv.MaNhanVien
	where
		kh.MaKhoHang like '%' + @TuKhoa + '%'
		or kh.TenKhoHang like '%' + @TuKhoa + '%'
		or kh.DiaChi like '%' + @TuKhoa + '%'
		or kh.MaNhanVienPhuTrach like '%' + @TuKhoa + '%'
);

select * from TimKiemKhoHang(N'M');