function Search(e) {
    $("#loadingDiv").toggleClass('loading');
    var model = GetDataModel();
    $.ajax({
        url: 'Hotel/GetOffer',
        type: 'POST',
        dataType: 'html',
        data: { data: model },
        success: function (result) {
            $("#hotelResult").html(result);
        },
        error: function (result) {
            $("#hotelResult").html("Something Went Wrong, Please Try Again.");
        },
        complete: function (result) {
            $("#loadingDiv").toggleClass('loading');
        }
    });
    e.preventDefault();
}

function UpdateTitle(e) {
    var ratingVal = $(e);
    ratingVal.attr("title", ratingVal.val());
}

function GetDataModel() {
    var model = {
        DestinationName: $("#destinationName").val(),
        DestinationCity: $("#destinationCity").val(),
        LengthOfStay: $("#lengthOfStay").val(),
        MinTripStartDate: $("#minTripStartDate").val(),
        MaxTripStartDate: $("#maxTripStartDate").val(),
        MaxStarRating: $("#maxStarRating").val(),
        MinStarRating: $("#minStarRating").val(),
        MaxTotalRate: $("#maxTotalRate").val(),
        MinTotalRate: $("#minTotalRate").val(),
        MaxGuestRating: $("#maxGuestRate").val(),
        MinGuestRating: $("#minGuestRate").val()
    };

    return model;
}