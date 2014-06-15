app.controller('LoginPage', function ($scope, $http, $location) {
    $scope.Login = function () {
        var userObj = {
            Username: $scope.Username,
            Password: $scope.Password
        };

        //$scope.Submit = function () {
            $http({ method: "POST", url: "/api/v1/Login", data: userObj })
            .success(function (data) {
                alert("Welcome " + data.FName);
                $location.path('/account');
                sessionStorage.setItem(0, JSON.stringify(data));
            })
            .error(function () {
                alert("Not Authorize, bro");
            })
        //}

    };
});