app.controller('Account', function ($scope, $http) {

    // Greet user
    var Greet = function () {
        var User = JSON.parse(sessionStorage.getItem("0"));
        $scope.Username = User.FName;
    };

    // Display User List
    var DisplayUsers = function () {
        $http({ method: "GET", url: "/api/v1/Users" })
        .success(function (data) {
            $scope.Users = data;
        });
    };
    
    DisplayUsers();

    // Follow User
    $scope.Follow = function (Id) {
        var User = JSON.parse(sessionStorage.getItem("0"));
        var followObj = {
            UserId: User.Id,
            FollowId: Id
        };
        $http({ method: "POST", url: "/api/v1/Follow", data: followObj })
    };


    // Display Tweets
    var DisplayTweets = function () {
        var User = JSON.parse(sessionStorage.getItem("0"));
        $http({ method: "GET", url: "/api/v1/Tweets/" + User.Id })
            .success(function (data) {
                $scope.Tweets = data;
            });
    };

    DisplayTweets();

    // Submit Tweet
    $scope.SubmitTweet = function () {
        var User = JSON.parse(sessionStorage.getItem("0"));
        var tweetObj = {
            Message: $scope.Tweet,
            UserId: User.Id
        };
        $http({ method: "POST", url: "/api/v1/Tweets", data: tweetObj })
        .success(function () { DisplayTweets(); });
    };
});