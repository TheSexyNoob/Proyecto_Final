--------------------------------------------------------------------
-- Script that creates the sample database ParkingDB.
--
-- This script is based on MySQL 5.7.23
--
-- Last updated: 20180909 (YYYYMMDD)
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

CREATE USER IF NOT EXISTS 'ParkingAdmin'@'%' IDENTIFIED WITH mysql_native_password AS 'ParkingAdmin';
GRANT USAGE ON *.* TO 'ParkingAdmin'@'%' REQUIRE NONE WITH MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;
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
    CONSTRAINT UQ_Admin_phone   UNIQUE (phone)
)ENGINE = INNODB;

---------------------------------------------------------------------
-- Inserts
---------------------------------------------------------------------

INSERT INTO Admins (name, flastname, slastname, id, phone, mail) VALUES(N'Diego', N'Rubí', N'Salas', 117250628, 87108548, N'diegoalru@gmail.com');

---------------------------------------------------------------------
-- Show tables
---------------------------------------------------------------------

SELECT *
FROM Admins;