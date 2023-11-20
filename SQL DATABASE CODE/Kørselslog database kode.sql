USE master;

ALTER DATABASE K�rselslog SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE IF EXISTS K�rselslog;

CREATE DATABASE K�rselslog;

GO

USE K�rselslog;

CREATE TABLE login(
	Brugernavn VARCHAR(25),
	Adgangskode VARCHAR(25),
	BrugerId INT
);

CREATE TABLE adminlogin(
	AdminBrugernavn VARCHAR(25),
	AdminAdgangskode VARCHAR(25),
	AdminId INT
);

CREATE TABLE k�rselslog(
	Start VARCHAR(25),
	Slut VARCHAR(25),
	Kilometer INT,
	BrugerId INT,
	LogId INT IDENTITY(1,1)

);

INSERT INTO login (Brugernavn, Adgangskode, BrugerId) VALUES ('Bruger1', 'Bruger123', 1);
INSERT INTO login (Brugernavn, Adgangskode, BrugerId) VALUES ('Jens', 'Jensen123', 2);

INSERT INTO adminlogin(AdminBrugernavn, AdminAdgangskode, AdminId) VALUES ('Admin', 'Admin123', 1);

INSERT INTO k�rselslog (Start, Slut, Kilometer, BrugerId) VALUES ('K�benhavn', 'Kokkedal', 25, 1);
INSERT INTO k�rselslog (Start, Slut, Kilometer, BrugerId) VALUES ('K�benhavn', 'Kokkedal', 25, 2);