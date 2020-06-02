function cargarEstudiantes() {
    var datos = JSON.parse(localStorage.getItem("estudiantes"));
    var carreras = JSON.parse(localStorage.getItem("carreras"));
    var html = "<table id=tabla class=table>";
    html += "<h2> Estudiantes</h2>";
    html += "<tr id=row0 style='background-color: #0099CC;color:white'>";
    html += "<td><strong>Cedula o Carnet</strong></td>";
    html += "<td><strong>Nombre</strong></td>";
    html += "<td><strong>Apellidos</strong></td>";
    html += "<td><strong>Carrera</strong></td>";
    html += "<td><strong>Nivel de Ingles</strong></td>";
    html += "<td><strong>Editar</strong></td>";
    html += "<td><strong>Eliminar</strong></td>";
    html += "<td><strong>Foto</strong></td>";
    html += "</tr>";
    for (var i = 0; i < datos.length; i++) {
        if (datos[i] == null) {

        }
        else {
            html += "<tr id=row" + (i + 1) + " style='color:#0099CC'>";
            html += "<td>" + datos[i].cedulaocarnet + "</td>";
            html += "<td>" + datos[i].nombre + "</td>";
            html += "<td>" + datos[i].apellidos + "</td>";

            for (var j = 0; j < carreras.length; j++) {
                if (datos[i].carrera == carreras[j].codigocarrera) {
                    html += "<td>" + carreras[j].nombre + "</td>";
                }
                else {
                    console.log("jaja no era");
                }
            }

            html += "<td>" + datos[i].ningles + "</td>";
            html += "<td><button class='buttonedit btn btn-warning' data-estudianteeditar=" + datos[i].cedulaocarnet + ">Editar</button>"
            html += "<td><button class='buttondelete btn btn-danger' data-estudianteborrar=" + datos[i].cedulaocarnet + ">Eliminar</button>"
            html += "<td><img src='Recursos/foto.jpg' width='50' heigt='50'/></td>";
        }
    }
    html = html + "</table>";
    document.getElementById('tabla').innerHTML = html;
}

function cargarcarreras() {
    var html = "<select class='form-control col-md-offset-5' id='carreras'>";
    var datos = JSON.parse(localStorage.getItem("carreras"));
    if (datos == null || datos.length == 0) {
        alert("Lo sentimos no hay carreras");
        location.href = "AdminDashboardEstudiantes.html";
    }
    else {
        for (var i = 0; i < datos.length; i++) {
            html += "<option value=" + datos[i].codigocarrera + ">" + datos[i].codigocarrera + " " + datos[i].nombre + "</option>";
        }
    }
    html += "</select>";
    document.getElementById("carreras").innerHTML = html;
}

function crearestudiante() {
    var cedulaocarnet = document.getElementById("cedulaocarnet").value;
    var nombre = document.getElementById("nombre").value;
    var apellidos = document.getElementById("apellidos").value;
    var carrera = document.getElementById("carreras").value;
    var niveldeingles = document.getElementById("niveldeingles").value;
    var datos = JSON.parse(localStorage.getItem("carreras"));

    if (cedulaocarnet == "" || cedulaocarnet == " " || nombre == "" || nombre == " " || apellidos == " " || apellidos == " ") {
        alert("Escribe todos los datos por favor");
    }

    else {
        var estudiante = {
            cedulaocarnet: cedulaocarnet,
            nombre: nombre,
            apellidos: apellidos,
            carrera: carrera,
            ningles: niveldeingles
        };
        var datosest = JSON.parse(localStorage.getItem("estudiantes"));
        if (datosest == null) {
            var arreglo = [];
            arreglo.push(estudiante);
            localStorage.setItem("estudiantes", JSON.stringify(arreglo));
            location.href = "estudiantecreado.html";
        }
        else {
            var estudianterepetido = false;
            for (var i = 0; i < datosest.length; i++) {
                if (cedulaocarnet == datosest[i].cedulaocarnet) {
                    estudianterepetido = true;
                }
            }
            if (estudianterepetido) {
                alert("La cedula o carnet ya corresponden a algun estudiante");
            }
            else {
                datosest.push(estudiante);
                localStorage.setItem("estudiantes", JSON.stringify(datosest));
                location.href = "estudiantecreado.html";
            }
        }
    }
}

function cargarestudianteborrar() {
    var estudiante = localStorage.getItem("estudiantedelete");
    document.getElementById("cedulaocarnet").value = estudiante;
    localStorage.removeItem("estudiantedelete");
}

function eliminarestudiante() {
    var cedulaocarnet = document.getElementById("cedulaocarnet").value;
    if (cedulaocarnet == "" || cedulaocarnet == " ") {
        alert("no has escrito un codigo de carrera")
    }
    else {
        var datos = JSON.parse(localStorage.getItem("estudiantes"));
        var cedulaestudianterepetida = false;
        for (var i = 0; i < datos.length; i++) {
            if (datos[i].cedulaocarnet == cedulaocarnet) {
                cedulaestudianterepetida = true;
            }
        }
        if (cedulaestudianterepetida) {

            for (var i = 0; i < datos.length; i++) {
                if (cedulaocarnet == datos[i].cedulaocarnet) {
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
            localStorage.setItem("estudiantes", JSON.stringify(arreglo));
            location.href = "estudianteeliminado.html"
        }
        else {
            alert("La cedula o carnet no existen");
        }
    }
}

function cargarestudianteeditar() {
    var estudianteeditar = localStorage.getItem("estudianteedit");
    var estudiantes = JSON.parse(localStorage.getItem("estudiantes"));
    for (var i = 0; i < estudiantes.length; i++) {
        if (estudianteeditar == estudiantes[i].cedulaocarnet) {
            document.getElementById("cedulaocarnet").value = estudiantes[i].cedulaocarnet;
            document.getElementById("nombre").value = estudiantes[i].nombre;
            document.getElementById("apellidos").value = estudiantes[i].apellidos;
            document.getElementById("carreras").value = estudiantes[i].carrera;
            document.getElementById("niveldeingles").value = estudiantes[i].ningles;
            break;
        }
    }
    localStorage.removeItem("estudianteedit");
}

function editarestudiante() {
    var cedulaocarnet = document.getElementById("cedulaocarnet").value;
    var nombre = document.getElementById("nombre").value;
    var apellidos = document.getElementById("apellidos").value;
    var carrera = document.getElementById("carreras").value;
    var ingles = document.getElementById("niveldeingles").value;
    var datos = JSON.parse(localStorage.getItem("estudiantes"));
    if (nombre == "" || nombre == " " || apellidos == "" || apellidos == " ") {
        alert("escribe todos los datos por favor");
    }
    else {
        for (var i = 0; i < datos.length; i++) {
            if (cedulaocarnet == datos[i].cedulaocarnet) {
                datos[i].cedulaocarnet == cedulaocarnet;
                datos[i].nombre = nombre;
                datos[i].apellidos = apellidos;
                datos[i].carrera = carrera;
                datos[i].ningles = ingles;
            }
        }
        localStorage.setItem("estudiantes", JSON.stringify(datos));
        location.href = "estudianteeditado.html";
    }
}

function usaurioOn() {
    var usuario = localStorage.getItem("usuarioOn");
    document.getElementById("userOn").innerHTML = "<p id=userOn style=color:white>" + usuario + "    <a href=login.html style=color:white>Salir</a></p>";
}

function prepareBinding() {
    //$( "#test_button" ).bind( "click", function() { my_alert('text 2');});
    $("#crearestudiante").click(function () {
        crearestudiante();
    });
    $(".buttonedit").click(function () {
        var estudiante = $(this).data('estudianteeditar');
        localStorage.setItem("estudianteedit", estudiante);
        location.href = "editarestudiante.html";
    });
    $(".buttondelete").click(function () {
        var carrera = $(this).data('estudianteborrar');
        localStorage.setItem("estudiantedelete", carrera);
        location.href = "eliminarestudiante.html";
    });
    $("#eliminarestudiante").click(function () {
        eliminarestudiante();
    });
    $("#editarestudiante").click(function () {
        editarestudiante();
    });
}