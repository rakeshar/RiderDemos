(function(app){
    var app = angular.module("employeeRoles", []);
    app.controller("addEmpRolesCtrl", function ($scope) {
        this.role = {
            roleName: "Rakesh",
            roleDesc: "Contra"
        };
    });
}(window));