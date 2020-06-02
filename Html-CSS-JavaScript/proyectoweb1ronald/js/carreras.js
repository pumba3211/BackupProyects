function cargarcarreras() {
    var datos = JSON.parse(localStorage.getItem("carreras"));
    var html = "<table id=tabla class=table>";
    html += "<h2> Carreras</h2>";
    html += "<tr id=row0 style='background-color: #0099CC;color:white'>";
    html += "<td><strong>Codigo Carrera</strong></td>";
    html += "<td><strong>Nombre</strong></td>";
    html += "<td><strong>Editar</strong></td>";
    html += "<td><strong>Eliminar</strong></td>";
    html += "</tr>";
    for (var i = 0; i < datos.length; i++) {
        if (datos[i] == null) {

        }
        else {
            html += "<tr id=row" + (i + 1) + " style='color:#0099CC'>";
            html += "<td>" + datos[i].codigocarrera + "</td>";
            html += "<td>" + datos[i].nombre + "</td>";
            html += "<td><button class='buttonedit btn btn-warning' data-carreraeditar=" + datos[i].codigocarrera + ">Editar</button>"
            html += "<td><button class='buttondelete btn btn-danger' data-carreraborrar=" + datos[i].codigocarrera + ">Eliminar</button>"
        }
    }
    html = html + "</table>";
    document.getElementById('tabla').innerHTML = html;
}

function crearcarrera() {
    var nombre = document.getElementById('nombre').value;
    var codigo = document.getElementById('codigo').value;
    if (nombre == "" || nombre == " " || codigo == " " || codigo == "") {
        alert("escribe todos los datos por favor");
    }
    else {
        var carrera = {codigocarrera: codigo, nombre: nombre};
        var datos = JSON.parse(localStorage.getItem("carreras"));
        if (datos == null) {
            var arreglo = [];
            arreglo.push(carrera);
            localStorage.setItem("carreras", JSON.stringify(arreglo));
            location.href = "carreracreada.html";
        }
        else {
            var codigocarrerarepetido = false;
            for (var i = 0; i < datos.length; i++) {
                if (datos[i].codigocarrera == codigo) {
                    codigocarrerarepetido = true;
                }
            }
            if (codigocarrerarepetido) {
                alert("este codigo de carrera ya esta registrado");
            }
            else {
                datos.push(carrera);
                localStorage.setItem("carreras", JSON.stringify(datos));
                location.href = "carreracreada.html";
            }
        }
    }
}

function cargarcarreraborrar() {
    var dato = localStorage.getItem("carreradelete");
    document.getElementById("codigo").value = dato;
    localStorage.removeItem("carreradelete");
}

function eliminarcarrera() {
    var codigo = document.getElementById("codigo").value;
    if (codigo == "" || codigo == " ") {
        alert("no has escrito un codigo de carrera")
    }
    else {
        var datos = JSON.parse(localStorage.getItem("carreras"));
        var codigocarrerarepetido = false;
        for (var i = 0; i < datos.length; i++) {
            if (datos[i].codigocarrera == codigo) {
                codigocarrerarepetido = true;
            }
        }
        if (codigocarrerarepetido) {

            for (var i = 0; i < datos.length; i++) {
                if (codigo == datos[i].codigocarrera) {
                    datos[i] = null;
                }
            }
            var arreglo = [];
            for (var i = 0; i < datos.length; i++) {
                if (datos[i] == null) {

                }
                else {
                    arreglo.push(datos[i]);
                }
            }

            localStorage.setItem("carreras", JSON.stringify(arreglo));
            location.href = "carreraeliminada.html";

        }
        else {
            alert("el codigo de carrera no existe");
        }
    }
}

function cargarcarreraeditar() {
    var codigo = localStorage.getItem("carreraedit");
    var datos = JSON.parse(localStorage.getItem("carreras"));
    for (var i = 0; i < datos.length; i++) {
        if (codigo == datos[i].codigocarrera) {
            document.getElementById("codigo").value = datos[i].codigocarrera;
            document.getElementById("nombre").value = datos[i].nombre;
            break;
        }
    }
    localStorage.removeItem("carreraedit");
}

function editarcarrera() {
    var codigo = document.getElementById("codigo").value;
    var nombre = document.getElementById("nombre").value;
    var datos = JSON.parse(localStorage.getItem("carreras"));
    for (var i = 0; i < datos.length; i++) {
        if (codigo == datos[i].codigocarrera) {
            datos[i].nombre = nombre;
            break;
        }
    }
    localStorage.setItem("carreras", JSON.stringify(datos));
    location.href = "carreraeditada.html";
}

function usaurioOn() {
    var usuario = localStorage.getItem("usuarioOn");
    document.getElementById("userOn").innerHTML = "<p id=userOn style=color:white>" + usuario + "    <a href=login.html style=color:white>Salir</a></p>";

}

function prepareBinding() {
    //$( "#test_button" ).bind( "click", function() { my_alert('text 2');});
    $("#crearcarrera").click(function () {
        crearcarrera();
    });
    $(".buttonedit").click(function () {
        var carrera = $(this).data('carreraeditar');
        localStorage.setItem("carreraedit", carrera);
        location.href = "editarcarrera.html";
    });
    $(".buttondelete").click(function () {
        var carrera = $(this).data('carreraborrar');
        localStorage.setItem("carreradelete", carrera);
        location.href = "eliminarcarrera.html";
    });
    $("#eliminarcarrera").click(function () {
        eliminarcarrera();
    });
    $("#editarcarrera").click(function () {
        editarcarrera();
    });

}