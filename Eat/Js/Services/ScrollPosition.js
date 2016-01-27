angular.module("app")
    .factory("ScrollPosition", function () {

        var positions = {};

        return {

            get: function (id) {
                if (positions[id]) {

                }
                else {
                    return 0;
                }
            }

        };
    });