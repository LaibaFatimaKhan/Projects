	--PROCEDURES
create procedure [Staff Display] @NIC integer = NULL, 
@FirstName varchar(255)= NULL, @LastName varchar(255)= NULL, 
@BranchId integer= NULL, @JobTitle varchar(255)= NULL, @HiringDate Date= NULL, 
@WorkHours integer= NULL	
as
select s.FirstName,s.LastName,b.idBranch,j.JobTitle,s.HireDate,s.HoursPerDay 
from Staff s inner join Branch b on s.Branch_idBranch = b.idBranch
inner join Jobs j on s.Jobs_idJob = j.idJob
where (s.NIC like Convert(varchar(15),ISNULL(@NIC,s.NIC))+'%') 
and (s.FirstName like ISNULL(@FirstName,s.FirstName)+'%') 
and (s.LastName like ISNULL(@LastName,s.LastName)+'%') 
and (s.Branch_idBranch like CONVERT(varchar(5),ISNULL(@BranchId,s.Branch_idBranch))+'%') 
and (j.JobTitle like ISNULL(@JobTitle,j.JobTitle)+'%') 
and (s.HireDate like CONVERT(varchar(5),ISNULL(@HiringDate,s.HireDate))+'%')
and (s.HoursPerDay like CONVERT(varchar(5),ISNULL(@WorkHours,s.HoursPerDay))+'%')
GO
CREATE procedure [Order Display] @NIC integer = NULL, 
@OrderID integer = NULL, @StaffID integer = NULL, 
@OrderDate Datetime= NULL 	
as
select c.NIC, o.idOrder, c.FirtsName+' '+c.LastName as 'Customer Name', 
s.FirstName+' '+s.LastName as 'Order Handled by' ,o.OrderDate 
from ((Customers c left join Orders o on c.CustomerID = o.Customers_CustomerID)
left join Staff s on s.idStaff = o.Staff_idStaff)
where (c.NIC like Convert(varchar(15),ISNULL(@NIC,c.NIC))) 
and (o.idOrder like Convert(varchar(5),ISNULL(@OrderID,o.idOrder))) 
and (s.idStaff like Convert(varchar(5),ISNULL(@StaffID,s.idStaff))+'%') 
and (o.OrderDate like CONVERT(varchar(5),ISNULL(@OrderDate,o.OrderDate))+'%') 
GO

CREATE procedure [Food Display] @FoodName varchar(255) = NULL, 
@FoodPrice integer = NULL 	
as
select fi.idFood, fi.[Name],fi.UnitPrice 
from FoodItems fi
where (fi.[Name] like Convert(varchar(15),ISNULL(@FoodName,fi.[Name]))+'%') 
and (fi.UnitPrice like Convert(varchar(5),ISNULL(@FoodPrice,fi.UnitPrice))) 
GO

create procedure [Delete Order] @FoodId integer
as
delete from OrderItems
where FoodItems_idFood = @FoodId
delete from FoodItems
where idFood = @FoodId
GO

create procedure [Add Order] @FoodName varchar(255), @FoodPrice integer
as	
insert into FoodItems(idFood,[Name],UnitPrice)
values((select max(idFood)+1 from FoodItems),@FoodName,@FoodPrice)
GO

create procedure [Add Staff] @NIC integer, 
@FirstName varchar(255),@LastName varchar(255)=NULL, 
@BranchId integer, @JobTitle varchar(255),
@HiringDate Date, @WorkHours integer
as
insert into Staff(idStaff,Jobs_idJob,Branch_idBranch,NIC,FirstName,LastName,HireDate,HoursPerDay)
values ((select max(idStaff)+1 from Staff),(select idJob from Jobs where JobTitle = @JobTitle),@BranchId,@NIC,@FirstName,@LastName,@HiringDate,@WorkHours) 
go




--CREATE DATABASE
CREATE TABLE FoodItems (
  idFood INTEGER  NOT NULL ,
  [Name] VARCHAR(50)    ,
  UnitPrice INTEGER      ,
PRIMARY KEY(idFood));


CREATE TABLE Jobs (
  idJob INTEGER NOT NULL ,
  JobTitle VARCHAR(50)    ,
  HourlyWages INTEGER      ,
PRIMARY KEY(idJob));


CREATE TABLE Branch (
  idBranch INTEGER NOT NULL ,
  BranchName VARCHAR(50)   ,
  Address VARCHAR(50)      ,
PRIMARY KEY(idBranch));


CREATE TABLE Customers (
  CustomerID INTEGER NOT NULL ,
  NIC INTEGER NOT NULL ,
  FirtsName VARCHAR(50) NOT NULL ,
  LastName VARCHAR(50)     ,
PRIMARY KEY(CustomerID));


CREATE TABLE Staff (
  idStaff INTEGER NOT NULL ,
  Jobs_idJob INTEGER NOT NULL ,
  Branch_idBranch INTEGER  NOT NULL ,
  NIC INTEGER NOT NULL ,
  FirstName VARCHAR(50) NOT NULL ,
  LastName VARCHAR(50)   ,
  HireDate DATE    ,
  HoursPerDay INTEGER      ,
PRIMARY KEY(idStaff)    ,
  FOREIGN KEY(Branch_idBranch)
    REFERENCES Branch(idBranch),
  FOREIGN KEY(Jobs_idJob)
    REFERENCES Jobs(idJob));


CREATE INDEX StaffBranch ON Staff (Branch_idBranch);
CREATE INDEX StaffJob ON Staff (Jobs_idJob);


CREATE INDEX IFK_has ON Staff (Branch_idBranch);
CREATE INDEX IFK_aredoneby ON Staff (Jobs_idJob);


CREATE TABLE Orders (
  idOrder INTEGER NOT NULL ,
  Customers_CustomerID INTEGER NOT NULL ,
  Staff_idStaff INTEGER NOT NULL ,
  OrderDate DATETIME      ,
PRIMARY KEY(idOrder)    ,
  FOREIGN KEY(Staff_idStaff)
    REFERENCES Staff(idStaff),
  FOREIGN KEY(Customers_CustomerID)
    REFERENCES Customers(CustomerID));


CREATE INDEX Orders_FKIndex1 ON Orders (Staff_idStaff);
CREATE INDEX Orders_FKIndex2 ON Orders (Customers_CustomerID);


CREATE INDEX IFK_take ON Orders (Staff_idStaff);
CREATE INDEX IFK_place ON Orders (Customers_CustomerID);


CREATE TABLE OrderItems (
  Orders_idOrder INTEGER NOT NULL ,
  FoodItems_idFood INTEGER NOT NULL ,
  Quantity INTEGER      ,
PRIMARY KEY(Orders_idOrder, FoodItems_idFood)    ,
  FOREIGN KEY(Orders_idOrder)
    REFERENCES Orders(idOrder),
  FOREIGN KEY(FoodItems_idFood)
    REFERENCES FoodItems(idFood));


CREATE INDEX Orders_has_FoodItems_FKIndex1 ON OrderItems (Orders_idOrder);
CREATE INDEX Orders_has_FoodItems_FKIndex2 ON OrderItems (FoodItems_idFood);


CREATE INDEX IFK_contain ON OrderItems (Orders_idOrder);
CREATE INDEX IFK_used ON OrderItems (FoodItems_idFood);


--LOAD DATA
Insert into Branch(idBranch,BranchName,[Address]) values(1,'Johar Branch','Johar Block5')
Insert into Branch(idBranch,BranchName,[Address]) values(2,'Defence Branch','DHA Phase2')
Insert into Branch(idBranch,BranchName,[Address]) values(3,'Nazimabad Branch','Nazimabad Chowrangi')

Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (1,'42101','Ali','Feroz')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (2,'42102','Laiba','Khan')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (3,'42103','Ahmed','Hussain')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (4,'42104','Faraz','Ali')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (5,'42105','Alam','Shah')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (6,'42107','Samra','Ali')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (7,'42108','Zainab','Shah')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (8,'42106','Waleed','Khan')

insert into FoodItems(idFood,Name,UnitPrice) values (1,'fruit juice',200)
insert into FoodItems(idFood,Name,UnitPrice) values (2,'pizza',1000)
insert into FoodItems(idFood,Name,UnitPrice) values (3,'burger',500)
insert into FoodItems(idFood,Name,UnitPrice) values (4,'ice cream',200)
insert into FoodItems(idFood,Name,UnitPrice) values (5,'pasta',400)
insert into FoodItems(idFood,Name,UnitPrice) values (6,'soup',300)
insert into FoodItems(idFood,Name,UnitPrice) values (7,'soda',50)
insert into FoodItems(idFood,Name,UnitPrice) values (8,'chicken tikka',500)
insert into FoodItems(idFood,Name,UnitPrice) values (9,'fried veggies',400)
insert into FoodItems(idFood,Name,UnitPrice) values (10,'plain rice',100)
insert into FoodItems(idFood,Name,UnitPrice) values (11,'custard',300)
insert into FoodItems(idFood,Name,UnitPrice) values (12,'bread',70)
insert into FoodItems(idFood,Name,UnitPrice) values (13,'curry',200)
insert into FoodItems(idFood,Name,UnitPrice) values (14,'fried rice',200)


insert into Jobs(idJob,JobTitle,HourlyWages) values (1,'Manager',1000)
insert into Jobs(idJob,JobTitle,HourlyWages) values (2,'Cashier',200)
insert into Jobs(idJob,JobTitle,HourlyWages) values (3,'Chef',500)
insert into Jobs(idJob,JobTitle,HourlyWages) values (4,'Waiter',200)
insert into Jobs(idJob,JobTitle,HourlyWages) values (5,'Cleaner',250)


insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (1,'43101','Lin','Shah',1,1,getdate(),10)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (2,'43102','Ali','Khan',2,1,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (3,'43103','Shahid','Ahmed',3,1,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (4,'43104','Ayaz','Hussain',4,1,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (5,'43105','Faisal','Khan',5,1,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (6,'43106','samad','Shah',1,2,getdate(),10)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (7,'43107','Ali','Ahmed',2,2,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (8,'43108','Shehzad','Ahmed',3,2,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (9,'43109','Ayaz','Khan',4,2,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (10,'43110','Faisal','Ali',5,2,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (11,'43111','Faraz','Ahmed',1,3,getdate(),10)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (12,'43112','Ali','Khan',2,3,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (13,'43113','Shahid','Shah',3,3,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (14,'43114','Saleem','Hussain',4,3,getdate(),12)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) 
values (15,'43115','Ahmed','Khan',5,3,getdate(),12)


insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(1,1,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(2,2,7,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(3,3,12,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(4,5,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(5,4,7,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(6,3,12,getdate()) 
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(7,1,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(8,5,7,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(9,3,12,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(10,4,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(11,6,7,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(12,6,12,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(13,8,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(14,7,7,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(15,3,12,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(16,1,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(17,8,7,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(18,5,12,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(19,2,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(20,1,7,getdate())

insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (1,1,2)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (2,2,3)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (3,3,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (4,4,3)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (5,5,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (6,6,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (7,8,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (8,7,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (9,1,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (10,2,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (11,3,2)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (12,10,3)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (13,11,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (14,12,3)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (15,13,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (16,14,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (17,12,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (18,10,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (19,2,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (20,3,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (1,14,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (13,12,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (5,10,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (2,13,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (9,3,1)
