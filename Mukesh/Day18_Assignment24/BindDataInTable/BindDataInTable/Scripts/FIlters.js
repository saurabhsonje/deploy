
myApp.filter("caseFilter", function () {
    return function (lName)
        {
        if (lName != null)
            lName = lName.toLowerCase();
        return lName.substring(0, 1).toUpperCase() + lName.substring(1);
        }
});