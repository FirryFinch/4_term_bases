IF OBJECT_ID ('dbo.Orders', 'U') IS NOT NULL DROP TABLE dbo.Orders;
CREATE TABLE dbo.Orders
(
IdOrder BIGINT IDENTITY(1,1) CONSTRAINT pk_order PRIMARY KEY,
IdCustomer INT NOT NULL,
OrderDate DATE NOT NULL,
ShipDate DATE NULL, 
PaidDate DATE NULL,
[Status] char(1)
);
IF OBJECT_ID ('dbo.Items', 'U') IS NOT NULL DROP TABLE dbo.Items;
CREATE TABLE dbo.Items
(
IdItem BIGINT IDENTITY(1,1) CONSTRAINT pk_items PRIMARY KEY,
IdOrder INT NOT NULL,
IdProduct INT NOT NULL,
Quantity INT NOT NULL,
Total INT NULL,
[Status] char(1)
);

ALTER TABLE dbo.Orders
ADD CONSTRAINT FR_Ord_Cust
	FOREIGN KEY (IdCustomer) REFERENCES Customers (IdCustomer)
ALTER TABLE dbo.Items1
ADD CONSTRAINT FR_It_Ord
	FOREIGN KEY (IdOrder) REFERENCES Orders (IdOrder)
ALTER TABLE dbo.Items1
ADD CONSTRAINT FR_It_Prod
	FOREIGN KEY (IdProduct) REFERENCES Products (IdProduct)

INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail])
VALUES ('Приветин', 'Кирилл', 'ул. Зеленая роща, 3', 'Москва', 120343, 89332940322, '1@g.com');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], CompanyName)
VALUES ('Попов', 'Алексей', 'сп. Ладыгина, 80', 'Кашира', 136825, 89278983498, '2@mail.box', 'Comp2');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Иванов', 'Александр', 'пр. Балканский, 5', 'Воскресенск', 285734, 89903273711, '3@mail.box', 'Comp3');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Макаров', 'Артем', 'ш. Ломоносова, 73', 'Наро-Фоминск', 343653, 89241102344, '4@mail.box', 'Comp4');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Суворова', 'Анна', 'пр. Бухарестский, 15', 'Луховицы', 116823, 8929329921, '5@mail.box', 'Comp5');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Лукьянова', 'Ольга', 'пр. Гагарина, 80', 'Истра', 201948, 89242940322, '6@mail.box', 'Comp6');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Яковлев', 'Михаил', 'ул. Будапештсткая, 10', 'Красногорск', 295882, 89262224522, '7@mail.box', 'Comp7');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Мухин', 'Дмитрий', 'пр. Домодедовский, 27', 'Можайск', 154067, 89282346678, '8@mail.box', 'Comp8');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Барабанова', 'Ирина', 'ул. 1905 года, 76', 'Балашиха', 375594, 89291284411, '9@mail.box', 'Comp9');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Некрасов', 'Вадим', 'проезд Ладыгина, 8', 'Сергиев Посад', 258768, 89446726734, '10@mail.box', 'Comp10');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Куликова', 'Полина', 'наб. Гоголя, 72', 'Домодедово', 940053, 89664569022, '11@mail.box', 'Comp11');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Сахаров', 'Владимир', 'пер. Ломоносова, 20', 'Чехов', 447325, 89569022309, '12@mail.box', 'Comp12');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Фролов', 'Владислав', 'пр. Ленинские горы, 1', 'Москва', 921039, 89787891122, '13@mail.box', 'Comp13');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Захаров', 'Вячеслав', 'ул.Каховка, 33', 'Москва', 675734, 89982333333, '14@mail.box', 'Comp14');
INSERT INTO dbo.Customers (LastName, FirstName, [Address], City, IndexCode, Phone, [E-mail], [CompanyName])
VALUES ('Кузнецов', 'Алексей', 'ул. Бауманская, 5', 'Москва', 546566, 89991022378, '15@mail.box', 'Comp15');

INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product1', 50, 23, 0 , 'Desc1');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product2', 150, 22, 0 , 'Desc2');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product3', 250, 21, 0 , 'Desc3');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product4', 350, 20, 0 , 'Desc4');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product5', 450, 19, 0 , 'Desc5');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product6', 550, 18, 0 , 'Desc6');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product7', 650, 17, 0 , 'Desc7');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product8', 750, 16, 0 , 'Desc8');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product9', 850, 15, 0 , 'Desc9');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product10', 950, 25, 0 , 'Desc10');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product11', 1050, 28, 0 , 'Desc11');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product12', 1150, 45, 0 , 'Desc12');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product13', 1250, 33, 0 , 'Desc13');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product14', 1350, 39, 0 , 'Desc14');
INSERT INTO dbo.Products ([PrName], PrPrice, InStock, ReOrder, [Description])
VALUES ('Product15', 1450, 21, 0 , 'Desc15');

INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (1, '01.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (49, '02.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (1, '03.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (50, '04.12.2012', '21.12.2012', '22.12.2012', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (51, '05.12.2012', '21.12.2012', '22.12.2012', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (52, '06.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (53, '07.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (54, '08.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (55, '09.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (56, '10.12.2012', '21.12.2012', '22.12.2012', 'A');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (57, '11.12.2012', '21.12.2012', '22.12.2012', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (58, '12.12.2012', '19.12.2012', '22.12.2012', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (59, '13.12.2012', '20.12.2012', '22.12.2012', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (60, '15.12.2012', '21.12.2012', '22.12.2012', 'P');

INSERT INTO dbo.Items1 (IdOrder, IdProduct, Quantity, Total, [Status])
VALUES (18, 3, 5, 600, 'A');
INSERT INTO dbo.Items1 (IdOrder, IdProduct, Quantity, Total, [Status])
VALUES (32, 3, 5, 1000, 'A');
INSERT INTO dbo.Items1 (IdOrder, IdProduct, Quantity, Total, [Status])
VALUES (36, 2, 7, 650, 'D');
INSERT INTO dbo.Items1 (IdOrder, IdProduct, Quantity, Total, [Status])
VALUES (40, 9, 4, 1500, 'A');
INSERT INTO dbo.Items1 (IdOrder, IdProduct, Quantity, Total, [Status])
VALUES (44, 2, 2, 200, 'A');


DELETE FROM Orders WHERE IdOrder>5

UPDATE Orders SET [Status] = 'C'
WHERE IdOrder > 0
UPDATE Customers SET [CompanyName] = 'Comp2'
WHERE IdCustomer='49'