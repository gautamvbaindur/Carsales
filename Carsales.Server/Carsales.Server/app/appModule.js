angular.module('carsales', [
    'ui.router', 'angular.filter'
])
    .config(['$stateProvider',
    function ($stateProvider) {
        $stateProvider
          .state('cars', {
              url: '/cars',
              templateUrl: 'carList.html',
              controller: 'carListCtrl'
          })
          .state('cars.detail', {
              url: '/:id',
              views: {
                  'detail': {
                      templateUrl: 'carDetail.html',
                      controller: 'carDetailCtrl'
                  }
              },
          })
    }
    ])
    .config(['$urlRouterProvider',
        function ($urlRouterProvider) {
            $urlRouterProvider.otherwise('/cars');
        }
])