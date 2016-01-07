


//if (!window.console) window.console = {};
//if (!window.console.log) window.console.log = function () { };
//angular.module('ui.bootstrap.demo', ['ngAnimate', 'ui.bootstrap']);
//angular.module('ui.bootstrap.demo').controller('ProgressDemoCtrl', function ($scope) {
//    $scope.max = 200;

//    $scope.random = function () {
//        var value = Math.floor((Math.random() * 100) + 1);
//        var type;

//        if (value < 25) {
//            type = 'success';
//        } else if (value < 50) {
//            type = 'info';
//        } else if (value < 75) {
//            type = 'warning';
//        } else {
//            type = 'danger';
//        }

//        $scope.showWarning = (type === 'danger' || type === 'warning');

//        $scope.dynamic = value;
//        $scope.type = type;
//    };
//    $scope.random();

//    $scope.randomStacked = function () {
//        $scope.stacked = [];
//        var types = ['success', 'info', 'warning', 'danger'];

//        for (var i = 0, n = Math.floor((Math.random() * 4) + 1) ; i < n; i++) {
//            var index = Math.floor((Math.random() * 4));
//            $scope.stacked.push({
//                value: Math.floor((Math.random() * 30) + 1),
//                type: types[index]
//            });
//        }
//    };
//    $scope.randomStacked();
//});

//var data = [{ Id: 1, Category: "Definitions", Group: "Definitions", BookType: "Definitions" },
//            { Id: 2, Category: "Guidance Notes", Group: "GN", BookType: "GN1" },
//            { Id: 3, Category: "Guidance Notes", Group: "GN", BookType: "GN2" },
//            { Id: 4, Category: "Guidance Notes", Group: "GN", BookType: "GN3" },
//            { Id: 5, Category: "Guidance Notes", Group: "GN", BookType: "GN4" },
//            { Id: 6, Category: "Guidance Notes", Group: "GN", BookType: "GN5" },
//            { Id: 7, Category: "Guidance Notes", Group: "GN", BookType: "GN6" },
//            { Id: 8, Category: "Guidance Notes", Group: "GN", BookType: "GN7" },
//            { Id: 9, Category: "Guidance Notes", Group: "GN", BookType: "GN8" },
//            { Id: 10, Category: "Other Guidance", Group: "COMMENTARY", BookType: "COMMENTARY" },
//            { Id: 11, Category: "Other Guidance", Group: "EGBR", BookType: "EGBR" },
//            { Id: 12, Category: "Other Guidance", Group: "EIDG", BookType: "EIDG" },
//            { Id: 13, Category: "Other Guidance", Group: "OSG", BookType: "OSG" },
//            { Id: 14, Category: "Wiring Matters", Group: "WM", BookType: "WM" },
//            { Id: 15, Category: "Wiring Matters", Group: "WRD", BookType: "WRD" },
//            { Id: 16, Category: "Other Guidance", Group: "EGEML", BookType: "EGEML" },
//            { Id: 17, Category: "Other Guidance", Group: "EGFDA", BookType: "EGFDA" },
//            { Id: 18, Category: "Other Guidance", Group: "COPESM", BookType: "COPESM" },
//            { Id: 19, Category: "Other Guidance", Group: "COPLED", BookType: "COPLED" },
//            { Id: 20, Category: "Other Guidance", Group: "COPIIT", BookType: "COPIIT" },
//            { Id: 21, Category: "Other Guidance", Group: "ML", BookType: "ML" },
//            { Id: 22, Category: "Other Guidance", Group: "TPS", BookType: "TPS" },
//            { Id: 23, Category: "Other Guidance", Group: "EM", BookType: "EM" },
//            { Id: 24, Category: "Other Guidance", Group: "COPEVCE", BookType: "COPEVCE" },
//            { Id: 25, Category: "Other Guidance", Group: "COPLVD", BookType: "COPLVD" },
//            { Id: 26, Category: "Other Guidance", Group: "PSPV", BookType: "PSPV" },
//            { Id: 27, Category: "Other Guidance", Group: "PSLS", BookType: "PSLS" },
//            { Id: 28, Category: "Other Guidance", Group: "Student", BookType: "Student" }];

//$scope.message = {
//    "type": "info",
//    "title": "Hey!",
//    "content": " Welcome back. This alert is for 5 seconds"
//};

//$scope.successFn = function () {
//    $scope.message = {
//        "type": "success",
//        "title": "Success!",
//        "content": "This is success message"
//    }
//    console.log('changing message to ' + $scope.message.type);
//};

//$scope.warningFn = function () {
//    $scope.message = {
//        "type": "warning",
//        "title": "Warning!",
//        "content": "This is warning message"
//    }
//    console.log('changing message to ' + $scope.message.type);
//};

//$scope.errorFn = function () {
//    $scope.message = {
//        "type": "error",
//        "title": "Error!",
//        "content": "This is error message"
//    }
//    console.log('changing message to ' + $scope.message.type);
//};

