function cargarusuarios() {
    var datos = JSON.parse(localStorage.getItem("usuario"));
    var html = "<table id=tabla class=table>";
    html += "<h2> Usuarios</h2>";
    html += "<tr id=row0 style='background-color: #0099CC;color:white'>";
    html += "<td><strong>Nombre</strong></td>";
    html += "<td><strong>Nombre de Usuario</strong></td>";
    html += "<td><strong>Cedula</strong></td>";
    html += "<td><strong>Rol</strong></td>";
    html += "<td><strong>Editar</strong></td>";
    html += "<td><strong>Eliminar</strong></td>";
    html += "</tr>";
    for (var i = 0; i < datos.length; i++) {
        if (datos[i] == null) {

        }
        else {
            html += "<tr id=row" + (i + 1) + " style='color:#0099CC'>";
            html += "<td>" + datos[i].nombre + "</td>";
            html += "<td>" + datos[i].username + "</td>";
            html += "<td>" + datos[i].cedula + "</td>";
            html += "<td>" + datos[i].rol + "</td>";
            html += "<td><button class='buttonedit btn btn-warning'  data-usernameeditar=" + datos[i].username + " >Editar</button>"
            html += "<td><button class='buttondelete btn btn-danger'  data-usernameborrar=" + datos[i].username + " >Eliminar</button>"
        }
    }
    html = html + "</table>";
    document.getElementById('tabla').innerHTML = html;
}

function crearusuario() {
    var nombre = document.getElementById('nombre').value;
    var username = document.getElementById('username').value;
    var cedula = document.getElementById('cedula').value;
    var rol = document.getElementById('rol').value;
    var password = document.getElementById('contraseña').value;
    if (nombre == "" || username == "" || cedula == "" || password == "" ||
        nombre == " " || username == " " || cedula == " " || password == " ") {
        alert("escribe todos los datos por favor");
    }
    else {
        var usuario = {nombre: nombre, username: username, cedula: cedula, rol: rol, password: password};
        var datos = JSON.parse(localStorage.getItem("usuario"));
        if (datos == null) {
            var arreglo = [];
            arreglo.push(usuario);
            localStorage.setItem("usuario", JSON.stringify(arreglo));
            location.href = "Usuariocreado.html";
        }
        else {
            var usernamerepetido = false;
            for (var i = 0; i < datos.length; i++) {
                if (usuario.username == datos[i].username) {
                    usernamerepetido = true;
                }
            }
            var cedularepetida = false;
            for (var i = 0; i < datos.length; i++) {
                if (usuario.cedula == datos[i].cedula) {
                    cedularepetida = true;
                }
            }
            if (cedularepetida || usernamerepetido) {
                if (cedularepetida == true) {
                    alert("Esa cedula ya esta reservada para un usuario");
                }
                else {
                    alert("Ese username ya esta reservado para un usuario");
                }
            }
            else {
                datos.push(usuario);
                localStorage.setItem("usuario", JSON.stringify(datos));
                location.href = "Usuariocreado.html";
            }
        }
    }
}

function usaurioOn() {
    var usuario = localStorage.getItem("usuarioOn");
    document.getElementById("userOn").innerHTML = "<p id=userOn style=color:white>" + usuario + "    <a href=login.html style=color:white>Salir</a></p>";

}

function cargarusuarioaborrar() {
    var username = localStorage.getItem('usuariodelete');
    document.getElementById("username").value = username;
    localStorage.removeItem("usuariodelete");
}

function eliminarusuario() {
    var username = document.getElementById("username").value;
    var usuarioexiste = false;
    var datos = JSON.parse(localStorage.getItem("usuario"));
    if (username == "" || username == " ") {
        alert("no has escrito un nombre de usuario");
    }
    else {
        for (var i = 0; i < datos.length; i++) {
            if (username == datos[i].username) {
                usuarioexiste = true;
            }
        }
        if (usuarioexiste) {
            for (var i = 0; i < datos.length; i++) {
                if (username == datos[i].username) {
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
            localStorage.setItem("usuario", JSON.stringify(arreglo));
            location.href = "usuarioeliminado.html";
        }
        else {
            alert("el usuario no existe");
        }
    }
}

function cargarusuarioaeditar() {
    var username = localStorage.getItem('usuarioedit');
    var datos = JSON.parse(localStorage.getItem("usuario"));
    var usuario;
    for (var i = 0; i < datos.length; i++) {
        if (username == datos[i].username) {
            usuario = datos[i];
            break;
        }
    }
    document.getElementById("username").value = usuario.username;
    document.getElementById("nombre").value = usuario.nombre;
    document.getElementById("contraseña").value = usuario.password;
    document.getElementById("cedula").value = usuario.cedula;
    document.getElementById("rol").value = usuario.rol;
    localStorage.removeItem("usuarioedit");
}

function editarusuario() {
    var nombre = document.getElementById('nombre').value;
    var username = document.getElementById('username').value;
    var cedula = document.getElementById('cedula').value;
    var rol = document.getElementById('rol').value;
    var password = document.getElementById('contraseña').value;
    if (nombre == "" || username == "" || cedula == "" || password == "" ||
        nombre == " " || username == " " || cedula == " " || password == " ") {
        alert("escribe todos los datos por favor");
    }
    else {
        var datos = JSON.parse(localStorage.getItem("usuario"));
        var cedularepetida = false;


        for (var i = 0; i < datos.length; i++) {
            if (username == datos[i].username) {
                datos[i].nombre = nombre;
                datos[i].contraseña = password;
                datos[i].rol = rol;
                datos[i].cedula = cedula;
                localStorage.setItem("usuario", JSON.stringify(datos));
                location.href = "usuarioeditado.html";
                break;
            }
        }

    }
}


function prepareBinding() {
    //$( "#test_button" ).bind( "click", function() { my_alert('text 2');});
    $("#crearusuario").click(function () {
        crearusuario();
    });
    $(".buttonedit").click(function () {
        var username = $(this).data('usernameeditar');
        localStorage.setItem("usuarioedit", username);
        location.href = "editarusuario.html";
    });
    $(".buttondelete").click(function () {
        var username = $(this).data('usernameborrar');
        localStorage.setItem("usuariodelete", username);
        location.href = "eliminarusuario.html";
    });
    $("#eliminarusuario").click(function () {
        eliminarusuario();
    });
    $("#editarusuario").click(function () {
        editarusuario();
    });
}

    