angular.module('carsales')
.controller('carListCtrl', function ($scope, $http) {
    $http.get('http://localhost:52316/api/cars').then(function (response) {
        $scope.cars = JSON.parse(response.data)
    })  
})