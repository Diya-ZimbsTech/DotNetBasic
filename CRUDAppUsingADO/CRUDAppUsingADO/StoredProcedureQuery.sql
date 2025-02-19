CREATE DATABASE CrudADOdb;
CREATE TABLE Employees (
    id INT IDENTITY PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    age INT NOT NULL,
    designation VARCHAR(100)NOT NULL,
    city VARCHAR(100)NOT NULL
);
go
create procedure spAddEmployee
(
@name varchar(50),
@gender varchar(20),
@age int,
@designation varchar(100),
@city varchar(50)
)
as
Begin
	Insert into Employees(name,gender,age,designation,city)
	values(@name,@gender,@age,@designation,@city)
End

go
create procedure spUpdateEmployee
(
@id int,
@name varchar(50),
@gender varchar(20),
@age int,
@designation varchar(100),
@city varchar(50)
)
as
begin
	Update Employees set name = @name, gender = @gender,age=@age, designation=@designation,city =@city
	where id=@id
End

go
create procedure spDeleteEmployee
(
@id int
)
as
begin 
delete from Employees where id= @id
End

go
create procedure spGetAllEmployee
as
begin
select * from Employees order by id
End