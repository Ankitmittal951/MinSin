/// <reference path="angular.min.js" />

var myApp = angular.module("myModule", []);


myApp.controller("mycontroller", function ($scope)
{
    $scope.message = "First Time";
})