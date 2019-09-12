myApp.directive("customDirective", function () {

    return {
        template: '<div>{{firstName}}' + ' ' + '{{lastName}}</div>',    
        restrict:'A'
    }
});