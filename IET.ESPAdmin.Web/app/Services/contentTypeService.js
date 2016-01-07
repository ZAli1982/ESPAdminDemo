//contentTypeService.js
espApp.factory("ContentTypeService", ["$http", "$q", function ContentTypeService($http, $q) {

    var _contenttypes = [];
    var _isInit = false;

    var _isReady = function () {
        return _isInit;
    }

    var _getContentType = function () {
        var deferred = $q.defer();
        $http.get("api/ContentTypes").then(
        function (result) {
            angular.copy(result.data, _contenttypes);
            _isInit = true;
            deferred.resolve();
        },
        function () {
            deferred.reject();
        });

        return deferred.promise;            
    };


    var _addContentType = function (newContentType) {
        var deferred = $q.defer();
        $http.post("api/ContentTypes", newContentType).then(
        function (result) {
            var newlyCreatedContentType = result.data;
            //Add to the array
            // first param is position, sec param is if you want to delete that position item, third param to add new object
            _contenttypes.splice(0, 0, newlyCreatedContentType);
            deferred.resolve(newlyCreatedContentType);
        },
        function () {
            deferred.reject();
        });

        return deferred.promise;
    };

    var _updateContentType = function (ContentType) {
        var deferred = $q.defer();
        $http.put("api/ContentTypes", ContentType).then(
        function (result) {
            var updatedContentType = result.data;
            //Add to the array
            // first param is position, sec param is if you want to delete that position item, third param to add new object
           // _contenttypes.splice(0, 0, newlyCreatedContentType);
            deferred.resolve(updatedContentType);
        },
        function () {
            deferred.reject();
        });

        return deferred.promise;
    };

    return {
        contenttypes : _contenttypes ,
        getContentType: _getContentType,
        addContentType: _addContentType,
        updateContentType: _updateContentType,
        isReady: _isReady
    };

}])