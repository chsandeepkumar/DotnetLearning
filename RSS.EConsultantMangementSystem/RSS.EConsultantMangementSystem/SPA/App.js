var app = angular.module('App', ['ngRoute']);
app.controller('Maincontroller', Maincontroller);
App.controller('RegistrationController', RegistrationController);

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when('/Registration', {
            templateUrl: 'SPA/Views/Registration.html',
            controller: RegistrationController
        })
       .otherwise({
           redirectTo: function () {
               return '/Registration';
           }
       });
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

App.config(configFunction);
