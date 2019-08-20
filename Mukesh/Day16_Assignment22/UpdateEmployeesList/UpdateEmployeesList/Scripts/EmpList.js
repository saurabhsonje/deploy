/// <reference path="angular.min.js" />

var myapp = angular.module("EmpModule", []);

myapp.controller("EmpController", function ($scope) {

    $scope.firstName= ""
    $scope.lastName= ""
    $scope.mobNumber = ""

    $scope.Employees = [{ firstName: "Rakesh", lastName: "Chaudhary", mobNumber: 73837983938 }]

    $scope.showForm = false;
    $scope.empDetails = []  
    $scope.getEmpDetails = function () {
        $scope.empDetails.push({ firstName: $scope.firstName, lastName: $scope.lastName, mobNumber: $scope.mobNumber })
        
    }

});