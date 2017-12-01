 <!-- Custom dropdown with checkboxes START-->

	<div id="presellersListCustomDropdownWrapper" class="registerClientForm" style="position:relative">
		<label for="presellersListInput">Belongs to Preseller</label>
		<input id="presellersListInput" class="form-control" style="background:white" readonly />
		<div class="presellersListInputCheckboxWrapper form-group">
			<div id="presellersListInputCheckboxWithSpanAll"><input id="presellersListInputCheckboxAll" type="checkbox" /><span> All</span></div>

			@foreach (var t in Model.Presellers)
			{
				<div id="presellersListInputCheckboxWithSpan"><input id="presellersListInputCheckbox" type="checkbox" value="@t.Id" /><span> @t.FirstName</span></div>
			}
		</div>

	</div>

<!-- Custom dropdown with checkboxes END-->


// Show-Hide Custom Dropdown with checkboxes

$('#presellersListInput').on('click', function (e) {
    var presellersListHidden = $('.presellersListInputCheckboxWrapper');
    if (presellersListHidden.is(':visible')) {

        presellersListHidden.hide();
        $('.presellersListInputCheckboxWrapper').css("height", "auto");
      
    } else {
        var relativeElement = $("#presellersListCustomDropdownWrapper");
        var absoluteElement = $('.presellersListInputCheckboxWrapper');
        var absoluteElementHeight = $('.presellersListInputCheckboxWrapper').height();
        var documentHeight = $(document).height();
        var scrollTopHeight = $(document).scrollTop();
        var windowHeight = $(window).height();
        var presellersListInputHeight = $("#presellersListInput").outerHeight();
        var presellersListInputHeightWhitoutMargin = $("#presellersListInput").height();
        var presellersListInputPosition = $("#presellersListInput").offset();

        var relativeElementPosition = relativeElement.offset();
        var relativeElementPositionTop = relativeElementPosition.top;
        var navBarHeight = $(".container").height();

        if (((relativeElementPositionTop - scrollTopHeight) + (presellersListInputHeight / 2)) > (windowHeight / 2)) {
           
            var heigthToSet = $("#presellersListInput").offset().top - scrollTopHeight - navBarHeight - 1;
            var style1 = { "bottom": presellersListInputHeightWhitoutMargin + 4, "height": heigthToSet }
            var style2 = { "bottom": presellersListInputHeightWhitoutMargin + 4 }
            if (absoluteElementHeight > heigthToSet) {
                absoluteElement.css(style1);


            } else {

                absoluteElement.css(style2);

            }

            presellersListHidden.show();
            
        }
        else {

            var scrollBottomHeight = documentHeight -(scrollTopHeight + windowHeight);
            var heigthToSet2 = documentHeight - ($("#presellersListInput").offset().top + $("#presellersListInput").outerHeight() + scrollBottomHeight);
            var positionToSet = (presellersListInputPosition.top - relativeElementPositionTop) + presellersListInputHeight;

            var style3 = { "top": positionToSet, "height": heigthToSet2 }
            var style4 = { "top": positionToSet }

            if (absoluteElementHeight > heigthToSet2) {

                absoluteElement.css(style3);
                
            } else {

                absoluteElement.css(style4);

            }

            presellersListHidden.show();
           
        }

    }

});

$("#presellersListCustomDropdownWrapper").on("click",function () {
    $("#presellersListInput").focus();
});

$("body").on("click", function (event) {
    if (!$(event.target).closest('#presellersListCustomDropdownWrapper').length) {
       
        $('.presellersListInputCheckboxWrapper').hide();
        $("#presellersListInput").blur();
        $('.presellersListInputCheckboxWrapper').css("height", "auto");

    }
});

/*Style Dropdown With Checkboxes START*/
.presellersListInputCheckboxWrapper {
    position: absolute;
    display: none;
    border: solid #1d95f7 1px;
    width: 290px;
    overflow-y: auto;
    background: #ffffff;
    z-index: 100000;
}

input[readonly] {
    cursor: pointer !important;
}

#presellersListInputCheckboxWithSpan {
    padding: 5px 10px 5px 10px;
}

    #presellersListInputCheckboxWithSpan:hover {
        background: #1d95f7;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

#presellersListInputCheckboxWithSpanAll {
    
    background: #ffffff;
    padding: 5px 10px 5px 10px;
    width: 100%;
}
#presellersListInputCheckboxWithSpanAll:hover {
    background: #1d95f7;
    cursor: pointer;
    color: white;
    font-weight: bold;
}

/*Style Dropdown With Checkboxes END*/