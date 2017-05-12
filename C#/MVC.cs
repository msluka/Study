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















