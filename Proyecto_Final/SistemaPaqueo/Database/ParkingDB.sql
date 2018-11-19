-- ------------------------------------------------------------------
-- Script that creates the sample database ParkingDB.
--
-- This script is based on MySQL 5.7.23
--
-- Last updated: 20181119 (YYYYMMDD)
--
-- Diegoalru
-- ------------------------------------------------------------------

-- ------------------------------------------------------------------
-- Drop database
-- ------------------------------------------------------------------

DROP DATABASE IF EXISTS parkingdb;

-- ------------------------------------------------------------------
-- Create empty database ParkingDB
-- ------------------------------------------------------------------

CREATE SCHEMA IF NOT EXISTS parkingdb DEFAULT CHARACTER SET utf8;

-- ------------------------------------------------------------------
-- Erase default user is exist
-- ------------------------------------------------------------------

DROP USER IF EXISTS 'ParkingAdmin'@'%';

-- ------------------------------------------------------------------
-- Create default user
-- ------------------------------------------------------------------

CREATE USER IF NOT EXISTS 'ParkingAdmin'@'%' IDENTIFIED BY 'ParkingAdmin';
GRANT ALL PRIVILEGES ON *.* TO 'ParkingAdmin'@'%';
GRANT ALL PRIVILEGES ON `parkingdb`.* TO 'ParkingAdmin'@'%' WITH GRANT OPTION;

-- ------------------------------------------------------------------
-- Use ParkingDB
-- ------------------------------------------------------------------

USE parkingdb;

-- -------------------------------------------------------------------
-- Drop tables
-- -------------------------------------------------------------------

DROP TABLE IF EXISTS Admins;
DROP TABLE IF EXISTS Vehicules;
-- DROP procedure IF EXISTS AdminChecker;

-- ------------------------------------------------------------------
-- Drop Routines
-- ------------------------------------------------------------------

DROP procedure IF EXISTS GetAdmins;
DROP procedure IF EXISTS AdminChecker;

-- ------------------------------------------------------------------
-- Create Tables
-- ------------------------------------------------------------------

CREATE TABLE Admins
(
	code 		INT(4)			 NOT NULL	AUTO_INCREMENT,
    password	NVARCHAR(20)	 NOT NULL,
    name 		NVARCHAR(20)	 NOT NULL,
    flastname	NVARCHAR(20)	 NOT NULL,
    slastname	NVARCHAR(20)	 NOT NULL,
    id			INT(9)			 NOT NULL,
    phone		INT(8)			 NOT NULL,
    mail 		NVARCHAR(20)	 NOT NULL,
    CONSTRAINT PK_Admin_code	 PRIMARY KEY (code),
    CONSTRAINT UQ_Admin_id       UNIQUE (id),
    CONSTRAINT UQ_Admin_phone    UNIQUE (phone)
)ENGINE = INNODB;

CREATE TABLE Vehicules
(
    licensePlate	VARCHAR(6)		   NOT NULL,
    colour 		    NVARCHAR(20),
    model	        NVARCHAR(20),
    type			NVARCHAR(20),
    InHour			DATETIME DEFAULT   CURRENT_TIMESTAMP,
    OutHour			DATETIME NULL,
    description		VARCHAR(250),
    CONSTRAINT      UQ_Vehicules_licensePlate     UNIQUE(licensePlate)
)ENGINE = INNODB;


/*CREATE TABLE Client
(
	code 		    INT(8)			 NOT NULL	AUTO_INCREMENT,
    id			    INT(9)			 NOT NULL,
    name 		    NVARCHAR(20)	 NOT NULL,
    company	        NVARCHAR(20)	 NOT NULL,
    vehiculePlate	VARCHAR(6)		 
    CONSTRAINT      PK_Client_code	 PRIMARY KEY (code),
    CONSTRAINT      UQ_Client_id     UNIQUE (id)
)ENGINE = INNODB;*/

-- ------------------------------------------------------------------
-- Inserts
-- ------------------------------------------------------------------

INSERT INTO Admins (password, name, flastname, slastname, id, phone, mail) VALUES(N'qwerty', N'Diego', N'Rubí', N'Salas', 117250628, 87108548, N'diegoalru@gmail.com');
INSERT INTO Admins (password, name, flastname, slastname, id, phone, mail) VALUES(N'qwerty', N'Admin', N'lastName', N'lastName', 117250629, 87108549, N'diegoalru@gmail.com');
-- ------------------------------------------------------------------
-- Create Routines
-- ------------------------------------------------------------------

DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE GetAdmins ()
BEGIN
SELECT code
       ,password
       ,name
       ,flastname
       ,slastname
       ,id
       ,phone
       ,mail
FROM Admins;
END$$
DELIMITER ;

DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE AdminChecker (AdminCode INT(4), AdminPassword NVARCHAR(20))
BEGIN
SELECT code
       ,mail
	   ,password
FROM Admins
WHERE code = AdminCode
	  AND password = AdminPassword;
END$$

DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE InsertVehicule(_licensePlate VARCHAR(6), _colour NVARCHAR(20), _model NVARCHAR(20), _type NVARCHAR(20), _description VARCHAR(250))
BEGIN
INSERT INTO Vehicules (licensePlate, colour, model, type, description) VALUES (_licensePlate, _colour, _model, _type, _description);
END$$

DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE GetVehiculeTime(plate VARCHAR(6), salida DATETIME)
BEGIN
-- Firts we set the time of the vehicule.
UPDATE Vehicules 
SET OutHour = CURRENT_TIMESTAMP 
WHERE licensePlate = plate;
-- We get the time that the car spend on the parking lot.
SELECT TIMEDIFF(InHour,OutHour) Tiempo_En_Parqueo
FROM Vehicules
WHERE licensePlate = plate;
END$$

DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE DeleteVehicule(plate VARCHAR(6))
BEGIN
-- We get the time that the car spend on the parking lot.
DELETE FROM Vehicules WHERE licensePlate = plate;
END$$

				/* JUST FOR TEST */
                /* JUST FOR TEST */
                /* JUST FOR TEST */
                /* JUST FOR TEST */
-- ------------------------------------------------------------------
-- Execute routines
-- ------------------------------------------------------------------


CALL GetAdmins();

CALL AdminChecker(1, N'qwerty');

CALL InsertVehicule('BCC997', 'ROJO', 'RAV4', 'TIPO...', 'Vehiculo en perfectas condiciones');

CALL GetVehiculeTime('BCC997', CURRENT_TIMESTAMP);

CALL DeleteVehicule('BCC997');