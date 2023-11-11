function megjelenitKod() {
    // Az elem kódjának lekérése
    var valasztottElem = document.getElementById("elemValaszto");
    var elemKodja = valasztottElem.value;

    // Az elem kódjának megjelenítése a HTML oldalon
    var kodMegjelenito = document.getElementById("kodMegjelenito");
    kodMegjelenito.innerHTML = "A kiválasztott elem kódja: " + elemKodja;
}