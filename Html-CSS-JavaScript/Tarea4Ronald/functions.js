var datos;

function cambiarparrafo() {
    datos = document.getElementById('parrafo').innerHTML;
    document.getElementById('parrafo').innerHTML = '<p>Hola como estas</p>';

}

function recambiarparrafo() {
    document.getElementById('parrafo').innerHTML = datos;
}