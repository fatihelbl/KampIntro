select ContactName, CompanyName, City from Customers

select * from Customers where City = 'London'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by UnitPrice

select count(*) from Products

select categoryID, count(*) from Products group by CategoryID having count (*) <10

select Products.ProductName, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID= Categories.CategoryID

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID =od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null