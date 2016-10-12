(function (angular) {
    'use strict';
    var myApp = angular.module('wtaio', []);

    myApp.controller('wtaioController', ['$scope', function ($scope) {
        $scope.getLocation = function () {
            alert("Woo");

        };
    }]);
})(window.angular);