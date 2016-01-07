if (!window.console) window.console = {};
if (!window.console.log) window.console.log = function () { };

var espApp = angular.module('espApp', ['ngRoute', 'ngTable', 'ngAnimate', 'ui.bootstrap', 'angularModalService', 'chart.js']);

espApp.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/", {
            controller: "EspLandingPage",
            templateUrl: "/IETAdminManager/template/espLandingPage.html"
        })
        .when("/adminContentTypeUtilities/Home", {
            controller: "AdminContentTypeController",
            templateUrl: "/IETAdminManager/template/adminContentTypeUtilities.html"
        })
        .when("/esp/Reports", {
            controller: "EspReportController",
            templateUrl: "/IETAdminManager/template/espreports.html"
        })
        .when("/esp/espUsefulSites", {
            controller: "EspUsefulSitesController",
            templateUrl: "/IETAdminManager/template/espUsefulSites.html"
        })
        .otherwise({ redirectTo: "/" });

    $locationProvider.html5Mode({
        enabled: false,
        requireBase: false
    });
    //$locationProvider.hashPrefix('!');

}]);


