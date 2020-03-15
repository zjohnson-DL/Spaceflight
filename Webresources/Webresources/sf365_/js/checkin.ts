/// <reference path="../../../node_modules/@types/knockout/index.d.ts" />
namespace SF365.checkin
{
    class CheckInViewModel
    {
        isbusy: KnockoutObservable<boolean>;
        constructor() {
            this.isbusy = ko.observable(false);
            
        }
        public function1() {
            // Some change
            alert("In my function!");
        }

    }


}