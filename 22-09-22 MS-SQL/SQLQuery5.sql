use Library
----------------------
create table Member_C( Member_Id int primary key, Acc_Open_Date date default getdate(), Max_Allowed_Books int Check (Max_Allowed_Books <= 100), Penalty int Check(Penalty <= 1000))

Create table Book_C(Book_No int primary key, Book_Name varchar(20) not null, Category varchar(20) check(category in ('Science', 'Fiction', 'Database', 'RDBMS', 'Others')))

Create table Issue_C(Lib_Issue_Id int Primary Key, Member_Id int Foreign Key references Member_C(Member_Id), Book_No int Foreign key references Book_C(Book_No), Issue_date Date ,Return_date Date, 
  constraint Date_Check1 check(Return_date > Issue_date))

--4)	Add a constraint Price < 2500 to Book table.
alter table Book_C add Price int
alter table Book_C add constraint Price check(Price < 2500)

--5)	View all the constraints for table Issue_C using view User_Constraints.
SELECT CONSTRAINT_NAME, CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='Issue_C';

--6)	Disable constraint created in step 3-d
alter table Issue_C drop constraint Date_Check1

--7)	Create a Read Only view to display Lib_Issue_Id, Book_Name, Member_Name, Author and Issue_date for all the books that have price between 500 – 750 and category as Database or RDBMS.
create view display
as
select i.Lib_Issue_Id, b.Book_Name, m.Member_Name, b.Author , i.Issue_date from Book b inner join Issue i on b.Book_No = i.Book_No inner join Member m on i.Member_Id = m.Member_ID where (b.Cost between 500 and 750) and b.Category in ('Database' , 'RDBMS')

select * from display

--8)	Create a view with check option to display all the books that has price greater then 500.
create view view2
as
select * from Book where Cost > 500
with check option

select * from view2

--9)	Perform DML operations to the view and evaluate the effect of Check Option.

insert into view2 values(105,'Stellar','Rob Stark', 850, 'Others')
select * from view2
insert into view2 values(106,'Spider Man','Stanley', 180, 'Others')
-- can't insert 106

--10)	Create Index on Book_Name in book table.
create index index1
on Book(Book_Name)

--11)	Create Index on Member_Id, Book_No in Issue table.
create index index2
on Issue(Member_ID,Book_No)

select * from Member
select * from Book
select * from Issue