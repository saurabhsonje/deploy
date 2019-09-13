var app = angular.module("Students", ["ngRoute"]);

//config function for add multiple pages in SPA

app.config(function ($routeProvider) {
    $routeProvider

        .when("/Add-Student", {
            templateUrl: "AddStudent.html",
            controller: "addStudentCntrl"
        })

        .when("/Edit-Student", {
            templateUrl: "EditStudent.html",
            controller: "editStudentCntrl"
        });
});


app.controller('StudentCntrl', function ($scope) {

    $scope.StudentData = [{ "ID": 1, "Name": "Tau", "Branch": "Computer" }]

    $scope.BindSelectData = function (E) {
        $scope.ID = E.ID;
        $scope.Name = E.Name;
        $scope.Branch = E.Branch;
        $scope.stdModel = E;
    }

});

//controller for Add Student into table
app.controller('addStudentCntrl', function ($scope) {
    $scope.addStudent = function () {
        var student = [];
        student.ID = $scope.StudentData.length + 1,
            student.Name = $scope.Name;
        student.Branch = $scope.Branch;

        $scope.StudentData.push(student);

        $scope.Name = null;
        $scope.Branch = null;
    }
});


//controller for edit Student information
app.controller('editStudentCntrl', function ($scope) {
    $scope.editStudent = function (E) {
        if (E.ID == $scope.ID) {
            E.Name = $scope.Name;
            E.Branch = $scope.Branch;
        }

    }

    $scope.deleteStudent = function (E) {
        if (E.ID == $scope.ID) {
            E.Name = null;
            E.Branch = null;
        }
        $scope.StudentData.pop(E);
    }
});