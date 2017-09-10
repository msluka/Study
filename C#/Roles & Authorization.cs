
/// Authorize Attribute 
	
    // Only Users with a Role "Admin" Can Access this Page.
	
	[Authorize(Roles = "Admin")]
	public ActionResult About()
	{
		ViewBag.Message = "Your application description page.";

		return View();
	}
	
	
	//Only Users with a Role "Admin" or "Manager" Can Access this Page.
	
	[Authorize(Roles = "Admin, Manager")]
	public ActionResult About()
	{
		ViewBag.Message = "Your application description page.";

		return View();
	}
	
	