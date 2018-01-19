var a = true;
var WebApp = /** @class */ (function () {
    function WebApp() {
        var _this = this;
        this.name = "Moeen";
        $(function () {
            _this.Initialize();
        });
    }
    WebApp.prototype.Start = function (user) {
        user.name = "Moeen";
    };
    WebApp.prototype.Initialize = function () {
        console.log("Application initialized");
    };
    return WebApp;
}());
var app = new WebApp();
app.Start({ name: "", age: 20 });
//# sourceMappingURL=myApp.js.map