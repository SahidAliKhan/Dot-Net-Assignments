use pubs
select * from titles 

--1) write a program to concat firstname and last name and print the concatenated String.
declare @fname varchar(20) = 'Sahid', @lname varchar(20) = ' Ali Khan'
begin print concat(@fname,@lname)
end

--2)Write a batch that will check for the existence of the title “The Gourment Microwave” If it exists, print the cost of the book else display “Not Found”.
declare
@n_check varchar(80),
@n_cost money
begin
select @n_check=title,@n_cost=price from titles where title='The Gourmet Microwave'
print @n_check
if(@n_check=null)
print 'not found'
else
print @n_cost
end

--3)Write a batch to display the titles of all the Psychology books if the average price of books is more than $15. Display the appropriate output.
declare @title1 varchar(80), @type char(12) = 'psychology'
begin
select @title1 = title from titles where type = @type and avg(price) >15
print @title1
end


--4)Write a procedure which accepts the city name as a parameter and displays the names of publishers residing in the city
CREATE PROCEDURE residingcity
	-- Add the parameters for the stored procedure here
@n_city varchar(20)
AS
BEGIN
     Select pub_name from publishers where city=@n_city
END
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[residingcity]
		@n_city = N'Chicago'

SELECT	'Return Value' = @return_value

GO


--5) Write a procedure which accepts the title_id as a parameter and displays the number of orders placed for the book.
create procedure ordersfor
@n_titleid varchar(6)
as
begin
 select title_id,count(ord_num) from sales group by title_id having title_id=@n_titleid;
end
go


DECLARE	@return_value int

EXEC	@return_value = [dbo].[ordersfor]
		@n_titleid = N'PS2091'

SELECT	'Return Value' = @return_value

GO

--6)Write a procedure which displays store names and the number of orders placed by the each store.
create procedure storename
as
begin
 select j.stor_name,count(i.ord_num) from sales i inner join stores j on i.stor_id=j.stor_id group by j.stor_name;
end
go
EXEC [dbo].[storename]

--7)Write a procedure that take a title_id as a parameter and returns the number of orders placed for the book. Define two parameters @in_tid as an ordinary parameter and @tot_orders as a return parameter. 
CREATE PROCEDURE totalorders 
	-- Add the parameters for the stored procedure here
	@n_titleid varchar(6),
	@n_int int output
AS
BEGIN
	select @n_int=count(ord_num) from sales group by title_id having title_id=@n_titleid;
END
GO

--8)Write a User Defined Function to get the number of working days between two dates.Assume Saturaday and Sunday as holidays.
CREATE FUNCTION Noofdays 
(	

	@n_startdate date,
	@n_enddate date
)
RETURNS int 
AS
Begin
declare @n_count int=0
while(@n_startdate<=@n_enddate)
begin
if(datename(weekday,@n_startdate)='Sunday' or datename(weekday,@n_startdate)='Saturday')
set @n_count=@n_count+0;
else
set @n_count=@n_count+1;
set @n_startdate=DATEADD(day,1,@n_startdate)
end
return @n_count
end
GO
select [dbo].[Noofdays]('2022-09-16','2022-09-20')



--9)Write a function that can calculate the yearly salary of a job if an applicant is    given the hourly salary. Consider that the yearly salary is based on 40 hours a week. In your function, if the hourly salary is given as a negative value, don't perform the calculation 
Create function Yearlysalary
(
 @n_hourlysalary float
)
returns float
as
begin
declare 
@n_week float,
@n_year float;
set @n_week=365/7;
set @n_year=@n_week*40*@n_hourlysalary;
return @n_year;
end
go

select [dbo].[Yearlysalary](20.0)


--10)Write a  function that processes a cylinder. It calculates and displays the diameter of the base, the circumference of the base, the base area, the side area, the total area, and the volume, given the radius and the height of a cylinder 
CREATE FUNCTION cylinder
(
	-- Add the parameters for the function here
	@n_radius float,
	@n_height float
)
RETURNS 
@cylinderdata TABLE 
(
	-- Add the column definitions for the TABLE variable here
	diameter float,
	circumference float,
	basearea float,
	sidearea float,
	totalarea float,
	volume float
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	declare 
	@dia float,
	@circum float,
	@base float,
	@side float,
	@total float,
	@vol float,
	@pi float=3.14
set	@dia=2*@n_radius;
set @circum=@pi*@dia;
set @base=@pi*@n_radius*@n_radius;
set @side=2*@pi*@n_radius*@n_height;
set @total=(2*@base)+@side;
set @vol=@pi*@n_radius*@n_radius*@n_height;
	
insert into @cylinderdata values(@dia,@circum,@base,@side,@total,@vol);
return

END
GO
drop function cylinder
select * from [dbo].[cylinder](7.0,14.0)


--11)You will create two new tables called NewCategories and NewProducts. Neither have the PRIMARY and FOREIGN KEY constraints of the Categories and Products tables. You will create a trigger on the NewCategories table. This trigger updates the Discontinued column in the NewProducts table whenever a category is deleted (whenever a record is deleted from the NewCategories table). All affected products are marked as 1, indicating that they are discontinued.
--13)You will create a DELETE trigger on the NewProducts table. This trigger determines whether an order history exists in the Order Details table before the trigger permits a deletion from the NewProducts table. 
--14) Create a trigger on NewProducts table to restrict the deletion of more than 3 records at the same time

create database pro

use pro

create table newcategories(
categoryid nchar(5),
categoryname varchar(25)
)

create table newproducts(
productid nchar(5),
productname varchar(25),
category varchar(25),
discontinuedcol int)

insert into newcategories values('10','Flour')

insert into newproducts(productid,productname,category) values('1','Wheatflour','Flour');
insert into newproducts(productid,productname,category) values('2','Ragiflour','Flour');
insert into newproducts(productid,productname,category) values('3','Maidaflour','Flour');
insert into newproducts(productid,productname,category) values('4','Dosaflour','Flour');

delete from newproducts where productname='1'


create trigger trigafterdeleted
on newcategories for Delete as
declare
@v_cat varchar(25),
@v_prod int=1,
@v_pr varchar(150)
begin
set @v_pr='delete trigger successfully';
select categoryname from deleted;
select @v_cat=categoryname from deleted;
update newproducts set discontinuedcol=@v_prod where category=@v_cat;
print 'trigger fired successfully'
end



delete from newcategories where categoryid=10

Select * from newproducts



create trigger deletenotmorethan3
on newproducts instead of Delete as
declare
@n_count int,
@n_audit_action varchar(100)
begin
set @n_audit_action='trigger before delete';
select @n_count=count(*) from deleted;
if(@n_count>=3)
print 'cant delete more than 3'
end

delete from newproducts where category='Flour'

select * from newproducts
