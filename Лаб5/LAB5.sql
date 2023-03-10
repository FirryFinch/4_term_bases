USE SALES
INSERT Products(PrName, Description, InStock)
VALUES ('T1', 'TEST1', 1)

USE SALES
INSERT Products(PrName, Description, InStock)
VALUES ('T2', 'TEST2', 1)

USE SALES
SELECT * FROM Products

DELETE FROM Products WHERE IdProduct>1019