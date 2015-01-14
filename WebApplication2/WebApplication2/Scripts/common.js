"use strict";
var utils = (function () {
    function utils() {
    }
    utils.prototype.setActiveMenu = function (menuName) {
        menuName = menuName || "home";
        $(".nav li").removeClass("active");
        $("#" + menuName).addClass("active");
    };
    return utils;
})();
//# sourceMappingURL=common.js.map
