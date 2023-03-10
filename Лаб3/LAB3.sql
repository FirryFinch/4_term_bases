--a Всё
SELECT * FROM Items1;

--b Столбцы
SELECT LastName, FirstName, Phone FROM Customers;

--c ORDER BY
SELECT LastName, FirstName, Phone FROM Customers ORDER BY LastName;

--d TOP
SELECT TOP = 5 LastName, FirstName, Phone FROM Customers;

--e СРАВНЕНИЕ
SELECT PrName, InStock FROM Products GROUP BY PrName, InStock HAVING InStock > 29;

--f BETWEEN
SELECT * FROM Products WHERE InStock BETWEEN 23 AND 31;

--g IN + ПОДЗАПРОС
SELECT * FROM Customers WHERE IdCustomer IN (SELECT IdCustomer FROM Orders WHERE [Status] = 'C');
SELECT DISTINCT Customers.IdCustomer, LastName, FirstName, [Address], City, IndexCode, [Phone], [E-mail], CompanyName FROM Customers JOIN Orders ON(Customers.IdCustomer = Orders.IdCustomer) WHERE Orders.[Status] = 'A';

--h LIKE + СТРОКОВЫЕ
SELECT LOWER (LastName), UPPER(FirstName) FROM Customers WHERE FirstName = 'Михаил';

--i IS NULL
SELECT * FROM Products WHERE [Description] IS NULL;

--j Агрегатные
SELECT City, Count(*) FROM Customers GROUP BY City;

--k Агрегатные и HAVING
SELECT City, Count(*) FROM Customers GROUP BY City, LastName HAVING LastName = 'Кузнецов';

--!l Соединения с предикатом
SELECT * FROM Customers JOIN Orders ON(Customers.IdCustomer = Orders.IdCustomer) WHERE Orders.[Status] = 'W';

--m DISTINCT
SELECT LastName FROM Customers;
SELECT DISTINCT LastName FROM Customers;

--n NOT EXISTS
SELECT * FROM Customers WHERE NOT EXISTS (SELECT IdCustomer FROM Orders WHERE IdCustomer = Customers.IdCustomer);

--o IIF()
SELECT PrName, IIF(PrPrice > 500, 'EXPENSIVE', 'CHEAP') AS ExCh FROM Products;

--Вариант 4
SELECT * FROM Orders WHERE OrderDate < '20.03.2018' ORDER BY IdOrder DESC;
SELECT * FROM Customers 
WHERE NOT EXISTS (SELECT IdCustomer FROM Orders WHERE IdCustomer = Customers.IdCustomer) 
ORDER BY LastName ASC;