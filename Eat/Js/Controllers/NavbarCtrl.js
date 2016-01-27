angular.module("app")
    .controller("NavbarCtrl", ["$scope", "$rootScope", function ($scope, $rootScope) {
        $scope.root = "";
        $rootScope.$on("$routeChangeSuccess", function (angularEvent, current, previous) {
            if (current.loadedTemplateUrl) {
                $scope.root = current.loadedTemplateUrl.split("/")[0];
            }
            else {
                $scope.root = "";
            }
        });
    }]);