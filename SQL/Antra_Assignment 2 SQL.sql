-- Joins: (AdventureWorks)
USE AdventureWorks2019
GO
-- 1. Write a query that lists the country and province names from person.CountryRegion and person.StateProvince tables. 
--    Join them and produce a result set similar to the following.
--    Country                        Province
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

-- 2. Write a query that lists the country and province names from person.CountryRegion and person.StateProvince tables 
--    and list the countries filter them by Germany and Canada.
--    Join them and produce a result set similar to the following.
--    Country                        Province
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')


-- Using Northwind Database: (Use aliases for all the Joins)
USE Northwind
GO
-- 3. List all Products that has been sold at least once in last 25 years.
--Answer1: Using DATEADD() function
SELECT DISTINCT p.ProductName
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate >= DATEADD(year, -25, GETDATE())
--Answer2: Using DATEDIFF() function --This will include all days in 1997
SELECT DISTINCT p.ProductName
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(year, o.OrderDate, GETDATE()) <= 25

-- 4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
--Answer1: Using DATEADD() function
SELECT TOP 5 o.ShipPostalCode AS [Locations(Zip Code)], COUNT(p.ProductName) AS SoldNum
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate >= DATEADD(year, -25, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY SoldNum DESC
--Answer2: Using DATEDIFF() function --This will include all days in 1997
SELECT TOP 5 o.ShipPostalCode AS [Locations(Zip Code)], COUNT(p.ProductName) AS SoldNum
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(year, o.OrderDate, GETDATE()) <= 25
GROUP BY o.ShipPostalCode
ORDER BY SoldNum DESC

-- 5. List all city names and number of customers in that city.     
SELECT c.City, COUNT(c.CustomerID) AS NumOfCustomers
FROM Customers c
GROUP BY c.City

-- 6. List city names which have more than 2 customers, and number of customers in that city
SELECT c.City, COUNT(c.CustomerID) AS NumOfCustomers
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2

-- 7. Display the names of all customers along with the count of products they bought
SELECT c.CompanyName AS Customer, COUNT(od.ProductID) AS CountOfProducts
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName

-- 8. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID, COUNT(od.ProductID) AS CountOfProducts
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.ProductID) > 100

-- 9. List all of the possible ways that suppliers can ship their products. Display the results as below
--     Supplier Company Name                Shipping Company Name
--     ---------------------------------    ----------------------------------
SELECT sp.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shiping Company Name] 
FROM Shippers sh CROSS JOIN Suppliers sp 

-- 10. Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM Orders o LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate

-- 11. Displays pairs of employees who have the same job title.
SELECT e.LastName + ' ' + e.FirstName AS Employee1, m.LastName + ' ' + m.FirstName AS Employee2, e.Title
FROM Employees e LEFT JOIN Employees m ON e.Title = m.Title
WHERE e.EmployeeID > m.EmployeeID
ORDER BY Employee1

-- 12. Display all the Managers who have more than 2 employees reporting to them.
SELECT e.FirstName + ' ' + e.LastName AS Manager, COUNT(m.FirstName + ' ' + m.LastName) AS Employee
FROM Employees e LEFT JOIN Employees m ON e.EmployeeID = m.ReportsTo
GROUP BY e.FirstName + ' ' + e.LastName
HAVING COUNT(m.FirstName + ' ' + m.LastName) > 2

-- 13. Display the customers and suppliers by city. The results should have the following columns
-- City
-- Name
-- Contact Name,
-- Type (Customer or Supplier)
SELECT c.City, c.CompanyName AS Name, c.ContactName AS [Contact Name], 'Customer' AS Type
FROM Customers c
UNION ALL
SELECT s.City, s.CompanyName AS Name, s.ContactName AS [Contact Name], 'Supplier' AS Type
FROM Suppliers s


-- All scenarios are based on Database NORTHWIND.
USE Northwind
GO
-- 14. List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Customers c JOIN Employees e ON c.City = e.City

-- 15. List all cities that have Customers but no Employee.
-- a. Use sub-query
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (SELECT e.City FROM Employees e)
-- b. Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.EmployeeID IS NULL

-- 16. List all products and their total order quantities throughout all orders.
--Answer1: Use sub-query
SELECT p.ProductName, 
(SELECT COUNT(od.Quantity) FROM [Order Details] od WHERE p.ProductID = od.ProductID) AS Quantities
FROM Products p 
--Answer2: Use Join
SELECT p.ProductName, COUNT(od.Quantity) AS Quantities
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

-- 17. List all Customer Cities that have at least two customers.
-- a. Use union
SELECT City, COUNT(CustomerID) AS Num
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2
UNION ALL
SELECT City, COUNT(CustomerID) AS Num
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) = 2
-- b. Use sub-query and no union
SELECT DISTINCT City
FROM Customers
WHERE City IN 
(SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2)

-- 18. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(od.ProductID) AS Num
FROM Customers c LEFT JOIN Orders o ON c.City = o.ShipCity JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductID) >= 2

-- 19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 p.ProductName, AVG(od.UnitPrice * od.Quantity) AS AVGPrice, o.ShipCity AS City, SUM(od.Quantity) AS Quantity
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID LEFT JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY p.ProductName, o.ShipCity
ORDER BY SUM(Quantity) DESC

-- 20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
--     and also the city of most total quantity of products ordered from. (tip: join sub-query)
SELECT o.ShipCity AS City, COUNT(o.OrderID) AS Orders
FROM Orders o JOIN 
(SELECT TOP 1 o1.ShipCity, SUM(od.Quantity) AS Quantity 
FROM Orders o1 JOIN [Order Details] od ON o1.OrderID = od.OrderID GROUP BY o1.ShipCity ORDER BY SUM(od.Quantity) DESC) dt
ON o.ShipCity = dt.ShipCity
GROUP BY o.ShipCity

-- 21. How do you remove the duplicates record of a table?
/* I will remove the duplicates record of a table using "SELECT DISTINCT"
 */
