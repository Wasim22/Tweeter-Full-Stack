var app = angular.module("myApp", ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/', {
        controller: 'Main',
        templateUrl: 'views/Main.html'
    })
    .when('/view/:id', {
        controller: 'ViewTweets',
        templateUrl: 'views/Tweets.html'
    })
    .when('/login', {
        controller: 'LoginPage',
        templateUrl: 'views/Login.html'
    })
    .when('/signup', {
        controller: 'SignupPage',
        templateUrl: 'views/Signup.html'
    })
    .when('/account', {
        controller: 'Account',
        templateUrl: 'views/AccountHome.html'
    })
    .otherwise({ redirecTo: '/' })
}]);

//app.controller('ViewController', function ($scope, $routeParams) {
//    $scope.MyId = $routeParams.id;
//});