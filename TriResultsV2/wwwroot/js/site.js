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

function courseChanged(obj, parentId) {
    var course = obj.value;

    if (course === "all") {
        $("#" + parentId + " [data-course]").fadeIn();
    } else {
        $("#" + parentId + " [data-course]").hide();
        $("#" + parentId + " [data-course='" + obj.value + "']").fadeIn();
    }
};
