var app = angular.module('student', []);

app.controller('studentCntr', function ($scope, $http,$window,$location) {
    

    $http({
            method: 'get',
            url: 'http://localhost:56983/api/Values'
           
            
        }).then(function successCallback(response) {
            $scope.Student_list = response.data;
            console.log(response.data);
           
            
        }, function errorCallback(response) {
            $scope.error = response.statusText;
        });

    $scope.AddStudio = function (Studio) {
        $http({
            url: 'http://localhost:56983/api/Values',
            method: 'post',
            data: Studio
        }).then(function successCallback(response) {
            $scope.studios = response.data;
            window.location.reload();
            
        }, function errorCallback(response) {
            $scope.error = response.statusText;
        });

    }

}
);