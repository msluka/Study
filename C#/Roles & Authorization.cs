
/// Authorize Attribute 
	
    /// Only Users with a Role "Admin" Can Access this Page.
	
	[Authorize(Roles = "Admin")]
	public ActionResult About()
	{
		ViewBag.Message = "Your application description page.";

		return View();
	}
	
	
	/// Only Users with a Role "Admin" or "Manager" Can Access this Page.
	
	[Authorize(Roles = "Admin, Manager")]
	public ActionResult About()
	{
		ViewBag.Message = "Your application description page.";

		return View();
	}
	
	/// Redirect to different pages after login, based on user role in ASP.NET MVC 5
	
	// In AccountController
	
    // POST: /Account/Login
	[HttpPost]
	[AllowAnonymous]
	[ValidateAntiForgeryToken]
	public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
	{
		if (!ModelState.IsValid)
		{
			return View(model);
		}

		var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
		
		// Get User Role
		var user = await UserManager.FindAsync(model.Email, model.Password);
		switch (result)
		{			
			case SignInStatus.Success:
				if (UserManager.IsInRole(user.Id, "Admin")) // Indicate Role
				{
					return RedirectToAction("Index", "Home"); // Define View for direction
				}
				
				return RedirectToLocal(returnUrl);

			case SignInStatus.LockedOut:
				return View("Lockout");
			case SignInStatus.RequiresVerification:
				return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
			case SignInStatus.Failure:
			default:
				ModelState.AddModelError("", "Invalid login attempt.");
				return View(model);
		}
	}
	
	