SELECT * FROM Customers
SELECT * FROM Products
SELECT * FROM Orders
SELECT * FROM Items1

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
CREATE PROCEDURE MeanValue
@Value1 REAL = 0,
@Value2 REAL = 0,
@Value3 REAL = 0
AS
BEGIN
SET NOCOUNT ON
SELECT 'MeanValue' = ((@Value1 + @Value2 + @Value3) / 3)
END
GO

EXEC MeanValue 1, 7, 9

GO
CREATE PROC NAMECOMP
@A NVARCHAR(100) AS
SELECT *
FROM Customers
WHERE
CompanyName = @A
GO

EXEC NAMECOMP Comp11

GO
CREATE PROCEDURE FPROD
@X REAL,
@Y REAL AS
SELECT *
FROM Products
WHERE
((PrPrice >= @X) AND (PrPrice <= @Y))
GO

EXEC FPROD 150, 750

GO
CREATE PROCEDURE FORD
@X DATE,
@Y DATE AS
SELECT *
FROM Orders
WHERE
(OrderDate = @X) OR (((OrderDate >= @X) AND (OrderDate <= @Y)) OR ((ShipDate >= @X) AND (ShipDate <= @Y)))
GO

EXEC FORD '06.12.2012', NULL

EXEC FORD '06.12.2012', '10.12.2012'

EXEC FORD '19.12.2012', '20.12.2012'

GO
CREATE PROCEDURE FCUS
@C1 NVARCHAR(100),
@C2 NVARCHAR(100) AS
SELECT *
FROM Customers
WHERE
(CompanyName = @C1) OR (CompanyName = @C2)
GO

EXEC FCUS 'Comp11', 'Comp2'

INSERT INTO Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (61, '15.12.2012', NULL, NULL, 'W');
INSERT INTO Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (62, '16.12.2012', NULL, NULL, 'W');
INSERT INTO Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (63, '19.12.2012', NULL, NULL, 'W');

GO
CREATE PROCEDURE HMPAID
AS
SELECT City, COUNT(*) AS 'HavePaid'
FROM Customers
WHERE IdCustomer IN (SELECT IdCustomer FROM Orders WHERE PaidDate IS NOT NULL)
GROUP BY City
GO

HMPAID

GO
CREATE TRIGGER T1
ON Customers
AFTER INSERT
AS
BEGIN
SELECT * FROM Customers
END 
GO

INSERT INTO Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Алексеев', 'Денис', 'ул. Бауманская, 12', 'Москва', 546568, 89998022378, '456@mail.box', 'Comp15');

GO
CREATE TRIGGER T2
ON Customers
AFTER DELETE
AS
BEGIN
SELECT * FROM DELETED
SELECT * FROM Customers
END 
GO

DELETE FROM Customers WHERE IdCustomer = 65

GO
CREATE TRIGGER T3
ON Orders
AFTER UPDATE
AS
BEGIN
SELECT * FROM INSERTED
SELECT * FROM Orders
END 
GO

UPDATE Orders SET [Status] = 'D'
WHERE IdOrder > 40

GO
CREATE TRIGGER T4
ON Products
INSTEAD OF DELETE
AS
BEGIN
DELETE FROM Items1 WHERE IdProduct IN (SELECT IdProduct FROM DELETED)
DELETE FROM Products WHERE IdProduct IN (SELECT IdProduct FROM DELETED)
SELECT * FROM Products
SELECT * FROM Items1
END 
GO

DELETE FROM Products WHERE IdProduct = 2

GO
CREATE TRIGGER T5
ON Products
AFTER INSERT
AS
BEGIN
SELECT PrName, PrPrice FROM INSERTED
END 
GO

INSERT INTO Products (PrName, PrPrice, InStock, ReOrder, Description)
VALUES ('Product19', 850, 2, NULL, 'Desc19');
INSERT INTO Products (PrName, PrPrice, InStock, ReOrder, Description)
VALUES ('Product20', 1000, 7, NULL, 'Desc20');

GO
CREATE TRIGGER T6
ON DATABASE 
FOR DROP_TABLE, ALTER_TABLE
AS
BEGIN
PRINT 'Удалять таблицы или изменять таблицы в этой БД не разрешено!';
ROLLBACK;
END
GO

DROP TABLE Items1