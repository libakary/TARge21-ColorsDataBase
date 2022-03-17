SELECT Shades.ShadesName, ColorType.PrimaryColorName FROM ColorType
INNER JOIN Shades ON Shades.PrimaryColorId = ColorType.Id
WHERE ColorType.PrimaryColorName LIKE 'Blue'