//site.js

(function () {

    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle")
        .on("click",
            function() {
                $sidebarAndWrapper.toggleClass("hide-sidebar");

                if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
                    $icon.removeClass("fa-angle-left");
                    $icon.addClass("fa-bars");
                } else {
                    $icon.removeClass("fa-bars");
                    $icon.addClass("fa-angle-left");
                }
            });

})();



