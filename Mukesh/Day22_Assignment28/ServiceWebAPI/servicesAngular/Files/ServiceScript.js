
var myApp = angular.module("myModule", []);
myApp.controller("myController", function ($scope, $http, $log) {

    $http({
        method: 'GET',
        url: 'http://localhost:63712/api/Service/get'
    }).then(function successCallback(response) {
        $scope.students = response.data
        $log.info(response)
    }, function errorCallback(response) {
        console.log("Error occured,please check")
    });

    $scope.postMe = function (st) {

        $http({
            url: "http://localhost:63712/api/Service/PostData",
            method: "POST",
            data:st
        }).then(function successCallback(response) {
            $scope.data = response.data;
        }, function errorCallback(response) {
            $scope.error = response.statusText;
        });
    };
});

