use Northwind

create view ViewProducts
as
select productid, productname, unitprice from Products

select * from ViewProducts