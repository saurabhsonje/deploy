var Addition = angular.module('Addition', []);
Addition.controller('additioncntrl', function ($rootScope , $scope) {
    $rootScope.a ;
    $rootScope.b;
    $scope.Add = function () {
        $scope.c = $rootScope.a + $rootScope.b;
    };
});


var substraction = angular.module('substraction', []);
substraction.controller('substractioncntrl', function ($rootScope,$scope) {
    $scope.Sub = function () {
        $scope.d = $rootScope.a - $rootScope.b;
    };
});

var multiplication = angular.module('multiplication', []);
multiplication.controller('multiplicationcntrl', function ($rootScope, $scope)
{
    $scope.Mul = function () {
        $scope.e = $rootScope.a * $rootScope.b;
    };
    });



var Division = angular.module('Division', []);
Division.controller('Divisioncntrl', function ($rootScope, $scope) {
    $scope.Div = function () {
        $scope.f = $rootScope.a / $rootScope.b;
    };
});


var Mainapp = angular.module("CombineModule", ["Addition", "substraction", "multiplication","Division"]);
