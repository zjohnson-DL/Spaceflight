/// <reference path="../../../node_modules/@types/knockout/index.d.ts" />
var SF365;
(function (SF365) {
    var checkin;
    (function (checkin) {
        var CheckInViewModel = /** @class */ (function () {
            function CheckInViewModel() {
                this.isbusy = ko.observable(false);
            }
            CheckInViewModel.prototype.function1 = function () {
                // Some change
                alert("In my function!");
            };
            return CheckInViewModel;
        }());
    })(checkin = SF365.checkin || (SF365.checkin = {}));
})(SF365 || (SF365 = {}));
//# sourceMappingURL=checkin.js.map