CREATE TABLE Departments(
	Id int primary key not null, 
	Name nvarchar(max) not null, 
);


CREATE TABLE Employees (
	Id int primary key not null identity(1,1), 
	Name nvarchar(max) not null,
	Salary decimal not null,
	DepartmentId int null foreign key references Departments(id)
);