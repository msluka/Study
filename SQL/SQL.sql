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

















