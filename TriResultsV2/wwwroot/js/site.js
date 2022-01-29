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

        InitialiseTooltips: function () {
            var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
            var tooltipList = tooltipTriggerList.map(function(tooltipTriggerEl) {
                return new bootstrap.Tooltip(tooltipTriggerEl);
            });
        },

        CourseChanged: function (obj, parentId) {
            var course = obj.value;
            var elementType = $("#" + parentId).get(0).tagName;

            if (course === "all") {
                $(".tri-multisport-pb-card").hide();
                $("#" + parentId + " [data-course]:not(.tri-multisport-pb-card)").fadeIn();

                if (elementType.toUpperCase() !== "TABLE") {
                    // "Show All" selected, so collapse all results.
                    $(".accordion-button").addClass("collapsed");
                    $(".accordion-collapse.collapse.show").removeClass("show");
                }
            } else {
                $("#" + parentId + " [data-course]").hide();
                $("#" + parentId + " [data-course='" + obj.value + "']").fadeIn();

                if (elementType.toUpperCase() !== "TABLE") {
                    var courseElementCount = $("#" + parentId + " [data-course='" + obj.value + "']").length;

                    if (courseElementCount > 1) {
                        // Multiple results for this course, so collapse the results.
                        $(".accordion-button").addClass("collapsed");
                        $(".accordion-collapse.collapse.show").removeClass("show");
                    } else {
                        // Only one result for this course, so automatically expand it.
                        $(".accordion-button.collapsed").removeClass("collapsed");
                        $(".accordion-collapse.collapse").addClass("show");
                    }
                }
            }

            // If the parent element is a table re-apply the table striping after filtering.
            if (elementType.toUpperCase() === "TABLE") {
                reapplyTableStriping(parentId);
            }
        },

        SportChanged: function (obj, parentId) {
            var sport = obj.value;
            var elementType = $("#" + parentId).get(0).tagName;

            if (sport === "all") {
                $("#" + parentId + " [data-sport]").fadeIn();
            } else {
                $("#" + parentId + " [data-sport]").hide();
                $("#" + parentId + " [data-sport='" + obj.value + "']").fadeIn();
            }

            // If the parent element is a table re-apply the table striping after filtering.
            if (elementType.toUpperCase() === "TABLE") {
                reapplyTableStriping(parentId);
            }
        }
    };
    /* End Public Functions */
})();
