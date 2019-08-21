var app = angular.module("stuModule", ["ngRoute"])
    .config(function ($routeProvider) {

        $routeProvider.when("/NewAddition", {
            templateUrl: "HtmlAdd.html",
            controller: "AddStudent"
        }).when("/Display", {
            templateUrl: "HtmlDisplay.html",
            controller: "DisplayStudent"
        })

    }).controller("AddStudent", function ($scope, $rootScope) {
        $rootScope.Name = ""
        $rootScope.ID = ""
        $rootScope.Course = ""
        $rootScope.stuDetails = []
        $scope.addStuDetails = function () {
            $rootScope.stuDetails.push({ Name: $scope.Name, ID: $scope.ID, Course: $scope.Course })
        }
        
    }).controller("DisplayStudent", function ($scope, $rootScope) {
        $scope.stuDetails = []
        $scope.getStuDetails = function () {
            $scope.stuDetails = $rootScope.stuDetails;
        }
    });