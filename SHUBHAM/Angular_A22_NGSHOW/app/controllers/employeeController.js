app.controller("employeeController",function($scope)
	{
            
                    $scope.IsVisible = false;
                    $scope.firstName ='';
                    $scope.lastName = '';
                    $scope.mobileNumber = '';
                    $scope.employees = [{firstName:'xyz',lastName:'qwe',mobileNumber:'1234567890'},
                                        {firstName:'yut',lastName:'klo',mobileNumber:'0987654321'}];
            
            
                    $scope.getValue = function()
                    {
                      if($scope.firstName == "" ||  $scope.lastName =="" || $scope.mobileNumber == "" )
                        {
                            $scope.IsVisible = false;
                            alert("ALL THE FIELDS ARE MANDATORY");
                        }    
                        else if(isNaN($scope.mobileNumber))
                        {
                        alert("MOBILE NUMBER MUST BE A NUMBER");
                        debugger
                        }else if($scope.mobileNumber.length !=10 )
                        {
                         alert("MOBILE NUMBER MUST BE OF 10 DIGITS");
                        }
                        else{

                            $scope.employees.push({ firstName :$scope.firstName , lastName : $scope.lastName, mobileNumber : $scope.mobileNumber});
                            alert('EMPLOYEE ADDED SUCCESSFULLY');
                            $scope.IsVisible = false;
                            $scope.firstName ='';
                            $scope.lastName = '';
							$scope.mobileNumber = '';
                             }
                       
                    } 
                         $scope.ShowHide = function(){
                         $scope.IsVisible = true;
                    }
	});
            