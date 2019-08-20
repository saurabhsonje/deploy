var app = angular.module("MyAppDemo", []);


app.filter('CustomFilter', function () {
    return function (input) {
        return (angular.isString(input) && input.length > 0) ?
            input.charAt(0).toUpperCase() + input.substr(1).toLowerCase() : input;
    }
});





app.controller("MyCtrlDemo", function ($scope) {

    $scope.myvalue = false;

    $scope.ShowForm = function () {
        $scope.myvalue = true;
    };


    $scope.Employees = [
        { "FirstName": "pooja", "LastName": "yerva", "Gender": "Female", "Salary": "10000", "DOB": new Date("12/3/1990") },
        { "FirstName": "rups", "LastName": "more", "Gender": "Female", "Salary": "10000", "DOB": new Date("12/3/1990") },
        { "FirstName": "pra", "LastName": "vidap", "Gender": "Female", "Salary": "10000", "DOB": new Date("12/3/1990") },
        { "FirstName": "raks", "LastName": "yerva", "Gender": "Female", "Salary": "10000", "DOB": new Date("12/3/1990") }
    ];


    $scope.Remove = function (i) {
        $scope.Employees.splice(i, 1);
    };

    $scope.AddEmployee = function () {


        if ($scope.firstname != undefined && $scope.lastname != undefined && $scope.gender != undefined && $scope.salary != undefined && $scope.dob != undefined) {
            var employee = [];
            employee.FirstName = $scope.firstname;
            employee.LastName = $scope.lastname;
            employee.Gender = $scope.gender;
            employee.Salary = $scope.salary;
            employee.DOB = $scope.dob;

            $scope.Employees.push(employee);

            // CLEAR TEXTBOX.
            $scope.firstname = null;
            $scope.lastname = null;
            $scope.gender = null;
            $scope.salary = null;
            $scope.dob = null;

            $scope.myvalue = false;
        }
    };

});


