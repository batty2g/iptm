(function() {
    'use strict';
var app = angular.module('iPushToMaster', []);

app.controller('FuckYouController', ['$scope', function($scope) {
    $scope.master = 'fucking';
    
    $scope.fuckYouMike = function () {
        $scope.master = 'fuck you mike';
    };
    
    $scope.fuckYouJames = function() {
        $scope.master = 'fuck you james';
    };
}]);
})();