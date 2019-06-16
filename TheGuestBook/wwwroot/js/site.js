// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function addOneLike(id) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            document.getElementById("NumberOfLikes" + id).firstElementChild.innerHTML = this.responseText;
            happyButton(id);
        }
    };
    xhttp.open("GET", "Messages/IncrementLikes?id=" + id, true);
    xhttp.send();
}

function happyButton(id) {
    var likeButton = document.getElementById("NumberOfLikes" + id);
    var likeButtonImg = likeButton.getElementsByTagName("img")[0];
    likeButtonImg.src = "../images/very-happy.png";
}
