/// <reference path="angular.min.js" />

//Entry point for JS
var myApp = angular.module("empModule", []);

//register the controller with module
myApp.controller("empController", function ($scope) {
    $scope.firstName = "Rakesh"
    $scope.middleName = "Jignesh"
    $scope.lastName = "varia"
    $scope.clickToChange = function () {
        $scope.firstName = "Somya"
        $scope.middleName = "kumar"
        $scope.lastName = "varia"
    }
    
});