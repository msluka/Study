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

