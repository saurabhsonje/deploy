app.directive('ngGuru', function ()
{
    return {
        template: '<span>{{ firstName | customfilter }}' + ' ' +'{{ lastName | customfilter}}</span>'
    }

});