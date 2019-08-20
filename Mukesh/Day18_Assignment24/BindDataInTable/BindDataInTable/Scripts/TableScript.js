/// <reference path="angular.min.js" />
var myApp = angular.module("myModule", []);

    myApp.controller("myController", function($scope) {
        $scope.employees = [
            { firstName: "Rakesh", lastName: "sharma", ID:10, salary:39000.980, DOB: new Date("November 12,1994") },
            { firstName: "Nilesh", lastName: "verMA", ID:11, salary:59000.954, DOB: new Date("July 12,1982") },
            { firstName: "Suresh", lastName: "MITAL", ID:12, salary:49000.965, DOB: new Date("June 12,1991") },
            { firstName: "Jacky", lastName: "chaudhary", ID:13, salary:89000.90, DOB: new Date("December 12,1979") }
        ];
        //$scope.employees = employees;
    });