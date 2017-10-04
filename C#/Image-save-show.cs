   
   /// Choose image and display it in browser (Javascript / Jquery)
   
   /// Helpful source: https://www.youtube.com/watch?v=c41gw_Ks5FU
   ///                 https://xdan.ru/working-with-files-in-javascript-part-2-filereader.html
   
   ///                 http://technotipstutorial.blogspot.com/2017/01/part-32-preview-image-before-upload.html
   
   // Html
   
   <div class="col-lg-6 panel panel-body">
        <input type="file" id="imageBrowse" />
        <div id="imgPreview" style="display: none;">
            <img class="img-responsive thumbnail" id="targetImg" />
            <div class="caption">
                <a href="#" onclick="ClearPreview()"><i class="glyphicon glyphicon-trash"></i></a>
                <span id="description"></span>
            </div>
        </div>
    </div>
	
	// Jquery
	
	<script src="~/Scripts/jquery-1.10.2.min.js"></script>
	<script>

		$(document).ready(function() {

			$("#imageBrowse").change(function () {

				var File = this.files;

				if (File && File[0]) {
					ReadImage(File[0]);
				}

			});


		});

		
		var ReadImage = function (file) {

			var reader = new FileReader;
			var image = new Image;

			reader.readAsDataURL(file);
			reader.onload = function (_file) {

				image.src = _file.target.result;
				image.onload = function () {

					var height = this.height;
					var width = this.width;
					var type = file.type;
					var size = ~~(file.size / 1024) + "KB";

					$("#targetImg").attr('src', _file.target.result);
					$("#description").text("Size:" + size + ", " + height + "X" + width + ", " + type);
					$("#imgPreview").show();

				}

			}

		}

		var ClearPreview = function () {
			$("#imageBrowse").val('');
			$("#description").text('');
			$("#imgPreview").hide();

		}
		
	</script>
		
	
	/// Upload and save Image to Database and display it.
	
	/// Helpful source: https://www.youtube.com/watch?v=MFVhhjQhUFU&t=1383s
	
	// Html 
	
	<div class="col-lg-3"></div>

    <div class="col-lg-6 panel panel-body">
        <input type="file" id="imageBrowse" /> // Input for a Picture
        <div id="imgPreview" style="display: none;">
            <img class="img-responsive thumbnail" id="targetImg" />
            <div class="caption">
                <a href="#" onclick="ClearPreview()"><i class="glyphicon glyphicon-trash"></i></a>
                <span id="description"></span>
            </div>

            <a href="#" class="btn btn-sm btn-success" onclick="SaveImage()">Save</a>
        </div>
    </div>

    <div class="col-lg-3" id="uploadedImg"></div>
	
	// Jquery
	
	var SaveImage = function () {

		var data = new FormData();
		var file = $("#imageBrowse").get(0).files;

		data.append("ImgFile", file[0]);

		$.ajax({
			type: "POST",
			url: "/Home/SaveImage",
			data: data,
			contentType: false,
			processData: false,
			success: function (imgId) { // Route issue: https://stackoverflow.com/questions/23245365/mvc-the-parameters-dictionary-contains-a-null-entry-for-parameter-k-of-non-n
				$("#uploadedImg").append('<img src="/Home/DisplayingImage?Id=' +
					imgId +
					'"class="img-responsive img-rounded" style="margin:5px;"/>');

			}

		}).done(function () {
		   // alert('success');
		}).fail(function (xhr, status, errorThrown) {
		   // alert('fail');
		});

	};
	
	// Model
	
	public class Images
    {
        public int Id { get; set; }
        public string ImgTitle { get; set; }
        public byte[] ImgByte { get; set; }
        public string ImgPath { get; set; }
      
    }
	
	// ViewModel
	
	public class ImgViewModel
    {
        public HttpPostedFileWrapper ImgFile { get; set; }
    }
	
	// Controller
	
	public JsonResult SaveImage(ImgViewModel model)
	{
		MyContext db = new MyContext(); // Context Issue: enable-migrations -ContextTypeName SavePicture.DAL.MyContext
		int imageId = 0;
		var file = model.ImgFile;
		byte[] imageByte = null;

		if (file != null)
		{
			file.SaveAs(Server.MapPath("/ImagesFolder/" + file.FileName));
			BinaryReader reader = new BinaryReader(file.InputStream);
			imageByte = reader.ReadBytes(file.ContentLength);
			Images img = new Images();
			img.ImgTitle = file.FileName;
			img.ImgByte = imageByte;
			img.ImgPath = "/ImagesFolder/" + file.FileName;
			db.Images.Add(img);
			db.SaveChanges();
			imageId = img.Id;

		}
		return Json(imageId, JsonRequestBehavior.AllowGet);
	}

	public ActionResult DisplayingImage(int id)
	{
		MyContext db = new MyContext();

		var img = db.Images.SingleOrDefault(x => x.Id == id);
		return File(img.ImgByte, "image/jpg");

	}
	
	
	
	