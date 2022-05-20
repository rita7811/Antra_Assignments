/* 
Use Northwind database. 
All questions are based on assumptions described by the Database Diagram sent to you yesterday. 
When inserting, make up info if necessary. Write query for each step. 
Do not use IDE. 
BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE. 
*/
USE Northwind 
GO
-- 1. Create a view named “view_product_order_[your_last_name]”, 
--    list all products and total ordered quantity for that product.
CREATE VIEW view_product_order_huang
AS
SELECT p.ProductName, SUM(od.Quantity) AS OrderQuantity
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

SELECT *
FROM view_product_order_huang

-- 2. Create a stored procedure “sp_product_order_quantity_[your_last_name]” 
-- that accept product id as an input and total quantities of order as output parameter.
CREATE PROC sp_product_order_quantity_huang
@id int,
@TotalQuantity int out
AS
BEGIN
SELECT @TotalQuantity = SUM(Quantity)
FROM [Order Details] 
WHERE ProductID = @id
END

BEGIN
DECLARE @TotalQuantity int
EXEC sp_product_order_quantity_huang 23, @TotalQuantity out
PRINT @TotalQuantity
END

-- SELECT ProductID, SUM(Quantity)
-- FROM [Order Details]
-- GROUP BY ProductID

-- 3. Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input 
-- and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
DROP PROC IF EXISTS sp_product_order_city_huang

CREATE PROC sp_product_order_city_huang
AS
BEGIN
SELECT TOP 5 o.ShipCity AS City, SUM(od.ProductID * od.Quantity) AS OrderSum
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.ShipCity
ORDER BY OrderSum DESC
END

EXEC sp_product_order_city_huang

-- 4. Create 2 new tables “people_your_last_name” “city_your_last_name”. 
-- City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
-- People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
-- Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. 
-- Create a view “Packers_your_name” lists all people from Green Bay. 
-- If any error occurred, no changes should be made to DB. 
-- (after test) Drop both tables and view.
--CREATE table "people_huang"
CREATE TABLE people_huang(
    Id int PRIMARY KEY,
    Name varchar(20) NOT NULL,
    City varchar(20)
)
INSERT INTO people_huang VALUES (1, 'Aaron Rodgers', 2)
INSERT INTO people_huang VALUES (2, 'Russell Wilson', 1)
INSERT INTO people_huang VALUES (3, 'Jody Nelson', 2)

SELECT *
FROM people_huang

--CREATE table "city_huang"
CREATE TABLE city_huang(
    Id int PRIMARY KEY,
    City varchar(20) NOT NULL
)
INSERT INTO city_huang VALUES (1, 'Seattle')
INSERT INTO city_huang VALUES (2, 'Green Bay')

SELECT *
FROM city_huang

-- Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. 
DELETE city_huang
WHERE City = 'Seattle'

INSERT INTO city_huang VALUES (1, 'Madison')

SELECT *
FROM city_huang

-- Create a view “Packers_your_name” lists all people from Green Bay. 
CREATE VIEW Packers_huang
AS
SELECT p.Name
FROM people_huang p JOIN city_huang c ON p.City = c.Id
WHERE c.City = 'Green Bay'

SELECT *
FROM Packers_huang

-- (after test) Drop both tables and view.
DROP VIEW Packers_huang
DROP TABLE people_huang
DROP TABLE city_huang

-- 5. Create a stored procedure “sp_birthday_employees_[you_last_name]” 
-- that creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. (Make a screen shot) 
-- drop the table. Employee table should not be affected.
CREATE PROC sp_birthday_employees_huang
AS
BEGIN
CREATE TABLE #birthday_employees_huang(
    Id int PRIMARY KEY,
    Name varchar(20) NOT NULL,
    Birthday DATETIME NOT NULL
)
INSERT INTO #birthday_employees_huang
SELECT EmployeeID, LastName + ' ' + FirstName AS Name, BirthDate
FROM Employees 
WHERE MONTH(BirthDate) = 2 

SELECT *
FROM #birthday_employees_huang
END

BEGIN
EXEC sp_birthday_employees_huang
END

DROP TABLE #birthday_employees_huang
DROP PROC sp_birthday_employees_huang

-- 6. How do you make sure two tables have the same data?
/* 
WAY 1: use "EXCEPT/MINUS" with "UNION ALL" to see if we can get 0 record. If a queryed record is 0, there are the same date in the two tables.
(SELECT * FROM TABLE_A EXCEPT SELECT * FROM TABLE_B)
UNION ALL
(SELECT * FROM TABLE_B EXCEPT SELECT * FROM TABLE_A)

WAY 2: use Full Outer Join to return data where Table_A's key IS NULL or Table_B's key IS NULL. If a queryed record is 0, there are the same date in the two tables.
SELECT * 
FROM TABLE_A t1 OUTER JOIN TABLE_B ON t1.id = t2.id
WHERE t1.id IS NULL OR t2.id IS NULL 
*/
