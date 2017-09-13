
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
	
	/// Register User with Role
	/// Helping source: https://www.youtube.com/watch?v=-IbNXvyyeVQ
	
	// In AccountViewModels
	
	public class RegisterUserViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
		
        public string Role { get; set; }
    }
	
	//In Views > Account
	
	@model RolesWithMvc.Models.RegisterUserViewModel
	@{
		ViewBag.Title = "Register User Woth Role";
	}

	<h2>@ViewBag.Title.</h2>

	@using (Html.BeginForm("RegisterUser", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
	{
		@Html.AntiForgeryToken()
		<h4>Create a new account.</h4>
		<hr />
		@Html.ValidationSummary("", new { @class = "text-danger" })
		<div class="form-group">
			@Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" })
			<div class="col-md-10">
				@Html.TextBoxFor(m => m.Email, new { @class = "form-control" })
			</div>
		</div>
		<div class="form-group">
			@Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" })
			<div class="col-md-10">
				@Html.PasswordFor(m => m.Password, new { @class = "form-control" })
			</div>
		</div>
		<div class="form-group">
			@Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" })
			<div class="col-md-10">
				@Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" })
			</div>
		</div>
		<div class="form-group">
			@Html.LabelFor(m => m.Role, new { @class = "col-md-2 control-label" })
			<div class="col-md-10">
				@Html.TextBoxFor(m => m.Role, new { @class = "form-control" })
			</div>
		</div>
		<div class="form-group">
			<div class="col-md-offset-2 col-md-10">
				<input type="submit" class="btn btn-default" value="Register" />
			</div>
		</div>
	}

	@section Scripts {
		@Scripts.Render("~/bundles/jqueryval")
	}

	
	//In AccountController
	
	public ActionResult RegisterUser()
        {
            return View();
        }

        //
        // POST: /Account/RegisterUser
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterUser(RegisterUserViewModel model)
        {
            using (var context = new ApplicationDbContext())
            {
                if (ModelState.IsValid)
                {
                    var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                    var result = await UserManager.CreateAsync(user, model.Password);
                    
                    if (result.Succeeded)
                    {
                        var roleStore = new RoleStore<IdentityRole>(context);
                        var roleManager = new RoleManager<IdentityRole>(roleStore);
                        await roleManager.CreateAsync(new IdentityRole(model.Role));
                        await UserManager.AddToRoleAsync(user.Id, model.Role);


                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        
                        return RedirectToAction("Index", "Home");
                    }
                    AddErrors(result);
                }
                
                return View(model);
            }
        }
		
		// In _loginPartial
		
		<li>@Html.ActionLink("RegisterUser", "RegisterUser", "Account", routeValues: null, htmlAttributes: new { id = "registerLink" })</li>
	
		
	/// Add multiple Roles to User
	
	//In AccountController
	
	public ActionResult RegisterUser()
	{
		return View();
	}

	//
	// POST: /Account/RegisterUser
	[HttpPost]
	[AllowAnonymous]
	[ValidateAntiForgeryToken]
	public async Task<ActionResult> RegisterUser(RegisterUserViewModel model)
	{
		using (var context = new ApplicationDbContext())
		{
			if (ModelState.IsValid)
			{
				var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
				var result = await UserManager.CreateAsync(user, model.Password);
				
				if (result.Succeeded)
				{
					var roleStore = new RoleStore<IdentityRole>(context);
                        var roleManager = new RoleManager<IdentityRole>(roleStore);
                        await roleManager.CreateAsync(new IdentityRole(model.Role));
                        await roleManager.CreateAsync(new IdentityRole(model.Role2));

                        //Multiple Roles						
                        string[] roles = { model.Role, model.Role2};
                        
                        foreach (var role in roles)
                        {
                            await UserManager.AddToRoleAsync(user.Id, role); 
                        }
												
                        //or
                        //await UserManager.AddToRoleAsync(user.Id, model.Role);
                        //await UserManager.AddToRoleAsync(user.Id, model.Role2);


					await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
					
					return RedirectToAction("Index", "Home");
				}
				AddErrors(result);
			}
			
			return View(model);
		}
	}
	
	/// Add multiple Roles to User from checkboxes
	
	//In AccountViewModels
	
	public class RegisterUserViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
		
        // New code from here
		
        public IList<string> SelectedRoles { get; set; }
        public IList<SelectListItem> AvailableRoles { get; set; }

        public RegisterUserViewModel()
        {
            SelectedRoles = new List<string>();
            AvailableRoles = new List<SelectListItem>();
        }

    }
	
	// In AccountController
	
	public ActionResult RegisterUser()
        {
            var mod = new RegisterUserViewModel
            {
                AvailableRoles = GetRoles()
            };
            return View(mod);
            
        }

        //
        // POST: /Account/RegisterUser
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterUser(RegisterUserViewModel model)
        {
            using (var context = new ApplicationDbContext())
            {
                if (ModelState.IsValid)
                {
                    
                    var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                    var result = await UserManager.CreateAsync(user, model.Password);
                    
                    if (result.Succeeded)
                    {
                        var roleStore = new RoleStore<IdentityRole>(context);
                        var roleManager = new RoleManager<IdentityRole>(roleStore);
                        //await roleManager.CreateAsync(new IdentityRole(model.Role));
                        //await roleManager.CreateAsync(new IdentityRole(model.Role2));

                        string[] roles = model.SelectedRoles.ToArray();                                              
                        
                        foreach (var role in roles)
                        {
                            await UserManager.AddToRoleAsync(user.Id, role); 
                        }
                       

                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        
                        return RedirectToAction("Index", "Home");
                    }
                    AddErrors(result);
                }
                
                return View(model);
            }
        }
		
		private IList<SelectListItem> GetRoles()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Text = "Admin", Value = "Admin"},
                new SelectListItem {Text = "User", Value = "User"},
                new SelectListItem {Text = "Manager", Value = "Manager"}
                
            };
        } // This List can be also written in RegisterUser() method or data can be retrieved from db.
		
					public ActionResult RegisterUser()
					{
						var mod = new RegisterUserViewModel
						{
							AvailableRoles = new List<SelectListItem>
							{
								new SelectListItem {Text = "Admin", Value = "Admin"},
								new SelectListItem {Text = "User", Value = "User"},
								new SelectListItem {Text = "Manager", Value = "Manager"}
							}
						};

						return View(mod);

					}
					
		// In Views > RegisterUser
		
		@model RolesWithMvc.Models.RegisterUserViewModel
		@{
			ViewBag.Title = "Register User";
		}

		<h2>@ViewBag.Title.</h2>

		@using (Html.BeginForm("RegisterUser", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
		{
			@Html.AntiForgeryToken()
			<h4>Create a new account.</h4>
			<hr />
			@Html.ValidationSummary("", new { @class = "text-danger" })
			<div class="form-group">
				@Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" })
				<div class="col-md-10">
					@Html.TextBoxFor(m => m.Email, new { @class = "form-control" })
				</div>
			</div>
			<div class="form-group">
				@Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" })
				<div class="col-md-10">
					@Html.PasswordFor(m => m.Password, new { @class = "form-control" })
				</div>
			</div>
			<div class="form-group">
				@Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" })
				<div class="col-md-10">
					@Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" })
				</div>
			</div>
            
            //New code			
			<div class="form-group">
				@Html.LabelFor(m => m.AvailableRoles, new { @class = "col-md-2 control-label" })
				<div class="col-md-10">
					@foreach (var item in Model.AvailableRoles)
					{
						<div class="checkbox">
							<label>
								<input type="checkbox"
									   name="SelectedRoles"
									   value="@item.Value" /> @item.Text
								</label>
							</div>
					}

				</div>
			</div>
			<div class="form-group">
				<div class="col-md-offset-2 col-md-10">
					<input type="submit" class="btn btn-default btn-success" value="Register" />
				</div>
			</div>
		}

		@section Scripts {
			@Scripts.Render("~/bundles/jqueryval")
		}
