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



