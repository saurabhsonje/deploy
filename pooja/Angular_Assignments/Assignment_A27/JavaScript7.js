var app = angular.module("MyAppDemo", ["ngRoute"]);


app.config(function ($routeProvider) {
    $routeProvider
      
        .when("/Add-Employee", {
            templateUrl: "Assignment7b.html",
            controller:"MyAddDemo"
        })
        
        .when("/Edit-Employee", {
            templateUrl: "Assignment7d.html",
            controller:"MyeditDemo"
        });
});




app.controller("MyDemo", function ($scope) {

    $scope.Employees = [
        { "Id": 1,"FirstName": "Pooja", "LastName": "yerva" },
        { "Id": 2, "FirstName": "rups", "LastName": "more" },
        { "Id": 3,"FirstName": "pra", "LastName": "vidap" },
        { "Id": 4,"FirstName": "raks", "LastName": "yerva" }
    ];

    $scope.BindSelectData = function (emp) {
        $scope.Id = emp.Id;
        $scope.firstname = emp.FirstName;
        $scope.lastname = emp.LastName;
        $scope.EmpModel = emp;
    }

});

app.controller("MyAddDemo", function ($scope) {
    $scope.AddEmployee = function () {
        if ($scope.firstname != undefined && $scope.lastname != undefined) {
            var employee = [];
            employee.Id = $scope.Employees.length + 1,  
            employee.FirstName = $scope.firstname;
            employee.LastName = $scope.lastname;

            $scope.Employees.push(employee);

            // CLEAR TEXTBOX.
            $scope.firstname = null;
            $scope.lastname = null;

        }

    };
});



app.controller("MyeditDemo", function ($scope) {

    $scope.EditEmployee = function (e) {

       
            if (e.Id == $scope.Id) {
                e.FirstName = $scope.firstname;
                e.LastName = $scope.lastname;
            }
      
 
    }

});
   