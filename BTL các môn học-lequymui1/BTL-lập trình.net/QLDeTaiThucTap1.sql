create database DeTaiThucTap
use DeTaiThucTap
go


create table NguoiDung
(
Username nvarchar(50) primary key not null,
Password nvarchar(50) not null,
Confirmpassword nvarchar(50) not null,
Email nvarchar(50) not null
)
create table sinhvien
(
hoten nvarchar(40),
masv char(10) primary key,
tuoi int,
gioitinh nvarchar(10),
sdt int,
diachi nvarchar(40),
lop nvarchar(20)
)
create table detai
(
tenDT nvarchar(40),
maDT char(10) primary key,
gioihan nvarchar(30)
)
create table bangdiem
(
maDT char(10) FOREIGN KEY REFERENCES detai(maDT),
masv char(10) FOREIGN KEY REFERENCES sinhvien(masv),
diemlan1 float,
diemlan2 float,
nhanxet nvarchar(100)
)
create table monhoc
(
tenMH nvarchar(40),
maMH char(10) primary key,
sotinchi int,
giatien money,
tongtien money
)
create table diemMH
(
masv char(10) FOREIGN KEY REFERENCES sinhvien(masv),
maMH char(10) FOREIGN KEY REFERENCES monhoc(maMH),
diemcc float,
diemkt float,
diemtk float
)
create table giangvien
(
hoten nvarchar(40),
gioitinh nvarchar(10),
maGV char(10),
sdt int,
maMH char(10) FOREIGN KEY REFERENCES monhoc(maMH)
)
select * from NguoiDung
INSERT INTO NguoiDung VALUES
(N'lequymui',N'lequymui',N'lequymui',N'lequymui@gmail.com'),
(N'nguyenngocminh',N'nguyenngocminh',N'nguyenngocminh',N'nguyenngocminh@gmail.com'),
(N'nguyenconghoang',N'nguyenconghoang',N'nguyenconghoang',N'nguyenconghoang@gmail.com'),
(N'duongquanghai',N'duongquanghai',N'duongquanghai',N'duongquanghai@gmail.com')
select * from sinhvien
INSERT INTO sinhvien VALUES
(N'Nguyen Van An','2023345','20',N'Nam','0946382463',N'Hà Nội',N'CNTT 3'),
(N'Nguyen Thi Lan','2021156','20',N'Nữ','0943784839',N'Thái Bình',N'Du lịch 3'),
(N'Nguyen Manh Long','2022245','19',N'Nam','0973374397',N'Hà Nội',N'CNTT 3'),
(N'Le Hoang Long','2027734','19',N'Nam','0937473437',N'Thái Bình',N'CNTT 4'),
(N'Le Van Nam','2028985','20',N'Nam','0936478384',N'Nam Định',N'CNTT 4'),
(N'Le Thi Tham','2024945','19',N'Nữ','0946374833',N'Thái Nguyên',N'QTKD 1'),
(N'Nguyen Kim Anh','2024546','20',N'Nữ','0963743746',N'Yên Bái',N'QTKD 1')
INSERT INTO detai VALUES
(N'Ung dung quan ly sinh vien','0777',N'20 ngày'),
(N'Thiet ke website ban hang dien thoai','0888',N'20 ngày'),
(N'Thiet ke website ban quan ao','0999',N'20 ngày'),
(N'Xay dung co so du lieu quan ly benh vien','1010',N'25 ngày')
INSERT INTO bangdiem VALUES
('0777','2028985','6','7.5',N'hoàn thành'),
('0888','2024945','6','4.5',N'chưa hoàn thành'),
('0999','2023345','7','8.75',N'hoàn thành'),
('1010','2024546','7.5','8.5',N'hoàn thành')
INSERT INTO monhoc VALUES
(N'Co so du lieu','01','4','550','2200'),
(N'Lap trinh mang','02','3','450','1350'),
(N'Thiet ke web','03','3','450','1350')
INSERT INTO giangvien VALUES
(N'Le Quy Mui',N'Nam','235','0967837352','03'),
(N'Nguyen Ngoc Minh',N'Nam','236','0973693886','01')

select * from monhoc where sotinchi >3
select count(sotinchi) from monhoc where sotinchi >3
select * from monhoc