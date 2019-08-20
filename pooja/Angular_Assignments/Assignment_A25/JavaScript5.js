var app = angular.module("MyAppDemo", []);

app.controller("MyCtrlDemo", function ($scope) {

    $scope.Customers = [
        { "FirstName": "Pooja", "LastName": "yerva", "Gender": "Female" },
        { "FirstName": "rups", "LastName": "more", "Gender": "Female" },

    ];

    $scope.myvalue = false;

    $scope.ShowFullName = function () {
        if ($scope.myvalue) {
            $scope.myvalue = false;
        }
        else {
            $scope.myvalue = true;
        }
        
    }

    $scope.AddCustomer = function () {

        

        if ($scope.firstName != undefined && $scope.lastName != undefined && $scope.gender != undefined) {
            var customer = [];
            customer.FirstName = $scope.firstName;
            customer.LastName = $scope.lastName;
            customer.Gender = $scope.gender;

            $scope.Customers.push(customer);

            // CLEAR TEXTBOX.
            $scope.firstName = null;
            $scope.lastName = null;
            $scope.gender = null;
           
          
        }
    };

    
});

app.filter('CustomFilter', function () {
    return function (input) {
        return (angular.isString(input) && input.length > 0) ?
            input.charAt(0).toUpperCase() + input.substr(1).toLowerCase() : input;
    }
});



app.directive('ngCustom', function () {

    return {

        template: '{{ firstName | CustomFilter }}' + ' ' + '{{ lastName | CustomFilter}}'

    }
});
