var app = angular.module("Myapp", []);

app.controller("Mycontroller", function ($scope, $http, $log) {

    $scope.AddEmployee = function (emp) {

        emp.Id = $scope.employees.length + 1;

        $http({

            method: 'Post',
            url: 'http://localhost:64329/api/Home/EmployeeInfo',
            data: emp
        })
        .then(function (response) {
            $scope.employees = response.data;
            $log.info(response);
            $scope.GetEmpInfo();
            $scope.EmployeeData.Location = '';
            $scope.EmployeeData.Name = '';
            $scope.EmployeeData.Salary = '';
        }, function (reason) {
            $scope.error = reason.data;
            $log.info(reason);
        });


    };


    $scope.GetEmpInfo = function () {
        $http({

            method: 'Get',
            url: 'http://localhost:64329/api/Home/GetInfo'
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


