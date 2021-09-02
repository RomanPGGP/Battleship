// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/GameHub").build();

document.getElementById("randomtab").addEventListener("click", function () {
    document.getElementById("findfriend").hidden = "hidden";
    document.getElementById("computerfriend").hidden = "hidden";
    document.getElementById("randomfriend").hidden = "";
});
document.getElementById("friendtab").addEventListener("click", function () {
    document.getElementById("findfriend").hidden = "";
    document.getElementById("computerfriend").hidden = "hidden";
    document.getElementById("randomfriend").hidden = "hidden";
});
document.getElementById("offlinetab").addEventListener("click", function () {
    document.getElementById("findfriend").hidden = "hidden";
    document.getElementById("computerfriend").hidden = "";
    document.getElementById("randomfriend").hidden = "hidden";
});

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("msg").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    //li.textContent = `${user} says ${message}`;
});

connection.start().then(function () {
    document.getElementById("conexionstatus").hidden = "";
    var user = document.getElementById("username").value;
    connection.invoke("ConnectedUser",user)
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("startButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    connection.invoke("SetUserName", user).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});