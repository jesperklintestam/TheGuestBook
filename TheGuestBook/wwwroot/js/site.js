// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function addOneLike(id) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            document.getElementById("LikeElement" + id).getElementsByClassName("number-of-likes")[0].innerHTML = this.responseText;
            happyButton(id);
        }
    };
    xhttp.open("GET", "Messages/IncrementLikes?id=" + id, true);
    xhttp.send();
}

//function getNumberOfLikesData() {
//    var xhttp = new XMLHttpRequest();
//    xhttp.onreadystatechange = function () {
//        if (this.readyState === 4 && this.status === 200) {
//            return this;
//        }
//    };
//    xhttp.open("GET", "Messages/GetNumberOfLikes", true);
//    xhttp.send();
//}

//$(document).ready(function () {
//    getNumberOfLikesData();
//    console.log("loaded");
//    console.log(Object.keys(this).length);
//    for (var i = 0; i < this.response.length; i++) {
//        var message = this.response[i];
//        for (var numberOfLikes in message) {
//            if (numberOfLikes > 5) {
//                happyButton(id);
//            }

//        }
//    }
//});

function happyButton(id) {
    var likeButton = document.getElementById("LikeElement" + id);
    var likeButtonImg = likeButton.getElementsByTagName("img")[0];
    likeButtonImg.src = "../images/very-happy.png";
}
