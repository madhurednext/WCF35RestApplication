define(function () {
    var vm = {
        activate: activate,
        title: 'In Home View'
    };

    return vm;

    //#region Internal Methods
    function activate() {
        alert('In Home View Activated ' + 'In home');
        return true;
    }
    //#endregion
});