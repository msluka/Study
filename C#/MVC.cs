/// ViewData

//  In controller ActionResult
	
	ViewData["key1"]="some data";

	
//	In View
    
	@ViewData["key1"]
	
	
/// ViewBag

//	In controller ActionResult           
	
	ViewBag.key1="some data";

//	In View
   
	@ViewBag.key1
	
	
///	TempData 

//	In Controller

	public ActionResult SampleView()
	{
		TempData["CurrentDateAndTime"] = DateTime.Now;
		return RedirectToAction("SampleView1");
	}

	public ActionResult SampleView1()
	{
		string str = TempData["CurrentDateAndTime"].ToString();
		return View("SampleView");
	}
	
//	In View
	
	<div>
		@TempData["CurrentDateAndTime"]
	</div>
	
	
/// Session

//	In Controller

	public ActionResult SampleView()
	{
		Session["CurrentDateAndTime"] = DateTime.Now;
		return RedirectToAction("SampleView1");

	}

	public ActionResult SampleView1()
	{
		string str = Session["CurrentDateAndTime"].ToString();
		return View("SampleView");
	}
	
//	In View
	
	<div>
		@Session["CurrentDateAndTime"]
	</div>
	

/// Model / Form / Request

// Model

	public class Customer
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public double Amount { get; set; }
    }
	
// Form (in FillCustomer View)

	<form action="DisplayCustomer" method="post">
        Customer Id: <input type="text" name="CustomerId"/><br/>
        Customer Code: <input type="text" name="CustomerCode" /><br />
        Amount: <input type="text" name="Amount"/><br />
        <input type="submit" value="Click Here"/><br/>
    </form>
  
// Request (from Customer Controller)

	public ActionResult DisplayCustomer()
        {
            Customer obj = new Customer();
            obj.Id = Convert.ToInt32(Request.Form["CustomerId"]);
            obj.CustomerCode = Request.Form["CustomerCode"].ToString();
            obj.Amount = Convert.ToDouble(Request.Form["Amount"]);
            
            return View(obj);
        }
 
// Display View

	<div>
		
		Customer Id is: @Model.Id<br/>
		Customer Code is: @Model.CustomerCode <br/>
		@if (Model.Amount > 100)
		{
			<span>This is VIP Customer and Amount is:</span>
			<span>@Model.Amount</span>
		}
		else
		{
			<span>This is usual Customer and Amount is:</span>
			<span>@Model.Amount</span>
		}

	</div>
	

	
/// Example with loosly typed TextBox:
	
//  Models


	namespace InputScreenMVC.Models
	{
		public class Customer
		{
			public int Id { get; set; }
			public string CustomerCode { get; set; }
			public double Amount { get; set; }
		}
	}
	
// Views / FillCustomer


	@model InputScreenMVC.Models.Customer


	<body>

		@using (Html.BeginForm("DisplayCustomer", "Customer", FormMethod.Post))
		{
			
			@Html.Label("CustomerId", "Enter Customer Id")
			@Html.TextBox("CustomerId", Model, new { @class = "form-control" })
			<br />
			@Html.Label("CustomerCode", "Enter Customer Code")
			@Html.TextBox("CustomerCode", Model, new { @class = "form-control" })
			<br />
			@Html.Label("Amount", "Enter Customer Amount")
			@Html.TextBox("Amount", Model, new { @class = "form-control" })
			<br />
			
			<input type="submit" class="btn btn-info" value="Click to Submit">

		}

	</body>


// Views / DisplayCustomer
	

	@model InputScreenMVC.Models.Customer
	
	<div>
		
		Customer Id is: @Model.Id<br/>
		Customer Code is: @Model.CustomerCode <br/>
		@if (Model.Amount > 100)
		{
			<span>This is VIP Customer and Amount is:</span>
			<span>@Model.Amount</span>
		}
		else
		{
			<span>This is usual Customer and Amount is:</span>
			<span>@Model.Amount</span>
		}

	</div>
	
	<div>
		@Html.ActionLink("Back", "FillCustomer", "Customer", new {@class="btn btn-primary btn-large"})
	</div>


// Controller / CustomerController

		
	[HttpPost]
	public ActionResult DisplayCustomer(Customer obj)
	{
		return View(obj);
	}
		
		
// Summary

//	1. Html Helper class creates Html elements.
//	2. Submit button Calls DisplayCustomer Action in CustomController.
//	3. DisplayCustomer Action takes as a parameter Customer object that 
//	   was created using Html Helper Class and pass it to the View.


/// MVC Architecture
/// ----------------
/// MVC stands for Model, View and Controller.

/// Model
/// Model represents shape of the data and business logic. It maintains the data of the application. 
/// Model objects retrieve and store model state in a database.
/// - Model is responsible for maintaining application data and business logic.

/// View 
/// View is a user interface. 
/// View display data using model to the user and also enables them to modify the data.
/// - View is a user interface of the application, which displays the data.

/// Controller
/// Controller handles the user request. Typically, user interact with View, 
/// which in-tern raises appropriate URL request, this request will be handled by a controller. 
/// The controller renders the appropriate view with the model data as a response.
/// - Controller handles user's requests and renders appropriate View with Model data.


/// Routing
/// -------
/// Routing maps URL to physical file or class (controller class in MVC).
/// Route contains URL pattern and handler information. URL pattern starts after domain name.
/// Routes can be configured in RouteConfig class. Multiple custom routes can also be configured.
/// Route constraints applies restrictions on the value of parameters.
/// Route must be registered in Application_Start event in Global.ascx.cs file.

	public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        routes.MapRoute(
            name: "Student",
            url: "students/{id}",
            defaults: new { controller = "Student", action = "Index"}
        );

        routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } 
        );
    }

// As shown in the above code, URL pattern for the Student route is students/{id}, 
// which specifies that any URL that starts with domainName/students, must be handled by StudentController. 
// Notice that we haven't specified {action} in the URL pattern because we want every URL that starts with 
// student should always use Index action of StudentController. We have specified default controller and action 
// to handle any URL request which starts from domainname/students.

	routes.MapRoute(
		name: "Student",
		url: "students/{id}",
		defaults: new { controller = "Student", action = "Index"}, constraints: new { id = @"\d+" }
	);

// So if you give non-numeric value for id parameter then that request will be handled by another route or, 
// if there are no matching routes then "The resource could not be found" error will be thrown.


/// Action methods
/// --------------
/// All the public methods in the Controlle class are called Action methods.
/// - Action method must be public. It cannot be private or protected
/// - Action method cannot be overloaded
/// - Action method cannot be a static method.

	using System.Web.Mvc;

	namespace MVC.Controllers
	{
		public class StudentController : Controller
		{
			// GET: Student
		public ActionResult Index()
        {
            return View();
        }

        public string GetString()
        {
            return "This is Index action method of StudentController";
        }
	}

/// Action method Parameters:
/// Every action methods can have input parameters as normal methods.
/// It can be primitive data type or complex type parameters as shown in the below example.
/// Action method parameters can be Nullable type. 

	[HttpPost]
	public ActionResult Edit(Student std)
	{
		// update student to the database
		
		return RedirectToAction("Index");
	}

	[HttpDelete]
	public ActionResult Delete(int id)
	{
		// delete student from the database whose id matches with specified id

		return RedirectToAction("Index");
	}


/// Action Selectors
/// ----------------
/// Three action selectors attributes are available in MVC 5 
///   - ActionName
///   - NonAction
///   - ActionVerbs

/// ActionName
/// attribute is used to specify different name of action than method name.

	[ActionName("find")]
    public ActionResult GetById(int id)
    {
        // get student from the database 
        return View();
    }
	
	// This action method will be invoked on 
	// http://localhost/student/find/1 request instead of 
	// http://localhost/student/getbyid/1 request.
	
/// NonAction
/// NonAction selector attribute indicates that a public method of a Controller is not 
/// an action method. Use NonAction attribute when you want public method in a controller 
/// but do not want to treat it as an action method.

	[NonAction]
    public Student GetStudnet(int id)
    {
        return studentList.Where(s => s.StudentId == id).FirstOrDefault();
    }

/// ActionVerbs
/// The ActionVerbs selector is used when you want to control the selection of an action method 
/// based on a Http request method. For example, you can define two different action methods with 
/// the same name but one action method responds to an HTTP Get request and another action method 
/// responds to an HTTP Post request.

	[HttpGet] // To retrieve the information from the server. 
	public ActionResult Index()
    {
        return View();
    }
	
	[HttpPost] // To create a new resource.
    public ActionResult PostAction()
    {
        return View("Index");
    }


    [HttpPut] // To update an existing resource.
    public ActionResult PutAction()
    {
        return View("Index");
    }

    [HttpDelete] // To delete an existing resource.
    public ActionResult DeleteAction()
    {
        return View("Index");
    }

    [HttpHead] // Identical to GET except that server do not return message body.
    public ActionResult HeadAction()
    {
        return View("Index");
    }
       
    [HttpOptions] // OPTIONS method represents a request for information about the communication options supported by web server.
    public ActionResult OptionsAction()
    {
        return View("Index");
    }
       
    [HttpPatch] // 	To full or partial update the resource.
    public ActionResult PatchAction()
    {
        return View("Index");
    }

/// We can also apply multiple http verbs using AcceptVerbs attribute. 

	[AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
	public ActionResult GetAndPostAction()
	{
		return RedirectToAction("Index");
	}


/// Example: Passing Model from Controller

	public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };
            return View(studentList);
        }
        
    }

// We pass this list object as a parameter in the View() method. The View() method is defined 
// in base Controller class, which automatically binds model object to the view.


/// Razor Syntax
/// ------------
/// Razor is one of the view engine supported in ASP.NET MVC. 
/// Razor allows us to write mix of HTML and server side code using C# or Visual Basic. 

/// Inline expression:
/// A single line expression does not require a semicolon at the end of the expression.

	// C# Razor Syntax:
	<h1>Razor syntax demo</h1>

	<h2>@DateTime.Now.ToShortDateString()</h2>
	
	//Result
	Razor syntax demo 
	08-09-2017

/// Multi-statement Code block:

	@{
		var date = DateTime.Now.ToShortDateString();
		var message = "Hello World";
	}

	<h2>Today's date is: @date </h2>
	<h3>@message</h3>
	
	//Result
	Razor syntax demo 
	Today's date is: 08-09-2017
	Hello World!
	
/// Display text from code block:
/// Use @: or <text>/<text> to display texts within code block.

	@{
		var date = DateTime.Now.ToShortDateString();
		string message = "Hello World!";
		@:Today's date is: @date <br />
		<text>Today's date is:</text> @date <br />
		@message                               
	}
	
	//Result
	Razor syntax demo 
	Today's date is: 08-09-2017
	Today's date is: 08-09-2017
	Hello World!
	
/// if-else condition:
/// The if-else code block must be enclosed in braces { }, even for single statement.

	@if(DateTime.IsLeapYear(DateTime.Now.Year) )
	{
		@DateTime.Now.Year @:is a leap year.
	}
	else { 
		@DateTime.Now.Year @:is not a leap year.
	}
	
	// Result:	
	2017 is not a leap year.
	
/// for loop:

	@for (int i = 0; i < 5; i++)
	{
		@i.ToString() 
	}

	// Result
	01234
	
/// Model:
/// Use @model to use model object anywhere in the view.

	@model Student

	<h2>Student Detail:</h2>
	<ul>
		<li>Student Id: @Model.StudentId</li>
		<li>Student Name: @Model.StudentName</li>
		<li>Age: @Model.Age</li>
	</ul>
	
	// Result
	Student Detail:
            
	- Student Id: 1 
	- Student Name: John 
	- Age: 18 
	
/// Declare Variables:

	@{ 
		string str = "";

		if(1 > 0)
		{
			str = "Hello World!";
		}
	}

	<p>@str</p>
	
	//Result	
	Hello World!
	
	
/// HTML Helpers
/// ------------
/// HtmlHelper class generates html elements using the model class object in razor view. 
/// It binds the model object to html elements to display value of model properties into html elements 
/// and also assigns the value of the html elements to the model properties while submitting web form.
	
///	@Html is an object of HtmlHelper class. (@ symbol is used to access server side object in razor syntax). 
///	ActionLink() and DisplayNameFor() is extension methods included in HtmlHelper class.
///	HtmlHelper extension method generates html elements based on model properties.
	
	// For example
	@Html.ActionLink("Create New", "Create") 
	// would generate anchor tag 
	<a href="/Student/Create">Create New</a>
	
/// There are many extension methods for HtmlHelper class, which creates different html controls.
/*
	HtmlHelper				Strogly Typed HtmlHelpers		Html Control
	----------				------------------------- 		------------
	Html.ActionLink			Anchor link
	Html.TextBox			Html.TextBoxFor					Textbox
	Html.TextArea			Html.TextAreaFor				TextArea
	Html.CheckBox			Html.CheckBoxFor				Checkbox
	Html.RadioButton		Html.RadioButtonFor				Radio button
	Html.DropDownList		Html.DropDownListFor			Dropdown, combobox
	Html.ListBox			Html.ListBoxFor					multi-select list box
	Html.Hidden				Html.HiddenFor					Hidden field
	Password				Html.PasswordFor				Password textbox
	Html.Display			Html.DisplayFor					Html text
	Html.Label				Html.LabelFor					Label
	Html.Editor				Html.EditorFor					Generates Html controls based 
																on data type of specified model 
																property e.g. textbox for string 
																property, numeric field for int, 
																double or other numeric type.
	
	
	The difference between calling the HtmlHelper methods and using an html tags is that 
	the HtmlHelper method is designed to make it easy to bind to view data or model data.
*/

/// TextBox()
/// ---------
/// The Html.TextBox() method creates <input type="text" > element.
/// @Html.TextBox() is loosely typed method.
/// TextBox()method signature:

	MvcHtmlString Html.TextBox(string name, string value, object htmlAttributes)

	// Html.TextBox() in Razor View
	
	@model Student

	@Html.TextBox("StudentName", null, new { @class = "form-control" }) 

	// Html Result 
	
	<input class="form-control" 
		   id="StudentName" 
		   name="StudentName" 
		   type="text" 
		   value="" />

/*  
	In the above example, the first parameter is "StudentName" property of Student model class 
	which will be set as a name & id of textbox. The second parameter is a value to display in a textbox, 
	which is null in the above example because TextBox() method will automatically display a value of the 
	StudentName property in the textbox. The third parameter will be set as class attribute. 
*/
	
/// We can also specify any name for the textbox. However, it will not be bind to a model.


/// TextBoxFor()
/// ------------
/// @Html.TextBoxFor() is a strongly typed (generic) extension method.
/// TextBoxFor() requires lambda expression as a parameter.
/// TextBoxFor() method Signature:

	MvcHtmlString TextBoxFor(Expression<Func<TModel,TValue>> expression, object htmlAttributes)
		
	// Html.TextBoxFor() in Razor View
	
	@model Student

	@Html.TextBoxFor(m => m.StudentName, new { @class = "form-control" }) 
		
	
/// TextBox() and TextBoxFor() Examples:
	
	@using (Html.BeginForm("DisplayCustomer", "Customer", FormMethod.Post))
	{
		
		@Html.Label("CustomerId", "Enter Customer Id")
		@Html.TextBox("CustomerId", Model, new { @class = "form-control" })
		<br />
		@Html.Label("CustomerCode", "Enter Customer Code")
		@Html.TextBox("CustomerCode", Model, new { @class = "form-control" })
		<br />
		@Html.Label("Amount", "Enter Customer Amount")
		@Html.TextBox("Amount", Model, new { @class = "form-control" })
		<br />
		
		<input type="submit" class="btn btn-info" value="Click to Submit">
	}

	@using (Html.BeginForm("DisplayCustomer", "Customer", FormMethod.Post))
    {

        @Html.Label("Id", "Enter Customer Id")
        @Html.TextBoxFor(x=>x.Id, new { @class = "form-control" })
        <br />
        @Html.Label("CustomerCode", "Enter Customer Code")
        @Html.TextBoxFor(x => x.CustomerCode, new { @class = "form-control" })
        <br />
        @Html.Label("Amount", "Enter Customer Amount")
        @Html.TextBoxFor(x => x.Amount, new { @class = "form-control" })
        <br />
        
        <input type="submit" class="btn btn-info" value="Click to Submit">
    }
	

/// TextArea()
/// ----------
/// The Html.TextArea() method creates <textarea rows="2" cols="20" > element with 
/// specified name, value and html attributes.
/// @Html.TextArea() is loosely typed method.
/// TextArea() method Signature:

	MvcHtmlString Html.TextArea(string name, string value, object htmlAttributes)
	
	public class Student
{
    public int StudentId { get; set; }
    [Display(Name="Name")]
    public string StudentName { get; set; }
    public string Description { get; set; } // Set Description is: "Male"
}
	
	// Html.TextArea() in Razor View
	
	@model Student

	@Html.TextArea("Description", null, new { @class = "form-control" })  
	
	// Html Result:

	<textarea class="form-control" 
              id="Description" 
              name="Description" 
              rows="2"
              cols="20">Male</textarea>
			  
/*
	In the above example, the first parameter is the "Description" property of Student model class 
	which will be set as a name & id of textarea. The second parameter is a value to display in a textarea, 
	which is null in the above example because TextArea() method will automatically display a value 
	of the Description property in the textarea. The third parameter will be set as class attribute.
*/

/// We can also specify any name for the textarea. However, it will not be bound to a model.	
	

/// TextBoxFor() 
/// ------------
/// TextBoxFor()method Signature:

	MvcHtmlString TextAreaFor(<Expression<Func<TModel,TValue>> expression, object htmlAttributes)

	// Html.TextAreaFor() in Razor View
	
	@model Student

	@Html.TextAreaFor(m => m.Description, new { @class = "form-control" }) 

	// Html Result:

	<textarea class="form-control" 
              cols="20" 
              id="Description" 
              name="Description" 
              rows="2"></textarea> 

			  
///	CheckBox()
/// ----------
/// The Html.CheckBox() is a loosely typed method.
/// It generates a <input type="checkbox" > with the specified name, isChecked boolean and html attributes.	  
/// CheckBox() method Signature:

	MvcHtmlString CheckBox(string name, bool isChecked, object htmlAttributes)	
	
	// Html.CheckBox() in Razor View

	@Html.CheckBox("isNewlyEnrolled", true)

	// Html Result:

	<input checked="checked" 
           id="isNewlyEnrolled" 
           name="isNewlyEnrolled" 
           type="checkbox" 
           value="true" />

		   
/// CheckBoxFor()
/// -------------
/// CheckBoxFor helper method is a strongly typed extension method. 
/// It generates <input type="checkbox"> element for the model property specified using a lambda expression. 
/// CheckBoxFor method binds a specified model object property to checkbox element. 
/// So it automatically checked or unchecked a checkbox based on the property value.
/// CheckBoxFor() method Signature:

	MvcHtmlString CheckBoxFor(<Expression<Func<TModel,TValue>> expression, object htmlAttributes)
		
	// Html.CheckBoxFor() in Razor View

	@model Student

	@Html.CheckBoxFor(m => m.isNewlyEnrolled)

	// Html Result:

	<input data-val="true" 
        data-val-required="The isNewlyEnrolled field is required." 
        id="isNewlyEnrolled" 
        name="isNewlyEnrolled" 
        type="checkbox" 
        value="true" />

	<input name="isNewlyEnrolled" type="hidden" value="false" />

/*	
	In the above Html result, notice that it has generated additional hidden field with the same name 
	and value=false. This is because when we submit a form with a checkbox, the value is only posted 
	if the checkbox is checked. So, if we leave the checkbox unchecked then nothing will be sent to 
	the server when in many situations we would want false to be sent instead. As the hidden input has 
	the same name as the checkbox, then if the checkbox is unchecked you'll still get a 'false' sent 
	to the server.
*/
	

/// RadioButton()
/// -------------
/// The Html.RadioButton() method creates an radio button element with a specified name, 
/// isChecked boolean and html attributes.
/// RadioButton() method Signature:

	MvcHtmlString RadioButton(string name, object value, bool isChecked, object htmlAttributes)
	
	// Html.RadioButton() in Razor View

	Male:   @Html.RadioButton("Gender","Male")  
	Female: @Html.RadioButton("Gender","Female")  

	// Html Result:

	Male: <input checked="checked" 
			id="Gender" 
			name="Gender" 
			type="radio" 
			value="Male" />

	Female: <input id="Gender" 
			name="Gender" 
			type="radio" 
			value="Female" />
			
/* 
	In the above example, we have created two radio button for the "Gender" property. 
	The second parameter is a value which will be sent to the server, if respective radio button is checked. 
	If the Male radio button is selected, then the string value "Male" will be assigned to a model 
	property Gender and submitted to the server. The above example creates two radio buttons.
*/


/// RadioButtonFor()
/// ----------------
/// RadioButtonFor helper method is a strongly typed extension method. 
/// It generates <input type="radio"> element for the property specified using a lambda expression. 
/// RadioButtonFor method binds a specified model object property to RadioButton control. 
/// So it automatically checked or unchecked a RadioButton based on the property value.
/// RadioButtonFor() method Signature:

	MvcHtmlString RadioButtonFor(<Expression<Func<TModel,TValue>> expression, object value, object htmlAttributes)

	// Html.RadioButtonFor() in Razor View

	@model Student

	@Html.RadioButtonFor(m => m.Gender,"Male")
	@Html.RadioButtonFor(m => m.Gender,"Female")

	// Html Result:

	<input checked="checked" 
        id="Gender" 
        name="Gender" 
        type="radio" 
        value="Male" />

	<input id="Gender" 
        name="Gender" 
        type="radio" 
        value="Female" />

/* 
	In the above example, the first parameter in RadioButtonFor() method is a lambda expression that specifies 
	the model property to be bind with the RadioButton element. We have created two radio button for the Gender 
	property in the above example. So, it generates two <input type="RadioButton"> element with id & name set 
	to property name - Gender. The second parameter is a value which will be sent to the server when form will 
	be submitted.
*/


/// DropDownList()
/// --------------
/// The Html.DropDownList() method generates a select element with specified name, list items and html attributes.
/// DropDownList() method signature:

	MvcHtmlString Html.DropDownList(string name, IEnumerable<SelectLestItem> selectList, 
	                                string optionLabel, object htmlAttributes)



	// Example
	
	public class Student
	{
		public int StudentId { get; set; }
		[Display(Name="Name")]
		public string StudentName { get; set; }
		public Gender StudentGender { get; set; }
	}

	public enum Gender
	{
		Male,
		Female    
	}

	// Html.DropDownList() in Razor View

	@using MyMVCApp.Models

	@model Student

	@Html.DropDownList("StudentGender", 
                    new SelectList(Enum.GetValues(typeof(Gender))),
                    "Select Gender",
                    new { @class = "form-control" })

	// Html Result

	<select class="form-control" id="StudentGender" name="StudentGender">
		<option>Select Gender</option> 
		<option>Male</option> 
		<option>Female</option> 
	</select>
	
/*
	In the above example, the first parameter is a property name for which we want to display list items. 
	The second parameter is list of values to be included in the dropdownlist. We have used Enum methods 
		to get the Gender enum values. 
	The third parameter is a label which will be the first list item and 
	the fourth parameter is for html attributes like css to be applied on the dropdownlist.
*/


/// Please note that you can add MyMVCApp.Models namespace into <namespaces> section in web.config 
/// in the Views folder instead of using @using to include namespces in all the views.


/// DropDownListFor()
/// -----------------
/// DropDownListFor helper method is a strongly typed extension method. 
/// It generates <select> element for the property specified using a lambda expression. 
/// DropDownListFor method binds a specified model object property to dropdownlist control. 
/// So it automatically list items in DropDownList based on the property value.

/// DropDownListFor() method signature:

	MvcHtmlString Html.DropDownListFor(Expression<Func<dynamic,TProperty>> expression, 
	                                   IEnumerable<SelectLestItem> selectList, string optionLabel, 
									   object htmlAttributes)


	// DropDownListFor() in Razor View

	@using MyMVCApp.Models

	@model Student

	@Html.DropDownListFor(m => m.StudentGender, 
                    new SelectList(Enum.GetValues(typeof(Gender))), 
                    "Select Gender", 
					new { @class = "form-control" })

	// Html Result:

	<select class="form-control" id="StudentGender" name="StudentGender">
		<option>Select Gender</option> 
		<option>Male</option> 
		<option>Female</option> 
	</select>

/*
	In the above example, the first parameter in DropDownListFor() method is a lambda expression 
		that specifies the model property to be bind with the select element. We have specified 
		StudentGender property of enum type. 
	The second parameter specifies the items to show into dropdown list using SelectList. 
	The third parameter is optionLabel which will be the first item of dropdownlist and
	the fourth parameter is for html attributes like css to be applied on the dropdownlist.
	
	So now, it generates <select> element with id & name set to property name - StudentGener and 
	two list items - Male & Female.
*/

	
/// Hidden()
/// --------
/// The Html.Hidden() method generates a input hidden field (<input type="hidden">) element 
/// with specified name, value and html attributes.

/// Hidden() method signature:

	MvcHtmlString Html.Hidden(string name, object value, object htmlAttributes)
	
	

	// Html.Hidden() in Razor View

	@model Student

	@Html.Hidden("StudentId")

	// Html Result:

	<input id="StudentId" 
				name="StudentId" 
				type="hidden" 
				value="1" />

/* 
	The above example creates a hidden field for StudentId property of Student model. 
	It binds StudentId with the hidden field, so that it can assign value of StudentId 
	to the hidden field and visa-versa.
*/

/// HiddenFor()
/// -----------
/// HiddenFor helper method is a strongly typed extension method. 
/// It generates a hidden input element for the model property specified using a lambda expression. 
/// HiddenFor method binds a specified model object property to <input type="hidden">. 
/// So it automatically sets a value of the model property to hidden field and visa-versa.

/// HiddenFor() method signature:

	MvcHtmlString Html.HiddenFor(Expression<Func<dynamic,TProperty>> expression)

	// HiddenFor() in Razor View

	@model Student

	@Html.HiddenFor(m => m.StudentId)

	// Html Result:

	<input data-val="true" 
				data-val-number="The field StudentId must be a number." 
				data-val-required="The StudentId field is required." 
				id="StudentId" 
				name="StudentId" 
				type="hidden" 
				value="1" />

/*
	In the above example, the first parameter in HiddenFor() method is a lambda expression 
	that specifies the model property to be bind with the hidden field. We have specified StudentId 
	property in the above example. So, it generates input text element with id & name set to property name. 
	The value attribute will be set to the value of a StudentId property which is 1 in the above example.

	Please notice that it has created data- attribute of html5 that is used for the validation in ASP.Net MVC.
*/


/// Password()
/// ----------
/// The Html.Password() method generates a input password element with specified name, value and html attributes.

/// Password() method signature:

	MvcHtmlString Html.Password(string name, object value, object htmlAttributes)


	// Html.Password() in Razor View

	@model Student

	@Html.Password("OnlinePassword")

	// Html Result:

	<input 
			id="OnlinePassword" 
			name="OnlinePassword" 
			type="password" 
			value="" />

	// The above example will create password field for "OnlinePassword" property.

	
///	PasswordFor()
/// -------------
/// PasswordFor helper method is a strongly typed extension method. 
/// It generates a <input type="password"> element for the model object property specified 
/// using a lambda expression. PasswordFor method binds a specified model object property 
/// to <input type="password">. So it automatically sets a value of the model property to 
/// password field and visa-versa.

/// PasswordFor() method signature:

	MvcHtmlString Html.PasswordFor(Expression<Func<dynamic,TProperty>> expression, object htmlAttributes)

	// PasswordFor() in Razor View

	@model Student

	@Html.PasswordFor(m => m.Password)

	// Html Result:

	<input id="Password" name="Password" type="password" value="mypassword" />

/*
	In the above example, the first parameter in PasswordFor() method is a lambda expression 
	that specifies the model property to be bind with the password textbox. We have specified 
	Password property in the above example. So, it generates input password element with id & name 
	set to property name. The value attribute will be set to the value of a Password property which 
	is "mypassword" in the above example.
*/
	
	
	