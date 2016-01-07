//EditContentTypeController.js

espApp.controller('EditContentTypeController', ['$scope', '$element', 'title', 'contentType', 'close', 'ContentTypeService', function EditContentTypeController($scope, $element, title, contentType, close, ContentTypeService) {
    $scope.title = title;
    $scope.contentType = contentType;
      var message = null;
      //  This close function doesn't need to use jQuery or bootstrap, because
      //  the button has the 'data-dismiss' attribute.
      $scope.ok = function () {
          //Save new Content Type to database;
          ContentTypeService.updateContentType($scope.contentType)
          .then(function() {
              //sucess
                      message = 'saved successfuly';
          },
          function () {

              //message = 'Content type did not save!'

          })//Close the form and return control to the caller.
          .then(function() {
              close({
                  //category : $scope.category,
                  //group: $scope.group, 
                  //bookType : $scope.bookType
                  message: message

              }, 500); // close, but give 500ms for bootstrap to animate
          });
      };

      //  This cancel function must use the bootstrap, 'modal' function because
      //  the doesn't have the 'data-dismiss' attribute.
      $scope.cancel = function () {

          //  Manually hide the modal.
          $element.modal('hide');

          //  Now call close, returning control to the caller.
          close({
              //category: $scope.category,
              //group: $scope.group,
              //bookType: $scope.bookType
              message: 'Content type not saved'
          }, 500); // close, but give 500ms for bootstrap to animate
      };

  }]);