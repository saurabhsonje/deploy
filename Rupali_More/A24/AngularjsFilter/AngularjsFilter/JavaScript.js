var app = angular.module("myApp", []);

app.filter('myFormat', function () {
    return function (FName) {
        var i, c, txt = "";
        for (i = 0; i < FName.length; i++) {
            c = FName[i];
            if (i== 0) {
                c = c.toUpperCase();
            }
            txt += c;
        }
        return txt;
    };
});

app.controller('mycontroller', function ($scope) {
    $scope.customers = [{ ID: "1", FName: "rupali", LName: "more", Salary: "564356", DOB: new Date("7/12/96") },
        { ID: "2", FName: "pooja", LName: "yerva", Salary: "655643", DOB: new Date("7/12/96") },
        { ID: "3", FName: "nilesh", LName: "more", Salary: "5646573", DOB: new Date("7/12/96") }];

   
    
    $scope.Add = function () {
        //Add the new item to the Array.
        var customer = {};
        customer.ID = $scope.ID
        customer.FName = $scope.FName;
        customer.LName = $scope.LName;
        customer.Salary = $scope.Salary;
        customer.DOB = $scope.DOB;

        $scope.customers.push(customer);

        //Clear the TextBoxes.
        $scope.ID = "";
        $scope.FName = "";
        $scope.LName = "";
        $scope.Salary = " ";
        $scope.DOB = " ";
      
    };
});

