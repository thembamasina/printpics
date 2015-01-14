var printpics;
(function (printpics) {
    printpics.setActiveMenu = function(menuName) {
        menuName = menuName || "home";
        $(".nav li").removeClass("active");
        $("#" + menuName).addClass("active");
    };
})(printpics || (printpics = {}));
