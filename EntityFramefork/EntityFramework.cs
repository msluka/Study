
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
		
	