//landingPageTopLayerBarChartController.js
espApp.controller("LandingPageTopLayerBarChartController", function LandingPageTopLayerBarChartController($scope) {
    $scope.labels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
    $scope.series = ['Series A', 'Series B', 'Series C'];

    $scope.data = [
      [65, 59, 80, 81, 56, 55, 40],
      [28, 48, 40, 19, 86, 27, 90],
      [23, 38, 22, 55, 26, 27, 80]
    ];
});