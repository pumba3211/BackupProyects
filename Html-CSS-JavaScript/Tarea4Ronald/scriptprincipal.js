$(document).on("ready", configurarApp);

function configurarApp() {
    var canvas = document.getElementById("miprimercanvas");
    var ctx = canvas.getContext("2d");
    canvas.width = screen.availWidth;
}

function dibujarFooter(canvas, contexto) {
    contexto.moveTo(0, 0);
    contexto.quadraticCurveTo(0, 0, canvas.width, canvas.height);
    contexto.stroke();
}
