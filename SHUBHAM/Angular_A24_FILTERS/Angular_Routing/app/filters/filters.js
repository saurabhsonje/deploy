app.filter('customfilter', function ()
{
    return function (inputString)
    {
        var afterSlicingFirstCharacter = inputString.slice(1);
        var gettingCapitalCharacter = String.fromCharCode(inputString.charCodeAt(0) - 32);
        return gettingCapitalCharacter + afterSlicingFirstCharacter;
    }
});


app.filter('salaryInRs', function ()
{
        return function (inputString)
        {
            return 'Rs '.concat(inputString);
        }
});