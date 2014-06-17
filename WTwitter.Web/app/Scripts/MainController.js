//app.controller('Main', function ($scope, $location) {
//    $scope.login = function () {
//        $location.path('/login');
//    };

//    $scope.signup = function () {
//        $location.path('/signup');
//    };

//});

app.controller('Main', function ($scope, $http, $location) {
    $scope.Login = function () {
        var userObj = {
            Username: $scope.username,
            Password: $scope.password
        };

        $http({ method: "POST", url: "/api/v1/Login", data: userObj })
        .success(function (data) {
            alert("Welcome " + data.FName);
            $location.path('/account');
            sessionStorage.setItem(0, JSON.stringify(data));
        })
        .error(function () {
            alert("Login failed. Try again.");
        })

    };

    $scope.SignupSubmit = function () {
        var userObj = {
            FName: $scope.Firstname,
            LName: $scope.Lastname,
            Username: $scope.Username,
            Password: $scope.Password
        };
        alert("Thank you for signing up, " + userObj.FName);

        $http({ method: "POST", url: "/api/v1/Users", data: userObj })
           .success(function () {
               $location.path('/login');
           })
    };
});