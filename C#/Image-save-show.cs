   
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
	
	
	/// Choose multiple images and display in browser (Javascript / Jquery)
	
	// Html
	
	<div class="col-lg-6 panel panel-body"> 
	
		<input type="file" id="imageBrowse" multiple="multiple" />
		
		<div id="imgPreview" style="display: none;">
			<a href="#" class="btn btn-sm btn-success" onclick="SaveImage()">Save</a>
		</div>
		
	</div>
	
	// Script
	
	script src="~/Scripts/jquery-1.10.2.min.js"></script>
	<script>
    
    $(document).ready(function () {

        $("#imageBrowse").change(function () {

            var File = this.files;
            for (var i = 0; i < File.length; i++) {
                if (File && File[i]) {
                    ReadImage(File[i]);
                }
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
                var name = file.name;
                var id = randomString(10);

                var imgContainer =
                    '<div id="'+id+'">' +
                        '<img class="img-responsive thumbnail" id="targetImg" src="'+_file.target.result+'"/>' +
                        '<div class="caption">' +
                            '<a href="#" onclick="ClearPreview('+id+')">' +
                                '<i class="glyphicon glyphicon-trash"></i>' +
                            '</a>' +
                            '<span id="description">Title:'+name+', Size: '+ size + ',  '+ height +' X' + width + ', '+ type+'</span>' +
                        '</div>' +
                    '</div>';

                $("#imgPreview").append(imgContainer);

                $("#imgPreview").show();

            }

        }

    }

    function randomString(length_) {

        var chars = '0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZabcdefghiklmnopqrstuvwxyz'.split('');
        
        if (typeof length_ !== "number") {
            length_ = Math.floor(Math.random() * chars.length_);
        }
        //var str = '';
        var str = "Id_";
        for (var i = 0; i < length_; i++) {
            str += chars[Math.floor(Math.random() * chars.length)];
        }
        return str;
    }


    var ClearPreview = function (ele) {
        if (ele) {
            
            ele.parentNode.removeChild(ele);
            //console.log(ele.id);
        }

    }
	
	
	/// Upload and save multiple Images to Database and display them.
	
	// Html
	
	<input type="file" id="imageBrowse" multiple="multiple" />
    
    <a href="#" class="btn btn-sm btn-success" onclick="SaveImage()">Save</a>
    
    <div id="uploadedImg"></div>
	
	// Script
	
	<script src="~/Scripts/jquery-1.10.2.min.js"></script>
	
	<script>
	
	var SaveImage = function () {

        var data = new FormData();
        
        var files = document.getElementById("imageBrowse").files;

        for (var i = 0; i < files.length; i++) {
            data.append("ImgFile", files[i]);
        }
        
        $.ajax({
            type: "POST",
            url: "/Home/SaveImage",
            data: data,
            contentType: false,
            processData: false,
            success: function (imgsId) {
				
				for(var i=0; i<imgsId.length; i++){
					
				$("#uploadedImg").append('<img src="/Home/DisplayingImage?Id=' +
					imgsId[i] +
					'"class="img-responsive img-rounded" style="margin:5px;"/>');
				}

			}

        }).done(function () {
            // alert('success');
        }).fail(function (xhr, status, errorThrown) {
            // alert('fail');
        });

    };
	
	</script>
	
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
        public List<HttpPostedFileWrapper> ImgFile { get; set; }
    }
	
	// Controller
	
	public JsonResult SaveImage(ImgViewModel model)
	{
		MyContext db = new MyContext();            
		List<int> imagesId = new List<int>();
		var files = model.ImgFile;
		byte[] imageByte = null;

		if (files != null)
		{
			foreach (var file in files)
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
				
				imagesId.Add(img.Id);
			}


		}
		return Json(imagesId, JsonRequestBehavior.AllowGet);
	}

	public ActionResult DisplayingImage(int id)
	{
		MyContext db = new MyContext();

		var img = db.Images.SingleOrDefault(x => x.Id == id);
		return File(img.ImgByte, "image/jpg");

	}
	
	// Web.config
	
	// https://stackoverflow.com/questions/3853767/maximum-request-length-exceeded
	
	// Error: Maximum request length exceeded

	
	<system.web>
		<httpRuntime targetFramework="4.5.2" maxRequestLength="1048576"/> 
	</system.web>
	
	// Or
	
	// https://alexandrebrisebois.wordpress.com/2015/12/09/troubleshooting-maxallowedcontentlength-exceeded/
	
	<configuration>
	  <system.web>
		<!-- maxRequestLength is in kilobytes (KB)  -->
		<httpRuntime maxRequestLength="4194303" />
	  </system.web>
	  <system.webServer>
		<security>
		  <requestFiltering>
			<!-- maxAllowedContentLength is in bytes (B)  -->
			<requestLimits maxAllowedContentLength="4294967295"/>
		  </requestFiltering>
		</security>
	  </system.webServer>
	</configuration>
	
	// maxRequestLength is in kilobytes (KB)
    // maxQueryString is in bytes (B) and of type uint. Its default value is 2048
    // maxUrl is in bytes (B) and of type uint. Its default value is 4096
    // maxAllowedContentLength is in bytes (B) and its default value is 30000000, which is about 28.61 MB. Its type is uint, and its max value is 4,294,967,295 bytes = 3,99 GB
	