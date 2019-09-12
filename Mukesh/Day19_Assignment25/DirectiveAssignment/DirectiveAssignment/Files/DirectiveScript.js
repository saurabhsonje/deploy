/// <reference path="../scripts/angular.js" />

var myApp = angular.module("myDirectives", []);

myApp.controller("DirController", function ($scope) {
    $scope.firstName=""
    $scope.lastName = ""

    $scope.getName = function () {
        firstName: $scope.firstName
        lastName: $scope.lastName
    }
    });