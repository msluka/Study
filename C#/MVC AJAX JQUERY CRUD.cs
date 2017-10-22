	/// MVC CRUD JQUERY AJAX
	
	/// Helpful source: https://www.aspsnippets.com/Articles/ASPNet-MVC-CRUD-Select-Insert-Edit-Update-and-Delete-in-ASPNet-MVC-Razor.aspx

	/// Model

	public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
    }
	
	/// DAL
	
	namespace MVC_CRUD_AJAX.DAL
	{
		public class MyContext : DbContext
		{
			public MyContext() : base("MVCwithAJAX") { } // Context Issue: enable-migrations -ContextTypeName MVC_CRUD_AJAX.DAL.MyContext
			public virtual DbSet<Product> Products { get; set; }

		}
	}
	
	/// Controller
	
	public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyContext db = new MyContext();
            var productList = db.Products.ToList();
            return View(productList);
        }

        [HttpPost]
        public JsonResult InsertProduct(Product product)
        {
            using (MyContext db = new MyContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }

            return Json(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            using (MyContext db = new MyContext())
            {
                Product updatedProduct = (from p in db.Products
                    where p.Id == product.Id
                    select p).FirstOrDefault();
                updatedProduct.Name = product.Name;
                updatedProduct.Unit = product.Unit;
                updatedProduct.Price = product.Price;
                db.SaveChanges();
            }

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult DeleteProduct(int productId)
        {
            using (MyContext db = new MyContext())
            {
                Product product = (from p in db.Products
                    where p.Id == productId
                    select p).FirstOrDefault();
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return new EmptyResult();
        }
	}	
	
	/// View
	
	@model IEnumerable<MVC_CRUD_AJAX.Models.Product>

	@{
		ViewBag.Title = "Home Page";
	}

	<div class="row">
		<div class="col-md-2">

		</div>
		<div class="col-md-8">
			<table id="tblProducts" class="table" cellpadding="0" cellspacing="0">
				<tr>
					<th style="width:100px">Id</th>
					<th style="width:150px">Name</th>
					<th style="width:150px">Unit</th>
					<th style="width:150px">Price</th>
					<th></th>
				</tr>
				@*<tr>
						<td>&nbsp;</td>
						<td>&nbsp;</td>
						<td>&nbsp;</td>
						<td>&nbsp;</td>
					</tr>*@
				@foreach (var product in Model)
				{
					<tr>
						<td class="ProductId">
							<span>@product.Id</span>
						</td>
						<td class="Name">
							<span>@product.Name</span>
							<input type="text" value="@product.Name" style="display:none" />
						</td>
						<td class="Unit">
							<span>@product.Unit</span>
							<input type="text" value="@product.Unit" style="display:none" />
						</td>
						<td class="Price">
							<span>@product.Price</span>
							<input type="text" value="@product.Price" style="display:none" />
						</td>
						<td>
							<a class="Edit" href="javascript:;">Edit</a>
							<a class="Update" href="javascript:;" style="display:none">Update</a>
							<a class="Cancel" href="javascript:;" style="display:none">Cancel</a>
							<a class="Delete" href="javascript:;">Delete</a>
						</td>
					</tr>
				}
			</table>

			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td style="width: 150px">
						Name<br />
						<input type="text" id="txtName" style="width:140px" />
					</td>
					<td style="width: 150px">
						Unit:<br />
						<input type="text" id="txtUnit" style="width:140px" />
					</td>
					<td style="width: 150px">
						Price:<br />
						<input type="text" id="txtPrice" style="width:140px" />
					</td>
					<td style="width: 200px">
						<br />
						<input type="button" id="btnAdd" value="Add" />
					</td>
				</tr>
			</table>

		</div>
		<div class="col-md-2">

		</div>
	</div>
	
	/// Script
	
	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
	<script type="text/javascript" src="http://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js"></script>

	<script type="text/javascript">
		//$(function () {
		//    //Remove the dummy row if data present.
		//    if ($("#tblProducts tr").length > 2) {
		//        $("#tblProducts tr:eq(1)").remove();
		//    }
		//});
		//function AppendRow(row, productId, name, unit, price) {
		//    //Bind ProductId.
		//    $(".ProductId", row).find("span").html(productId);

		//    //Bind Name.
		//    $(".Name", row).find("span").html(name);
		//    $(".Name", row).find("input").val(name);

		//    //Bind Unit.
		//    $(".Unit", row).find("span").html(unit);
		//    $(".Unit", row).find("input").val(unit);

		//    //Bind Price.
		//    $(".Price", row).find("span").html(price);
		//    $(".Price", row).find("input").val(price);

		//    $("#tblProducts").append(row);
		//};

		//Add event handler.
		$("body").on("click", "#btnAdd", function () {
			var txtName = $("#txtName");
			var txtUnit = $("#txtUnit");
			var txtPrice = $("#txtPrice");

			var product = {};

			product.Name = txtName.val();
			product.Unit = txtUnit.val();
			product.Price = txtPrice.val();

			$.ajax({
				type: "POST",
				url: "/Home/InsertProduct",
				data: '{product:' + JSON.stringify(product) + '}',
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				success: function (r) {
					
					// var row = $("#tblProducts tr:last-child").clone(true);

					var row = '<tr>' +
						'<td class="ProductId"><span>' +
						r.Id +
						'</span></td>' +
						'<td class="Name"><span>' +
						r.Name +
						'</span><input type="text" value="' +
						r.Name +
						'" style="display:none" /></td>' +
						'<td class="Unit"><span>' +
						r.Unit +
						'</span><input type="text" value="' +
						r.Unit +
						'" style="display:none" /></td>' +
						'<td class="Name"><span>' +
						r.Price +
						'</span><input type="text" value="' +
						r.Price +
						'" style="display:none" /></td>' +
						'<td><a class="Edit" href="javascript:;">Edit</a>' +
						'<a class="Update" href="javascript:;" style="display:none">Update</a>' +
						'<a class="Cancel" href="javascript:;" style="display:none"> Cancel</a>' +
						'<a class="Delete" href="javascript:;"> Delete</a>' +
						'</td>' +
						'</tr>';
					$("#tblProducts").append(row);

					// AppendRow(row, r.Id, r.Name, r.Unit, r.Price);
					
					txtName.val("");
					txtUnit.val("");
					txtPrice.val("");

				}
			});
		});

		//Edit event handler.
		$("body").on("click", "#tblProducts .Edit", function () {
			var row = $(this).closest("tr");
			$("td", row).each(function () {
				if ($(this).find("input").length > 0) {
					$(this).find("input").show();
					$(this).find("span").hide();
				}
			});
			row.find(".Update").show();
			row.find(".Cancel").show();
			row.find(".Delete").hide();
			$(this).hide();
		});

		//Update event handler.
		$("body").on("click", "#tblProducts .Update", function () {
			var row = $(this).closest("tr");
			$("td", row).each(function () {
				if ($(this).find("input").length > 0) {
					var span = $(this).find("span");
					var input = $(this).find("input");
					span.html(input.val());
					span.show();
					input.hide();
				}
			});
			row.find(".Edit").show();
			row.find(".Delete").show();
			row.find(".Cancel").hide();
			$(this).hide();

			var product = {};
			product.Id = row.find(".ProductId").find("span").html();
			product.Name = row.find(".Name").find("span").html();
			product.Unit = row.find(".Unit").find("span").html();
			product.Price = row.find(".Price").find("span").html();
			$.ajax({
				type: "POST",
				url: "/Home/UpdateProduct",
				data: '{product:' + JSON.stringify(product) + '}',
				contentType: "application/json; charset=utf-8",
				dataType: "json"

			});
		});

		//Cancel event handler.
		$("body").on("click", "#tblProducts .Cancel", function () {
			var row = $(this).closest("tr");
			$("td", row).each(function () {
				if ($(this).find("input").length > 0) {
					var span = $(this).find("span");
					var input = $(this).find("input");
					input.val(span.html());
					span.show();
					input.hide();
				}
			});
			row.find(".Edit").show();
			row.find(".Delete").show();
			row.find(".Update").hide();
			$(this).hide();
		});

		//Delete event handler.
		$("body").on("click", "#tblProducts .Delete", function () {
			if (confirm("Do you want to delete this row?")) {
				var row = $(this).closest("tr");
				var productId = row.find(".ProductId").find("span").html();
				$.ajax({
					type: "POST",
					url: "/Home/DeleteProduct",
					data: '{productId: ' + productId + '}',
					contentType: "application/json; charset=utf-8",
					dataType: "json",
					//async: false,
					success: function(response) {
						//row.remove();
					},
					error: function(response) {
						// alert("Something went wrong!");

					}
				}).done(row.fadeOut(500,
					function() {
						row.remove();
						alert("Successfully deleted");
					}));
			}
		});
	</script>