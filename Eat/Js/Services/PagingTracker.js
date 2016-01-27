angular.module("app")
    .factory("PagingTracker", ["PagingInfo", function (PagingInfo) {

        var cache = {};

        return {

            init: function (id) {
                if (!cache[id]) {
                    cache[id] = new PagingInfo();
                }
                return cache[id];
            }

        }

    }]);