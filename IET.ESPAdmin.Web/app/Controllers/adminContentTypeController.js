// AdminContentTypeController.js
espApp.controller('AdminContentTypeController', ["$scope", "$filter", "ngTableParams", "$location", "ContentTypeService", "ModalService", "$log", "$window", function AdminContentTypeController($scope, $filter, ngTableParams, $location, ContentTypeService, ModalService, $log, $window) {
   
    //Getting the data 
    var data = ContentTypeService; 
    $scope.isBusy = false;

    //Check to see if data is already in cache
    if (ContentTypeService.isReady() == false) {
        $scope.isBusy = true;
        ContentTypeService.getContentType().then(
                function() {
                    // on success
                    ContentTypeActionTable(data.contenttypes);
                },
                function() {
                    // on error
                    alert('Error');
                })
            .then(function() {
                //finally call
                $scope.isBusy = false;
            });
    } else {
        ContentTypeActionTable(data.contenttypes);
    }

    $scope.alerts = [];
    function addAlert(type, title, content) {
        $scope.alerts.push(
            {
                "type": type,
                "title": title,
                "content": content
            }
        );
    }
    
    //  ContentTypeActionTable Table
        function ContentTypeActionTable(data) {
            $scope.ContentTypeActionTableParams = new ngTableParams({
                page: 1,            // show first page
                count: 10,          // count per page
                sorting: {
                    name: 'asc'     // initial sorting
                }
            }, {
                total: data.length, // length of data
                getData: function ($defer, params) {
                    // use build-in angular filter
                    var filteredData = params.filter() ?
                            $filter('filter')(data, params.filter()) :
                            data;

                    var orderedData = params.sorting() ?
                            $filter('orderBy')(filteredData, params.orderBy()) :
                            data;

                    params.total(orderedData.length); // set total for recalc pagination
                    $defer.resolve(orderedData.slice((params.page() - 1) * params.count(), params.page() * params.count()));
                }
            });
        };

        $scope.newContentType = {};

        $scope.addContentType = function () {
           
            ModalService.showModal({
                templateUrl: '/IETAdminManager/Template/Partials/addContentTypeModal.html',
                controller: "AddContentTypeController",
                inputs: {
                    title: "Add new content type"
                }
            }).then(function (modal) {
                modal.element.modal();
                modal.close.then(function (result) {
                    if (result.message) {
                        
                       // alert(result.message);
                    }
                    //$scope.complexResult = "Name: " + result.name + ", age: " + result.age;
                });
            });
        }
    

    //Saving Content Type
        function save(newContentType) {
            ContentTypeService.addContentType($scope.newContentType)
            .then(function () {
                //sucess
                $window.location = "#/adminContentTypeUtilities/Home";
                    },
            function () {
                //error
                alert('Could not save new Content Type');
            })
            .then(function () {
                //finally call
                $scope.isBusy = false;
            });
        };

        $scope.ContentTypeActionTableOnClick = function (contentType) {

            ModalService.showModal({
                templateUrl: '/IETAdminManager/Template/Partials/updateContentTypeModal.html',
                controller: "EditContentTypeController",
                inputs: {
                    title: "Update new content type",
                    contentType: contentType
                    //category: contentType.category,
                    //group : contentType.group,
                    //bookType: contentType.bookType
                }
            }).then(function (modal) {
                modal.element.modal();
                modal.close.then(function (result) {
                    if (result.message) {
                        //alert(result.message);
                    }
                    //$scope.complexResult = "Name: " + result.name + ", age: " + result.age;
                });
            });
        };

}]);