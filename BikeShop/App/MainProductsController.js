(function () {

    var app = angular.module("productsViewer", []);

    var mainProductsController = function ($scope, $http) {
        $scope.message = "Hello Angular";

        var onProductsReceived = function (response) {
            $scope.products = response.data;
        };

        var onProductsReceiveError = function () {
            $scope.error = "Could not get the product.";
        }

        $http.get("/api/products").then(onProductsReceived, onProductsReceiveError);


        $scope.searchButtonClicked = function () {
            console.log("Search button clicked");
        };

    };
    //app.controller("mainProductsController", mainProductsController);

    //To make minification work, we change the above line to following

    app.controller("mainProductsController", ["$scope", "$http", mainProductsController]);

}());
