//userService.js
espApp.factory("UserService", ["$http", "$q", function UserService($http, $q) {

    var _isInit = false;

    var _isReady = function () {
        return _isInit;
    }

    var _getUserLogon = function () {
        var deferred = $q.defer();
        $http.get("api/User/GetLogonUser").then(
        function (result) {
            var data = result.data;
            _isInit = true;
            deferred.resolve(data);
        },
        function () {
            deferred.reject();
        });

        return deferred.promise;            
    };


    

    return {
        getUserLogon: _getUserLogon,
        isReady: _isReady
    };

}])