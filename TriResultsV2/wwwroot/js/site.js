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

    // If the parent element is a table re-apply the table striping after filtering.
    var elementType = $("#" + parentId).get(0).tagName;

    if (elementType.toUpperCase() === "TABLE") {
        $("#" + parentId + " tr").each(function(index) {
            $(this).removeClass("tri-striped-row");
        });

        $("#" + parentId + " tr:visible").each(function(index) {
            $(this).toggleClass("tri-striped-row", !!(index & 1));
        });
    }
};
