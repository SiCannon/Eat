angular.module("app")
    .controller("FoodListCtrl", ["$scope", "FoodService",
        function ($scope, FoodService) {

            $scope.noData = function () { return $scope.foods != null && $scope.foods.length == 0; }
            $scope.loading = true;

            FoodService.query(function (data) {
                $scope.foods = data;
                $scope.loading = false;
            });

        }]);