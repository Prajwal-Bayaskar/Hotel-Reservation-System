create database DbHotel;

use DbHotel
create table Login
(username nvarchar(30),
password nvarchar(30))

insert into Login values('admin','123456'),
('prajwal','123456')


use DbHotel;
select * from Login


CREATE or ALTER Procedure sp_login
@username nvarchar(30),
@password nvarchar(30)
as
begin
select * from Login where username=@username
and password=@password
end


*********************************************************************

	---------------------------------------------------------------------------------------
	----------------------------------------------------------------------------------------------------------------

	use DbHotel
create table tbl_Customers
(
	CustNo int identity(1,1),
	Name nvarchar(30),
    Contact nvarchar(30),
	Nationality  nvarchar(30),
	Gender nvarchar(30),
	Birth_Date nvarchar(30),
	Id_Proof nvarchar(30),
	Address nvarchar(150),
	Room_Type nvarchar(50),
	Bed_Type nvarchar(50),
	Check_In nvarchar(40),
	Check_Out nvarchar(40),
	Checked_Out nvarchar(20) not null default 'NO',
	Room_No int,
	foreign key (Room_No) references tbl_RoomData(Room_No),
	Price nvarchar(50));
	
	


	CREATE or ALTER Procedure sp_BookRoom

	
	@Name nvarchar(30),
    @Contact nvarchar(30),
	@Nationality  nvarchar(30),
	@Gender nvarchar(30),
	@Birth_Date nvarchar(50),
	@Id_Proof nvarchar(40),
	@Address nvarchar(150),
	@Room_Type nvarchar(30),
	@Bed_Type nvarchar(30),
	@Check_In nvarchar (30),
	@Room_No int,
	@Price nvarchar(30)

	AS
	BEGIN

	SET NOCOUNT ON;
	Insert into tbl_Customers(Name,Contact,Nationality,Gender,Birth_Date,Id_Proof,Address,Room_Type,Bed_Type,Check_In,Room_No,Price) 
	Values(@Name,@Contact,@Nationality,@Gender,@Birth_Date,@Id_Proof,@Address,@Room_Type,@Bed_Type,@Check_In,@Room_No,@Price)

	begin
	Update  tbl_RoomData set R_Status='Booked' where Room_No=@Room_No
	end
	end
	GO


	CREATE or ALTER procedure sp_viewCustomers
    @CustNo int
	AS
	begin
	if(@CustNo='')
	begin
	select * from tbl_Customers;
	end
	else
	begin
	select * from tbl_Customers where CustNo=@CustNo;
	end
	begin
	select Room_No from tbl_Customers where CustNo=@CustNo
	end
	Go
--------------------

	Create or ALTER Procedure sp_bookingCancel
	@CustNo varchar(30),
	@RoomNo int
	As
	Begin
	if(@CustNo='')
	begin
	select * from tbl_Customers;
	end
	else
	begin
	Delete from tbl_Customers where CustNo=@CustNo
	end
	begin
	Update tbl_RoomData set R_Status='Available' where Room_No=@RoomNo;
	end
	end
	GO
	----------------------------------------------------------------
	use DbHotel
	create table  tbl_RoomData(Room_No int primary key,Room_Type nvarchar(30),Bed_Type nvarchar(30),Price nvarchar(30),R_Status nvarchar(30) default 'Available');

	Create  procedure sp_AddRoom
	@Room_No int,
	@Room_Type nvarchar(30),
	@Bed_Type nvarchar(30),
	@Price nvarchar(30),
	@R_Status nvarchar(30)
	As
	Begin
	Insert into tbl_RoomData(Room_No,Room_Type ,Bed_Type,Price,R_Status)
	Values(@Room_No,
	@Room_Type,
	@Bed_Type,
	@Price,
	@R_Status);

	
	End
	Go

	CREATE or ALTER procedure sp_viewRooms
    @Room_No nvarchar(30)
	AS
	begin
	if(@Room_No='')
	begin
	select * from tbl_RoomData;
	end
	else
	begin
	select * from tbl_RoomData where Room_No=@Room_No;
	end
	end

	
create table tbl_Staff
(EmpId int identity(1,1),Name varchar(100),Contact_No nvarchar(50),Gender nvarchar(30),Address nvarchar(150),Role nvarchar(30),username nvarchar(30),
password nvarchar(30),ConfPassword nvarchar(30));

use DbHotel

CREATE or ALTER Procedure sp_AddEmp
@EmpId int,
@Name varchar(100),
@Contact_No nvarchar(50),
@Gender nvarchar(30),
@Address nvarchar(150),
@Role nvarchar(30),
@username nvarchar(30),
@password nvarchar(30),
@ConfPassword nvarchar(30)
AS
Begin 

Insert into tbl_Staff(Name, Contact_No,Gender ,Address ,Role,username,password,ConfPassword)
Values(@Name,@Contact_No ,@Gender ,@Address ,@Role,@username, @password ,@ConfPassword)

End
Go

CREATE or ALTER Procedure staff_login
@username nvarchar(30),
@password nvarchar(30)
as
begin
select * from tbl_Staff where username=@username
and password=@password
end
Go

CREATE or ALTER procedure sp_viewEmployee
    @EmpId nvarchar(30)
	AS
	begin
	if(@EmpId='')
	begin
	select * from tbl_Staff;
	end
	else
	begin
	select * from tbl_Staff where EmpId=@EmpId;
	end
	end
	go

	Create or alter Procedure sp_deleteEmp
	@EmpId int
	As
	Begin
	if(@EmpId='')
	begin
	select * from tbl_Staff;
	end
	else
	begin
	Delete from tbl_Staff where EmpId=@EmpId;
	end
	end


	CREATE Procedure sp_CheckOut
	@CustNo int,
	@Check_Out nvarchar(30)

	As
	Begin
	if(@CustNo='')
	begin
	select * from tbl_Customers;
	end
	else
	begin
	Update  tbl_Customers set Checked_Out='YES', Check_Out=@Check_Out  where CustNo=@CustNo;
	end
	end
	Go

	--------------------------------------------------------------------------------------------------
	
	CREATE or ALTER Procedure sp_LoadRoomNo
	
	@Room_Type nvarchar(30),
	@Bed_Type nvarchar(30)

	As
	Begin
	Select Room_No from  tbl_RoomData  where Room_Type=@Room_Type and Bed_Type=@Bed_Type and R_Status='Available';
	end
	Go

	 select * from tbl_Customers where Checked_Out='YES';
use DbHotel
create table tbl_feedback
(CustId int identity(1,1),Name varchar(100),Contact_No nvarchar(50),Email nvarchar(50),Review nvarchar(300));


CREATE or ALTER Procedure sp_addFeedback
@CustId int,
@Name nvarchar(100),
@Contact_No nvarchar(50),
@Email nvarchar(50),
@Review nvarchar(300)

As
Begin
insert into tbl_feedback(Name ,Contact_No ,Email ,Review )
Values(@Name,@Contact_No,@Email,@Review)

End
go


create table tbl_CustLogin
(CustId int identity(1,1),Name varchar(100),Contact_No nvarchar(50),Gender nvarchar(30),Address nvarchar(150),username nvarchar(30),
password nvarchar(30),ConfPassword nvarchar(30));

CREATE or ALTER Procedure sp_CustLogin
@username nvarchar(30),
@password nvarchar(30)
as
begin
select * from tbl_CustLogin where username=@username
and password=@password
end
Go

CREATE or ALTER Procedure sp_AddCust
@EmpId int,
@Name varchar(100),
@Contact_No nvarchar(50),
@Gender nvarchar(30),
@Address nvarchar(150),
@username nvarchar(30),
@password nvarchar(30),
@ConfPassword nvarchar(30)
AS
Begin 

Insert into tbl_Staff(Name, Contact_No,Gender ,Address ,Role,username,password,ConfPassword)
Values(@Name,@Contact_No ,@Gender ,@Address ,@username, @password ,@ConfPassword)

End
Go

use DbHotel
create table tbl_Online_Customers
(
	CustNo int identity(1,1),
	Name nvarchar(30),
    Contact nvarchar(30),
	Nationality  nvarchar(30),
	Gender nvarchar(30),
	Birth_Date nvarchar(30),
	Id_Proof nvarchar(30),
	Address nvarchar(150),
	Mode nvarchar(50) not null default 'Online',
	Room_Type nvarchar(50),
	Bed_Type nvarchar(50),
	Check_In nvarchar(40),
	Check_Out nvarchar(40),
	Checked_Out nvarchar(20) not null default 'NO',
	Room_No int,
	foreign key (Room_No) references tbl_RoomData(Room_No),
	Price nvarchar(50));
	

	CREATE or ALTER Procedure sp_OnlineBookRoom

	@Name nvarchar(30),
    @Contact nvarchar(30),
	@Nationality  nvarchar(30),
	@Gender nvarchar(30),
	@Birth_Date nvarchar(50),
	@Id_Proof nvarchar(40),
	@Address nvarchar(150),
	
	@Room_Type nvarchar(30),
	@Bed_Type nvarchar(30),
	@Check_In nvarchar (30),
	@Room_No int,
	@Price nvarchar(30)

	AS
	BEGIN
	SET NOCOUNT ON;
	Insert into tbl_Online_Customers(Name,Contact,Nationality,Gender,Birth_Date,Id_Proof,Address,Room_Type,Bed_Type,Check_In,Room_No,Price) 
	Values(@Name,@Contact,@Nationality,@Gender,@Birth_Date,@Id_Proof,@Address,@Room_Type,@Bed_Type,@Check_In,@Room_No,@Price)

	begin
	Update  tbl_RoomData set R_Status='Booked' where Room_No=@Room_No
	end
	end
	GO

	CREATE or ALTER Procedure sp_AddNewCust
@Name varchar(100),
@Contact_No nvarchar(50),
@Gender nvarchar(30),
@Address nvarchar(150),
@username nvarchar(30),
@password nvarchar(30),
@ConfPassword nvarchar(30)
AS
Begin 

Insert into tbl_CustLogin(Name, Contact_No,Gender ,Address ,username,password,ConfPassword)
Values(@Name,@Contact_No ,@Gender ,@Address ,@username, @password ,@ConfPassword)

End
Go


	CREATE or ALTER procedure sp_viewOnlineCust
    @CustNo int
	AS
	begin
	if(@CustNo='')
	begin
	select * from tbl_Online_Customers;
	end
	else
	begin
	select * from tbl_Online_Customers where CustNo=@CustNo;
	end
	end
	Go


	CREATE or ALTER procedure sp_viewMyBooking
    @CustNo int
	AS
	begin
	if(@CustNo='')
	begin
	select * from tbl_Online_Customers;
	end
	else
	begin
	select * from tbl_Customers where CustNo=@CustNo;
	end
	end
	Go

	Create or ALTER Procedure sp_OnbookCancel
	@CustNo int,
	@RoomNo int
	As
	Begin
	if(@CustNo='')
	begin
	select * from tbl_Online_Customers;
	end
	else
	begin
	Delete from tbl_Online_Customers where CustNo=@CustNo
	end
	begin
	Update tbl_RoomData set R_Status='Available' where Room_No=@RoomNo;
	end
	end
	GO

	use DbHotel
	CREATE  Procedure sp_LoadCustRoomNo
	
	@CustNo int
	As
	Begin
	select Room_No from tbl_Customers where CustNo=@CustNo
	end
	Go

	 select * from tbl_Customers where Checked_Out='YES';
use DbHotel
create table tbl_feedback
(CustId int identity(1,1),Name varchar(100),Contact_No nvarchar(50),Email nvarchar(50),Review nvarchar(300));

CREATE  Procedure sp_OnLoadCustRoomNo
	
	@CustNo int
	As
	Begin
	select Room_No from tbl_Online_Customers where CustNo=@CustNo
	end
	Go

	//////////////////////////////////////////////////////////////////////
	Use OctDb;
	Create table Information(ID int primary, Name varchar(60), Country varchar(50), Subject varchar(30), Sport varchar(50), Gender varchar(30));
	
	Create or ALTER Procedure sp_Information
	@MyID int ,@Name varchar(50),@Country varchar(50),@Subject varchar(50),@Sport varchar(50),@Gender varchar(50)

	As
	Begin
	insert into Information(MyID,Name,Country,Subject,Sport,Gender)
	Values(@MyID,@Name,@Country,@Subject,@Sport,@Gender)
	end
	go

