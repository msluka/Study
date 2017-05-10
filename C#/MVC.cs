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