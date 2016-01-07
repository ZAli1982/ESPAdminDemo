//welcomeController.js
espApp.controller('WelcomeController', ['$scope', 'UserService', function WelcomeController($scope, UserService) {

    $scope.gettimeofday = getTimeOfDay();

    function getTimeOfDay() {

        var now = new Date();
        var hrs = now.getHours();
        var msg = "";

        if (hrs >= 0 && hrs < 12) {
            msg = "Good Morning";
        }
        else if (hrs >= 12 && hrs < 17) {
            msg = "Good Afternoon";
        }
        else if (hrs >= 17) {
            msg = "Good Evening";
        }

        return msg;

    }

    //Getting the current user log on 
    $scope.isBusy = false;
    //Check to see if data is already in cache
    if (UserService.isReady() == false) {
        $scope.isBusy = true;
        UserService.getUserLogon().then(
                function (data) {
                    // on success
                    LogonUser(data);
                    //alert('sucess');
                },
                function () {
                    // on error
                    alert('Error');
                })
            .then(function () {
                //finally call
                $scope.isBusy = false;
            });
    } else {
        
    }

    function LogonUser(data) {
        $scope.logonUser = data;
    }

}]);

