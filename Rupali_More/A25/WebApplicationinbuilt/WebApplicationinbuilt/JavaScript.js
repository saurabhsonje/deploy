var app = angular.module('myapp1', []);

app.controller("mycontroller", function ($scope) {
    $scope.Employees = [{ name: "rupali", Number: "456734" ,Salary:"5000"},
        { name: "tau", Number: "456734", Salary: "56743" }];

    $scope.Add = function () {
        var Employee = {};
        Employee.name = $scope.name;
        Employee.Number = $scope.Number;
        Employee.Salary = $scope.Salary;
        $scope.Employees.push(Employee);

        //for cleare text boxes

        $scope.name = "";
        $scope.Number = "";
        $scope.Salary = "";
    }
               

    

   
});