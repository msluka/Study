   
   /// Take image and display it in browser (Javascript / Jquery)
   
   /// Helpful source: https://www.youtube.com/watch?v=c41gw_Ks5FU
   ///                 https://xdan.ru/working-with-files-in-javascript-part-2-filereader.html
   
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