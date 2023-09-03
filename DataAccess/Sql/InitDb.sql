CREATE DATABASE Szotar;

GO

USE Szotar;

CREATE TABLE Szotar
(
	Id		INT
		IDENTITY(1, 1)
		PRIMARY KEY
		NOT NULL,
	Hun		NVARCHAR(200)
		NOT NULL,
	Eng		NVARCHAR(200)
		NOT NULL
);

INSERT INTO Szotar(Hun, Eng)
VALUES
	('szék', 'chair'),
	('asztal', 'table'),
	('telefon', 'telephone');