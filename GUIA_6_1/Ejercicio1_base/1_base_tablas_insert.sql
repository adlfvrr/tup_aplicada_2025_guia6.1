

USE master

GO

DROP DATABASE IF EXISTS Guia6_1_Ejercicio1_adolf_db

GO

CREATE DATABASE Guia6_1_Ejercicio1_adolf_db

GO

USE Guia6_1_Ejercicio1_adolf_db

GO

CREATE TABLE Figuras
(
	Id INT IDENTITY(1,1),
	Tipo INT NOT NULL, --	1. Rectangulo | 2. Circulo
	Ancho NUMERIC(18,2),
	Largo NUMERIC(18,2),
	Radio NUMERIC(18,2),
	Area NUMERIC(18,2)
	CONSTRAINT PK_Figuras PRIMARY KEY (Id)
)

GO

INSERT INTO Figuras (Tipo, Ancho, Largo, Radio)
VALUES
(1,1,1, NULL),
(1,1,2, NULL),
(1,2.2,1, NULL),
(2,NULL,NULL,1),
(2,NULL,NULL,2.1)

GO

SELECT f.Id,
		CASE WHEN f.Tipo = 1 THEN 'Rectangulo'
			WHEN f.Tipo = 2 THEN 'Circulo'
			ELSE 'No identificado'
			END AS Tipo,
		f.Area,
		f.Ancho,
		f.Largo,
		f.Radio
FROM Figuras f

GO

USE master

GO

DROP DATABASE IF EXISTS Guia_6_1_Ejercicio1_Vitale_DB

GO