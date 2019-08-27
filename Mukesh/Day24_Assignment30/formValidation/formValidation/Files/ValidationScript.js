var myApp = angular.module("validateModule", [])
    .controller("validateController", function ($scope, $http) {

        $http({
            method: 'GET',
            url: 'http://localhost:58646/api/getinfo'
        }).then(function successCallback(response) {
            $scope.employees = response.data
            $log.info(response)
        }, function errorCallback(response) {
            console.log("Error occured,please check")
        }).catch(function (except) {
            console.log('Error message: ', except);
            throw except;
        });

        $scope.addDetails = function (emp) {
            try {
                $http({
                    method: 'Post',
                    url: 'http://localhost:58646/api/postInfo',
                    data: emp
                }).then(function successCallbac(response) {
                    $scope.employees = response.data
                }, function errorCallback(response) {
                    $scope.error = reason.data;
                    console.log("Error occured,please check")
                })
                throw new Error("An Exception Occured");
            }
            catch (except) {
                $exceptionHandler(except.message, " : Button was Pressed");
            }
        };

    });