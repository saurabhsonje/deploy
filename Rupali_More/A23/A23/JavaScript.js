var app = angular.module("myApp", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "main.html",
            controller: "mycontroller"
        })
        .when("/EmployeeInfo", {
            templateUrl: "EmployeeInfo.html",
            controller: "myAddController"

        });
});

app.controller('mycontroller', function ($scope) {
    $scope.customers = [{ Name: "rupali", Number: "5643" },
    { Name: "pooja", Number: "7643" },
    { Name: "yerva", Number: "6543" }];

});

app.controller('myAddController', function ($scope) {
    $scope.Add = function () {
        //Add the new item to the Array.
        var customer = {};
        customer.Name = $scope.Name;
        customer.Number = $scope.Number;

        $scope.customers.push(customer);

        //Clear the TextBoxes.
        $scope.Name = "";
        $scope.Number = "";
        $scope.myValue = false;
    };
})