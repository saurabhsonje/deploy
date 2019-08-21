var app = angular.module("myApp", []);

app.controller("MyController", function ($scope, $window) {
    $scope.myValue = false;

    $scope.ShowForm = function () {
        $scope.myValue = true;
    };


    $scope.Customers = [
        { FirstName: "John", LastName: "More", MobNo: "87654324423" },
        { FirstName: "Mudassar", LastName: "Desai", MobNo: "5648728324" },
        { FirstName: "Suzanne", LastName: "Patil", MobNo: "57864589" },
        { FirstName: "Robert", LastName: "Deshmukh", MobNo: "65438788" }
    ];

    $scope.Add = function () {
        //Add the new item to the Array.
        var customer = {};


        customer.FirstName = $scope.FirstName;
        customer.LastName = $scope.LastName;
        customer.MobNo = $scope.MobNo;
        $scope.Customers.push(customer);

        //Clear the TextBoxes.
        $scope.FirstName = "";
        $scope.LastName = "";
        $scope.MobNo = "";
        $scope.myValue = false;
    };

    $scope.Remove = function (index) {
        //Find the record using Index from Array.
        var name = $scope.Customers[index].FirstName;
        if ($window.confirm("Do you want to delete: " + name)) {
            //Remove the item from Array using Index.
            $scope.Customers.splice(index, 1);
        }
    }
});