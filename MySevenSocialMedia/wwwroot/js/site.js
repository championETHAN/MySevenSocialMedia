// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ShowPasswordFunction() {
    var x = document.getElementById("PasswordInput");
    var y = document.getElementById("ConfirmPasswordInput");
    if (x.type === "password" || y.type === "password") {
        x.type = "text"
        y.type = "text";
    } else {
        x.type = "password"
        y.type = "password"            ;
    }
}