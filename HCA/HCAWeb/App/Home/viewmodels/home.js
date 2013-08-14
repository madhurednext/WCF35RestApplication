define(function () {
    var vm = {
        activate: activate,
        title: 'Home View'
    };

    return vm;

    //#region Internal Methods
    function activate() {
        alert('Home View Activated ' + 'home');
        return true;
    }
    //#endregion
});