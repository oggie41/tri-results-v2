$(window).on("beforeunload", function () {
    //displayLoadingIndicator();
});

// For testing - loading spinner always visible.
//$(function () {
//    displayLoadingIndicator();
//});

function displayLoadingIndicator() {
    $(".tri-loading-overlay").show();
}
