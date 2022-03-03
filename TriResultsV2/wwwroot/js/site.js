$(window).on("beforeunload", function () {
    //Tri.DisplayLoadingIndicator();
});

/* Using a JavaScript closure - it creates an Immediately-Invoked Function Expression (IIFE), allowing for private variables/functions. */
var Tri = (function () {
    /* Private Functions/Variables */
    var trackConnectorCount = 3;
    var activeTrackConnector = 3;
    var traversalAdded = false;

    function reapplyTableStriping(parentId) {
        $("#" + parentId + " tr").each(function (index) {
            $(this).removeClass("tri-striped-row");
        });

        $("#" + parentId + " tr:visible").each(function (index) {
            $(this).toggleClass("tri-striped-row", !!(index & 1));
        });
    }

    function changeActiveTrackConnector() {
        for (let i = 0; i < trackConnectorCount; i++) {
            $("#icoActiveTrackConnector").removeClass("fa-circle-" + (i+1));
        }
        $("#icoActiveTrackConnector").addClass("fa-circle-" + activeTrackConnector);

        $(".track-connector-icon").removeClass("text-success");
        $(".track-connector-icon").removeClass("text-danger");
        $(".track-connector-icon:not(.fa-circle-" + activeTrackConnector + ")").addClass("text-danger");
        $(".track-connector-icon.fa-circle-" + activeTrackConnector).addClass("text-success");

        if (activeTrackConnector === 1) {
            $("#btnTrackConnectorDelete").prop("disabled", true);
        } else {
            $("#btnTrackConnectorDelete").prop("disabled", false);
        }

        var lastTrackConnectorInList = 3;

        if (traversalAdded) {
            lastTrackConnectorInList = 2;
        }

        if (activeTrackConnector === lastTrackConnectorInList) {
            $("#divAddTraversalValid").show();
            $("#divAddTraversalInvalid").hide();
        } else {
            $("#divAddTraversalValid").hide();
            $("#divAddTraversalInvalid").show();
        }
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
        },

        InitialiseTrackBuilder: function () {
            $(function () {
                var slOffset = document.getElementById("slOffset");

                if (slOffset !== null && slOffset !== undefined) {
                    var lblSliderValue = document.getElementById("lblOffsetValue");

                    if (lblSliderValue !== null && lblSliderValue !== undefined) {
                        slOffset.oninput = function () {
                            var offsetValue = this.value;
                            var offsetDirection = "";
                            var offsetDescription = "Shared single road in both directions";

                            if (offsetValue > 0) {
                                offsetDirection = "right";
                            }

                            if (offsetValue < 0) {
                                offsetDirection = "left";
                                offsetValue = offsetValue * -1;
                            }

                            if (offsetValue > 0) {
                                offsetDescription = "Overlapping adjacent road in opposite direction";

                                if (offsetValue == 3) {
                                    offsetDescription = "Adjacent road in opposite direction";
                                } else if (offsetValue > 3) {
                                    offsetDescription = "Adjacent road with spacing in opposite direction";
                                }
                            }

                            lblSliderValue.innerHTML = "Offset = " + offsetValue + "m " + offsetDirection;
                            $("#lblOffsetDescription").text(offsetDescription);
                        }
                    }
                }

                $("#btnConvertToSections").click(function (e) {
                    $("#divTrackBuilderStep1").hide();
                    $("#divTrackBuilderStep2").fadeIn();
                });

                $("#btnTrackConnectorFirst").click(function (e) {
                    activeTrackConnector = 1;
                    changeActiveTrackConnector();
                });

                $("#btnTrackConnectorBack").click(function (e) {
                    if (activeTrackConnector > 1) {
                        activeTrackConnector--;
                        changeActiveTrackConnector();
                    }
                });

                $("#btnTrackConnectorForward").click(function (e) {
                    if (activeTrackConnector < trackConnectorCount) {
                        activeTrackConnector++;
                        changeActiveTrackConnector();
                    }
                });

                $("#btnTrackConnectorLast").click(function (e) {
                    activeTrackConnector = trackConnectorCount;
                    changeActiveTrackConnector();
                });

                $("#btnTrackConnectorDelete").click(function (e) {
                    $("#divDialogHeader").text("Delete Track Connector?");
                    $("#divDialogBody").html("Are you sure you want to delete connector " + activeTrackConnector + "?<br/><br/>Note: This connector is in use so the track progression list will be re-generated.");
                    $("#dlgConfirm").modal("show");
                });

                $("#lnkClearTrackProgressionList").click(function (e) {
                    $("#divDialogHeader").text("Clear Track Progression List?");
                    $("#divDialogBody").html("Are you sure you want to delete all traversals?");
                    $("#dlgConfirm").modal("show");
                });

                $("#btnNavigateToLastTrackConnector").click(function (e) {
                    if (traversalAdded) {
                        activeTrackConnector = 2;
                    } else {
                        activeTrackConnector = trackConnectorCount;
                    }
                    changeActiveTrackConnector();
                });

                $("#btnAddTraversal3To2").click(function (e) {
                    activeTrackConnector = 2;
                    traversalAdded = true;
                    $("#trFrom3To2").show();
                    $("#lblDistance6").hide();
                    $("#lblDistance10").show();
                    $("#divAddTraversalValidStep2").show();
                    $("#divAddTraversalValidStep1").hide();
                    $("#lnkDeleteStep1").hide();
                    $("#ico-navigate-track-connector").removeClass("fa-circle-3");
                    $("#ico-navigate-track-connector").addClass("fa-circle-2");
                    changeActiveTrackConnector();
                });

                $("#btnCancel").click(function (e) {
                    $("#divTrackBuilderStep2").hide();
                    $("#divTrackBuilderStep1").show();
                });
            });
        }
    };
    /* End Public Functions */
})();
