app.controller('SignupPage', function ($scope, $http, $location) {
    $scope.SignupSubmit = function () {
        var userObj = {
            FName: $scope.Firstname,
            LName: $scope.Lastname,
            Username: $scope.Username,
            Password: $scope.Password
        };
        alert("Thank you for signing up, " + userObj.FName);

        //$scope.GetAll = function () {
        $http({ method: "POST", url: "/api/v1/Users", data: userObj })
           .success(function () {
               $location.path('/login');
           })
        //}
    };


});