
Entity Framework
================
/* 
	Entity Framework
    ----------------	
	is an ORM framework.
	ORM stands for Object Relational Mapping. 
	
	Object Relational Mapping framework 
	-----------------------------------
	automatically creates classes based on database tables, 
	and the vice versa is also true, that is, it can also automatically 
	generate SQL to create databases tables based on classes. 

	
	
	Database First
	--------------
		https://www.tutorialspoint.com/entity_framework/entity_database_first_approach.htm
	
		It creates model codes (classes, properties, DbContext etc.) 
		from the database in the project.
		
		1. To create the model, first right-click on your console project in 
		   solution explorer and select Add → New Items
		
		2. Select ADO.NET Entity Data Model from middle pane and enter name.
		
		3. Select EF Designer from database and click Next button
		
		4. Select all the tables Views and stored procedure you want to include and click Finish. */
		
		class Program
		{
			static void Main(string[] args)
			{
				using (var db = new SampleEntities())
				{
					//Get List of Employees
					
					var employees = db.Employees;

					foreach (var emp in employees)
					{
						Console.WriteLine(emp.FirstName + "  " + emp.LastName);
					}
				
				
					//Delete an Employee
									   
					var employeeToDelete = db.Employees.SingleOrDefault(x => x.ID == 1);
					
					db.Employees.Remove(employeeToDelete);
					db.SaveChanges();
		
					//Edit an Employee
					
					var employeeToEdit = db.Employees.SingleOrDefault(x => x.ID == Id2);
						
					employeeToEdit.FirstName = "David";
					db.SaveChanges();

						
					//Add an Employee
						
					var newEmployee = new Employee()
						
					{
						FirstName = David,
							LastName = Bush,
							Gender = Male,
							Salary = 900000,
							DepartmentId = 2
							 
					};

					db.Employees.Add(newEmployee);
					db.SaveChanges();

					
					//List of Male Employees Working in London

					var MaleEmp = from e in db.Employees where e.Gender == "Male" && e.Gender == "Male" select e;
					//var MaleEmp = db.Employees.Where(s => s.Department.Location.Equals("London") && s.Gender == "Male").ToList();

					foreach (var emp in MaleEmp)
					{
						Console.WriteLine( emp.FirstName + "  " +
										  emp.LastName + ", " +
										  emp.Gender + ", " +
										  emp.Department.Location

						);
					}

					Console.WriteLine(Environment.NewLine);
				}
			}
		}
		
		
/*
	Model First
	-----------
		https://www.tutorialspoint.com/entity_framework/entity_model_first_approach.htm
	
		In Model First, you define your model in an Entity Framework designer then generate SQL, 
		which will create database schema to match your model and then you execute the SQL to create 
		the schema in your database.

		The classes that you interact with in your application are automatically generated from the EDMX file.
	
		The model is stored in an EDMX file and can be viewed and edited in the Entity Framework Designer.
		
		
		1. To create model, first right-click on your console project in solution explorer and select Add → New Items…
		
		2. Select ADO.NET Entity Data Model from middle pane and enter name ModelFirstDemoDB in the Name field.
		
		3. Select Empty EF Designer model and click Next button. 
		   The Entity Framework Designer opens with a blank model. Now we can start adding entities, 
		   properties and associations to the model.
		   
		4. Right-click on the design surface and select Properties. 
		   In the Properties window, change the Entity Container Name to ModelFirstDemoDBContext.
		   
		5. Right-click on the design surface and select 
		   Add New → Entity…
		
		6. Right-click on the new entity on the design surface and select 
		   Add New → Scalar Property, enter Name as the name of the property.
		   
		Relationship
		------------
		
		1. Right-click on the design surface and select Add New → Association…
		
		2. Ensure the Add foreign key properties and click OK.
		
		Database generation
		-------------------
		
		1. Right-click on the design surface and select Generate Database from Model…
		
		2. You can select existing database or create a new connection by clicking on New Connection…
		
		3. After finishing this will add *.edmx.sql file in the project. 
		   You can execute DDL scripts in Visual Studio by opening .sql file, 
		   then right-click and select Execute.
		   
		DbContext
		---------
		
		1. Right-click on an empty spot of your model in the EF Designer and select 
		   Add Code Generation Item…
		
		   You will see in your solution explorer that 
				ModelFirstDemoModel.Context.tt and ModelFirstDemoModel.tt 
		   templates are generated. */
		   
		   
/*
	Code First
	-----------
		https://www.tutorialspoint.com/entity_framework/entity_framework_first_example.htm
		
		https://blog.rajsoftware.com/2014/07/17/entity-framework-updating-code-first-existing-entity-using-foreign-key-ids-mistakes/
*/		
		
		using System;
		using System.Collections.Generic;
		using System.ComponentModel.DataAnnotations.Schema;
		using System.Data.Entity;
		using System.Linq;


		namespace CodeFirstApp
		{
			public class MyContext : DbContext
			{
				public MyContext() : base("MyDb") { }

				public virtual DbSet<Employee> Employees { get; set; }
				public virtual DbSet<Department> Departments { get; set; }


			}

			public class Department
			{
				public int ID { get; set; }
				public string Name { get; set; }
				public string Location { get; set; }

				public virtual ICollection<Employee> Employees { get; set; }

			}

			public class Employee
			{
				public int Id { get; set; }
				[Column("Name")]
				public string Firstname { get; set; }
				public string Lastname { get; set; }
				public int Salary { get; set; }
				
				public virtual Department Department { get; set; }
			}


			class Program
			{
				static void Main(string[] args)
				{
					using (var db = new MyContext())
					{

						//Change an employee name
						var employee = (from d in db.Employees where d.Firstname == "David" select d).Single();
						//var employee = db.Employees.Single(x => x.Firstname == "David");

						if (employee.Department != null)
						{
							Console.WriteLine("Before: " + employee.Firstname + ' ' + employee.Department.Location);
						}
						else
						{
							Console.WriteLine("Before: " + employee.Firstname + " Location Unknown");

						}

						var department = (from d in db.Departments where d.Location == "London" select d).Single();

						//Foreign Key
						employee.Department = department;
						db.SaveChanges();


						Console.WriteLine("After: " + employee.Firstname + ' ' + employee.Department.Location);
						Console.WriteLine("--------------------");

						//---------------------------------------------------------------------------------------

						// Eager Loading

						var dep = db.Departments.Include(x => x.Employees).ToList();

						foreach (var e in dep)
						{
							Console.WriteLine(e.Name + ' ' + e.Location);

							foreach (var b in e.Employees)
							{
								Console.WriteLine(b.Firstname + ' ' + b.Lastname + ' ' + b.Salary);
							}

							Console.WriteLine();
						}

						Console.WriteLine("--------------------");

						//---------------------------------------------------------------------------------------

						// Lazy Loading
						// db.Configuration.LazyLoadingEnabled = false; // Disables Lazy Loading 
						// or just remove virtual keyword

						var dep2 = db.Departments.ToList();

						foreach (var e in dep2)
						{
							Console.WriteLine(e.Name + ' ' + e.Location);

							foreach (var b in e.Employees)
							{
								Console.WriteLine(b.Firstname + ' ' + b.Lastname + ' ' + b.Salary);
							}

							Console.WriteLine();
						}

						Console.WriteLine("--------------------");

						//---------------------------------------------------------------------------------------

						// Native SQL
						var dep3 = db.Departments.SqlQuery("select * from Departments").ToList();

						foreach (var e in dep3)
						{
							Console.WriteLine(e.Name + ' ' + e.Location);

							foreach (var b in e.Employees)
							{
								Console.WriteLine(b.Firstname + ' ' + b.Lastname + ' ' + b.Salary);
							}

							Console.WriteLine();

						}

						Console.WriteLine("--------------------");

						//---------------------------------------------------------------------------------------


						// SqlCommand
						Console.WriteLine("SqlCommand");
						var id = 3;
						var location = "Paris";
						var sql = @"UPDATE Departments SET Location = {0} where ID = {1}";
						db.Database.ExecuteSqlCommand(sql, location, id);
						


					}
				}
			}
		}

/*
	Async & Await
	-------------		
*/

	using System;
	using System.Threading;
	using System.Threading.Tasks;

	namespace AsyncAwait
	{
		class Program
		{
			static void Main(string[] args)
			{
				Message2();
				Console.WriteLine("Main Message");
				Console.ReadLine();
			}

			public static async void Message2()
			{
				// var task = Task.Run(new Action(Message1));

				var task = new Task(Message1);

				task.Start();
				await task;

				Console.WriteLine("Second Message");

			}

			public static void Message1()
			{
				Thread.Sleep(5000);
				Console.WriteLine("First Message");
			}
		}
	}
