// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("randomtab").addEventListener("click", function () {
    document.getElementById("findfriend").hidden = "hidden";
    document.getElementById("computerfriend").hidden = "hidden";
    document.getElementById("randomfriend").hidden = "";
})
document.getElementById("friendtab").addEventListener("click", function () {
    document.getElementById("findfriend").hidden = "";
    document.getElementById("computerfriend").hidden = "hidden";
    document.getElementById("randomfriend").hidden = "hidden";
})
document.getElementById("offlinetab").addEventListener("click", function () {
    document.getElementById("findfriend").hidden = "hidden";
    document.getElementById("computerfriend").hidden = "";
    document.getElementById("randomfriend").hidden = "hidden";
})
document.getElementsById("gb").addEventListener("click", function () {
    document.getElementById("shipicon").hidden = "";
})