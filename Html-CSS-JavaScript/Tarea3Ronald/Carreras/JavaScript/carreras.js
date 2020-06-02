var carreraeditar;

function cargarCarreras() {
    $.post('PHP/consultarcarreras.php', function (data) {
        var tabla = "<table id='carreras' class='table'><tr><td><strong>Codigo Carrera</strong></td><td><strong>Nombre Carrera</strong></td><td><strong>Eliminar</strong></td><td><strong>Editar</strong></td></tr>";
        for (var i = 0; i < data.length; i++) {
            tabla += "<tr><td>" + data[i].codigo_carrera + "</td><td>" + data[i].nombre_carrera + "</td>";
            tabla += "<td><button class='eliminar ' data-carreraeliminar=" + data[i].codigo_carrera + ">Eliminar</button></td>";
            tabla += "<td><button class='editar' data-carreraeditar=" + data[i].codigo_carrera + ">Editar</button></td></tr>";
        }
        tabla += "</table>";
        document.getElementById('carreras').innerHTML = tabla;
        $(".eliminar").click(function () {
            var confirmacion = confirm("Desea borrar la carrera?");
            if (confirmacion) {
                var carrera = $(this).data('carreraeliminar');
                $.post('PHP/eliminarcarrera.php', "carrera=" + carrera, function (data) {
                    alert(data);
                    cargarCarreras();
                });
            }
        });
        $(".editar").click(function () {
            carreraeditar = $(this).data('carreraeditar');
            location.href = "editarcarrera.php?codigo_carrera=" + carreraeditar;
        });
    });
}


