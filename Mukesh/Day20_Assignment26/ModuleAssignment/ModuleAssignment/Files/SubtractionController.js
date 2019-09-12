subApp.controller("subController", function ($scope, $rootScope) {
    $scope.subNumbers = function () {

        alert(parseInt($rootScope.secondNumber) - parseInt($rootScope.firstNumber))
    }
});