addApp.controller("addController", function ($scope, $rootScope) {
    $rootScope.firstNumber;
    $rootScope.secondNumber;
    
    $scope.addNumbers = function () {
        alert(parseFloat($rootScope.firstNumber) + parseFloat($rootScope.secondNumber))
    }

});