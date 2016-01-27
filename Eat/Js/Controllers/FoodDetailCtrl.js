angular.module("app")
    .constant("ControllerStateEnum", {
        Empty: "Empty",
        Loading: "Loading",
        GotData: "GotData",
        NotFound: "NotFound",
        Error: "Error"
    });

angular.module("app")
    .controller("FoodDetailCtrl", ["$scope", "$routeParams", "$location", "FoodService", "ControllerStateEnum",
        function ($scope, $routeParams, $location, FoodService, ControllerStateEnum) {

            $scope.isLoading = function () { return $scope.state == ControllerStateEnum.Loading; }
            $scope.isGotData = function () { return $scope.state == ControllerStateEnum.GotData; }
            $scope.isNotFound = function () { return $scope.state == ControllerStateEnum.NotFound; }
            $scope.isError = function () { return $scope.state == ControllerStateEnum.Error; }

            $scope.state = ControllerStateEnum.Loading;

            if ($routeParams.foodId == "new") {
                $scope.food = {};
                $scope.state = ControllerStateEnum.GotData;
            }
            else {
                FoodService.get($routeParams.foodId,
                    function (data) {
                        $scope.food = data;
                        $scope.state = ControllerStateEnum.GotData;
                    },
                    function (status) {
                        if (status == 404) {
                            $scope.state = ControllerStateEnum.NotFound;
                        }
                        else {
                            $scope.state = ControllerStateEnum.Error;
                        }
                    });
            }

            $scope.Submit = function (goback) {
                FoodService.save($scope.food, function () {
                    if (goback) {
                        $scope.GoBack();
                    }
                });
            }

            $scope.GoBack = function () {
                $location.path("/food");
            }

        }]);