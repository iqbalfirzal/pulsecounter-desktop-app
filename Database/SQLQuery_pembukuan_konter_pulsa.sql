CREATE DATABASE Pembukuan_Counter_Pulsa
ON
(
NAME= 'PEMBUKUAN_COUNTER_PULSA_DAT',
FILENAME= 'E:\1- KULIAH -1\Pemrograman Lanjut\FinalProject\Database\PEMBUKUAN_COUNTER_PULSA_DAT.MDF',
SIZE= 5,
MAXSIZE= 20,
FILEGROWTH= 5
)

LOG ON
(
NAME= 'PEMBUKUAN_COUNTER_PULSA_LOG',
FILENAME= 'E:\1- KULIAH -1\Pemrograman Lanjut\FinalProject\Database\PEMBUKUAN_COUNTER_PULSA_LOG.LDF',
SIZE= 5,
MAXSIZE= 20,
FILEGROWTH= 5
)

CREATE TABLE Manager
(
kd_Manager char(6) primary key not null,
USERNAME varchar(20),
PASSWORD varbinary(225),
Nama varchar(30) not null,
Gender char(1) check(gender='L' or gender='P'),
Tempat_Lahir varchar(30),
Tanggal_Lahir DATE,
Alamat varchar(30),
Nomor_Handphone numeric
)

CREATE TABLE Karyawan
(
kd_Karyawan char(6) primary key not null,
USERNAME varchar(20),
PASSWORD varbinary(225),
Nama varchar(30) not null,
Gender char(1) check(gender='L' or gender='P'),
Tempat_Lahir varchar(30),
Tanggal_Lahir DATE,
Alamat varchar(30),
Nomor_Handphone numeric,
Gaji numeric
)

CREATE TABLE Jenis_Pulsa
(
kd_Jenis_Pulsa char(6) primary key not null,
nama_Jenis varchar(30)
)

CREATE TABLE Provider
(
kd_Provider char(6) primary key not null,
nama_Provider varchar(30)
)

CREATE TABLE Pulsa
(
kd_Pulsa char(6) primary key not null,
Harga numeric,
nominal numeric,
keterangan char(30) not null ,
kd_Jenis_Pulsa char(6) foreign key references Jenis_Pulsa(kd_Jenis_Pulsa),
kd_Provider char(6) foreign key references Provider(kd_Provider)
)

CREATE TABLE Transaksi
(
kd_Transaksi int identity(00000001,1) primary key not null,
nomor_Handphone char(20) not null,
tanggal_Transaksi datetime,
kd_Pulsa char(6) foreign key references Pulsa(kd_Pulsa),
kd_Karyawan char(6) foreign key references Karyawan(kd_Karyawan)
)

select * from Karyawan

insert into Karyawan values ('KRY001','user',HASHBYTES('sha1','user'),'user yang rajin','L','Yogyakarta','1998/06/06','Yogyakarta','0812345679',175000)

insert into Manager values ('MNG001','admin',HASHBYTES('sha1','admin'),'admin yang budiman','L','Yogyakarta','1989/06/06','Yogyakarta','0812345678')

SELECT * FROM Karyawan

SELECT kd_Transaksi, tanggal_Transaksi, kd_Pulsa, kd_Karyawan FROM Transaksi

insert into Provider values ('PR0001','Simpati')
insert into Provider values ('PR0002','IM3')
insert into Provider values ('PR0003','PLN')
insert into Provider values ('PR0004','AS')
insert into Provider values ('PR0005','Tri')
insert into Provider values ('PR0006','Smartfren')
insert into Provider values ('PR0007','XL')
insert into Provider values ('PR0008','Telkomsel')
insert into Provider values ('PR0009','BOLT')
insert into Provider values ('PR0010','Hinet')
insert into Provider values ('PR0011','Axis')
insert into Provider values ('PR0012','Net1')
insert into Provider values ('PR0013','Telkom')

insert into Jenis_PULSA values ('JP0001','Pulsa Data 1GB')
insert into Jenis_PULSA values ('JP0002','Pulsa Data 2GB')
insert into Jenis_PULSA values ('JP0003','Pulsa Data 3GB')
insert into Jenis_PULSA values ('JP0004','Pulsa Data 4GB')
insert into Jenis_PULSA values ('JP0005','Pulsa Data 5GB')
insert into Jenis_PULSA values ('JP0006','Pulsa Data 6GB')
insert into Jenis_PULSA values ('JP0007','Pulsa Data 7GB')
insert into Jenis_PULSA values ('JP0008','Pulsa Data 8GB')
insert into Jenis_PULSA values ('JP0009','Pulsa Data 9GB')
insert into Jenis_PULSA values ('JP0010','Pulsa Data 10GB')
insert into Jenis_PULSA values ('JP0011','Pulsa Data 11GB')
insert into Jenis_PULSA values ('JP0012','Pulsa Data 12GB')
insert into Jenis_PULSA values ('JP0013','Pulsa Data 13GB')
insert into Jenis_PULSA values ('JP0014','Pulsa Data 14GB')
insert into Jenis_PULSA values ('JP0015','Pulsa Data 15GB')
insert into Jenis_PULSA values ('JP0016','Pulsa Data 16GB')
insert into Jenis_PULSA values ('JP0017','Pulsa Data 17GB')
insert into Jenis_PULSA values ('JP0018','Pulsa Data 18GB')
insert into Jenis_PULSA values ('JP0019','Pulsa Data 19GB')
insert into Jenis_PULSA values ('JP0020','Pulsa Data 20GB')
insert into Jenis_PULSA values ('JP0021','Pulsa Listrik 25000')
insert into Jenis_PULSA values ('JP0022','Pulsa Listrik 50000')
insert into Jenis_PULSA values ('JP0023','Pulsa Listrik 100000')
insert into Jenis_PULSA values ('JP0024','Pulsa Listrik 200000')
insert into Jenis_PULSA values ('JP0025','Pulsa Listrik 250000')
insert into Jenis_PULSA values ('JP0026','Pulsa Listrik 300000')
insert into Jenis_PULSA values ('JP0027','Pulsa Listrik 350000')
insert into Jenis_PULSA values ('JP0028','Pulsa Listrik 500000')
insert into Jenis_PULSA values ('JP0029','Pulsa Listrik 1000000')
insert into Jenis_PULSA values ('JP0030','Pulsa Listrik 2000000')
insert into Jenis_PULSA values ('JP0031','Pulsa 5000')
insert into Jenis_PULSA values ('JP0032','Pulsa 10000')
insert into Jenis_PULSA values ('JP0033','Pulsa 25000')
insert into Jenis_PULSA values ('JP0034','Pulsa 50000')
insert into Jenis_PULSA values ('JP0035','Pulsa 100000')

insert into Pulsa values ('P00001','27000','25000','Data Simpati 2GB','JP0002','PR0001')
insert into Pulsa values ('P00002','33000','30000','Data Simpati 3GB','JP0003','PR0001')
insert into Pulsa values ('P00003','65000','63000','Data Simpati 6GB','JP0006','PR0001')
insert into Pulsa values ('P00004','85000','83000','Data Simpati 10GB','JP0010','PR0001')
insert into Pulsa values ('P00005','25000','23000','Data IM3 2GB','JP0002','PR0002')
insert into Pulsa values ('P00006','31000','28000','Data IM3 3GB','JP0003','PR0002')
insert into Pulsa values ('P00007','60000','58000','Data IM3 6GB','JP0006','PR0002')
insert into Pulsa values ('P00008','80000','78000','Data IM3 10GB','JP0010','PR0002')
insert into Pulsa values ('P00009','23000','20000','Listrik 25000 PLN','JP0021','PR0003')
insert into Pulsa values ('P00010','53000','50000','Listrik 50000 PLN','JP0022','PR0003')
insert into Pulsa values ('P00011','103000','100000','Listrik 100000 PLN','JP0023','PR0003')
insert into Pulsa values ('P00012','203000','200000','Listrik 200000 PLN','JP0024','PR0003')
insert into Pulsa values ('P00013','7000','5000','Pulsa 5000 AS','JP0031','PR0004')
insert into Pulsa values ('P00014','11000','10000','Pulsa 10000 Tri','JP0032','PR0005')

insert into Transaksi values ('6285869145466',getdate(),'P00001','KRY001')
insert into Transaksi values ('6285869145566',getdate(),'P00002','KRY001')
insert into Transaksi values ('6285869145465',getdate(),'P00001','KRY001')

select * from Karyawan
select * from Manager
select * from Transaksi
select * from Pulsa
select * from Jenis_Pulsa
select * from Provider

SELECT kd_Transaksi, tanggal_Transaksi, kd_Pulsa, kd_Karyawan FROM Transaksi
SELECT kd_Karyawan, Nama, Gender, Tempat_Lahir, Tanggal_Lahir, Alamat, Nomor_Handphone, Gaji, USERNAME, PASSWORD FROM Karyawan

SELECT t.kd_Transaksi, t.nomor_Handphone, p.nominal, p.Harga, k.Nama, t.tanggal_Transaksi 
FROM Transaksi t INNER JOIN pulsa p ON t.kd_Pulsa = p.kd_Pulsa INNER JOIN Karyawan k ON t.kd_Karyawan = k.kd_Karyawan

SELECT p.kd_Pulsa, p.nominal, p.Harga, jp.nama_Jenis, pv.nama_Provider, p.keterangan FROM Pulsa p INNER JOIN Jenis_Pulsa jp ON p.kd_Jenis_Pulsa = jp.kd_Jenis_Pulsa INNER JOIN Provider pv ON p.kd_Provider = pv.kd_Provider
ALTER TABLE Pulsa ALTER COLUMN keterangan varchar(30) not null
select getdate()