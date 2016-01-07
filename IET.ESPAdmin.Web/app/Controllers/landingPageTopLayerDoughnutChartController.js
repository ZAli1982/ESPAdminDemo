//landingPageTopLayerDoughnutChartController.js
espApp.controller("LandingPageTopLayerDoughnutChartController", function LandingPageTopLayerDoughnutChartController($scope) {
    $scope.labels = ["Download Sales", "In-Store Sales", "Mail-Order Sales", "Internet Sales"];
    $scope.data = [300, 500, 100,100];
});