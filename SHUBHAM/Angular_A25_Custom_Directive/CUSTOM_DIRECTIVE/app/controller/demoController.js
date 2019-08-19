app.controller('DemoController', function ($scope) {

    $scope.firstName = '';
    $scope.lastName = '';
    $scope.isVisible = false;

    $scope.show = function () {
        if ($scope.isVisible)
            $scope.isVisible = false;
        else
            $scope.isVisible = true;
    }
});
