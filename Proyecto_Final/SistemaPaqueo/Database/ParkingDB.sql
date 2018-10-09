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