firstModule.controller('firstController', function ($scope, $rootScope) {

    $scope.firstInput = '';
    $scope.secondInput = '';
    $scope.getValue = function () {
        $rootScope.setValues($scope.firstInput, $scope.secondInput);
    }
});