use Library
go

----------------------------------- Problem 1 -----------------------------------
select * from Member
select * from Issue
select * from Book

select * from Member where Year(Acc_Open_Date) = 2006

select * from Book where Author = 'Loni' and Cost < 600

select * from Issue where Return_date > GETDATE()

update Issue set Return_date = '31-Dec-06 ' where Lib_Issue_Id != 7005 and Lib_Issue_Id != 7006

select * from Issue where (Day(Return_date) - Day(Issue_Date)) > 30

select * from Book where (Cost >= 500 and Cost <= 750) and Category = 'Database'

select * from Book where Category = 'Science' or Category = 'Database'or  Category ='Fiction'or  Category = 'Management'

select * from Member order by Penalty_Amount desc

select * from Book order by Category, Cost desc

select * from Book where Book_Name like '%SQL%'

select * from Member where Member_Name like 'R%' or Member_Name  like 'G%' and Member_Name  like '%I%'

select upper(Author) as Author_In_Upper from Book order by Book_Name desc

select Book_No,('is written by') as '--------------------',Book_Name from Book

--Task 14
Select Lib_Issue_Id,Book_No,Member_Id,Concat(datename(WEEKDAY,Issue_Date),',',CONVERT(varchar,Issue_Date,107)) as issuedate,Concat(DATENAME(WEEKDAY,Return_date),',',CONVERT(varchar,Return_date,107)) as returndate from issue where Member_Id=2

select Book_No, Book_Name, Author, Cost, substring(Category,1,1) as Category from Book

select concat('*',Book_Name) as Book_Name, concat('*',Author) as Author from Book

select Lib_Issue_Id, Issue_Date, Return_Date, Datediff(day, Issue_Date,Return_Date) as No_of_Days_Book_issued  from Issue

select * from Member order by Acc_Open_Date

select count(Book_No) as Total_Book from Issue where Member_Id = 2

select sum(Penalty_Amount) as Total_Penalty from Member

select sum(Cost) as Total_Cost from Book where Category = 'Database'

select min(Cost) as Cheapest_Book from Book

select min(Issue_Date) as First_Book_Date from Issue

select max(Issue_Date) as Last_Book_Date from Issue

select avg(Cost) as Average_Price_Book from Book


----------------------------------- Problem 2 -----------------------------------
select * from Member
select * from Issue
select * from Book
--1)List the various categories and count of books in each category.
select distinct Category, count(Book_No) from Book group by Category

--2)List the book_No and the number of times the book is issued in the descending order of count.
select Book_No, count(Book_No) as Total_Books from Issue group by Book_No order by count(Book_No) desc

--3)Find the maximum, minimum, total and average penalty amount in the member table.
select min(Penalty_Amount) as Min, max(Penalty_Amount) as max, sum(Penalty_Amount) as total, avg(Penalty_Amount) as avg from Member

--4)Display the member id and the no of books for each member that has issued more then 2 books.
Select member_id,count(distinct(Book_No)) as booksborrowed from issue group by Member_Id having count(distinct(Book_No))>=2

--5)Display the member id, book no and no of times the same book is issued by the member in the descending order of count.
Select member_id,Book_No,count(distinct(Book_No)) as bookscount from issue order by bookscount desc --wrong

--6)Display the month and no of books issued each month in the descending order of count.
select Month(issue_date) as Month_Name, count(Book_No) as books from Issue group by month(Issue_Date) order by books

--7)  List the book_no of all the books that are not issued to any member so far. 
select Book_No from Issue where Issue_Date is null

--8)List all the member id that exist in member table and has also at least one book issued by them. 
Select i.member_id from issue i inner join member j on i.Member_Id=j.member_id group by i.member_id having count(Book_No)>0

--9)List the member ID with highest and lowest no of books issued. 
Select top 1 member_id,count(Book_No) as highest from issue group by member_id order by highest desc 
Select top 1 member_id,count(Book_No) as lowest from issue group by member_id order by lowest

--10)List all the Issue_details for books issued in December and July without using any arithmetic, Logical or comparison operator.
select * from Issue where month(issue_date) in (7,12) 

--11) List the Book_No, Book_Name and Issue_date for all the books that are issued in month of December and belong to category Database.
select b.Book_No, b.Book_Name, i.Issue_Date from Book b, Issue i where b.Book_No = i.Book_No and month(i.Issue_Date) in (12) and b.Category = 'Database'

--12) List the Member Id, Member Name and No of books Issued in the descending order of the count.
select i.Member_ID, m.Member_Name, count(i.Book_No) as NoOfBooks from Member m inner join issue i on i.Member_ID = m.Member_Id group by i.Member_Id,m.Member_Name order by NoOfBooks desc

--13)List the Book No, Book Name, Issue_date and Return_Date for all the books issued by Richa Sharma.
select b.Book_No, b.Book_Name, i.Issue_Date, i.Return_date from Book b inner join Issue i on b.Book_No = i.Book_No inner join Member m on i.Member_Id = m.Member_ID  where m.Member_Name = 'Richa Sharma'

--14)List the details of all the members that have issued books in Database category.
Select * from member where member_id in (Select issue.member_id from issue inner join Book on issue.Book_No=Book.Book_No where Book.Category='Database') 

--15)List all the books that have highest price in their own category.
select Category, max(cost) as HighestPrice from Book group by Category

--16)List all the Issue_Details where Issue_date is not within the Acc_open_date and Return_date for that member.
Select i.Lib_Issue_Id,i.Member_Id,i.Book_No from issue i inner join member m on i.Member_Id=m.member_id where i.Issue_Date not between m.Acc_open_date and i.Return_date

--17)List all the members that have not issued a single book so far.
select m.Member_ID, m.Member_Name from member m inner join issue i on i.Member_Id = m.Member_ID where i.Issue_Date is null

--18)List all the Members where No of books Issued exceeds the Max No of books allowed.
select m.Member_ID,m.Member_Name,m.Max_Books_Allowed from member m inner join issue i on i.Member_Id = m.Member_ID where count(i.Book_No) > m.Max_Books_Allowed group by i.Book_No

--19)List all the members that have issued the same book as issued by Garima.
Select member.member_id,member_name,issue.Book_No from issue inner join member on member.member_id=Issue.Member_Id where issue.Book_No in(Select issue.Book_No from issue inner join member on member.member_id=Issue.Member_Id where member.member_name like'Garima%')

--20)List the Book_Name, Price of all the books that are not returned for more then 30 days.
select b.Book_Name, sum(b.Cost) as Price from issue i inner join book b on i.Book_No = b.Book_No where DATEDIFF(day,i.Issue_Date,i.Return_date)>30 group by b.Book_Name

--21)List all the authors and book_name that has more then 1 book written by them.
Select Book_Name,author from Book where author in (Select author from book group by author having count(Book_Name)>1)

--22)List the Member ID, Member Name of the people that have issued the highest and the lowest no of books.
Select top 1 member_id,count(Book_No) as count1 from issue group by member_id order by count1 desc 
Select top 1 member_id,count(Book_No) as count1 from issue group by member_id order by count1

--23)List the details of highest 3 priced books.
Select top 3 * from Book order by Cost desc

--24)List the total cost of all the books that are currently issued but not returned.
Select sum(Cost) from Book where Book_No in(Select Book_No from issue where Return_date is null)

--25)List the details of the book that has been issued maximum no of times.
Select * from Book where Book_No in(Select top 1 Book_No from issue group by Book_No order by count(Book_No) desc)