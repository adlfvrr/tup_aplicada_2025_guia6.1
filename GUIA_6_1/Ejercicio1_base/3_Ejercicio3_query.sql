

USE Guia6_1_Ejercicio1_adolf_db

GO

SELECT f.Id, f.Tipo, f.Area, f.Ancho, f.Largo, f.Radio
FROM Figuras f
WHERE Id=3
ORDER BY f.Id

GO

USE master