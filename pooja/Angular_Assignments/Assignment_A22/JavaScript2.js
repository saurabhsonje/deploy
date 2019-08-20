var app = angular.module("MyAppDemo", []);

app.controller("MyCtrlDemo", function ($scope) {

    $scope.myvalue = false;

    $scope.ShowForm = function () {
        if ($scope.myvalue) {
            $scope.myvalue = false;
        }
        else {
            $scope.myvalue = true;
        }
    };


    $scope.Employees = [
        { "FirstName": "Pooja", "LastName": "yerva", "Gender": "Female" },
        { "FirstName": "rups", "LastName": "more", "Gender": "Female" },
        { "FirstName": "pra", "LastName": "vidap", "Gender": "Female" },
        { "FirstName": "raks", "LastName": "yerva", "Gender": "Female" }
    ];


    $scope.Remove = function (i) {
        $scope.Employees.splice(i, 1);
    };

    $scope.AddEmployee = function () {


        if ($scope.firstname != undefined && $scope.lastname != undefined && $scope.gender != undefined) {
            var employee = [];
            employee.FirstName = $scope.firstname;
            employee.LastName = $scope.lastname;
            employee.Gender = $scope.gender;

            $scope.Employees.push(employee);

            // CLEAR TEXTBOX.
            $scope.firstname = null;
            $scope.lastname = null;
            $scope.gender = null;

            $scope.myvalue = false;
        }
    };

});


