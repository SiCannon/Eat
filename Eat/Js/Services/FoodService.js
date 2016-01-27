angular.module("app")
    .factory("FoodService", ["$http",
        function ($http) {
            return {

                query: function (success) {
                    $http.get("/api/food")//, { params: { pageNumber: pageNumber, pageSize: pageSize, searchText: searchText } })
                        .success(function (data) {
                            success(data);
                        });
                },

                get: function (id, success, error) {
                    $http.get("/api/food/" + id.toString())
                        .success(function (data) {
                            success(data);
                        })
                        .error(function (data, status) {
                            error(status);
                        });
                },

                save: function (food, success) {
                    $http.post("/api/food", food).success(success);
                }
            }

        }]);
