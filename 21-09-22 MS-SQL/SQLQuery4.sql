use Northwind
go

select * from Customers
select * from Orders
--1.    How many customers do we have in our database?
select count(CustomerID) as Total_Customers from Customers

--2.    How many of our customer names begin with the letter "b"?
select count(CustomerID) from Customers where CompanyName like 'b%'

--3.    How many of our customer names contain the letter "s" ?
select count(CustomerID) from Customers where CompanyName like '%s%'

--4.    How many customers do we have in each city?
select count(CustomerID), City from Customers group by City

--5.    What are the top three cities where we have our most customers?
select top 3 count(City), City from Customers group by City order by count(City) desc

--6.    Who has been our top customer - please list CustomerID, CompanyName, ContactName for the customer that we have sold the most to?
Select * from Customers where CustomerID in (Select top 1 CustomerId from Orders group by CustomerID order by count(OrderID) desc);

--7.    Who has been our top customer - please list CustomerID, CompanyName in the year 1997?
Select CustomerID, CompanyName from Customers where CustomerID in (Select top 1 CustomerId from Orders where year(ShippedDate)=1997  group by CustomerID order by count(OrderID) desc);

--8.    Name the top 3 countries that we ship our orders to?
Select top 3 ShipCountry,count(OrderId) as count1 from Orders group by ShipCountry order by count1 desc; 

--9.    Which shipper do we use the most to ship our orders out through?
Select top 1 ShipName,count(OrderId) as count1 from Orders group by ShipName order by count1 desc; 

--10. List the following employee information (EmployeeID, LastName, FirstName, ManagerLastName, ManagerFirstName)
Select i.EmployeeID,i.FirstName,i.LastName,i.Reportsto,j.FirstName,j.LastName from Employees i inner join Employees j on i.ReportsTo=j.EmployeeID

--11. What are the last names of all employees who were born in the month of November?
Select LastName from Employees where DATENAME(Month,BirthDate)='November'

--12. List each employee (lastname, firstname, territory) and sort the list by territory and then by employee last name. Remember employees may work for more than one territory.
Select LastName,FirstName,Region from Employees  order by 3,1

--13. In terms of sales value, what has been our best selling product of all time?
Select * from Products where UnitPrice*UnitsOnOrder in (Select max(UnitPrice*UnitsOnOrder) from Products)

--14. In terms of sales value, and only include products that have at least been sold once, which has been our worst selling product of all time? 
Select * from Products where UnitPrice*UnitsOnOrder in (Select min(UnitPrice*UnitsOnOrder) from Products where UnitsOnOrder<>0)

--15. In terms of sales value, which month has been traditionally best for sales?
Select top 1 DATENAME(Month,OrderDate),count(Month(OrderDate)) as count1 from Orders group by DATENAME(Month,OrderDate) order by count1 desc

--16. What is the name of our best sales person?
Select * from Employees where EmployeeID in (Select top 1 EmployeeID from Orders group by EmployeeID order by count(OrderId) desc);

--17. Product report (productID, ProductName, Supplier Name, Product Category). Order the list by product category.
Select ProductID,ProductName,SupplierID,CategoryID from Products order by CategoryID desc

--18. Produce a count of the employees by each sales region
Select region,count(EmployeeID) from employees group by Region

--19. List the dollar values for sales by region?
Select ShipRegion,sum(freight) as dollars from Orders group by ShipRegion

--20. What is the average value of a sales order?
Select avg(freight) as average from orders

--21. List orders (OrderID, OrderDate, Customer Name) where the total order value is greater than the average value of a sales order?
Select * from orders where freight > any(Select avg(freight) as average from orders)

--22. Produce a customer report (must also include those we have not yet done business with) showing CustomerID, Customer name and total sales made to that customer
Select k.CustomerID,k.ContactName,sum(l.freight) as totalsale from customers k inner join orders l on k.CustomerID=l.CustomerID group by k.CustomerID,k.ContactName order by totalsale desc

--23. List all products that need to be re-ordered. Do not include discontinued products in this report.
Select ProductName,ReorderLevel from Products where ReorderLevel<>0 and Discontinued=0 order by ReorderLevel desc

--24. List all customers that we made a sale to in the year 1996
Select CustomerID,ContactName from Customers where CustomerID in (Select distinct(CustomerID) from Orders where Year(ShippedDate)=1996)

--25. List all customers that we did not make a sale to in the year 1996
Select CustomerID,ContactName from Customers where CustomerID in (Select distinct(CustomerID) from Orders where Year(ShippedDate)<>1996)

