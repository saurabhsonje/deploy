angular.module('formExample', [])
    .controller('FormController', ['$scope', function ($scope) {
        $scope.userType = 'guest';
        $scope.setpristine = function () {
            $scope.userType = 'guest';
            if ($scope.myform.$dirty) {
                $scope.myForm.$setPristine();
            }
            $scope.re = /^[a-zA-Z]\w{3,14}$/; 
        };
    }]);