window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    var scrollButton = document.getElementById("scrollBtn");

    if (document.body.scrollTop > 300 || document.documentElement.scrollTop > 300) {
        scrollButton.style.display = "block";
    } else {
        scrollButton.style.display = "none";
    }
}
    
function scrollToTop() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

document.addEventListener("DOMContentLoaded", function () {
    var loadingScreen = document.getElementById("loading-screen");
    loadingScreen.style.display = "none";
});
