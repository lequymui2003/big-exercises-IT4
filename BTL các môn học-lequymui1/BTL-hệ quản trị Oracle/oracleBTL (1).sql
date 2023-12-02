 -- T?o b?ng ng??i d�ng
CREATE TABLE nguoidung (
  usename VARCHAR(40) NOT NULL,
  password VARCHAR(40) NOT NULL,
  comfirmpw VARCHAR(40) NOT NULL,
  email VARCHAR(50) NOT NULL,
  PRIMARY KEY (usename)
);

-- T?o b?ng sinh vi�n
CREATE TABLE sinhvien (
  hoten VARCHAR2(100) NOT NULL,
  ma_SV VARCHAR(10) NOT NULL,
  sdt VARCHAR(20) NOT NULL,
  diachi VARCHAR2(100) NOT NULL,
  ngaysinh DATE NOT NULL,
  lop VARCHAR(100) NOT NULL,
  gioitinh VARCHAR2(10) NOT NULL,
  PRIMARY KEY (ma_SV)
);

-- T?o b?ng ?? t�i
CREATE TABLE detai (
  ma_DT VARCHAR(10) NOT NULL,
  tenDT VARCHAR2(255) NOT NULL,
  gioihan VARCHAR(50) NOT NULL,
  PRIMARY KEY (ma_DT)
);

-- T?o b?ng b?ng ?i?m
CREATE TABLE bangdiem (
  diemlan1 FLOAT NOT NULL,
  diemlan2 FLOAT NOT NULL,
  nhanxet VARCHAR2(255) NOT NULL,
  ma_SV VARCHAR(10) NOT NULL,
  ma_DT VARCHAR(10) NOT NULL,
  FOREIGN KEY (ma_SV) REFERENCES sinhvien (ma_SV),
  FOREIGN KEY (ma_DT) REFERENCES detai(ma_DT)
);
-- T?o b?ng m�n h?c
CREATE TABLE monhoc (
  ma_MH VARCHAR(10) NOT NULL,
  tenMH VARCHAR2(50) NOT NULL,
  sotinchi INT NOT NULL,
  giatien INT NOT NULL,
  tongtien INT NOT NULL,
  PRIMARY KEY (ma_MH)
);

-- T?o b?ng ?i?m m�n h?c
CREATE TABLE diemMH (
  ma_SV VARCHAR(10) NOT NULL,
  ma_MH VARCHAR(10) NOT NULL,
  diemcc FLOAT NOT NULL,
  diemkt FLOAT NOT NULL,
  diemtk FLOAT NOT NULL,
  PRIMARY KEY (ma_SV, ma_MH),
  FOREIGN KEY (ma_SV) REFERENCES sinhvien (ma_SV),
  FOREIGN KEY (ma_MH) REFERENCES monhoc (ma_MH)
);

-- T?o b?ng gi?ng vi�n
CREATE TABLE giangvien (
  ma_GV VARCHAR(10) NOT NULL,
  hoten VARCHAR2(100) NOT NULL,
  ma_MH VARCHAR(10) NOT NULL,
  sdt VARCHAR(20) NOT NULL,
  gioitinh VARCHAR(20) NOT NULL,
  PRIMARY KEY (ma_GV),
  FOREIGN KEY (ma_MH) REFERENCES monhoc (ma_MH)
);

DECLARE
  usename VARCHAR(40) := 'user1';
  password VARCHAR(40) := '123456';
  comfirmpw VARCHAR(40) := '123456';
  email VARCHAR(50) := 'user1@example.com';
BEGIN
  -- Ki?m tra xem t�n ng??i d�ng ?� t?n t?i ch?a
  IF NOT EXISTS (SELECT * FROM nguoidung WHERE usename = usename) THEN
    -- Th�m d? li?u v�o b?ng
    INSERT INTO nguoidung (usename, password, comfirmpw, email)
    VALUES (usename, password, comfirmpw, email);
    dbms_output.put_line('Th�m ng??i d�ng th�nh c�ng!');
  ELSE
    dbms_output.put_line('T�n ng??i d�ng ?� t?n t?i!');
  END IF;
END;
CONNECT system/1 default
startup
CREATE DATABASE mydb
    DATAFILE 'D:\u01\app\oracle\oradata\ORCL21\minhdtrai.dbf'
    SIZE 20M;
SHUTDOWN
CONNECT

create spfile='D:\u01\app\oracle\database\minhDB.ora' from pfile


CREATE TEMPORARY TABLESPACE minh2
TEMPFILE 'D:\u01\app\oracle\oradata\ORCL21\minh2.dbf'
SIZE 30M;

 CREATE USER 123445
IDENTIFIED BY 123
DEFAULT TABLESPACE minh2
TEMPORARY TABLESPACE temp01
QUOTA 100M ON minh2;