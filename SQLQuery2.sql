Use COSO;

create table DonVi
(
	MaDonVi varchar(6) primary key,
	TenDonVi varchar(50),
	MaCoSo varchar(6)
);

create table GV
(
	MaGV varchar(6) primary key,
	HoTen varchar(50),
	Sdt char(15),
	GhiChu varchar(50),
	MaDonVi varchar(6)
);



insert into DonVi (MaDonVi, TenDonVi, MaCoSo) values ('A001', 'Truong A', 'AB001'),
 ('A002', 'Truong B', 'AB002'), 
 ('A003', 'Truong C', 'AB001'), 
 ('A004', 'Truong D', 'AB002');

 insert into GV (MaGV, HoTen, Sdt, GhiChu, MaDonVi) values ('GV001', 'Nguyen Van A', '0123456789', NULL, 'A001'), 
 ('GV002', 'Tran Van B', '0123456789', NULL, 'A001'),
 ('GV003', 'Nguyen Thi D', '0987654321', NULL, 'A002'),
 ('GV004', 'Nguyen Van C', '0987123456', NULL, 'A002'),
 ('GV005', 'Doan Thi E', '0321456789', NULL, 'A003'),
 ('GV006', 'Vuong Thi M', '0123987654', NULL, 'A003'),
 ('GV007', 'Cao Van N', '0123456987', NULL, 'A004'),
 ('GV008', 'Nguyen Hoang P', '0123498765', NULL, 'A004');

 select * from DonVi;
 select * from GV;

 select distinct MaCoSo from DonVi;