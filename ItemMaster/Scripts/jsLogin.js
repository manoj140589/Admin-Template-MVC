$(document).ready(function () {
    $(".preloader").fadeOut();
});

$("#btnLogin").bind("click", function () {
    alert("Login done");
    window.location.href = "Home";
});