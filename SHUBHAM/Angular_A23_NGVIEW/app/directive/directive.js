app.directive('ngStudent', function () {
    return { template: '<div><input type="text" ng-model="firstName" placeholder="Enter Name""/><br><input type="submit" ng-click="getValue()"/></div>' };
});
