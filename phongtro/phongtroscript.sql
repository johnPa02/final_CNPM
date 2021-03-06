CREATE DATABASE QLPT
GO
USE QLPT
GO

CREATE TABLE MATKHAU
(
	USERNAME VARCHAR(30) primary key,
	PW VARCHAR(30)
)

CREATE TABLE NHANVIEN
(
	MANV CHAR(5) PRIMARY KEY,
	HOTEN NVARCHAR(30) NOT NULL,
	NGAYSINH DATE,
	SDT CHAR(11),
	QUEQUAN NVARCHAR(30),
	NGAYVAOLAM DATE,
)
CREATE TABLE KHACHHANG
(
	MAKH CHAR(5) PRIMARY KEY,
	HOTENKH NVARCHAR(30),
	NGAYSINH DATE,
	QUEQUAN NVARCHAR(30),
	SDT CHAR(11)
)


CREATE TABLE HOADON
(
	MAHD CHAR(5) PRIMARY KEY,
	MAKH CHAR(5),
	NGAYHOADON DATE,
	MAPHONG CHAR(5),
	TONGTIEN INT,
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
)

CREATE TABLE CHITIETHOADON
(
	MAHD CHAR(5) NOT NULL,
	TENDV NVARCHAR(30) NOT NULL,
	SOLUONG INT,
	DONGIA INT,
	PRIMARY KEY(MAHD,TENDV),
	FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)
)
DROP TABLE CHITIETHOADON