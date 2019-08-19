app.controller('studentController', function ($scope)
{
    $scope.firstName = '';
    $scope.firstNameList = ['KK','JJ','LL'];
    $scope.getValue = function()
    {

        if ($scope.firstName == undefined || $scope.firstName == "" || !isNaN($scope.firstName))
            alert('ENTER VALID DATA');
        else {

            $scope.firstNameList.push($scope.firstName.toUpperCase());
            alert('NAME ADDED SUCCESSFULLY');
        }
      
    }
});



