CREATE DATABASE PDL_Task
GO
USE PDL_Task
GO
CREATE TABLE Departments
(
	DepartmentId INT IDENTITY PRIMARY KEY,
	DepartmentCode NVARCHAR(10) NOT NULL UNIQUE,
	DepartmentName NVARCHAR(40) NOT NULL
)
GO
CREATE TABLE Retailers
(
	RetailerId INT IDENTITY PRIMARY KEY,
	RetailerCode NVARCHAR(10) NOT NULL UNIQUE,
	RetailerName NVARCHAR(40) NOT NULL,
	DepartmentId INT NOT NULL REFERENCES Departments(DepartmentId)
)
GO
INSERT INTO Departments (DepartmentCode, DepartmentName)
VALUES
( 'WMD', 'Grocery Stores'),
('MCKD', 'Stores')
GO
INSERT INTO Retailers(RetailerCode, RetailerName, DepartmentId)
VALUES
( 'WM', 'Walmart', 1),
('MCK', 'Macy''s', 2)
GO
