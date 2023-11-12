// Amikor az ablak görgetése megváltozik, ellenőrizzük, hogy megjelenítjük-e a gombot
window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    var scrollButton = document.getElementById("scrollBtn");

    if (document.body.scrollTop > 500 || document.documentElement.scrollTop > 500) {
        scrollButton.style.display = "block";
    } else {
        scrollButton.style.display = "none";
    }
}
    
function scrollToTop() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}
    