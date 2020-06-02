carreraeditar = 1;

function cargarcarreraeditar() {
    $.post('PHP/cargarcarreraeditar.php', "codigo_carrera=" + carreraeditar, function (data) {
        var form = "<form id='editar' action='PHP/editarcarrera.php' method='post' accept-charset='utf-8'>";
        form += "<label>Codigo Carrera</label><br/><input type='text' name='codigo_carrera' value='" + data[0].codigo_carrera + "'/>";
        form += "<br/><label>Nombre Carrera</label><br/>";
        form += "<input type='text' name='nombre_carrera' value='" + data[0].nombre_carrera + "'/><br/><input type='submit'/></form>";
        document.getElementById('editar').innerHTML = form;
    });
}