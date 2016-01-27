angular.module("app", ["ngRoute", "ngResource"])

    .config(['$routeProvider',
        function ($routeProvider) {
            $routeProvider.
                when('/food', {
                    templateUrl: 'Food/List',
                    controller: 'FoodListCtrl'
                }).
                when('/food/:foodId', {
                    templateUrl: 'Food/Detail',
                    controller: 'FoodDetailCtrl'
                }).
                otherwise({
                    redirectTo: '/food'
                });
        }]);