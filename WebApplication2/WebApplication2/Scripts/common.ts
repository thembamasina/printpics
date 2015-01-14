"use strict";

class utils {
    setActiveMenu(menuName: string) : void {
        menuName = menuName || "home";
        $(".nav li").removeClass("active");
        $("#" + menuName).addClass("active");
    }
}