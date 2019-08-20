var app = angular.module("MainApp", [])
app.controller("ChangeText", function ($scope) {
    $scope.FirstName = "Pooja",
        $scope.LastName = "Yerva",
        $scope.Gender = "Female"
    $scope.Change = function () {
        $scope.FirstName = "Rupali",
            $scope.LastName = "More",
            $scope.Gender = "Female"
    }
});

