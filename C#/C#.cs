///"If else" replacement


int age = 35;
string ale;
ale = (age >= 18) ? "Welcome" : "Denied";
Console.WriteLine(ale);


///Optional Arguments
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


///Named Arguments
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
// By Value:

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


//By reference:

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

class Program
{
    static void GetValues(out int x, out int y)
    {
        x = 5;
        y = 42;
    }
    static void Main(string[] args)
    {
        int a, b;
        GetValues(out a, out b);
        Console.WriteLine(a+" "+b);
        //Now a equals 5, b equals 42
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


///factorial

static int Fact(int num) {
    if (num == 1) {
        return 1;
    }
    return num * Fact(num - 1);
}

///Recursion. A recursive method is a method that calls itself.
///In programming, the step by step logic required for the solution to a problem is called an algorithm.


//Making a Pyramid

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

///Encapsulation (is also called information hiding)- private & public method (access modifiers);

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
	
/// A class constructor is a special member method of a class that is executed whenever a new object of that class is created.

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
        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Console.WriteLine(p.getName());
			//Output David
        }
    }

/// The Person class has a Name property that has both the set and the get accessors.

class Program
    {
        class Person
        {
            private string name; //field
            public string Name  //property
            {
                get { return name; }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);
        }
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
	
// Auto-implemented property. Also called auto-properties, they allow for easy and short declaration of private members.

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

	
	
	
	