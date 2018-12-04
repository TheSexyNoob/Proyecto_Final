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
DROP TABLE IF EXISTS Clients;
DROP TABLE IF EXISTS TypeOfVehicules;
DROP TABLE IF EXISTS Parking;
DROP TABLE IF EXISTS Spot_type;
DROP TABLE IF EXISTS Spot;
DROP TABLE IF EXISTS Bill;

-- ------------------------------------------------------------------
-- Drop Routines
-- ------------------------------------------------------------------

DROP procedure IF EXISTS GetAdmins;
DROP procedure IF EXISTS GetVehicules;
DROP procedure IF EXISTS GetClients;
DROP procedure IF EXISTS GetBills;
DROP procedure IF EXISTS AdminChecker;
DROP procedure IF EXISTS ReturnCodeClient;
DROP procedure IF EXISTS InsertVehicule;
DROP procedure IF EXISTS GetVehiculeTime;
DROP procedure IF EXISTS DeleteVehicule;
DROP procedure IF EXISTS GetTypes;
DROP procedure IF EXISTS CreateBill;

-- DROP procedure IF EXISTS test;
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

CREATE TABLE Clients
(
	code 		    INT(8)			   NOT NULL	   AUTO_INCREMENT,
    id			    INT(9)			   NOT NULL,
    name 		    NVARCHAR(20)	   NOT NULL,
    company	        NVARCHAR(20)	   NOT NULL,
    CONSTRAINT      PK_Client_code	   PRIMARY KEY (code),
    CONSTRAINT      UQ_Client_id       UNIQUE 	   (id)
)ENGINE = INNODB;

CREATE TABLE Parking
(
	code 		    INT(8)			    NOT NULL    AUTO_INCREMENT,
--  number			INT(3)				NOT NULL,
	name			NVARCHAR(30)		NOT NULL,
	CONSTRAINT 		PK_Parking_Code		PRIMARY KEY(code)
)ENGINE = INNODB;

CREATE TABLE TypeOfVehicules
(
    code 		    INT(1)			   NOT NULL,
    description		varchar(20)		   NOT NULL,
    fare		    decimal	     	   NOT NULL,
    CONSTRAINT      PK_Type_code	   PRIMARY KEY (code)
)ENGINE = INNODB;

CREATE TABLE Vehicules
(	
	code 		    INT(8)			   NOT NULL    AUTO_INCREMENT,
    licensePlate	VARCHAR(6)		   NOT NULL,
    codeCLient		INT(8)			   NOT NULL,
    colour 		    NVARCHAR(20),
    model	        NVARCHAR(20),
    type			INT(1)			   NOT NULL,
    InHour			DATETIME DEFAULT   CURRENT_TIMESTAMP,
    OutHour			DATETIME NULL,
    description		VARCHAR(250),
    CONSTRAINT      PK_Vehicules_code  PRIMARY KEY (code),
    CONSTRAINT      UQ_Vehicules_licensePlate  UNIQUE(licensePlate),
    CONSTRAINT		FK_Client_vehicule FOREIGN KEY (codeCLient) REFERENCES Clients (code),
    CONSTRAINT		FK_Vehicules_type  FOREIGN KEY (type) REFERENCES TypeOfVehicules (code)
)ENGINE = INNODB;

CREATE TABLE Spot_type
(
	code			INT(1)				NOT NULL,
    name			NVARCHAR(20)		NOT NULL,
    CONSTRAINT 	PK_SpotType_code		PRIMARY KEY(code)
)ENGINE = INNODB;

CREATE TABLE Spot
(
	code			INT(5)				NOT NULL,
    number			INT(3)				NOT NULL,
    type			INT(1)				NOT NULL,
    licensePlate	VARCHAR(6)		   	NOT NULL,
    CONSTRAINT 		PK_Spot_code		PRIMARY KEY(code),
    CONSTRAINT  	FK_Spot_type		FOREIGN KEY (type)	REFERENCES Spot_type(code),
    CONSTRAINT  	FK_Spot_licensePlate FOREIGN KEY (licensePlate)	REFERENCES Vehicules(licensePlate)
)ENGINE = INNODB;

CREATE TABLE Bill
(
	code 		    INT(7)			    NOT NULL    AUTO_INCREMENT,
    parkingname		NVARCHAR(30)		NOT NULL, -- parking	
	licensePlate	VARCHAR(6)		    NOT NULL, -- vehicule
    type			INT(1)			    NOT NULL, -- vehicule
    InHour			DATETIME 		    NOT NULL, -- vehicule
    OutHour			DATETIME 			NOT NULL, -- vehicule
    idClient	    INT(9)			    NOT NULL, -- client
    name 			NVARCHAR(20)	    NOT NULL, -- client
    company	        NVARCHAR(20)	    NOT NULL, -- client
    adm_name 		NVARCHAR(20)	    NOT NULL, -- admin
    adm_mail		NVARCHAR(20)	 	NOT NULL, -- admin
    CONSTRAINT 		PK_Bill_code		PRIMARY KEY(code),
    CONSTRAINT		FK_Bill_license		FOREIGN KEY(licensePlate) REFERENCES Vehicules(licensePlate),
    CONSTRAINT		FK_Bill_id			FOREIGN KEY(idClient) 	  REFERENCES Clients(id)
)ENGINE=INNODB;

-- ------------------------------------------------------------------
-- Create Routines
-- ------------------------------------------------------------------

-- This method is for return all the data from Admins.
DELIMITER $$
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


-- This method is for return all the data from Vehicules.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE GetVehicules ()
BEGIN
SELECT  licensePlate
		,codeClient
		,colour
		,model
		,type
		,InHour
		,OutHour
		,description
FROM Vehicules;
END$$
DELIMITER ;

-- This method is for return all the data from Clients.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE GetClients ()
BEGIN
SELECT code
		,id
		,name
		,company
FROM Clients;
END$$
DELIMITER ;

-- This method is for return all the types of vehicules and thier fare.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE GetTypes()
BEGIN
SELECT code
		,description
		,fare
FROM TypeOfVehicules;
END$$
DELIMITER ;

-- With this method, you can check if the admin that we are looking for exists.
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

-- This method retunrs the code of a client, with it's ID.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE ReturnCodeClient(idCLient INT(9))
BEGIN
SELECT code 
FROM Clients 
WHERE id =  idCLient;
END$$

-- With this method we establish the time of departure.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE SetVehiculeTime(plate VARCHAR(6), salida DATETIME)
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

-- With this method we delete from the database the vehicule. ****
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE DeleteVehicule(plate VARCHAR(6))
BEGIN
DELETE FROM Vehicules WHERE licensePlate = plate;
END$$

-- This help us to insert clients to the database.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE InsertClient(idCLient INT(9), _name NVARCHAR(20), _company NVARCHAR(20))
BEGIN
INSERT INTO Clients (id, name, company) VALUES ( idCLient, _name, _company);
END$$

-- This help us to insert vehicules to the database.
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE InsertVehicule(_licensePlate VARCHAR(6), idCLient INT(9), _colour NVARCHAR(20), _model NVARCHAR(20), _type INT(1), _description VARCHAR(250))
BEGIN
INSERT INTO Vehicules (licensePlate, codeCLient, colour, model, type, description) VALUES (_licensePlate, (SELECT code 
																											FROM Clients 
                                                                                                            WHERE id = idCLient),_colour, _model, _type, _description);
END$$

-- With this method we can create bills
DELIMITER $$
USE parkingdb$$
CREATE PROCEDURE CreateBill(_licensePlate VARCHAR(6), _idClient INT(9), _idAdmin INT(4) )
BEGIN
/*	Structure:
	parkingname		NVARCHAR(30)		NOT NULL, -- parking	
	licensePlate	VARCHAR(6)		    NOT NULL, -- vehicule
    type			INT(1)			    NOT NULL, -- vehicule
    InHour			DATETIME 		    NOT NULL, -- vehicule
    OutHour			DATETIME 			NOT NULL, -- vehicule
    idClient	    INT(9)			    NOT NULL, -- client
    name 			NVARCHAR(20)	    NOT NULL, -- client
    company	        NVARCHAR(20)	    NOT NULL, -- client
    adm_name 		NVARCHAR(20)	    NOT NULL, -- admin
    adm_mail		NVARCHAR(20)	 	NOT NULL, -- admin */
-- INSERT INTO BILL (
END $$

-- ------------------------------------------------------------------
-- Inserts
-- ------------------------------------------------------------------

INSERT INTO Admins (password, name, flastname, slastname, id, phone, mail) VALUES(N'qwerty', N'Diego', N'Rubí', N'Salas', 117250628, 87108548, N'diegoalru@gmail.com');
INSERT INTO Admins (password, name, flastname, slastname, id, phone, mail) VALUES(N'qwerty', N'Admin', N'lastName', N'lastName', 117250629, 87108549, N'diegoalru@gmail.com');

INSERT INTO TypeOfVehicules (code, description, fare) VALUES (1, 'Tarifa para MOTOS', 400);
INSERT INTO TypeOfVehicules (code, description, fare) VALUES (2, 'Tarifa para AUTOS', 600);

CALL InsertClient (117250628, N'Diego', N'UNKNOWN');
CALL InsertClient (333999333, N'ABC',   N'UNKNOWN');
CALL InsertClient (111111111, N'ABC',   N'UNKNOWN');
CALL InsertClient (999333999, N'XYZ',   N'UNKNOWN');

CALL InsertVehicule('BCC997', 117250628, 'RED', 'RAV4', 2, 'Carro en perfectas condiciones');
CALL InsertVehicule('BCC111', 333999333, 'RED', 'RAV4', 1, 'Moto en perfectas condiciones');
CALL InsertVehicule('ABC123', 111111111, 'RED', 'RAV4', 1, 'Moto en perfectas condiciones');
CALL InsertVehicule('XYZ999', 999333999, 'RED', 'RAV4', 2, 'Carro en perfectas condiciones');
				
-- ------------------------------------------------------------------
-- Execute routines
-- ------------------------------------------------------------------
				/* JUST FOR TEST */
                /* JUST FOR TEST */
                /* JUST FOR TEST */
                /* JUST FOR TEST */

CALL GetAdmins();

CALL GetClients();

CALL GetTypes();

-- CALL AdminChecker(1, N'qwerty');

-- CALL InsertVehicule('BCC996', 117250628, 'RED', 'RAV4', '2', 'Vehiculo en perfectas condiciones');

-- CALL SetVehiculeTime('BCC997', CURRENT_TIMESTAMP);

CALL GetVehicules();

-- CALL DeleteVehicule('BCC997');
