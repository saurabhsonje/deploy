app.controller('studentController', function($scope) 
	{
                   $scope.firstName = "XYZ";
                   $scope.lastName = "IOP";
               
                 $scope.Change = function() {
                       $scope.firstName = 'ABC';
                       $scope.lastName = 'HJK';
    };
});