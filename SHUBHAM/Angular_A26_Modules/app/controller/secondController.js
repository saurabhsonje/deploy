secondModule.controller('secondController', function ($scope, $rootScope) {

    firstInput = '';
    secondInput = '';

    $rootScope.setValues = function (firstInput, secondInput) {
        this.firstInput = firstInput;
        this.secondInput = secondInput;
    }

    $scope.Addition = function () {
        alert(parseInt(this.firstInput) + parseInt(this.secondInput));
    }

    $scope.Subtraction = function () {
        alert(parseInt(this.firstInput) - parseInt(this.secondInput));
    }
});