angular.module('carsales')
.controller('carDetailCtrl', function ($scope, $state, $stateParams) {
    $scope.car = $scope.cars.filter(function (item) {
        return item.Id == $stateParams.id
    })[0]
})