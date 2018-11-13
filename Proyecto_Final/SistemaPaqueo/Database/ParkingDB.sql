--------------------------------------------------------------------
-- Script that creates the sample database ParkingDB.
--
-- This script is based on MySQL 5.7.23
--
-- Last updated: 20181009 (YYYYMMDD)
--
-- Diegoalru
---------------------------------------------------------------------

---------------------------------------------------------------------
-- Drop database
---------------------------------------------------------------------

DROP DATABASE IF EXISTS parkingdb;

---------------------------------------------------------------------
-- Create empty database ParkingDB
---------------------------------------------------------------------

CREATE SCHEMA IF NOT EXISTS parkingdb DEFAULT CHARACTER SET utf8;

---------------------------------------------------------------------
-- Erase default user is exist
---------------------------------------------------------------------

DROP USER IF EXISTS 'ParkingAdmin'@'%';

---------------------------------------------------------------------
-- Create default user
---------------------------------------------------------------------

CREATE USER IF NOT EXISTS 'ParkingAdmin'@'%' IDENTIFIED BY 'ParkingAdmin';
GRANT ALL PRIVILEGES ON *.* TO 'ParkingAdmin'@'%';
GRANT ALL PRIVILEGES ON `parkingdb`.* TO 'ParkingAdmin'@'%' WITH GRANT OPTION;

---------------------------------------------------------------------
-- Use ParkingDB
---------------------------------------------------------------------

USE parkingdb;

---------------------------------------------------------------------
-- Create Tables
---------------------------------------------------------------------

CREATE TABLE Admins
(
	code 		INT(4)			NOT NULL	AUTO_INCREMENT,
    name 		NVARCHAR(20)	NOT NULL,
    flastname	NVARCHAR(20)	NOT NULL,
    slastname	NVARCHAR(20)	NOT NULL,
    id			INT(9)			NOT NULL,
    phone		INT(8)			NOT NULL,
    mail 		NVARCHAR(20)	NOT NULL,
    CONSTRAINT PK_Admin_code	PRIMARY KEY (code),
    CONSTRAINT UQ_Admin_id      UNIQUE (id),
    CONSTRAINT UQ_Admin_phone   UNIQUE (phone)
)ENGINE = INNODB;

---------------------------------------------------------------------
-- Inserts
---------------------------------------------------------------------

INSERT INTO Admins (name, flastname, slastname, id, phone, mail) VALUES(N'Diego', N'Rubí', N'Salas', 117250628, 87108548, N'diegoalru@gmail.com');
INSERT INTO Admins (name, flastname, slastname, id, phone, mail) VALUES(N'Admin', N'lastName', N'lastName', 117250629, 87108549, N'diegoalru@gmail.com');

---------------------------------------------------------------------
-- Show tables
---------------------------------------------------------------------

SELECT *
FROM Admins;