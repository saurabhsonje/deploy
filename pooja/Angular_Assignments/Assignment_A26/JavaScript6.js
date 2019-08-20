var app = angular.module("Mainapp", ["MyAppDemo", "MyDemo"]);


var Addapp = angular.module("MyAppDemo", ["ngRoute"]);

Addapp.config(function ($routeProvider) {
    $routeProvider

        .when("/Add", {
            templateUrl: "Assignment6b.html",
            controller: "Mycontroller"

        });
});

Addapp.controller("MyCtrlDemo", function ($scope,$rootScope) {

    $rootScope.Customers = [
        { "FirstName": "Pooja", "LastName": "yerva", "Gender": "Female" },
        { "FirstName": "rups", "LastName": "more", "Gender": "Female" },

    ];

});


var Subapp = angular.module("MyDemo", []);

Subapp.controller("Mycontroller", function ($rootScope, $scope) {


    $scope.AddCustomer = function () {
       
        var customer = [];
        customer.FirstName = $scope.firstName;
        customer.LastName = $scope.lastName;
        customer.Gender = $scope.gender;

        $rootScope.Customers.push(customer);

        // CLEAR TEXTBOX.
        $scope.firstName = null;
        $scope.lastName = null;
        $scope.gender = null;
  
    };

});
