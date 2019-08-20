var app = angular.module("MyAppDemo", ["ngRoute"]);



app.config(function ($routeProvider) {
    $routeProvider

        .when("/Add", {
            templateUrl: "Assignment3b.html",
            controller: "MyDemo"

        });
});




app.controller("MyCtrlDemo", function ($scope) {
    console.log("MyCtrlDemo", $scope);
    $scope.Employees = [
        { "FirstName": "Pooja", "LastName": "yerva" },
        { "FirstName": "rups", "LastName": "more" },
        { "FirstName": "pra", "LastName": "vidap" },
        { "FirstName": "raks", "LastName": "yerva" }
    ];


});


app.controller("MyDemo", function ($scope) {
    console.log("MyDemo", $scope);

    // $scope.Employees = [{ "FirstName": "Pooja", "LastName": "yerva" }];


    //$scope.myvalue = false;

    //$scope.ShowForm = function () {
    //    $scope.myvalue = true;
    //};
    $scope.AddEmployee = function () {


        if ($scope.firstname != undefined && $scope.lastname != undefined) {
            var employee = [];
            employee.FirstName = $scope.firstname;
            employee.LastName = $scope.lastname;

            $scope.Employees.push(employee);

            // CLEAR TEXTBOX.
            $scope.firstname = null;
            $scope.lastname = null;
            //  $scope.myvalue = false;

        }
    };


});
