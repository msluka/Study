/*SQL was originally invented in early 1970.
The first version was called:
SEQUEL - Structured English Query Language.
The name later was changed to 
SQL - Structured Query Language.
SQL is used to access and manipulate a database.
SQL is an ANSI (American National Standards Institute) standard*/


/*--CREATING TABLE--*/
CREATE TABLE groceries (id INTEGER PRIMARY KEY, name TEXT, quantity INTEGER );

INSERT INTO groceries VALUES (1, "Bananas", 4);
INSERT INTO groceries VALUES (2, "Peanut Butter", 1);
INSERT INTO groceries VALUES (3, "Dark chocolate bars", 2);
SELECT * FROM groceries;


/*--ORDER BY--*/
CREATE TABLE groceries (id INTEGER PRIMARY KEY, name TEXT, quantity INTEGER, aisle INTEGER);

INSERT INTO groceries VALUES (1, "Bananas", 4, 7);
INSERT INTO groceries VALUES(2, "Peanut Butter", 1, 2);
INSERT INTO groceries VALUES(3, "Dark Chocolate Bars", 2, 2);
INSERT INTO groceries VALUES(4, "Ice cream", 1, 12);
INSERT INTO groceries VALUES(5, "Cherries", 6, 2);
INSERT INTO groceries VALUES(6, "Chocolate syrup", 1, 4);

SELECT * FROM groceries WHERE aisle > 5 ORDER BY aisle;

/*--SUM / GROUP BY--*/
CREATE TABLE groceries (id INTEGER PRIMARY KEY, name TEXT, quantity INTEGER, aisle INTEGER);

INSERT INTO groceries VALUES(1, "Bananas", 56, 7);
INSERT INTO groceries VALUES(2, "Peanut Butter", 1, 2);
INSERT INTO groceries VALUES(3, "Dark Chocolate Bars", 2, 2);
INSERT INTO groceries VALUES(4, "Ice cream", 1, 12);
INSERT INTO groceries VALUES(5, "Cherries", 6, 2);
INSERT INTO groceries VALUES(6, "Chocolate syrup", 1, 4);

SELECT aisle, SUM(quantity) FROM groceries GROUP BY aisle;

/*--AUTOINCREMENT / AND / OR--*/

CREATE TABLE exercise_logs
    (id INTEGER PRIMARY KEY AUTOINCREMENT,
    type TEXT,
    minutes INTEGER, 
    calories INTEGER,
    heart_rate INTEGER);

INSERT INTO exercise_logs(type, minutes, calories, heart_rate) VALUES ("biking", 30, 100, 110);
INSERT INTO exercise_logs(type, minutes, calories, heart_rate) VALUES ("biking", 10, 30, 105);
INSERT INTO exercise_logs(type, minutes, calories, heart_rate) VALUES ("dancing", 15, 200, 120);

SELECT * FROM exercise_logs WHERE calories > 50 ORDER BY calories;

/* AND */
SELECT * FROM exercise_logs WHERE calories > 50 AND minutes < 30;

/* OR */
SELECT * FROM exercise_logs WHERE calories > 50 OR heart_rate > 100;

/*---*/
CREATE TABLE songs (
    id INTEGER PRIMARY KEY,
    title TEXT,
    artist TEXT,
    mood TEXT,
    duration INTEGER,
    released INTEGER);
    
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("Bohemian Rhapsody", "Queen", "epic", 60, 1975);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("Let it go", "Idina Menzel", "epic", 227, 2013);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("I will survive", "Gloria Gaynor", "epic", 198, 1978);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("Twist and Shout", "The Beatles", "happy", 152, 1963);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("La Bamba", "Ritchie Valens", "happy", 166, 1958);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("I will always love you", "Whitney Houston", "epic", 273, 1992);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("Sweet Caroline", "Neil Diamond", "happy", 201, 1969);
INSERT INTO songs (title, artist, mood, duration, released)
    VALUES ("Call me maybe", "Carly Rae Jepsen", "happy", 193, 2011);
 
SELECT title FROM songs;    
SELECT title FROM songs WHERE released > 1990 OR mood = "epic";

SELECT title FROM songs WHERE released > 1990 and mood = "epic" and duration <240;


/*--Selecting Multiple Columns--*/
--Do not put a comma after the last column name.

SELECT FirstName, LastName, City 
FROM customers;

/*--Selecting All Columns--*/
--In SQL, the asterisk means all.

SELECT * 
FROM customers; 

/*--The DISTINCT Keyword--*/
--is used in conjunction with SELECT to eliminate all duplicate records and return only unique ones.

SELECT DISTINCT City 
FROM customers; 

/*--The TOP Keyword--*/
--we can retrieve the first three records from the customers table.

SELECT TOP 3 City 
FROM customers; 

/*--Fully Qualified Names--*/
--is especially useful when working with multiple tables that may share the same column names.

SELECT City 
FROM customers;
--Fully
SELECT customers.City 
FROM customers;

/*--Order By--*/
--is used with SELECT to sort the returned data. 
SELECT * 
FROM customers
ORDER BY FirstName;

--Sorting Multiple Columns--*/
SELECT * 
FROM customers 
ORDER BY LastName, Age;

/*--WHERE--*/

SELECT * 
FROM customers
WHERE ID = 7;

/*--SQL Operators--*/
-- !=;=;>;<;>=;<=;BETWEEN;

SELECT * 
FROM customers
WHERE ID != 5;
-- the record with ID=5 is excluded from the list.

SELECT * 
FROM customers 
WHERE ID BETWEEN 3 AND 7;

/*--Text Values--*/
-- Use single quotation marks (').

SELECT ID, FirstName, LastName, City 
FROM customers
WHERE City = 'New York';

/*--Logical Operators--*/
-- AND; OR; IN; NOT; 

SELECT ID, FirstName, LastName, Age
FROM customers
WHERE Age >= 30 AND Age <= 40;

SELECT * 
FROM customers 
WHERE City = 'New York' OR City = 'Chicago';

--Combining AND & OR
SELECT * 
FROM customers
WHERE City = 'New York'
AND (Age=30 OR Age=35);

--The IN operator is used when you want to compare a column with more than one value. 
SELECT * 
FROM customers 
WHERE City IN ('New York', 'Los Angeles', 'Chicago');

--The NOT IN operator allows you to exclude a list of specific values from the result set. 
SELECT * FROM customers 
WHERE City NOT IN ('New York', 'Los Angeles', 'Chicago');

/*--The CONCAT Function--*/
--is used to concatenate two or more text values and returns the concatenating string.

SELECT CONCAT(FirstName, ', ' , City) 
FROM customers;

/*--The AS Keyword--*/
--A concatenation results in a new column.

SELECT CONCAT(FirstName,', ', City) AS new_column 
FROM customers;

/*--Arithmetic Operators--*/

SELECT ID, FirstName, LastName, Salary+500 AS Salary
FROM employees;

/*--The UPPER/LOWER Function--*/

SELECT FirstName, UPPER(LastName) AS LastName 
FROM employees;

/*--SQRT / AVG / SUM--*/
--The SQRT function returns the square root of given value in the argument:
SELECT Salary, SQRT(Salary) 
FROM employees;

-- The AVG function returns the average value of a numeric column:
SELECT AVG(Salary) 
FROM employees;

--The SUM function is used to calculate the sum for a column's values:
SELECT SUM(Salary) 
FROM employees;

/*--DESC / ASC--*/
--The DESC keyword sorts results in descending order. 
--Similarly, ASC sorts the results in ascending order.

SELECT FirstName, Salary 
FROM employees 
WHERE  Salary > 3100
ORDER BY Salary DESC;


/*--Subqueries--*/
--A subquery is a query within another query. 

SELECT FirstName, Salary 
FROM employees 
WHERE  Salary > (SELECT AVG(Salary) FROM employees) 
ORDER BY Salary DESC;

/*--The Like Operator--*/
--is useful when specifying a search condition within your WHERE clause.

SELECT * 
FROM employees 
WHERE FirstName LIKE '%A_';

/*--The MIN / MAX Function--*/

SELECT MIN(Salary) AS Salary 
FROM employees;

SELECT MAX(Salary) AS Salary 
FROM employees;


/*--Joining Tables--*/

--INNER JOIN is equivalent to JOIN. It returns rows when there is a match between the tables.

SELECT 
	Persons.Name
	,Persons.Surname
	,Persons.Age
	,Items.Name
	,Items.Price
	
FROM Persons
	JOIN Items ON Items.PersonID = Persons.ID

ORDER BY Items.Price;

--FULL OUTER JOIN keyword returns all the rows from the left table, and all the rows from the right table.

SELECT Customers.CustomerName
       ,Orders.OrderID
	   
FROM Customers
	FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
	
ORDER BY Customers.CustomerName;

-- The LEFT JOIN returns all rows from the left table, even if there are no matches in the right table.

SELECT *	
FROM Persons
	LEFT JOIN Items ON Items.PersonID = Persons.ID
ORDER BY Items.Price;

--The RIGHT JOIN returns all rows from the right table, even if there are no matches in the left table

SELECT *	
FROM Persons
	RIGHT JOIN Items ON Items.PersonID = Persons.ID
ORDER BY Items.Price; 

/*--Custom Names--*/
--It can be used to shorten the join statements by giving the tables "nicknames":

SELECT ct.ID
	,ct.Name
	,ord.Name
	,ord.Amount
	
FROM customers AS ct
	,orders AS ord
WHERE ct.ID = ord.Customer_ID
ORDER BY ct.ID;


/*--UNION--*/
--The UNION operator is used to combine the result-sets of two or more SELECT statements.
--UNION combines multiple datasets into a single dataset, and removes any existing duplicates.
--UNION ALL combines multiple datasets into one dataset, but does not remove duplicate rows. 
--UNION ALL is faster than UNION, as it does not perform the duplicate removal operation over the data set.

SELECT ID, FirstName, LastName, City 
FROM First

UNION ALL

SELECT ID, FirstName, LastName, City 
FROM Second;

--If your columns don't match exactly across all queries, you can use a NULL (or any other) value such as:

SELECT FirstName, LastName, Company 
FROM businessContacts
UNION
SELECT FirstName, LastName, NULL 
FROM otherContacts;

/*--Inserting Data--*/
--The INSERT INTO statement is used to add new rows of data to a table in the database.
--Make sure the order of the values is in the same order as the columns in the table.
--you must provide a value for every column that does not have a default value, or does not support NULL.

INSERT INTO Employees 
VALUES (8, 'Anthony', 'Young', 35);

--you can specify the table's column names in the INSERT INTO statement:
--You can specify your own column order, as long as the values are specified in the same order as the columns.

INSERT INTO Employees (ID, FirstName, Age, LastName) 
VALUES (8, 'Anthony', 35, 'Young');

/*--UPDATE--*/
--The UPDATE statement allows us to alter data in the table. 
--If you omit the WHERE clause, all records in the table will be updated!

UPDATE Employees 
SET Salary=5000
WHERE ID=1;

--Updating Multiple Columns

UPDATE Employees 
SET Salary=5000, FirstName='Robert'
WHERE ID=1;

/*--DELETE--*/
--The DELETE statement is used to remove data from your table.
--If you omit the WHERE clause, all records in the table will be deleted!

DELETE 
FROM Employees
WHERE ID=1;

/*--Creating a Table--*/

CREATE TABLE Users
(
   UserID int,
   FirstName nvarchar(100),
   LastName nvarchar(100),
   City nvarchar(100),
   PRIMARY KEY(UserID)
);

--AUTO INCREMENT

CREATE TABLE Persons (
    ID int IDENTITY(1,1) PRIMARY KEY,
    LastName nvarchar(50) NOT NULL,
    FirstName nvarchar(50),
    Age int
);  

/*--ALTER TABLE--*/

--The ALTER TABLE command is used to add, delete, or modify columns in an existing table.

--ADDING COLUMNS

ALTER TABLE People 
ADD DateOfBirth date;

--DROPPING COLUMNS
--delete the column

ALTER TABLE People 
DROP COLUMN DateOfBirth;

--DROPPING TABLE
--To delete the entire table, use the DROP TABLE command:

DROP TABLE People;

--RENAMING COLUMN

sp_RENAME 'Persons.Name', 'Surname' , 'COLUMN'

--RENAMING TABLE

sp_RENAME 'Persons', 'Humans'

/*--Views--*/

--In SQL, a VIEW is a virtual table that is based on the result-set of an SQL statement.
--A view contains rows and columns, just like a real table. 
--The fields in a view are fields from one or more real tables in the database.

CREATE VIEW List AS
SELECT Name, Phone
FROM  Users;

SELECT *
FROM List;

--Updating a View

ALTER VIEW List AS
SELECT Name, Phone, ID
FROM  Users;

--Deleting a View

DROP VIEW List;

/*--Date--*/

SELECT * 
FROM Appointments 
WHERE AppointmentTime < DATEADD(day, 1, GETDATE()) and  AppointmentTime > GETDATE();

--

SELECT * 
FROM Appointments 
WHERE AppointmentTime < DATEADD(hour, 10, GETDATE()) and  AppointmentTime > GETDATE();

/*--Count--*/

SELECT COUNT(*) AS NumberOfOrders 
FROM Orders;

--

SELECT COUNT(Clients) AS NumberOfClients
FROM Orders;

/*--Convert--*/

--https://www.w3schools.com/sql/func_convert.asp
--CONVERT(data_type(length),expression,style)
--data_type(length)	Specifies the target data type (with an optional length
--expression	    Specifies the value to be converted
--style	            Specifies the output format for the date/time 

SELECT convert(VARCHAR(11), Appointments.Date,105)
FROM Appointments
WHERE ID =2;


/*--Trigger--*/

CREATE TRIGGER usersUpdateTime
   ON  Users
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	
	INSERT INTO Logs(UpdateTime)
	VALUES (GETDATE())

END
GO

--
ALTER TRIGGER usersUpdateTime
   ON  Users
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN

	DECLARE @OldValue nvarchar(50);
	DECLARE @NewValue nvarChar(50);

	SELECT @OldValue = Name FROM deleted
	SELECT @NewValue = Name FROM inserted
	
	INSERT INTO Logs(UpdateTime, [OldValue], [NewValue])
	VALUES (GETDATE(), @OldValue, @NewValue)

END

/*--Function--*/
--Scalar Functions
--Table Valued Functions
--Multi statement table valued functions

--Scalar Function returns a scalar value
--Scalar functions may or may not have parameters, but always return a single (scalar) value. 
--The returned value can be of any data type, except text, ntext, image, cursor, and timestamp

CREATE FUNCTION CalculateAge(@DOB DATE)

RETURNS INT
AS
BEGIN
	
	DECLARE @Age INT

	SET @Age = DATEDIFF(YEAR, @DOB, GETDATE()) -
	
		CASE
			WHEN (MONTH(@DOB) > MONTH(GETDATE())) OR
			(MONTH(@DOB) = MONTH(GETDATE()) AND DAY(@DOB) > DAY(GETDATE()))

			THEN 1
			ELSE 0
		END

	RETURN @Age

END
GO

--Scalar Function invocation
SELECT  dbo.CalculateAge('04/16/1981') --as AGE 

--Inline Table Valued Function returns a table

--In an Inline Table Valued function, the RETURNS clause cannot contain the structure of the table,
--the function returns. Whereas with the multi statement table valued function, we specify the
--structure of the table that gets returned.
--Inline Table Valued function cannot have BEGIN and END block, whereas the multi-statement
--function can have.
--Inline Table valued functions are better for performance than multi statement table valued
--functions. If the given task, can be achieved using an inline table valued function, always prefer to
--use them, over multi-statement table valued functions.

CREATE FUNCTION FilterUsersByGender (@Gender nvarchar(10))
RETURNS TABLE 
AS
RETURN 
(	SELECT ID, Name, Surname, Gender
	FROM Users
	WHERE Gender = @Gender
)

--Table Valued Function invocation
SELECT * FROM FilterUsersByGender('Male')

--The table returned by the table valued function can also be used in joins with other tables.

SELECT Name, Gender, ProductName
FROM FilterUsersByGender('Male') G --alias
JOIN Products P --alias
ON G.ID = P.UsersID

--Multi statement table valued functions 

CREATE FUNCTION MSTFilterUsersByGender ()

RETURNS @Table TABLE (ID int, Name nvarchar(20), Gender nvarchar(10)) 

AS

BEGIN

	INSERT INTO @Table
	SELECT ID, Name, Gender
	FROM Users

	RETURN
	
END

--Multi statement table valued invocation

SELECT * FROM dbo.MSTFilterUsersByGender()

/*--Stored procedures--*/

--If you have a situation where you write the same query over and over again, 
--you can save that specific query as a stored procedure and call it just by it's name.

CREATE PROCEDURE spGetUsers

AS

BEGIN

	SELECT Name, Gender 
	FROM Users
	
END

--To execute the stored procedure:

spGetUsers
--or
EXECUTE spGetUsers

--Stored Procedures with parameters

CREATE PROCEDURE spGetUsersByNameAndGender

@Name nvarchar(20),
@Gender nvarchar(20)

AS

BEGIN

	SELECT ID, Name, Email, Gender
	FROM Users
	WHERE Name = @Name AND Gender =  @Gender

END

--To execute the stored procedure with parameters:

spGetUsersByNameAndGender 'Diane', 'Female'


/*--Transactions--*/

--A transaction is a group of commands that change the data stored in a database.
--A transaction ensures that either all of the commands succeed, or none of them. 
--If one of the commands in the transaction fails, all of the commands fail, and 
--any data that was modified in the database is rolled back. 
--Note: NOT able to see the un-committed changes. To do that: 
--SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

Create Procedure spTransaction

As

Begin

	Begin Try
		Begin Transaction
			Update Users Set Surname = 'Hamilton', Gender = 'Female'  
			Where Name = 'Gloria'

			Update Users Set ID = 'abc' 
			Where Gender = 'Female'
		Commit Transaction
	End Try

	Begin Catch
		Rollback Transaction
		Print 'Transaction rolled back'
	End Catch

End


/*--INDEX--*/

--Indexes are used to retrieve data from the database very fast. 
--The users cannot see the indexes, they are just used to speed up searches/queries.

--Note: Updating a table with indexes takes more time than updating a table without 
--(because the indexes also need an update). So, only create indexes on columns that 
--will be frequently searched against.

	--The SQL statement below creates an index named "idx_lastname" on the "LastName" column 
	--in the "Persons" table:
	
	CREATE INDEX idx_lastname
	ON Persons (LastName);
	
	--or like that:
	
	CREATE INDEX IX_Persons_Lastname -- Convention: IX=Index; Persons = TableName; Lastname = column;
	ON Persons (LastName);
	
	--If you want to create an index on a combination of columns, you can list the column names 
	--within the parentheses, separated by commas:
	
	CREATE INDEX idx_pname
    ON Persons (LastName, FirstName);
		
-- FIND indexes
   --if we want to find where we have indexes we can use the stored procedure:
   
   sp_Helpindex Persons
	
-- DROP INDEX Statement
   --DROP INDEX table_name.index_name;
   
	CREATE INDEX Persons.IX_Persons_Lastname

--Clustered and Nonclustered indexes 

    -- Clustered indexes --
	
	--A clustered index determines the physical order of data in a table. 
	--For this reason, a table can have only one clustered index.
	
	--When we use PRIMARY KEY constraint, automatically creates a unique clustered index.
	
	CREATE TABLE Persons (
		ID int IDENTITY(1,1) PRIMARY KEY, -- a unique clustered index will be created.
		LastName nvarchar(50) NOT NULL,
		FirstName nvarchar(50),
		Age int
	); 
	
	--or like that:
	
	Create Clustered Index IX_Employee_Salary
	ON Employee (Salary ASC)
	
	--Create a composite clustered Index on the Gender and Salary columns 

	Create Clustered Index IX_Employee_Gender_Salary
	ON Employee (Gender DESC, Salary ASC)
	
	-- Nonclustered indexes --
	
	--A nonclustered index is analogous to an index. The data is stored in one place, 
	--the index in another place. The index will have pointers to the storage location of the data.
	
	--A table can have more than one nonclustered index
	
	Create NonClustered Index IX_Employee_Name
	ON Employee (Name)
	
	-- Difference --

	--1. Only one clustered index per table, where as you can have more than one nonclustered index.

	--2. Clustered index is faster than a nonclustered index, because, the clustered index has to refer 
	--   back to the table, if the selected column is not present in the index. 

	--3. Clustered index determines the storage order of rows in the table, and hence doesn't require 
	--   additional disk space, but where as a Non Clustered index is stored separately from the table, additional storage space is required. 
