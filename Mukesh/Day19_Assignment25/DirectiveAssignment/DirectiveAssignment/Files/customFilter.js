myApp.filter("caseFilter", function () {
    return function (Name) {
        if (Name != null)
            Name = Name.toLowerCase();
        return Name.substring(0, 1).toUpperCase() + Name.substring(1);
    }
});