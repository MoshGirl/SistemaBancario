$(document).ready(function () {
    $("#btnShow").mousedown(function () {
        $("#Senha").attr("type", "text");
    });

    $("#btnShow").on("mouseleave", function () {
        $("#Senha").attr("type", "password")
    });
    $("#senha2").mousedown(function () {
        $("#Senha").attr("type", "text");
    });

    $("#senha2").on("mouseleave", function () {
        $("#Senha").attr("type", "password")
    });
});
