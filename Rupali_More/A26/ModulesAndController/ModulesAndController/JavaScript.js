var Addition = angular.module('Addition', []);
Addition.controller('additioncntrl', function ($scope) {
    $scope.a = 10;
    $scope.b = 10;
    $scope.c = $scope.a + $scope.b;
});


var subtraction = angular.module('subtraction', []);
subtraction.controller('subtractioncntrl', function ($scope) {
    $scope.a1 = 20;
    $scope.b1 = 10;
    $scope.d = $scope.a1 - $scope.b1;
});


angular.module("CombineModule", ["Addition", "subtraction"]);
