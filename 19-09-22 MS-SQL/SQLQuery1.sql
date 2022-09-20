create database Shopping
use Shopping

create table Customer(Custid int primary key, CustName varchar(20) , City varchar(20) , StateName varchar(20))

create table products(Prodid int primary key, ProdName varchar(20), UnitPrice int ,UnitOfMeasurement int,QtyinStock int)

create table Sales_Header(InvoiceNo int primary key,InvoiceDate date,InvoiceAmt int, DiscountPercent int)

create table Sales_Detail(InvoiceNo int, Custid int, Prodid int, QtySold int)

alter table Sales_Detail
add foreign key(InvoiceNo) references Sales_Header(InvoiceNo)

alter table Sales_Detail
add foreign key(Custid) references Customer(Custid), foreign key(Prodid) references products(Prodid)

alter table Sales_Detail drop column QtySold

alter table Sales_Detail add Qty int

exec sp_rename 'Sales_Detail.Qty', 'Quantity','column'

create database Library
use Library

create table Member(Member_ID int primary key, Member_Name Char(25), Acc_Open_Date Date,
Max_Books_Allowed int, Penalty_Amount int)

create table Book(Book_No int primary key, Book_Name varchar(30), Author Char(30), Cost int, Category Char(10))

create table Issue(Lib_Issue_Id	int primary key, Book_No int foreign key references Book(Book_No),
Member_Id int foreign key references Member(Member_Id), Issue_Date Date, Return_date Date)