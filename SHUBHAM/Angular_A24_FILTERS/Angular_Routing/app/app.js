var app = angular.module('demo', ['ngRoute']);

app.directive('ngStudent', function ()
{
    return
    {
            template: "<div> <input type='text' ng-model='' />" +
            +"<input type='text'  />" +
            +"<input type='button' value='Add Student' ng-click='getValues()'/>" +
            +"</div>"
    }
});


app.config(function ($routeProvider)
    {
          $routeProvider.when("/studentList", {
          templateUrl :"app/views/studentList.html"
    });
});
