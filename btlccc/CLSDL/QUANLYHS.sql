use master 
go
if(exists(select * from sysdatabases where name='QUANLYHS'))
drop database QUANLYHS
go
create database QUANLYHS 



go
use QUANLYHS
go
create table MonHoc
(
MaMon nvarchar(100) not null primary key,
TenMon nvarchar(200) not null,
SoTiet int not null
)
create table CanBoGiaoVien
(
MaCanBoGiaoVien nvarchar(100) not null primary key,
HoTen nvarchar(200) not null,
DiaChi nvarchar(200) not null,
SoDienThoai nvarchar(101) not null,
TaiKhoan nvarchar(200) not null,
MatKhau nvarchar(80) not null,
LoaiTaiKhoan nvarchar(100) not null
)
create table Lop
(
MaLop nvarchar(100) not null primary key,
TenLop nvarchar(200) not null,
NienKhoa nvarchar(100) not null,
SiSo int not null,
GiaoVienChuNhiem nvarchar(100) not null,
constraint GVCN_Lop_CBGV foreign key(GiaoVienChuNhiem) references CanBoGiaoVien(MaCanBoGiaoVien)
on delete cascade on update cascade
)
create table HoSoHocSinh
(
MaHocSinh nvarchar(100) not null primary key,
HoTen nvarchar(200) not null,
NgaySinh datetime not null,
GioiTinh nvarchar(50) not null,
DiaChi nvarchar(200) not null,
DiemVaoTruong float not null,
HoTenBoMe nvarchar(200) not null,
SoDienThoai nvarchar(110) not null,
MaLop nvarchar(100) not null,
constraint Malop_HSHS_Lop foreign key (MaLop) references Lop(MaLop)
on delete cascade on update cascade
)
create table Diem
(
MaHocSinh nvarchar(100) not null,
MaMonHoc nvarchar(100) not null,
DiemTB_Ky1 float  null,
DiemTB_Ky2 float  null,
primary key(MaHocSinh,MaMonHoc),
constraint MaHS_Diem_HSHS foreign key (MaHocSinh) references HoSoHocSinh(MaHocSinh)
on delete cascade on update cascade,
constraint MaMon_Diem_Mon foreign key (MaMonHoc) references MonHoc(MaMon)
on delete cascade on update cascade
)
create table PhanCongGiangDay
(
MaLop nvarchar(100) not null,
MaMon nvarchar(100) not null,
MaCanBoGiaoVien nvarchar(100) not null,
NgayPhanCong datetime not null,
primary key (MaLop,MaMon,MaCanBoGiaoVien),
constraint Lop_PhanCong foreign key (MaLop) references Lop(MaLop),
constraint CBGV_PhanCong foreign key (MaCanBoGiaoVien) references CanBoGiaoVien(MaCanBoGiaoVien)
on delete cascade on update cascade,
constraint Mon_PhanCong foreign key (MaMon) references MonHoc(MaMon)
on delete cascade on update cascade
)
go
delete CanBoGiaoVien

select *from MonHoc

--mon
insert into MonHoc values ('MH0001','lap trinh window','45')
insert into MonHoc values ('MH0002','lap trinh nhung','45')
insert into MonHoc values ('MH0003','lap trinh web','45')
insert into MonHoc values ('MH0004','lap trinh android','45')
insert into MonHoc values ('MH0005','lap trinh app','45')

--can bo giao vien

insert into CanBoGiaoVien values ('GV0001','Nguyen Van An','Ha Noi','012345678','nguyen thi','1','gv')
insert into CanBoGiaoVien values ('GV0002','Nguyen Duc Anh','Thai Binh','012345678','nguyen thu','1','gv')
--insert into CanBoGiaoVien values ('gv3','nguyen thi c','ha noi','012345678','nguyen thi c','1','gv')
insert into CanBoGiaoVien values ('GV0003','Nguyen Van Canh','Hai Duong','098765432','admin','admin','admin')
--delete from CanBoGiaoVien
--Lop
insert into Lop values ('LH0001','cong  nghe thong tin','2018-2019','3','GV0001')
insert into Lop values ('LH0002','khoa hoc may tin','2018-2019','3','GV0002')
insert into Lop values ('LH0003','ky thuat phan mem','2018-2019','3','GV0001')
insert into Lop values ('LH0004','dien tu','2018-2019','3','GV0002')
insert into Lop values ('LH0005','tu dong hoa','2018-2019','3','GV0002')
insert into Lop values ('LH0006','tieng anh','2017-2018','3','GV0001')
--insert into Lop values ('lop7','tieng nhat','2016-2017','3','gv1')
--delete Lop
select * from Lop
---ho so hoc sinh

insert into HoSoHocSinh values ('HS0001','Do Duc Vinh','12/20/1997','nam','ha noi',10,'ko biet','01696437653','LH0001')
insert into HoSoHocSinh values ('HS0002','Nguyen Duc Anh','12/20/1997','nam','ha noi',10,'ko biet','01696437653','LH0002')
insert into HoSoHocSinh values ('HS0003','Nguyen Duc Ba','12/20/1997','nam','ha noi',10,'ko biet','01696437653','LH0001')
insert into HoSoHocSinh values ('HS0004','Do Van Bang','12/20/1997','nam','ha noi',10,'ko biet','01696437653','LH0004')
insert into HoSoHocSinh values ('HS0005','Dao Duc Ngao','12/20/1997','nam','ha noi',10,'ko biet','01696437653','LH0003')

-----------------------------------
insert into HoSoHocSinh values ('HS0006','Nguyen Duc Thang','12/20/1997','nam','ha noi',10,'ko biet','01696437653','LH0005')
insert into HoSoHocSinh values ('hs7','do duc trang','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')

----Lay 5 ban ghi------

insert into HoSoHocSinh values ('hs8','nguyen duc hoa','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
insert into HoSoHocSinh values ('hs9','do duc qua','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs10','tran duc com','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs11','ly duc canh','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop5')
insert into HoSoHocSinh values ('hs12','ton duc vi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop5')
insert into HoSoHocSinh values ('hs13','ta duc ngot','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop6')
insert into HoSoHocSinh values ('hs14','la duc nhat','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop6')
insert into HoSoHocSinh values ('hs15','tu duc nhi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs16','truong duc the','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop5')
insert into HoSoHocSinh values ('hs17','trieu duc gioi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop6')
insert into HoSoHocSinh values ('hs18','hoa duc nha','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop1')
insert into HoSoHocSinh values ('hs19','Tran duc nha','12/20/1997','Nu','ha noi',10,'ko biet','01696437653','lop1')
insert into HoSoHocSinh values ('hs20','hoa duc hieu','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs21','do duc khong','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
insert into HoSoHocSinh values ('hs22','ta bien cuong','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs23','le cong vinh','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop5')
insert into HoSoHocSinh values ('hs24','bui thi yen','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop6')
insert into HoSoHocSinh values ('hs25','tran van chi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs26','anh thi muon','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs27','cuong thi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')

insert into HoSoHocSinh values ('hs28','ta bien cuong','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs29','le cong vinh','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop5')
insert into HoSoHocSinh values ('hs30','bui thi yen','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop6')
insert into HoSoHocSinh values ('hs31','tran van chi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
insert into HoSoHocSinh values ('hs32','anh thi muon','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs33','cuong thi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
insert into HoSoHocSinh values ('hs34','ta bien cuong','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs35','le cong vinh','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop5')
insert into HoSoHocSinh values ('hs36','bui thi yen','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop6')
insert into HoSoHocSinh values ('hs37','tran van chi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop4')
insert into HoSoHocSinh values ('hs38','anh thi muon','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs39','cuong thi','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
insert into HoSoHocSinh values ('hs40','Tran duc nha','12/20/1997','Nu','ha noi',10,'ko biet','01696437653','lop1')
insert into HoSoHocSinh values ('hs41','hoa duc hieu','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs42','do duc khong','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
insert into HoSoHocSinh values ('hs43','Tran duc nha','12/20/1997','Nu','ha noi',10,'ko biet','01696437653','lop1')
insert into HoSoHocSinh values ('hs44','hoa duc hieu','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop2')
insert into HoSoHocSinh values ('hs45','do duc khong','12/20/1997','nam','ha noi',10,'ko biet','01696437653','lop3')
select * from HoSoHocSinh


delete HoSoHocSinh

--diem
insert into Diem values ('HS0001','MH0001',10,null)
insert into Diem values ('HS0002','MH0003',null,10)
insert into Diem values ('HS0003','MH0002',7,null)
insert into Diem values ('HS0004','MH0005',null,8)
insert into Diem values ('HS0005','MH0004',2,null)
insert into Diem values ('HS0006','MH0004',null,10)



insert into Diem values ('hs7','mon3',3,null)
insert into Diem values ('hs8','mon3',null,8)
insert into Diem values ('hs9','mon3',6,null)
insert into Diem values ('hs10','mon4',null,10)
insert into Diem values ('hs11','mon4',10,4)
insert into Diem values ('hs12','mon4',10,null)
insert into Diem values ('hs13','mon5',1,10)
insert into Diem values ('hs14','mon5',7,null)
insert into Diem values ('hs15','mon5',10,8)
insert into Diem values ('hs16','mon1',null,10)
insert into Diem values ('hs17','mon2',9,10)
insert into Diem values ('hs18','mon1',10,10)
insert into Diem values ('hs19','mon2',null,10)
insert into Diem values ('hs20','mon3',10,3)
insert into Diem values ('hs21','mon4',6,10)
insert into Diem values ('hs22','mon5',10,2)
insert into Diem values ('hs23','mon2',null,10)
insert into Diem values ('hs24','mon4',5,10)
insert into Diem values ('hs25','mon2',null,10)
insert into Diem values ('hs26','mon1',10,7)
insert into Diem values ('hs27','mon5',null,10)


insert into Diem values ('hs28','mon5',7,null)
insert into Diem values ('hs29','mon5',10,8)
insert into Diem values ('hs30','mon1',null,10)
insert into Diem values ('hs31','mon2',9,10)
insert into Diem values ('hs32','mon1',10,10)
insert into Diem values ('hs33','mon2',null,10)
insert into Diem values ('hs34','mon3',10,3)
insert into Diem values ('hs35','mon4',6,10)
--
--insert into Diem values ('hs42','mon5',null,10)
select *from Diem
--delete Diem
--phan cong
select * from Diem

insert into PhanCongGiangDay values ('LH0001','MH0001','GV0001','12-22-2016')
insert into PhanCongGiangDay values ('LH0002','MH0005','GV0002','12-22-2016')
insert into PhanCongGiangDay values ('LH0003','MH0004','GV0002','12-22-2016')
insert into PhanCongGiangDay values ('LH0004','MH0002','GV0001','12-22-2016')
insert into PhanCongGiangDay values ('LH0005','MH0003','GV0001','12-22-2016')

--insert into PhanCongGiangDay values ('lop1','mon3','gv2','12-22-2016')


--insert into PhanCongGiangDay values ('lop6','mon4','gv2','12-22-2016')
--insert into PhanCongGiangDay values ('lop2','mon5','gv2','12-22-2016')
--insert into PhanCongGiangDay values ('lop1','mon5','gv2','12-22-2016')
select * from PhanCongGiangDay
--delete PhanCongGiangDay
select *from Diem 