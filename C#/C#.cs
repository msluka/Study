/// C# is an object-oriented language
/// The .NET Framework consists of:

///	- the Common Language Runtime (CLR) and 
/// - the .NET Framework class library.

/// CLR is the foundation of the .NET Framework. It manages code at execution time, 
/// 	providing core services such as memory management, code accuracy, and many other aspects of the code.

/// Class library is a collection of classes, interfaces, and value types that enable developers 
/// 	to accomplish a range of common programming tasks, such as data collection, file access, and working with text.

/// Identifier - A variable name, also called an identifier. 
/// Implicitly typed variables - Variables declared using the var keyword are called implicitly typed variables.
/// 	Implicitly typed variables must be initialized with a value.

/// Statement - A line of code that completes an action is called a statement. Each statement in C# must end with a semicolon.

/// Algorithm - In programming, the step by step logic required for the solution to a problem is called an algorithm.

/// IDE - an integrated development environment is a software suite that consolidates the basic tools developers need 
/// 	to write and test software. 

/// COMPILER - is a special program that processes statements written in a particular programming language and turns 
/// 	them into machine language or "code" that a computer's processor uses.
/// 	Traditionally, the output of the compilation has been called object code or sometimes an object module . 
/// 	Note that the term "object" here is not related to object-oriented programming.
/// 	The object code is machine code that the processor can execute one instruction at a time.
/// GUI (usually pronounced GOO-ee) is a graphical (rather than purely textual) user interface to a computer. 

/// A matrix - is a collection of numbers arranged into a fixed number of rows and columns.
/// 		   Each number that makes up a matrix is called an element of the matrix. 
///            The elements in a matrix have specific locations.

/// Operators - An operator is a symbol that performs mathematical or logical manipulations. (+, -, *, /, %)
/// Precedence - Operator precedence determines the grouping of terms in an expression, which affects how an expression 
///		is evaluated.
/// 	If none of the expressions are in parentheses, multiplicative (multiplication, division, modulus) operators 
///		will be evaluated before additive (addition, subtraction) operators. 
///		Operators of equal precedence are evaluated from left to right.

/// Assignment operator - the = assignment operator assigns the value on the right side of the operator to the variable 
/// 	on the left side. 
/// Compound assignment operators - perform an operation and an assignment in one statement. For example:

	x *= 8; // equivalent to x = x * 8
	x /= 5; // equivalent to x = x / 5
	x %= 2; // equivalent to x = x % 2

/// Increment Operator

	x++; //equivalent to x = x + 1

/// Decrement Operator
/// The decrement operator (--) works in much the same way as the increment operator

	x--; //equivalent to x = x - 1

/// The increment operator has two forms, prefix and postfix.

	++x; //prefix
	x++; //postfix

/// Prefix increments the value, and then proceeds with the expression. 

	int x = 3;
	int y = ++x;
	// x is 4, y is 4

/// Postfix evaluates the expression and then performs the incrementing.

	int x = 3;
	int y = x++;
	// x is 4, y is 3

//prefix / postfix Example:

	int a = 4;
	int b = 6;
	b = a++;
	Console.WriteLine(++b);
	// Output: 5

/// The if statement - is a conditional statement that executes a block of code when a condition is true.
/// 	When only one line of code is in the if block, the curly braces can be omitted.

	if (x > y)
	Console.WriteLine("x is greater than y");

/// The else Clause - An optional else clause can be specified to execute a block of code when the condition 
/// 	in the if statement evaluates to false.

	int mark = 85;

	if (mark < 50) 
	{
	   Console.WriteLine("You failed.");
	}
	else 
	{
	   Console.WriteLine("You passed.");
	}

	// Outputs "You passed." 

///"If else" replacement - The Conditional Operator (?)	

	int age = 35;
	string ale;
	ale = (age >= 18) ? "Welcome" : "Denied";
	Console.WriteLine(ale);
	
/// The if-else if Statement - can be used to decide among three or more actions.

	int x = 33;

	if (x == 8) {
	   Console.WriteLine("Value of x is 8");
	}
	else if (x == 18) {
	   Console.WriteLine("Value of x is 18");
	}
	else if (x == 33) {
	   Console.WriteLine("Value of x is 33");
	}
	else {
	   Console.WriteLine("No match");
	}
	//Outputs "Value of x is 33"

/// The switch statement - provides a more elegant way to test a variable for equality against a list of values.
/// 	Each value is called a case. The optional default case is executed when none of the previous cases match.
///     The role of the break statement is to terminate the switch statement. 
/// 	All case and default code must end with a break statement.

	int age = 88;
	switch (age) {
	  case 16:
		Console.WriteLine("Too young");
		break;
	  case 42:
		Console.WriteLine("Adult");
		break;
	  case 70:
		Console.WriteLine("Senior");
		break;
	  default:
		Console.WriteLine("The default case");
		break;
	}
	// Outputs "The default case"
	
/// While - A while loop repeatedly executes a block of code as long as a given condition is true.
/// 	Without a statement that eventually evaluates the loop condition to false, the loop will 
///		continue indefinitely. 

	int num = 1;
	while(num < 6) 
	{
	   Console.WriteLine(num);
	   num+=2;
	}
	/* Outputs
	1
	3
	5
	*/
	
/// Do-while - A do-while loop is similar to a while loop, except that a do-while loop is guaranteed to 
/// 	execute at least one time.

/// The do-while loop executes the statements at least once, and then tests the condition.
/// The while loop executes the statement only after testing condition.

	int x = 42;
	do {
	  Console.WriteLine(x);
	  x++;
	} while(x < 10);

	// Outputs 42
	
/// The for Loop
/// A for loop executes a set of statements a specific number of times.

	for (int x = 10; x < 13; x++)
	{
	  Console.WriteLine("Value of x: {0}", x);
	}
	/*
	Value of x: 10
	Value of x: 11	
	*/

/// The init and increment statements may be left out, if not needed, but the semicolons are mandatory.
/// for (; ;) {} is an infinite loop.

	int x = 10;
	for ( ; x > 0 ; )
	{
	  Console.WriteLine(x);
	  x += 3;
	}
	

/// break
/// When the break statement is encountered inside a loop, the loop is immediately terminated and 
/// the program execution moves on to the next statement following the loop body.

	int num = 0;
	while (num < 20)
	{
	   if (num == 5)
		 break;

	   Console.WriteLine(num);
	   num++;
	}

	/* Outputs:
	0
	1
	2
	3
	4
	*/
	
/// continue
/// The continue statement is similar to the break statement, but instead of terminating the loop entirely, 
/// it skips the current iteration of the loop and continues with the next iteration.

	for (int i = 0; i < 5; i++) {
	  if (i == 2)
		continue;

	  Console.WriteLine(i);
	}
	/* Outputs:
	0
	1
	3
	4
	*/
	
/// Logical Operators (&&,||, !)
/// Logical operators are used to join multiple expressions and return true or false.

// The AND Operator

	int age = 42;
	int grade = 75;
	if(age > 16 && age < 80 && grade > 50) 
	  Console.WriteLine("Hey there");

// The OR Operator

	int age = 18;
	int score = 85;
	if (age > 20 || score > 50) {
		Console.WriteLine("Welcome");
	}
	
// The NOT Operator

	int age = 8;
	if ( !(age >= 16) ) {
	  Console.Write("Your age is less than 16");
	}

	// Outputs "Your age is less than 16"

// The Conditional Operator (?)	

	int age = 42;
	string msg;
	msg = (age >= 18) ? "Welcome" : "Sorry";
	Console.WriteLine(msg);

	
/// Method
/// A method is a group of statements that perform a particular task.
/// To use a method, you need to declare the method and then call it.
/// Each method declaration includes:
/// - the return type (The return type of a method is declared before its name. )
/// - the method name
/// - an optional list of parameters.

	int Sqr(int x)
	{
	  int result = x*x;
	  return result;
	}

// In the example above, the return type is int, which indicates that the method returns an integer value. 
// When a method returns a value, it must include a return statement.
// void is a basic data type that defines a valueless state.

	static void SayHi()
	{
	  Console.WriteLine("Hello");
	}

	static void Main(string[] args)
	{
	  SayHi();
	}
	//Outputs "Hello"

/// Parameters and Arguments
/// A parameter is a variable in a method definition. 
/// When a method is called, the arguments are the data you pass into the method's parameters.

	static void Foo(int i, double f)
	{
		Console.WriteLine(i);
		Console.WriteLine(f);
		Console.ReadLine();
	}

	static void Main(string[] args)
	{
			Foo(3, 2.5);
	}
		
// Here i and f are the parameters, and 3 and 2.5 are the arguments.

/// Multiple Parameters
/// You can add as many parameters to a single method as you want. 
/// If you have multiple parameters, remember to separate them with commas, 
/// both when declaring them and when calling the method.

        static int Sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            int res = Sum(11, 42);
            Console.WriteLine(res);
        }
		// Output: 53

		
/// Optional Arguments
/// Just remember, that you must havethe parameters with default values at the end 
/// of the parameter list when defining the method.

class Program {
    static int Pow(int x, int y = 2) {
        int result = 1;
        for (int i = 0; i < y; i++) {
            result *= x;
        }
        return result;
    }
    static void Main(string[] args) {
        Console.WriteLine(Pow(6));
        //Outputs 36

        Console.WriteLine(Pow(3, 4));
        //Outputs 81
    }
}


/// Named Arguments
/// Named arguments use the name of the parameter followed by a colon and the value.
class Program {
    static int Area(int h, int w) {
        return h * w;
    }
    static void Main(string[] args) {
        int res = Area(w: 5, h: 8);
        Console.WriteLine(res);
        //Outputs 40
    }
}


/// Passing Arguments (By value, By reference, and as Output)

// By Value
// By value copies the argument's value into the method's formal parameter. 
// Here, we can make changes to the parameter within the method without having 
// any effect on the argument.
// By default, C# uses call by value to pass arguments.

class Program {
    static void Sqr(int x) {
        x = x * x;
    }
    static void Main(string[] args) {
        int a = 3;
        Sqr(a);

        Console.WriteLine(a);
        // Outputs 3
    }
}

// In the example above, the Sqr method does not change the original value of the variable, 
// as it is passed by value, meaning that it operates on the value, not the actual variable.


// By reference
// Pass by reference copies an argument's memory address into the formal parameter. 
// Inside the method, the address is used to access the actual argument used in the call. 
// This means that changes made to the parameter affect the argument.
// The ref keyword is used both when defining the method and when calling it.


class Program {
    static void Sqr(ref int x) {
        x = x * x;
    }
    static void Main(string[] args) {
        int a = 3;
        Sqr(ref a);

        Console.WriteLine(a);
        // Outputs 9
    }
}


// As Output
// Output parameters are similar to reference parameters, except that they transfer data out of the method 
// rather than accept data in. Similar to the ref keyword, the out keyword is used both when defining the 
// method and when calling it.

class Program
{
	static void GetValues(out int x, out int y, out string z)
	{
		x = 5 - 2;
		y = x + 42;
		z = (x + y).ToString();
	}
	static void Main(string[] args)
	{
		int a, b;
		string c;
		GetValues(out a, out b, out c);
		Console.WriteLine(a + " " + b + '\n' + c);
		Console.ReadLine();
		
		/*Outputs: 3 45
				   48  */

	}
}


// One more example of "out"

class Program
{
    static int Test(out int x, int y=4) {
        x = 6;
        return x * y;
    }
    static void Main(string[] args) {
        int a;
        int z = Test(out a);
        Console.WriteLine(a + z);
        //Outputs 30
    }
}


/// Overloading
/// Method overloading is when multiple methods have the same name, but different parameters.
/// When overloading methods, the definitions of the methods must differ from each other 
/// by the types and/or number of parameters.

class Program
{
	static void Print(int a) {
		Console.WriteLine("Value: " + a);
	}
	static void Print(double a) {
		Console.WriteLine("Value: " + a);
	}
	static void Print(string label, double a) {
		Console.WriteLine(label + a);
	}
	static void Main(string[] args)
	{
		Print(11);
		Print(4.13);
		Print("Average: ", 7.57);
	}
}

/// Recursion 
/// A recursive method is a method that calls itself.
/// One of the classic tasks that can be solved easily by recursion is calculating the factorial of a number.

/// Factorial
/// if you call the Fact method with the argument 4, it will execute as follows:
///	return 4*Fact(3), which is 4*3*Fact(2), which is 4*3*2*Fact(1), which is 4*3*2*1.

 class Program
    {
        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(4));
            Console.ReadLine();
			
			//Output: 24
        }
    }


/// Making a Pyramid

class Program {
    static void DrawPyramid(int n) {
        for (int i = 1; i <= n; i++) //The first for loop that iterates through each row of the pyramid contains two for loops.
        {
            for (int j = i; j <= n; j++) //The first inner loop displays the spaces needed before the first star symbol.
            {
                Console.Write("  ");
            }
            for (int k = 1; k <= 2 * i - 1; k++) //The second inner loop displays the required number of stars for each row, which is calculated based on the formula (2*i-1) where i is the current row.
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args) {
        DrawPyramid(5);
    }
}


/// Class
/// A class is like a blueprint. It defines the data and behavior for a type.
/// In programming, the term type is used to refer to a class name: We're creating an object of a particular type.

/// Object
/// An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.
/// Creating an object is called instantiation.
/// An object is called an instance of a class.

/// Properties. 
/// The characteristics of an object are called properties. 

/// Access modifier
/// Access modifiers are keywords used to specify the accessibility of a member (fields and methods).
/// If no access modifier is defined, the member is private by default.
/// - public - makes the member accessible from the outside of the class. 
/// - private - makes members accessible only from within the class and hides them from the outside. 
/// - protected - 
/// - internal - 
/// - protected internal.

//Example of a Class

class Program
    {
        class Dog
        {
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            Dog bob = new Dog();
            bob.name = "Bobby";
            bob.age = 3;
            
            Console.WriteLine(bob.age);
			 //Outputs 3
        }
    }

/// Encapsulation 
/// also called information hiding - is defined 'as the process of enclosing one or more items 
/// within a physical or logical package'.
/// Encapsulation is implemented by using access modifiers.

/// In summary, the benefits of encapsulation are:
/// - Control the way data is accessed or modified.
/// - Code is more flexible and easy to change with new requirements.
/// - Change one part of code without affecting other parts of code.

    class BankAccount {
        private double balance=0;
        public void Deposit(double n) {
            balance += n;
        }
        public void Withdraw(double n) {
            balance -= n;
        }
        public double GetBalance() {
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            Console.WriteLine(b.GetBalance());
			//Output 157 
        }
    }
	
// We used encapsulation to hide the balance member from the outside code. 
// Then we provided restricted access to it using public methods. 
// The class data can be read through the GetBalance method and modified only through the Deposit and Withdraw methods.
// You cannot directly change the balance variable. You can only view its value using the public method. 
// You cannot directly change the balance variable.
	
//
  
	class Person {

		private int age;

		public int GetAge() {
		 return age;
		}

		public void SetAge(int n) {
		 age = n;
		}
	}
	
	
/// Constructors	
/// A class constructor is a special member method of a class that is executed whenever a new object of that class is created.
/// A default constructor has no parameters. However, when needed, parameters can be added to a constructor. 
/// Constructors can be overloaded like any method by using different numbers of parameters.

	class Person
	{
		private int age;
		public Person()
		{
			Console.WriteLine("Hi there");
		}
	}
	static void Main(string[] args)
	{
		Person p = new Person();
	}
		
//

	class Program
    {
        class Person
        {
            private int age;
            private string name;
            
            public Person(string nm)
            {
                name = nm;
            }
            public string getName()
            {
                return name;
            }
            
            
            public Person(int _age)
            {
                age = _age;
            }
            public int getAge()
            {
                return age;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Person p2 = new Person(25);
     
            Console.WriteLine(p.getName());
			//Output: David
            Console.WriteLine(p2.getAge());
			//Output: 25
        }
    }

	
/// Properties	
/// Properties are an extension of fields and are accessed using the same syntax. 
/// They use accessors through which the values of the private fields can be read, written or manipulated.
/// The name of the property can be anything you want, but coding conventions dictate properties have the same name as 
/// the private field with a capital letter. 
/// The property is accessed by its name, just like any other public member of the class
/// A property can also be private, so it can be called only from within the class.
/// The Person class bellow has a Name property that has both the set and the get accessors.

	class Person
		{
			private string name; //field
			
			public string Name //property
			{
				get { return name; }
				set { name = value; }
			}
			
			public string getName(){
				
				return name;
				
			}
		}
		static void Main(string[] args)
		{
			Person p = new Person();
			p.Name = "Bob";
			Console.WriteLine(p.Name);
			Console.WriteLine(p.getName());
		}
	
//

	class Person
	{
	  private int age=0;
	  public int Age
	  {
		get { return age; }
		set {
		  if (value > 0)
			age = value;
		}
	  }
	}
	
/// Any accessor of a property can be omitted. 
/// For example, the following code creates a property that is read-only:

	class Person
	{
	  private string name;
	  public string Name
	  {
		get { return name; }
	  }
	}
	
/// Auto-implemented property. Also called auto-properties, they allow for easy and short declaration of private members.
/// In the example below you can see, you do not need to declare the private field name separately - it is created 
/// by the property automatically. 

 class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);
			// Outputs "Bob"
        }
    }

	
/// Arrays

/// C# provides numerous built-in classes to store and manipulate data.
/// One example of such a class is the Array class.
/// An array is a data structure that is used to store a collection of data. 
/// You can think of it as a collection of variables of the same type.

/// Since arrays are objects, we need to instantiate them with the new keyword:

	int[ ] myArray = new int[5]; 
	
/// This instantiates an array named myArray that holds 5 integers.
/// Note the square brackets used to define the number of elements the array should hold.

/// After creating the array, you can assign values to individual elements by using the index number:
	
	int[ ] myArray = new int[5];
	myArray[0] = 23;
	
/// This will assign the value 23 to the first element of the array.

/// Arrays in C# are zero-indexed meaning the first member has index 0, the second has index 1, and so on.

/// We can provide initial values to the array when it is declared by using curly brackets:

	string[ ] names = new string[3] {"John", "Mary", "Jessica"};
	double[ ] prices = new double[4] {3.6, 9.8, 6.4, 5.9};
	
/// We can omit the size declaration when the number of elements are provided in the curly braces:

	string[ ] names = new string[ ] {"John", "Mary", "Jessica"};
	double[ ] prices = new double[ ] {3.6, 9.8, 6.4, 5.9};
	
/// We can even omit the new operator. The following statements are identical to the ones above:

	string[ ] names = {"John", "Mary", "Jessica"};
	double[ ] prices = {3.6, 9.8, 6.4, 5.9};

/// Array values should be provided in a comma separated list enclosed in {curly braces}.

/// To access individual array elements, place the element's index number in square brackets following the array name.

	static void Main(string[] args)
		{
			int[] box = { 11, 45, 62, 70, 88 };

			Console.WriteLine(box[2]);
			//Outputs 62

			Console.WriteLine(box[3]);
			//Outputs 70

			Console.ReadLine();
		}
		
/// Arrays & Loops

/// The for loop
/// For example, we can declare an array of 10 integers and assign each element an even value with the for loop
/// and we can also use the loop to read the values of an array.

	class Program
	{
		static void Main(string[] args)
		{
			int[ ] a = new int[10];
			for (int k = 0; k < 10; k++) {
				a[k] = k*2;
			}
			for (int k = 0; k < 10; k++) {
				Console.Write(a[k]+", ");
			
				//Outputs: 0, 2, 4, 6, 8, 10, 12, 14, 16, 18,
			}
			
			Console.ReadLine();
		}
	}

/// The foreach Loop

/// The foreach loop provides a shorter and easier way of accessing array elements.

	static void Main(string[] args)
	{
		string[] names = { "John", "Mary", "Jessica" };

		foreach (var name in names)
		{
			Console.WriteLine(name);
		}

		Console.ReadLine();
		
	}

//

	static void Main(string[] args)
	{
		int[ ] arr = {11, 35, 62, 555, 989};
		int sum = 0; 
		
		foreach (int x in arr) {
			sum += x;
		}
		Console.WriteLine(sum);
		//Outputs 1652

	}

/// Multidimensional Arrays

/// An array can have multiple dimensions. A multidimensional array is declared as follows:
	
/// 2D array
                          // c = column
	int[ , ] someNums = { // 1c,2c  
							{2, 3}, //first row
							{5, 6}, //second row
							{4, 6}  //third row
						};
	
	// This will create an array with three rows and two columns. 
	// Nested curly brackets are used to define values for each row.

/// The same array can be declared as follows:

	int[,] someNums = new int[3, 2];
	
	someNums[0, 0] = 2;  // first row, first column
	someNums[0, 1] = 3;  // first row, second column             

	someNums[1, 0] = 5;  // second row, first column
	someNums[1, 1] = 6;  // second row, second column

	someNums[2, 0] = 4;  // third row, first column
	someNums[2, 1] = 6;  // third row, second column


/// To access an element of the array, provide both indexes. 
/// For example someNums[2, 0] will return the value 4, as it accesses the first column of the third row.

/// We have to use two nested for loops, one to iterate through the rows and one through the columns.

			for (int r = 0; r < 3; r++)       // iterates through the rows
            {
                for (int c = 0; c < 2; c++)   // iterates through the columns
                {
                    Console.Write(someNums[r, c] + " ");
                }
                
                Console.WriteLine();
				
				//Outputs: 2 3
				//		   5 6
				//         4 6

            }

            Console.ReadLine();
			
/// 3D array

	string[,,] someNums  =  {  //  c = column   
							   //  1c    2c    3c         
							 { 
								{ "000","001","002" }, // first row
								{ "010","011","012" }, // second row     // first layer
								{ "020","021","022" }  // third row
							 }, 
							 
							 { 
							    { "100","101","102" }, // first row
								{ "110","111","112" }, // second row     // second layer
								{ "120","121","122" }  // third row
							 }  

						    };	

/// The same array can be declared as follows:

	string[,,] someNums = new string[2, 3, 3];

	someNums[0, 0, 0] = "000"; //first layer, first row, first column
	someNums[0, 0, 1] = "001"; //first layer, first row, second column
	someNums[0, 0, 2] = "002"; //first layer, first row, third column

	someNums[0, 1, 0] = "010"; //first layer, second row, first column
	someNums[0, 1, 1] = "011"; //first layer, second row, second column
	someNums[0, 1, 2] = "012"; //first layer, second row, third column

	someNums[0, 2, 0] = "020"; //first layer, third row, first column
	someNums[0, 2, 1] = "021"; //first layer, third row, second column
	someNums[0, 2, 2] = "022"; //first layer, third row, third column

	someNums[1, 0, 0] = "100"; //second layer, first row, first column
	someNums[1, 0, 1] = "101"; //second layer, first row, second column
	someNums[1, 0, 2] = "102"; //second layer, first row, third column

	someNums[1, 1, 0] = "110"; //second layer, second row, first column
	someNums[1, 1, 1] = "111"; //second layer, second row, second column
	someNums[1, 1, 2] = "112"; //second layer, second row, third column

	someNums[1, 2, 0] = "120"; //second layer, third row, first column
	someNums[1, 2, 1] = "121"; //second layer, third row, second column
	someNums[1, 2, 2] = "122"; //second layer, third row, thitd column

	for (int l = 0; l < 2; l++)
	{
		for (int r = 0; r < 3; r++)
		{
			for (int c = 0; c < 3; c++)
			{
				Console.Write(someNums[l, r, c] + " ");
			}

			Console.WriteLine(); // prints rows from a new line
		}

		Console.WriteLine(); // prints layers from a new line

	}

	Console.ReadLine();

	/* Outputs: 000 001 002				
				010 011 012
				020 021 022

				100 101 102
				110 111 112
				120 121 122 */
	
	
/// Jagged Arrays

/// A jagged array is an array whose elements are arrays. 
/// So it is basically an array of arrays.	

/// The following is a declaration of a single-dimensional array that has three elements, 
/// each of which is a single-dimensional array of integers:

	int[ ][ ] jaggedArr = new int[3][ ];

/// Each dimension is an array, so we can also initialize the array upon declaration like this:

	int[ ][ ] jaggedArr = new int[ ][ ] 
	{
	  new int[ ] {1,8,2,7,9},
	  new int[ ] {2,4,6},
	  new int[ ] {33,42}
	};
	
///	or this:

	int[ ][ ] jaggedArr =  
		{
		  new int[ ] {1,8,2,7,9},
		  new int[ ] {2,4,6},
		  new int[ ] {33,42}
		};
		
/// ot this:

	int[][] jaggedArr = new int[3][]; //array that has three elements each of which is an array

	jaggedArr[0] = new int[5]; //the first array has 5 elements(columns)
	jaggedArr[1] = new int[3]; //the second array has 3 elements(columns)
	jaggedArr[2] = new int[2]; //the third array has 2 elements(columns)

	jaggedArr[0][0] = 1; // the first element of the first array
	jaggedArr[0][1] = 8; // the second element of the first array
	jaggedArr[0][2] = 2; // the third element of the first array
	jaggedArr[0][3] = 7; // the fourth element of the first array
	jaggedArr[0][4] = 9; // the fifth element of the first array

	jaggedArr[1][0] = 2; // the first element of the second array
	jaggedArr[1][1] = 4; // the second element of the second array
	jaggedArr[1][2] = 6; // the third element of the second array

	jaggedArr[2][0] = 33; // the first element of the third array
	jaggedArr[2][1] = 42; // the second element of the third array

/// We can access individual array elements as shown in the example below:

	int x = jaggedArr[2][1]; 
	// Oputput: 42
	// This accesses the second element of the third array.

/// We can print them as follows:

		static void Main(string[] args)
		{
			int[][] jaggedArr = 
			{
				new int[ ] {1,8,2,7,9},
				new int[ ] {2,4,6},
				new int[ ] {33,42}
			};

			for (var i = 0; i < jaggedArr.Length; i++)
			{
				int[] inner = jaggedArr[i]; 

				for (int j = 0; j < inner.Length; j++)
				{
					Console.Write(inner[j]+" "); // prints array elements(columns)
				}

				Console.WriteLine(); // prints next array from a new line
			}
					   
			Console.ReadLine();
		}
	
/// A jagged array is an array-of-arrays, so an int[ ][ ] is an array of int[ ], 
/// each of which can be of different lengths and occupy their own block in memory.
 
/// A multidimensional array (int[,]) is a single block of memory (essentially a matrix). 
/// It always has the same amount of columns for every row.	


/// Arrays Properties and Methods

/// The Array class in C# provides various properties and methods to work with arrays. 
/// For example:
/// 	the Length property returs the number of elements of the array
///     the Rank property returns the number of dimensions of the array
/// 	the Max method returns the largest value.
/// 	the Min method returns the smallest value.
/// 	the Sum method returns the sum of all elements.


	static void Main(string[] args)
	{
		int[][] jaggedArr =
		{
			new int[ ] {1,8,2,7,9},
			new int[ ] {2,4,6},
			new int[ ] {33,42}
		};

		foreach (var array in jaggedArr)
		{
			Console.WriteLine("Length " + array.Length  + "\n" +
							  "Dimension " + array.Rank + "\n" +
							  "Max Number " + array.Max() + "\n" +
							  "Min Number " + array.Min() + "\n" +
							  "Sum " + array.Sum() + "\n"  );
		}
	   
		Console.ReadLine();
		/* Outputs: Length 5
					Dimension 1
					Max Number 9
					Min Number 1
					Sum 27

					Length 3
					Dimension 1
					Max Number 6
					Min Number 2
					Sum 12

					Length 2
					Dimension 1
					Max Number 42
					Min Number 33
					Sum 75
		*/

	}
	
/// To use the Min, Max, and Sum methods with the multidimensional arrays 
/// we have to use the cast<int>() method:

	static void Main(string[] args)
	{
		int[,] someNums = { {2, 3}, {5, 6}, {4, 6} };
		
		Console.WriteLine("Length " + someNums.Length + "\n" +
						  "Dimension " + someNums.Rank + "\n" +
		
						  "Max Number " + someNums.Cast<int>().Max() + "\n" +
						  "Min Number " + someNums.Cast<int>().Min() + "\n" +
						  "Sum " + someNums.Cast<int>().Sum() + "\n" );
		
		Console.ReadLine();
		
		/* Output:  Length 6
					Dimension 2
					Max Number 6
					Min Number 2
					Sum 26
		*/
	}



/// Strings

/// It’s common to think of strings as arrays of characters. In reality, strings in C# are objects.
/// When we declare a string variable, we basically instantiate an object of type String. 
/// String objects support a number of useful properties and methods: 
	  
	
///Length returns the length of the string.

	string a = "some text";
	Console.WriteLine(a.Length);
	//Outputs 9

///IndexOf(value) returns the index of the first occurrence of the value within the string.

	string a = "some text";
	Console.WriteLine(a.IndexOf('t'));
	//Outputs 5

///Insert(index, value) inserts the value into the string starting from the specified index.
	
	string a = "some text";
	a = a.Insert(0, "This is ");
	Console.WriteLine(a);
	//Outputs "This is some text"

///Replace(oldValue, newValue) replaces the specified value in the string.

	string a = "This is some text"
	a = a.Replace("This is", "I am");
	Console.WriteLine(a);
	//Outputs "I am some text"

///Contains(value) returns true if the string contains the specified value.

	string a = "I am some text"
	if (a.Contains("some"))
	 Console.WriteLine("found");
	//Outputs "found"
	
///Remove(index) removes all characters in the string after the specified index.

	string a = "I am some text"
	a = a.Remove(4);
	Console.WriteLine(a);
	//Outputs "I am"

///Substring(index, length) returns a substring of the specified length, starting from the specified 

	string a = "I am"
	a = a.Substring(2);
	Console.WriteLine(a);
	//Outputs "am"

///access characters of a string by its index,

	string a = "some text";
	Console.WriteLine(a[2]);
	//Outputs "m"
	
///String.Concat(); combines the strings.

	string s1 = "some text ";
    string s2 = "another text";
    string s3 = String.Concat(s1,s2);
           
    Console.WriteLine(s3);
    //Output: some text another text

//

	static void Main(string[] args)
	{
		string text = "Razor is not a programming language. It's a server side markup language.";
        text = text.Replace("Razor", "HTML");
        text = text.Substring(0, text.IndexOf(".")+1);
		
		Console.WriteLine(text);
		//Outputs: HTML is not a programming language.
	}	
	
/// Destructors
/// As constructors are used when a class is instantiated, destructors are automatically invoked when 
/// an object is destroyed or deleted. 
/// - A class can only have one destructor.
/// - Destructors cannot be called. They are invoked automatically.
/// - A destructor does not take modifiers or have parameters. 
/// - The name of a destructor is exactly the same as the class prefixed with a tilde (~).
/// This can be useful, for example, if your class is working with storage or files. The constructor would initialize 
/// and open the files. Then, when the program ends, the destructor would close the files.

	class Program
    {
        class Dog
        {
            public Dog() {
                Console.WriteLine("Constructor");
            }
            ~Dog() {
                Console.WriteLine("Destructor");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
			
			/*Outputs:
			Constructor
			Destructor
			*/
        }	
		
    }

// In the example above, when the program runs, it first creates the object, which calls the constructor. 
// The object is deleted at the end of the program and the destructor is invoked when the program's execution is complete.


/// Static
/// Class members (variables, properties, methods) can also be declared as static. 
/// This makes those members belong to the class itself, instead of belonging to individual objects. 
/// No matter how many objects of the class are created, there is only one copy of the static member.
/// Because of their global nature, static members can be accessed directly using the class name without an object.

/// You must access static members using the class name. 
/// If you try to access them via an object of that class, you will generate an error.

	class Program
    {
        class Cat {
            public static int count=0;
            public Cat() {
                count++;
            }
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
			
			//Output 2
        }
    }
		
/// Static Methods
/// Static methods can access only static members. 
/// The Main method is static, as it is the starting point of any program. 
/// Therefore any method called directly from Main had to be static.

	class Program
    {
        class Calc
        {
            public static void Addition()
            {
                int a = 2;
                int b = 2;
                int sum = a + b;
                Console.WriteLine(sum);
            }

        }

        class MixCalc
        {
            public static void Subtract()
            {
                int a = 10;
                int b = 5;
                int result = a - b;
                Console.WriteLine(result);
            }

            public static void CallAddition()
            {
                Calc.Addition();
            } 
			
        }

        static void Main(string[] args)
        {
            MixCalc.Subtract();
            MixCalc.CallAddition();
            Console.ReadLine();
			
			/*Outputs: 5
			           4*/
        }
		
    }
	
	
/// Constant members are static by default.

	class MathClass 
	{
	  public const int ONE = 1;
	}
	
	static void Main(string[] args) 
	{
	  Console.Write(MathClass.ONE);
	}
	//Outputs 1
	
/// Static Constructors
/// Constructors can be declared static to initialize static members of the class.
/// The static constructor is automatically called once when we access a static member of the class.
	
	class Program
    {
        class SomeClass {
            public static int X { get; set; }
            public static int Y { get; set; }
            
            static SomeClass() {
                X = 10;
                Y = 20;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SomeClass.X);
			
			//Output: 10
        }
    }
	
// The constructor will get called once when we try to access SomeClass.X or SomeClass.Y.


/// Static Classes
/// An entire class can be declared as static.
/// A static class can contain only static members. 
/// You cannot instantiate an object of a static class, as only one instance of the static class can exist in a program.
/// Static classes are useful for combining logical properties and methods. The good examples of this are:
/// Math class; Console class; Convert class; DateTime class;

// Math.Pow() returns a specified number raised to the specified power.
	
	Console.WriteLine(Math.Pow(2, 3));
	//Outputs 8

// Math.Round() rounds the decimal number to its nearest integral value.	
	
	Console.WriteLine(Math.Round(12.6));
	//Outputs 13
	
// Math.PI the constant PI.
// Math.E represents the natural logarithmic base e.
// Math.Max() returns the larger of its two arguments.
// Math.Min() returns the smaller of its two arguments.
// Math.Abs() returns the absolute value of its argument.
// Math.Sin() returns the sine of the specified angle.
// Math.Cos() returns the cosine of the specified angle.
// Math.Sqrt() returns the square root of a specified number

/// The Array class includes some static methods for manipulating arrays:

	int[] arr = {1, 2, 3, 4};

	Array.Reverse(arr);
	//arr = {4, 3, 2, 1}

	Array.Sort(arr);
	//arr = {1, 2, 3, 4}


/// The this Keyword
/// is used inside the class and refers to the current instance of the class, meaning it refers to the current object.

/// One of the common uses of this is to distinguish class members from other data, 
/// such as local or formal parameters of a method,	

/// Another common use of this is for passing the current instance to a method as parameter (exp. ShowInfo(this);).

	class Program
    {
        class Person
        {
            private string name;
            private int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public static void ShowInfo(Person p)
            {
                Console.WriteLine("This is " + p.name + ". Age: " + p.age);
            }

            public void TellMeAboutYourself()
            {
                ShowInfo(this);
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person("Anna", 21);
            Person.ShowInfo(person);
			//Output: This is Anna. Age: 21

            Person person2 = new Person("David", 22);
            Person.ShowInfo(person2);
			//Output: This is David. Age: 22

            person.TellMeAboutYourself();
			// Output: This is Anna. Age: 21
            
            Console.ReadLine();	
        }
    }
	

/// The readonly Modifier
/// prevents a member of a class from being modified after construction. 
/// It means that the field declared as readonly can be modified only when you 
/// declare it or from within a constructor.

	class Person 
	{
	  private readonly string name = "John"; 
	  public Person(string name) {
		this.name = name; 
	  }
	}

// If we try to modify the name field anywhere else, we will get an error.

/// There are three major differences between readonly and const fields. 
/// - First, a constant field must be initialized when it is declared, 
///   whereas a readonly field can be declared without initialization, as in:

	  readonly string name; // OK
	  const double PI; // Error
	  
/// - Second, a readonly field value can be changed in a constructor, but a constant value cannot.

/// - Third, the readonly field can be assigned a value that is a result of a calculation, 
///   but constants cannot, as in:

	  readonly double a = Math.Sin(60); // OK
	  const double b = Math.Sin(60); // Error! 
	  
	
	
///***
// A class, objects and members of the class.
	
class Program
    {        
        class Book
		{
			public string BookName;
			public string Author;
			public string PublishingDate;

			public static int BooksSold;
			//Static members are not accessible by the objects.
			//They are only accessible by the class.

			public const int Rental_Days = 5;
			//const is only accessible by the class.

		}
    
    
        static void Main()
        {
			//Book newBook;//newBook = new Book();
			  
			Book newBook = new Book();

			newBook.BookName = "C#";
			newBook.Author = "Msluka";
			newBook.PublishingDate = "01.07.2017";

			Book newBook1 = new Book();

			newBook1.BookName = "Java";
			newBook1.Author = "Msluka";
			newBook1.PublishingDate = "01.08.2017";

			Book.BooksSold = 2;
				
			Console.WriteLine(newBook.BookName + '\n' +
							  newBook.PublishingDate + '\n' + 
							  newBook1.BookName + '\n' + 
							  newBook1.PublishingDate + '\n'+ 
							  "Rental days: " + Book.Rental_Days + '\n' + 
							  "Sold: " + Book.BooksSold);
			//MessageBox.Show()
          
        }
        
    }
	
// Adding Properties to Classes

class Program
    {
        class Car
        {
            public string Color { get; set; }
    
            public Car.Doors NumberOfDoors { get; set; }
    
            public enum Doors
            {
                two = 2,
                four = 4,
                six = 6
            }
    
            private string _engine;
    
            public string Engine
            {
                get { return _engine;}
    
                set
                {
                    if(value == "V6" || value == "V8")
                    { _engine = value;}
                }
            }
    
            //-----Read Only Property-----//
            
            private bool _state;
    
            public bool CarState
            {
                get { return _state; }
                set { _state = value; }
            }
    
            public void Turn_On_or_Off()
            {
                if (this.CarState == false)
                {
                    this.CarState = true;
                }
    
                else if (this.CarState == true)
                {
                    this.CarState = false;}
            }
            
        }
        
        static void Main(string[] args)
        {   
            Car myCar = new Car();
            myCar.NumberOfDoors = Car.Doors.four;
            myCar.Color = "red";
            myCar.Engine = "V8";
            myCar.Turn_On_or_Off(); // a click event is needed
            Console.WriteLine(myCar.NumberOfDoors.ToString() +'\n'+
                              myCar.Color +'\n'+
                              myCar.Engine+'\n'+
                              myCar.CarState
                              );
			//Outputs: four red V8 True 
        }
    }
	
// Date and Time

		DateTime.Now; // represents the current date & time
        DateTime.Today; // represents the current day
        DateTime.DaysInMonth(2017, 2); //return the number of days in the specified month 
                              
        string DateFormat = "dd.MM.yyyy HH:mm:ss"; //MM = two digit // mm = two digit //HH = two digit, 24 hour clock // hh = two digit, 12 hour clock
        string date = DateTime.Now.ToString(DateFormat);
        Console.WriteLine(date);
		  
// Age Calculator

class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string DateOfBirth{get; set;} 
                      
        }
        
        static void Main(string[] args)
        {   
            Person p1 = new Person();
            p1.Name = "Msluka";
            p1.DateOfBirth = "04/16/1981";
                      
            DateTime birth = DateTime.Parse(p1.DateOfBirth);
            DateTime today = DateTime.Today;     //we usually don't care about birth time
            TimeSpan age = today - birth;        //.NET FCL should guarantee this as precise
            double ageInDays = age.TotalDays;    //total number of days ... also precise
            double daysInYear = 365.2425;        //statistical value for 400 years
            double ageInYears = ageInDays / daysInYear;  //can be shifted ... not so precise
			                                             //Age => (DateTime.Now - DateOfBirth).Days; //Option 2//
            
            
            Console.WriteLine(ageInYears.ToString().Substring(0,2));
			Console.WriteLine(ageInYears.ToString().Split('.')[0]; 
			//Output: 35
        }
    }
	
///Polymorphism

class Program
    {
        class Shape {
            public virtual void Draw() {
                Console.WriteLine("Base Draw ");
            }
        }
        class Circle : Shape {
            public override void Draw() {
                // draw a circle...
                Console.WriteLine("Circle Draw ");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                // draw a rectangle...
                Console.WriteLine("Rect Draw ");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
            
            Circle z = new Circle();
            z.Draw();
        }
    }
	
/// A struct type is a value type that is typically used to encapsulate small groups of related variables,
/// such as the coordinates of a rectangle or the characteristics of an item in an inventory. 
/// Structs do not support inheritance and cannot contain virtual methods.
/// Structs can contain methods, properties, indexers, and so on. 
/// Consider defining a struct instead of a class if you are trying to represent a simple set of data. 

 class Program
    {
        struct Book {
            public string title;  
            public double price;
            public string author;
        }
        static void Main(string[] args)
        {
            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";
            
            Console.WriteLine(b.title);
			//Outputs "Test"
        }
    }

/// Structs cannot contain default constructors (a constructor without parameters), 
/// but they can have constructors that take parameters.
/// In that case the new keyword is used to instantiate a struct object

 class Program
    {
        struct Point {
            public int x;
            public int y;
            public Point(int x, int y) {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Point p = new Point(10, 15);
            Console.WriteLine(p.x);
			// Outputs 10
        }
    }
	
/// Enums
/// The enum keyword is used to declare an enumeration: 
/// a type that consists of a set of named constants called the enumerator list.

class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
        static void Main(string[] args)
        {
            int x = (int)Days.Tue;
            Console.WriteLine(x);
			//Output: 2
        }
    }
	
///By default, the first enumerator has the value 0.
///You can also assign your own enumerator values:

class Program
    {
        enum Days { Sun, Mon, Tue=5, Wed, Thu, Fri, Sat }; 
        static void Main(string[] args)
        {
            int x = (int)Days.Fri;
            Console.WriteLine(x);
			//Output: 8
        }
    }
	
/// Enums are often used with switch statements.

	class Program
    {
        enum TrafficLights { Green, Red, Yellow };
        static void Main(string[] args)
        {
            TrafficLights x = TrafficLights.Red;
            switch (x) {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
				
				//Output: "Stop!"
            }
        }
    }

/// Exceptions
/// We use the general Exception type to handle all kinds of exceptions. 
/// We can also use the exception object e to access the exception details, 
/// such as the original error message (e.Message):

class Program
    {
        static void Main(string[] args)
        {
            try {
                int[] arr = new int[] { 4, 5, 8 };
                Console.Write(arr[8]);
            }
            catch(Exception e) {
                Console.WriteLine("An error occurred");
				//Output: "An error occurred"
				
				Console.WriteLine(e.Message);
				//Output: Index was outside the bounds of the array.
            }
        }
    }

/// Multiple Exceptions
/// The most commonly used exceptions: 
/// DivideByZeroException, FileNotFoundException, FormatException, 
/// IndexOutOfRangeException, InvalidOperationException, OutOfMemoryException.

 class Program 
	{
		static void Main(string[] args) 
		{
			int x, y;
			
			try {
				x = Convert.ToInt32(Console.Read());
				y = Convert.ToInt32(Console.Read());
				Console.WriteLine(x / y);
				} 
			catch (DivideByZeroException e) {
				Console.WriteLine("Cannot divide by 0");
				//Output:"Cannot divide by 0" //if the user enters 0 for the second number
				} 
			catch (Exception e) {
				Console.WriteLine("An error occurred");
				//Output: "An error occurred" //if the user enters non-integer values
				}
		}
	}
	
/// Finally Exception
/// The finally block is used to execute a given set of statements, 
/// whether an exception is thrown or not. 

class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            int num1 = 8;
            int num2 = 0;
            try {
                result = num1 / num2;
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Error");
			}
            finally {
                Console.WriteLine(result);
            }
			
			//Output: "Error" 
            //Output: 0			
        }
    }

/// Files
/// The System.IO namespace has The File class
/// The WriteAllText() method creates a file with the specified path and writes the content to it. 
/// If the file already exists, it is overwritten.

class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            File.WriteAllText("test.txt", str);
            
            string txt = File.ReadAllText("Hello.txt");
            Console.WriteLine(txt);
			
			//Output: Hello
        }
    }

/// AppendAllText() - appends text to the end of the file.
/// Create() - creates a file in the specified location.
/// Delete() - deletes the specified file.
/// Exists() - determines whether the specified file exists.
/// Copy() - copies a file to a new location.
/// Move() - moves a specified file to a new location

class Program
    {
        static void Main(string[] args)
        {
            string pathBeforeCreation = @"D:\";
            string text = "Hello" + Environment.NewLine; ;
            string fileName = "HelloWorld.txt";
            string createdFile = @"D:\HelloWorld.txt";
            
   
            if (File.Exists(createdFile))
            {
                File.AppendAllText(createdFile, text);
                string innertext = File.ReadAllText(createdFile);
                Console.WriteLine(innertext);
                Console.ReadLine();
            }

            else
            {
                File.WriteAllText(createdFile, String.Empty);
                //File.Create(pathBeforeCreation + fileName);
                File.AppendAllText(createdFile, text);
                string innertext = File.ReadAllText(createdFile);
                Console.WriteLine(innertext);
                Console.ReadLine();
            }
        }
    }
	
/// *Generics
/// **Generic Methods
/// Generics allow the reuse of code across different types. 
/// In the code below, T is the name of our generic type.
/// If you omit specifying the type when calling a generic method, 
/// the compiler will use the type based on the arguments passed to the method.

class Program
    {
        static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
            
        }
        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
             //Now b is 4, a is 9
            
            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
			//Output: World Hello
        }
    }	

/// Multiple generic parameters can be used with a single method. 
/// For example: Func<T, U> takes two different generic types.

 class Program
    {
        static void Func<T,U> (T x, U y) {
        
            Console.WriteLine(x+" "+y);
        }
        
        static void Main(string[] args) {
 
            double x = 7.42;
            string y = "test";
            Func(x,y);
            
            //Output: 7.42 test 
        }
        
    }
	
	
/// Constructor with Parametrs
/// Auto Increment ID

class Program

    {
        class Person
        {
            private string Name;
            private int Age;

            private static int Id = 0;
            private int id;

            public Person(string name, int age)
            {
                Id++;
                this.Name = name;
                this.Age = age;
                this.id = Id;
            }

            public void GetData()
            {   
                Console.WriteLine("Name: " + this.Name + "\n"+ 
                                  "Age: " + this.Age + "\n" + 
                                  "ID: " + id.ToString("D3") + "\n");
            }
        }

        static void Main(string[] args)
        {
            Person Man1 = new Person("John", 20);
            Person Woman1 = new Person("Sandra", 18);
            
            Man1.GetData();
            Woman1.GetData();
            Console.ReadLine();
        }
    }	
	

/// Timer

class Program
{

    private static void Main()
    {
        myTimer();
    }
        
    public static void myTimer()
    {
        System.Timers.Timer aTimer = new System.Timers.Timer();
        aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        aTimer.Interval = 1000;
        aTimer.Enabled = true;

        while (Console.Read() != 'q') ;
    }
   
    private static void OnTimedEvent(object sender, ElapsedEventArgs e)
    {            
        DateTime now = DateTime.Now;
           
        Console.Write("\x000D"+now);         
    }
        
}

//

class Program
{
    private static void Main()
    {
        myTimer();
    }

    public static void myTimer()
    {
        System.Timers.Timer aTimer = new System.Timers.Timer();
        aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        aTimer.Interval = 1000;
        aTimer.Enabled = true;

        while (Console.Read() != 'e') ;
    }

    static int i = 0;
    private static void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
        i++;

        Console.Write("\x000D" + i);
    }
}

/// Simple Timer

class Program
{
	static void Main(string[] args)
	{
		int num = 60;

		while (num >= 0)
		{

			Console.Write("\x000D" + num--);
		  
			Thread.Sleep(1000);
		}
	   
		Console.ReadLine();

	}
}


/// DateTime CultureInfo

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input date in dd/mm/yyyy hh:mm");

        CultureInfo provider = CultureInfo.InvariantCulture;

        CultureInfo frenchCultureProvider = CultureInfo.GetCultureInfo("gb");

        var dateInput = Console.ReadLine();

        var dateTime = DateTime.ParseExact(dateInput, "dd/MM/yyyy HH:mm", provider);

        Console.WriteLine($"{dateTime.ToString("D", frenchCultureProvider)} {dateTime.ToString("T", frenchCultureProvider)}");

        Console.ReadKey();
    }
}	

/// Check Char / Digit

class Program
{
    private static void Main()
    {
        do
        {
            var txt = Console.ReadLine();

            if (txt.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Is Digit");

            }

            else
            {
                Console.WriteLine("Is Char");
            }

        } while (true);
    }
}

/// Lambda
/// A lambda expression is an anonymous function and it is mostly used to create delegates in LINQ.
/// It's a shorthand that allows you to write a method in the same place you are going to use it. 
/// You can read n => n % 2 == 1 like: 
/// "input parameter named n goes to anonymous function which returns true if the input is odd".

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 31, 37, 22, 19, 20 };
        List<int> oddNumbers = numbers.Where(n => n % 2 == 1).ToList();

        oddNumbers.ForEach(Console.WriteLine);

        Console.ReadLine();
		//Outputs: 31 37 19
    }
}

/// Compare Objects

namespace CompareObjects
{

    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override bool Equals(object otherCustomer)
        {
            var customerInstance = otherCustomer as Customer;
            return Name == customerInstance.Name
                   && Surname == customerInstance.Surname
                   && Age == customerInstance.Age
                   && City == customerInstance.City;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();


            var customer1 = new Customer
            {
                Name = "Jhone",
                Surname = "Doe",
                Age = 33,
                City = "Berlin"
            };

            var customer2 = new Customer
            {
                Name = "Jhone",
                Surname = "Doe",
                Age = 33,
                City = "Berlin"
            };

            Console.WriteLine(customer1.Equals(customer2)); // true
            Console.WriteLine(customer1 == customer2); // false
            Console.ReadLine();
        }
    }
}


/// LINQ
/// Language Integrated Query
/// is uniform query syntax in C# and VB.NET used to save and retrieve data from different sources.
/// LINQ providers: 	
/// LINQ to Objects
///	LINQ to XML
///	LINQ to SQL
/// LINQ to DataSets
/// LINQ to Entities

//Quary Syntax:

string[] musicalArtists = { "Adele", "Maroon 5", "Avril Lavigne" };

        IEnumerable<string> aArtists =
            from artist in musicalArtists
            where artist.StartsWith("A")
            select artist;

        foreach (var artist in aArtists)
        {
            Console.WriteLine(artist);
        }
		
//Method Syntax:

string[] musicalArtists = { "Adele", "Maroon 5", "Avril Lavigne" };

var aArtists = musicalArtists
            .Where(artist => artist.StartsWith("A"))
            .Select(artist=>artist).ToList();

        aArtists.ForEach(Console.WriteLine);
        Console.ReadLine();

//

class Program
{
    public class Album
    {
        public string Name { get; set; }

        public string Year { get; set; }
    }

    public class MusicalArtist
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string LatestHit { get; set; }

        public List<Album> Albums { get; set; }
    }

    class ArtistViewModel
    {
        public string ArtistName { get; set; }

        public string Song { get; set; }
    }
	
    static List<MusicalArtist> GetMusicalArtists()
    {
        return new List<MusicalArtist>
            {
                new MusicalArtist
                {
                    Name = "Adele",
                    Genre = "Pop",
                    LatestHit = "Someone Like You",
                    Albums = new List<Album>
                    {
                        new Album { Name = "21", Year = "2011" },
                        new Album { Name = "19", Year = "2008" },
                    }
                },
                new MusicalArtist
                {
                    Name = "Maroon 5",
                    Genre = "Adult Alternative",
                    LatestHit = "Moves Like Jaggar",
                    Albums = new List<Album>
                    {
                        new Album { Name = "Misery", Year = "2010" },
                        new Album { Name = "It Won't Be Soon Before Long", Year = "2008" },
                        new Album { Name = "Wake Up Call", Year = "2007" },
                        new Album { Name = "Songs About Jane", Year = "2006" },
                    }
                },
                new MusicalArtist
                {
                    Name = "Lady Gaga",
                    Genre = "Pop",
                    LatestHit = "You And I",
                    Albums = new List<Album>
                    {
                        new Album { Name = "The Fame", Year = "2008" },
                        new Album { Name = "The Fame Monster", Year = "2009" },
                        new Album { Name = "Born This Way", Year = "2011" },
                    }
                }
            };
    }

    //Querying A Custom Type
    static void QueryingCustomTypes()
    {
        List<MusicalArtist> artistsDataSource = GetMusicalArtists();

        IEnumerable<MusicalArtist> artistsResult =
            from artist in artistsDataSource
            select artist;

        Console.WriteLine("\nQuerying Custom Types");
        Console.WriteLine("---------------------\n");

        foreach (MusicalArtist artist in artistsResult)
        {
            Console.WriteLine(
                "Name: {0}\nGenre: {1}\nLatest Hit: {2}\n",
                artist.Name,
                artist.Genre,
                artist.LatestHit);
        }

        Console.ReadLine();
    }

    //Custom Projection with Data Source Type
    static void CreatingCustomProjectionsWithTheDataSourceType()
    {
        List<MusicalArtist> artistsDataSource = GetMusicalArtists();

        IEnumerable<MusicalArtist> artistsResult =
            from artist in artistsDataSource
            select new MusicalArtist
            {
                Name = artist.Name,
                LatestHit = artist.LatestHit
            };

        Console.WriteLine("\nCustom Projection With Data Source Type");
        Console.WriteLine("---------------------------------------\n");

        foreach (MusicalArtist artist in artistsResult)
        {
            Console.WriteLine(
                "Name: {0}\nLatest Hit: {1}\n",
                artist.Name,
                artist.LatestHit);
        }

        Console.ReadLine();
    }

    //Custom Projection on a Different Type
    static void CreatingCustomProjectionsOnDifferentType()
    {
        List<MusicalArtist> artistsDataSource = GetMusicalArtists();

        IEnumerable<ArtistViewModel> artistsResult =
            from artist in artistsDataSource
            select new ArtistViewModel
            {
                ArtistName = artist.Name,
                Song = artist.LatestHit
            };

        Console.WriteLine("\nCustom Projection On a Different Type");
        Console.WriteLine("-------------------------------------\n");

        foreach (ArtistViewModel artist in artistsResult)
        {
            Console.WriteLine(
                "Artist Name: {0}\nSong: {1}\n",
                artist.ArtistName,
                artist.Song);
        }

        Console.ReadLine();
    }

    //Projecting Anonymous Types
    private static void ProjectingAnonymousTypes()
    {
        List<MusicalArtist> artistsDataSource = GetMusicalArtists();

        var artistsResult =
            from artist in artistsDataSource
            select new
            {
                Name = artist.Name,
                NumberOfAlbums = artist.Albums.Count
            };

        Console.WriteLine("\nProjecting Anonymous Types");
        Console.WriteLine("--------------------------\n");

        foreach (var artist in artistsResult)
        {
            Console.WriteLine(
                "Artist Name: {0}\nNumber of Albums: {1}\n",
                artist.Name,
                artist.NumberOfAlbums);
        }
        Console.ReadLine();
    }

    static void Main(string[] args)
    {

        QueryingCustomTypes();
        CreatingCustomProjectionsWithTheDataSourceType();
        CreatingCustomProjectionsOnDifferentType();
        ProjectingAnonymousTypes();

    }
}

/// ADO.NET

public IEnumerable<Customer> GetAllCustomers()
{

	var result = new List<Customer>();

	using (var conn = new SqlConnection(Settings.Default.ConnectionString))
	{

		conn.Open();
		var querry = "SELECT * FROM Customers";
		using (var command = new SqlCommand(querry, conn))

		{
			var dataReader = command.ExecuteReader();

			while (dataReader.Read())
			{
				result.Add(new Customer
				{

					Id = (int)dataReader["Id"],
					CityName = (string)dataReader["CityName"],
					Name = (string)dataReader["Name"],
					Surname = (string)dataReader["Surname"]

				});
			}
		}

	}

	return result;

}

//

public Customer GetCustomer(int id)
{
	
	var result = new List<Customer>();

	using (var conn = new SqlConnection(Settings.Default.ConnectionString))
	{

		conn.Open();
		var querry = "SELECT * FROM Customers WHERE Id = @Id";
		using (var command = new SqlCommand(querry, conn))

		{
			command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
			var dataReader = command.ExecuteReader();

			while (dataReader.Read())
			{
				result.Add(new Customer
				{

					Id = (int)dataReader["Id"],
					CityName = (string)dataReader["CityName"],
					Name = (string)dataReader["Name"],
					Surname = (string)dataReader["Surname"]

				});
			}
		}

	}

	return result.SingleOrDefault();

}

//

public void AddCustomer(Customer customer)
{

	using (var conn = new SqlConnection(Settings.Default.ConnectionString))
	{
		
		var querry = "INSERT INTO Customers (Name, Surname, CityName) Values " +
					 "(@Name, @Surname, @CityName)";

		using (var command = new SqlCommand(querry, conn))

		{
			command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.Name;
			command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = customer.Surname;
			command.Parameters.Add("@CityName", SqlDbType.NVarChar).Value = customer.CityName;

			conn.Open();
			command.ExecuteNonQuery();
		  
		}

	}
	
}

// 

public void UpdateCustomer(Customer customer)
{

	using (var conn = new SqlConnection(Settings.Default.ConnectionString))
	{

		var querry = "UPDATE Customers SET Name =@Name, Surname=@Surname, CityName=@CityName WHERE Id = @Id";
					 
		using (var command = new SqlCommand(querry, conn))

		{
			command.Parameters.Add("@Id", SqlDbType.Int).Value = customer.Id;
			command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.Name;
			command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = customer.Surname;
			command.Parameters.Add("@CityName", SqlDbType.NVarChar).Value = customer.CityName;

			conn.Open();
			command.ExecuteNonQuery();

		}
		
	}
	
}

// 

public void DeleteCustomer(int id)
{

	using (var conn = new SqlConnection(Settings.Default.ConnectionString))
	{

		var querry = "DELETE FROM Customers WHERE Id = @Id";

		using (var command = new SqlCommand(querry, conn))

		{
			command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
		  
			conn.Open();
			command.ExecuteNonQuery();

		}

	}

}

/// Executing a SQL server stored procedure in c#

/*CREATE PROCEDURE [dbo].[getCustomersOrdersReport]

AS
BEGIN

SELECT 

customers.Name + ' ' + customers.Surname as CustoemrName

,COUNT (orders.Id) as OrdesCount
,(SELECT
                COUNT(DISTINCT(ProductId))
                FROM OrderProducts orderProd
                JOIN Orders ords ON orderProd.OrderId = ords.Id 
                WHERE ords.CustomerId = customers.Id
         ) AS ProductsCount
		
,SUM(aggregatedOrderProducts.QuantitySum) as QuantitySum
,SUM(aggregatedOrderProducts.TotalPrice) as TotalPrice
		

FROM (
 SELECT OrderId,
 SUM(Quantity) AS QuantitySum,
 SUM(Quantity * Price) AS TotalPrice
 FROM OrderProducts
 GROUP BY OrderId) AS aggregatedOrderProducts

JOIN Orders AS orders ON aggregatedOrderProducts.OrderId = orders.Id
JOIN Customers AS customers ON orders.CustomerId = customers.Id
GROUP BY customers.Id, customers.Name, customers.Surname


END
*/

public IEnumerable<OrdersListRow> GetCustomerOrdersReport()
{
	var result = new List<OrdersListRow>();

	using (var conn = new SqlConnection(Settings.Default.ConnectionString))
	{	
		var query = "getCustomersOrdersReport";

		using (var command = new SqlCommand(query, conn))
		{
			command.CommandType = CommandType.StoredProcedure;
			
			conn.Open();
			var reader = command.ExecuteReader();

			while (reader.Read())
			{
				result.Add(new OrdersListRow
				{
					CustomerName = (string)reader["CustoemrName"],
					OrdersCount = (int)reader["OrdesCount"],
					ProductsCount = (int)reader["ProductsCount"],
					ProductsQuantitySum = (int)reader["QuantitySum"],
					TotalPrice = (decimal)reader["TotalPrice"]
				});
			}
		}
	}	

	return result;
	
}

/// SQL transaction in c#

public void AddSingleProductOrder(Order order, int productId, int quantity, int price)
{
	using (var connection = new SqlConnection(Settings.Default.ConnectionString))
	{
		connection.Open();
		var transaction = connection.BeginTransaction();

		try
		{

			var createOrderQuery = $"insert into orders (OrderDate, CustomerId) " +
								   "Values (@OrderDate, @CustomerId);" +
								   "Select Scope_Identity();";

			var orderId = 0;
			using (var createOrderCommand = new SqlCommand(createOrderQuery, connection, transaction))
			{
				createOrderCommand.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = order.OrderDate;
				createOrderCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = order.CustomerId;

				orderId = Convert.ToInt32(createOrderCommand.ExecuteScalar());
			}

			var createOrderProductQuery = $"insert into orderProducts (OrderId, ProductId, Quantity, Price) " +
										  "Values (@OrderId, @ProductId, @Quantity, @Price)";

			using (
				var createOrderProductCommand = new SqlCommand(createOrderProductQuery, connection, transaction)
			)
			{
				createOrderProductCommand.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderId;
				createOrderProductCommand.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;
				createOrderProductCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
				createOrderProductCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;

				createOrderProductCommand.ExecuteNonQuery();
			}

			transaction.Commit();

		}
		catch (Exception e)
		{
			transaction.Rollback();
		}
	}
}


///Remove Punctuation from string

	string s = "Believe someone's statement, without proof.";
			var sb = new StringBuilder();

			foreach (char c in s)
			{
				if (!char.IsPunctuation(c))
					sb.Append(c);
			}

			s = sb.ToString();
			   
			Console.WriteLine(s);
			Console.ReadLine();
			//Output: Believe someones statement without proof


///Remove Punctuation from string using Regex

	string s = "Believe someone's statement, without proof.";

	string result = Regex.Replace(s, @"\p{P}", "");

	Console.WriteLine(result);
			Console.ReadLine();
			//Output: Believe someones statement without proof
		

///Remove Punctuation and Spaces from string using Regex

	string s = "Believe someone's statement, without proof.";

	string result = Regex.Replace(s, @"\W|_", String.Empty);

	Console.WriteLine(result);
			Console.ReadLine();
			//Output: Believesomeonesstatementwithoutproof

		
///Remove anything that's not a word, apostrophe or whitespace character

	string s = "Believe someone's statement, without proof.";

	string result = Regex.Replace(s, @"[^\w\'\s]", String.Empty);

	Console.WriteLine(result);
			Console.ReadLine();
			//Output: Believe someone's statement without proof
			
			
/// Start a new line and remove anything that's not a word or apostrophe.

	string s = "Believe someone's statement,without proof.";
			
			Console.WriteLine(s);

			if (Regex.IsMatch(s, @"\s"))
			{
				string result = Regex.Replace(s, @"[^\w\']", "\n");
				string result2 = Regex.Replace(result, @"[^\w\'\s]", String.Empty);

				Console.WriteLine(result2);
				Console.ReadLine();
			}

/// Regex
/// The Regex class is used for representing a regular expression.

/// The following example matches words that start with 'S':

using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      private static void showMatch(string text, string expr)
      {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         foreach (Match m in mc)
         {
            Console.WriteLine(m);
         }
      }
      
      static void Main(string[] args)
      {
         string str = "A Thousand Splendid Suns";
         
         Console.WriteLine("Matching words that start with 'S': ");
         showMatch(str, @"\bS\S*");
         Console.ReadKey();
      }
   }
}

///The following example matches words that start with 'm' and ends with 'e':

using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      private static void showMatch(string text, string expr)
      {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         foreach (Match m in mc)
         {
            Console.WriteLine(m);
         }
      }
      static void Main(string[] args)
      {
         string str = "make maze and manage to measure it";

         Console.WriteLine("Matching words start with 'm' and ends with 'e':");
         showMatch(str, @"\bm\S*e\b");
         Console.ReadKey();
      }
   }
}

/// Removing trailing zeros in a decimal

class Program
    {
        static void Main(string[] args)
        {
            decimal[] decimalNumbers = { 1.0M, 1.01M, 1.0010M, 0.00M, 1.0050M };

            foreach (decimal decimalNumber in decimalNumbers)
            {
                Console.WriteLine("Original Decimal Number = {0}, Without Zeros = {1}",
                                    decimalNumber, decimalNumber.ToString("0.####"));
            }

            Console.ReadLine();

			//Outputs: Original Decimal Number = 1.0, Without Zeros = 1
					 //Original Decimal Number = 1.01, Without Zeros = 1.01
					 //Original Decimal Number = 1.0010, Without Zeros = 1.001
					 //Original Decimal Number = 0.00, Without Zeros = 0
					 //Original Decimal Number = 1.0050, Without Zeros = 1.005


        }
    }



/// Entity Framework

/// is an ORM framework. ORM stands for object Relational Mapping.
/// ORM framework automatically creates classes based on database tables and 
/// the vice versa is also true, that is, it can also automatically generate 
/// necessary SQL to create database tables based on classes.


/// Fibonacci
/// ---------

///	0	1	1	2	3	5	8	13	21	34	55

	static int Fibonacci(int n)  
	{  
		int firstnumber = 0, secondnumber = 1, result = 0;  

		if (n == 0) return 0;   
		if (n == 1) return 1;  


		for (int i = 2; i <= n; i++)  
		{  
			result = firstnumber + secondnumber;  
			firstnumber = secondnumber;  
			secondnumber = result;  
		}  

		return result;  
	}  
	
/// Math Power
/// ----------
/// 2*2*2*2 = Pow(2,4)

	static int Power(int a, int b){
		
		if (a == 0 || b == 0) return 0;		
		 
		int result = 1;
		
		for (int i = 0; i < b; i++){			
		   
			result *= a;
			
		}
		
		return result;
	}
	Console.WriteLine(Pow(2, 4))
	//Outputs 32
	
	
	static int Pow(int x, int y = 2) {
        int result = 1;
        for (int i = 0; i < y; i++) {
            result *= x;
        }
        return result;
    }
   
        Console.WriteLine(Pow(6));
        //Outputs 36
	
	// or just Math.Pow(2,3)
	
	
/// Factorial
/// ---------

/// 4 * 3 * 2 * 1 = 24
	
	static int Fact(int num)
	{
		if (num == 1)
		{
			return 1;
		}
		return num * Fact(num - 1);
	}
	static void Main(string[] args)
	{
		Console.WriteLine(Fact(4));
		Console.ReadLine();
		
		//Output: 24
	}
	
/// Sort array JS
/// -------------

	var points = [40, 100, 1, 5, 25, 10];

	function myFunction() {
		
		points.sort(function(a, b){return a-b});
		
	}

	
/// BubbleSort JS

	var a = [33, 103, 3, 726, 200, 984, 198, 764, 9];

	function bubbleSort(a)
	{
		var swapped;
		do {
			swapped = false;
			for (var i=0; i < a.length-1; i++) {
				if (a[i] > a[i+1]) {
					var temp = a[i];
					a[i] = a[i+1];
					a[i+1] = temp;
					swapped = true;
				}
			}
		} while (swapped);
	}

	bubbleSort(a);
	console.log(a);
	
	
/// Serialize and Deserialize
/// -------------------------

	/// JSON
	
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Threading;
	using System.Web.Script.Serialization;

	namespace objectToJSON
	{
		public class Student {

			public string Name { get; set; }
			public int Age { get; set; }
			
		}
		class Program
		{
			static void Main(string[] args)
			{
				List<Student> Students = new List<Student>
				{ 
					new Student {Name = "David", Age = 18},
					new Student {Name = "Alex", Age = 20},
					new Student {Name = "Sara", Age = 19}
				};


				Console.WriteLine("Serializing...");
				Thread.Sleep(3000);

				//Serializer
				JavaScriptSerializer convertor = new JavaScriptSerializer();

				//Serialize
				var studentsToJson = convertor.Serialize(Students);

				File.WriteAllText("Json.txt", studentsToJson);

				var textJson = File.ReadAllText("Json.txt");
				Console.WriteLine(textJson);
				Console.WriteLine();
				
				Console.WriteLine("Deserializing...");
				Thread.Sleep(3000);

				//Deserialize
				List<Student> StudentsFromJson = (List<Student>)convertor.Deserialize(textJson, typeof(List<Student>));
			   

				foreach (var std in StudentsFromJson)
				{
					Console.WriteLine(std.Name + ' ' + std.Age);
				}
		
			}
		}
	}
	
	/// XML
	
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Xml.Serialization;


	namespace SerializeXML
	{
	 
		public class Student
		{
			public int Id { get; set; }		 
			public string Name { get; set; }		 
			public int Age { get; set; }
		}


		class Program
		{
			static void Main(string[] args)
			{
				
				List<Student> students = new List<Student>();

				students.Add(new Student { Id = 1, Name = "David", Age = 20 });
				students.Add(new Student { Id = 1, Name = "John", Age = 22 });
				students.Add(new Student { Id = 1, Name = "Sara", Age = 21 });


				//Serialize 

				XmlSerializer serializer = new XmlSerializer(typeof(List<Student>)); // (typeof(Student)) if object is single
				StreamWriter sw = new StreamWriter("students.xml");
				//Stream sw = File.OpenWrite("students.txt");
				serializer.Serialize(sw, students);
				sw.Close();

				var xmlText = File.ReadAllText("students.xml");
				Console.WriteLine(xmlText);


				//Deserialize

				StreamReader sr = new StreamReader("students.xml");
				var studentsFromFile = (List<Student>) serializer.Deserialize(sr);
				sr.Close();

				foreach (var std in studentsFromFile)
				{
					Console.WriteLine(std.Name + " " + std.Age);
					
				}
			}
		}
	}


	
/// Dynamic 
/// -------

/// A dynamic variable can have any type. Its type can change during runtime.

	using System;	
	using System.Threading;

	namespace Dynamic
	{
		public class Student
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public int Age { get; set; }
		}


		class Program
		{
			static void Main(string[] args)
			{

				// Dynamic Object

				dynamic student = new Student();
				
				student.Name = "David";
				student.Age = 22;


				Console.WriteLine($"Student's Name is: {student.Name } and Age: { student.Age}");

				Console.WriteLine("The Student is transforming...");

				Thread.Sleep(3000);


				student.Name = "Sara";
				student.Age = 20;

				Console.WriteLine($"Now, Student's Name is: {student.Name } and Age:{ student.Age}");

				Thread.Sleep(3000);

				// ----------------------------------------------------------------------------------

				// Dynamic variables

				dynamic test = "TEXT";
				Console.WriteLine("Test is string: " + test);

				test = 20;
				Console.WriteLine("Now, Test is int: " + test);

				test = true;

				if (test == true)
					Console.WriteLine("Now, Test is boolian");
				
			}
		}
	}

