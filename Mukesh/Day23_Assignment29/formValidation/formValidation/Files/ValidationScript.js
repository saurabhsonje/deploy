var myApp = angular.module("validateModule", [])
    .controller("validateController", function ($scope) {

        $scope.userName = ""
        $scope.email = ""
        $scope.password = ""
        $scope.confirmPassword = ""
        $scope.phone = ""
        $scope.employees = [{ userName: "Rakesh", email: "R@r.com", password: "RJ98uik", confirmPassword: "RJ98uik", phone: "8973765309" }]

        $scope.addDetails = function () {
            $scope.employees.push({userName: $scope.userName, email: $scope.email, password: $scope.password, confirmPassword: $scope.password, phone: $scope.phone})
        };
    });