app.controller('Main', function ($scope, $location) {
    $scope.login = function () {
        $location.path('/login');
    };

    $scope.signup = function () {
        $location.path('/signup');
    };

});
