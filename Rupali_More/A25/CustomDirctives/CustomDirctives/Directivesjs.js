var app = angular.module('myapp', []);
app.controller('mycontroller', function ($scope) {
    $scope.FirstName ='';
    $scope.LastName = '';

    
});
app.directive('ngGuru', function () {
    return {
        template: '{{ FirstName }}'+ ' '+'{{ LastName }} '
    };
});