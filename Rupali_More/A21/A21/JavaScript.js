var app = angular.module('myapp', [])
app.controller("myCtrl", function ($scope) {
    $scope.EmployeeFirstName = "Rupali",
        $scope.EmployeeMiddleName = "Madhukar",
        $scope.EmployeeLastName = "More"
    $scope.changeInfo = function () {
        $scope.EmployeeFirstName = "Seema",
            $scope.EmployeeMiddleName = "ram",
            $scope.EmployeeLastName = "Pande"
    }

});
