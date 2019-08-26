var app = angular.module('appServices', []);

app.controller("angularController", function ($scope, $http, $log) {

    $scope.AddEmployee = function (emp) {

        emp.Id = $scope.employees.length + 1;

        $http({

            method: 'Post',
            url: 'http://localhost:53497/api/home/EmployeeInfo',
            data: emp
        })
            .then(function (response) {
                $scope.employees = response.data;
                $log.info(response);
                $scope.GetEmpInfo();
            }, function (reason) {
                $scope.error = reason.data;
                $log.info(reason);
            })
            .catch(function (e) {
                console.log('Error: ', e);
                throw e;
            });

    };


    $scope.GetEmpInfo = function () {
        $http({

            method: 'Get',
            url: 'http://localhost:53497/api/home/GetInfo'
        })
        .then(function (response) {
            $scope.employees = response.data;

            $log.info($scope.employees);
        }, function (reason) {
            $scope.error = reason.data;
            $log.info(reason);
        });


    }

});

