$(function () {
    // Document ready.

    // For testing - loading spinner always visible.
    //displayLoadingIndicator();
});

$(window).on("beforeunload", function () {
    //displayLoadingIndicator();
});

function displayLoadingIndicator() {
    $(".tri-loading-overlay").show();
}

function courseChanged(obj, resultTableId) {
    var course = obj.value;

    if (course === "all") {
        $("#" + resultTableId + " [data-course]").fadeIn();
    } else {
        $("#" + resultTableId + " [data-course]").hide();
        $("#" + resultTableId + " [data-course='" + obj.value + "']").fadeIn();
    }
};
