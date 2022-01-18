$(window).on("beforeunload", function () {
    //Tri.DisplayLoadingIndicator();
});

/* Using a JavaScript closure - it creates an Immediately-Invoked Function Expression (IIFE), allowing for private variables/functions. */
var Tri = (function () {
    /* Private Functions/Variables */
    function reapplyTableStriping(parentId) {
        $("#" + parentId + " tr").each(function (index) {
            $(this).removeClass("tri-striped-row");
        });

        $("#" + parentId + " tr:visible").each(function (index) {
            $(this).toggleClass("tri-striped-row", !!(index & 1));
        });
    }
    /* End Private Functions/Variables */

    /* Public Functions */
    return {
        DisplayLoadingIndicator: function () {
            $(".tri-loading-overlay").show();
        },

        CourseChanged: function (obj, parentId) {
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
                reapplyTableStriping(parentId);
            }
        },

        SportChanged: function (obj, parentId) {
            var sport = obj.value;

            if (sport === "all") {
                $("#" + parentId + " [data-sport]").fadeIn();
            } else {
                $("#" + parentId + " [data-sport]").hide();
                $("#" + parentId + " [data-sport='" + obj.value + "']").fadeIn();
            }

            // If the parent element is a table re-apply the table striping after filtering.
            var elementType = $("#" + parentId).get(0).tagName;

            if (elementType.toUpperCase() === "TABLE") {
                reapplyTableStriping(parentId);
            }
        }
    };
    /* End Public Functions */
})();
