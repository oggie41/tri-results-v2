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
                var slRadiusInMetres = document.getElementById("slRadiusInMetres");

                if (slRadiusInMetres !== null && slRadiusInMetres !== undefined) {
                    var lblRadiusInMetres = document.getElementById("lblRadiusInMetres");

                    if (lblRadiusInMetres !== null && lblRadiusInMetres !== undefined) {
                        slRadiusInMetres.oninput = function () {
                            var radiusInMetres = this.value;
                            lblRadiusInMetres.innerHTML = "Radius (in metres) = " + radiusInMetres + "m";
                        }
                    }
                }

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
                    activeTrackConnector = 3;
                    changeActiveTrackConnector();
                    $("#divTrackBuilderStep2").hide();
                    $("#divTrackBuilderStep1").show();
                });

                $("input[name='radMapQueryFiltering']").change(function () {
                    var radMapQueryFiltering = $("input[name='radMapQueryFiltering']:checked").attr("id");

                    if (radMapQueryFiltering === "radRadius") {
                        $("#divRadiusFiltering").show();
                        $("#divBoundingBoxFiltering").hide();
                    }
                    else if (radMapQueryFiltering === "radBoundingBox") {
                        $("#divRadiusFiltering").hide();
                        $("#divBoundingBoxFiltering").show();
                    }
                });

                $("#btnAnalyseScenery").click(function (e) {
                    $("body").css("cursor", "wait");
                    $("#txtLandUseAll").val("Contacting Overpass server...");
                    $("#txtLandUse").val("");
                    $("#txtNaturalAll").val("Contacting Overpass server...");
                    $("#txtNamedFeatures").val("Contacting Overpass server...");

                    var radiusInMetres = $("#slRadiusInMetres").val();
                    var latLong = $("#txtLatLong").val();
                    var bbox = $("#txtBoundingBox").val();

                    // Which map query filtering method has been selected?
                    var radMapQueryFiltering = $("input[name='radMapQueryFiltering']:checked").attr("id");

                    var overpassLanduseData = "";
                    var overpassNaturalData = "";
                    var overpassNamedFeaturesData = "";

                    if (radMapQueryFiltering === "radRadius"){
                        overpassLanduseData = "[out:json];relation(around:" + radiusInMetres + "," + latLong + ")[landuse];convert relation \"landuse\"=t[\"landuse\"]; out tags;";
                        overpassNaturalData = "[out:json];relation(around:" + radiusInMetres + "," + latLong + ")[natural];convert relation \"natural\"=t[\"natural\"]; out tags;";
                        overpassNamedFeaturesData = "[out:json];relation(around:" + radiusInMetres + "," + latLong + ")[natural][name];convert relation \"natural\"=t[\"natural\"],\"name\"=t[\"name\"]; out tags;";
                    }
                    else if (radMapQueryFiltering === "radBoundingBox") {
                        overpassLanduseData = "[out:json];relation(" + bbox + ")[landuse];convert relation \"landuse\"=t[\"landuse\"]; out tags;";
                        overpassNaturalData = "[out:json];relation(" + bbox + ")[natural];convert relation \"natural\"=t[\"natural\"]; out tags;";
                        overpassNamedFeaturesData = "[out:json];relation(" + bbox + ")[natural][name];convert relation \"natural\"=t[\"natural\"],\"name\"=t[\"name\"]; out tags;";
                    }

                    // Retrieve the landuse data.
                    $.ajax({
                        url: "https://overpass.kumi.systems/api/interpreter?data=" + overpassLanduseData,
                        type: "GET",
                        dataType: "json",
                        async: true,
                        success: function (data) {
                            $("#txtLandUseAll").val("");

                            if (data) {
                                if (data.elements) {
                                    if (data.elements.length > 0) {
                                        // Group the land use records.
                                        var landUseGrouped = {};

                                        $(data.elements).each(function() {
                                            landUseGrouped[this.tags.landuse] = 1 + (landUseGrouped[this.tags.landuse] || 0);
                                        });

                                        // Convert the grouped land use object to an array.
                                        var arrLandUseGrouped = [];
                                        Object.keys(landUseGrouped).forEach(function (key) {
                                            arrLandUseGrouped.push({
                                                landuse: key,
                                                count: landUseGrouped[key]
                                            });
                                        });

                                        arrLandUseGrouped.sort((a, b) => a.landuse.toLowerCase() > b.landuse.toLowerCase() ? 1 : -1);
                                        arrLandUseGrouped.sort((a, b) => a.count < b.count ? 1 : -1);

                                        var landUseAll = "";

                                        $(arrLandUseGrouped).each(function() {
                                            landUseAll += this.landuse + " (" + this.count + ")" + "\r\n";
                                        });

                                        if (landUseAll) {
                                            var pos = landUseAll.lastIndexOf("\r\n");
                                            landUseAll = landUseAll.substring(0, pos);

                                            $("#txtLandUseAll").val(landUseAll);

                                            if (arrLandUseGrouped.length > 0) {
                                                // Retrieve the predominant land use (top in the ordered array).
                                                var landUse = arrLandUseGrouped[0].landuse;

                                                if (landUse) {
                                                    $("#txtLandUse").val(landUse);
                                                }
                                            }
                                        }
                                    } else {
                                        $("#txtLandUse").val("No land use data found.");
                                    }
                                }
                            }
                        },
                        error: function (data) {
                            $("#txtLandUseAll").val("Overpass error: " + data.status + " (" + data.statusText + ")");
                            $("#txtLandUse").val("");
                        },
                        complete: function (data) {
                            $("body").css("cursor", "auto");
                        }
                    });

                    // Retrieve the natural data.
                    $.ajax({
                        url: "https://overpass.kumi.systems/api/interpreter?data=" + overpassNaturalData,
                        type: "GET",
                        dataType: "json",
                        async: true,
                        success: function (data) {
                            $("#txtNaturalAll").val("");

                            if (data) {
                                if (data.elements) {
                                    if (data.elements.length > 0) {
                                        // Group the natural records.
                                        var naturalGrouped = {};

                                        $(data.elements).each(function () {
                                            naturalGrouped[this.tags.natural] = 1 + (naturalGrouped[this.tags.natural] || 0);
                                        });

                                        // Convert the grouped natural object to an array.
                                        var arrNaturalGrouped = [];
                                        Object.keys(naturalGrouped).forEach(function (key) {
                                            arrNaturalGrouped.push({
                                                natural: key,
                                                count: naturalGrouped[key]
                                            });
                                        });

                                        arrNaturalGrouped.sort((a, b) => a.natural.toLowerCase() > b.natural.toLowerCase() ? 1 : -1);
                                        arrNaturalGrouped.sort((a, b) => a.count < b.count ? 1 : -1);

                                        var naturalAll = "";

                                        $(arrNaturalGrouped).each(function () {
                                            naturalAll += this.natural + " (" + this.count + ")" + "\r\n";
                                        });

                                        if (naturalAll) {
                                            var pos = naturalAll.lastIndexOf("\r\n");
                                            naturalAll = naturalAll.substring(0, pos);

                                            $("#txtNaturalAll").val(naturalAll);
                                        }
                                    } else {
                                        $("#txtNaturalAll").val("No natural data found.");
                                    }
                                }
                            }
                        },
                        error: function (data) {
                            $("#txtNaturalAll").val("Overpass error: " + data.status + " (" + data.statusText + ")");
                        },
                        complete: function (data) {
                            $("body").css("cursor", "auto");
                        }
                    });

                    // Retrieve the named natural data.
                    $.ajax({
                        url: "https://overpass.kumi.systems/api/interpreter?data=" + overpassNamedFeaturesData,
                        type: "GET",
                        dataType: "json",
                        async: true,
                        success: function (data) {
                            $("#txtNamedFeatures").val("");

                            if (data) {
                                if (data.elements) {
                                    if (data.elements.length > 0) {
                                        var namedFeatures = "";

                                        $(data.elements).each(function () {
                                            namedFeatures += this.tags.natural + " (" + this.tags.name + ")" + "\r\n";
                                        });

                                        if (namedFeatures) {
                                            var pos = namedFeatures.lastIndexOf("\r\n");
                                            namedFeatures = namedFeatures.substring(0, pos);

                                            $("#txtNamedFeatures").val(namedFeatures);
                                        }
                                    } else {
                                        $("#txtNamedFeatures").val("No named natural data found.");
                                    }
                                }
                            }
                        },
                        error: function (data) {
                            $("#txtNamedFeatures").val("Overpass error: " + data.status + " (" + data.statusText + ")");
                        },
                        complete: function (data) {
                            $("body").css("cursor", "auto");
                        }
                    });
                });
            });
        }
    };
    /* End Public Functions */
})();
