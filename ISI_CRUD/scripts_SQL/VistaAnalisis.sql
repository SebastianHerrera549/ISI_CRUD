CREATE VIEW [dbo].[Análisis de precio] AS
SELECT p.ProductName AS [Nombre del producto],
       p.UnitPrice AS [Precio unitario],
       AVG(p.UnitPrice) OVER() AS [Precio promedio de todos los productos],
       AVG(p.UnitPrice) OVER() - p.UnitPrice AS [Diferencia entre el precio promedio y el precio del producto]
FROM Products p;