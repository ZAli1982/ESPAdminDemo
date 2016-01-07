//carouselController.js
//angular.module('ui.bootstrap.demo', ['ngAnimate', 'ui.bootstrap']);
espApp.controller('CarouselController', function CarouselController($scope) {
    $scope.myInterval = 5000;
    $scope.noWrapSlides = false;
    var slides = $scope.slides = [];
    $scope.addSlide = function () {
        //var newWidth = 600 + slides.length + 1;
        var newWidth = slides.length + 1;
        slides.push({
            //image: '//placekitten.com/' + newWidth + '/300',
            image: 'Image/img' + newWidth +'.jpg',//placekitten.com/' + newWidth + '/300',
            text: ['Text1', 'Text2', 'Text3', 'Text4'][slides.length % 4] + ' ' +
              ['Text5', 'Text6', 'Text7', 'Text8'][slides.length % 4]
        });
    };
    for (var i = 0; i < 5; i++) {
        $scope.addSlide();
    }
});
