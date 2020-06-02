//Agregar, Editar y Eliminar Carrera
function agregarCarrera() {
    alert("Carrera Agregada Existosamente");
    header("Location: carreras.html");
}

function editarCarrera(codigo) {
    $("#edit").val(codigo);
    $('#formularioEditarCarrera').submit();
}

function eliminarCarrera(codigo) {
    var r = confirm("¿Esta Seguro que desea eliminar esta Carrera?");

    if (r == true) {

        $("#id").val(codigo);
        $('#formularioCarrera').submit();
    }
    else {
        header("Location: carreras.html");
    }
}

//Agregar, Editar y Eliminar Estudiante 
function agregarEstudiante() {
    alert("Estudiante Agregado Existosamente");
    header("Location: estudiantes.html");
}

function editarEstudiante(id) {
    $("#edit").val(id);
    $('#formularioEditarEstudiante').submit();
}

function eliminarEstudiante(cedula) {

    var r = confirm("¿Esta Seguro que desea eliminar este Estudiante?");

    if (r == true) {

        $("#id").val(cedula);
        $('#formularioEstudiante').submit();
    }
    else {
        header("Location: estudiante.php");
    }
}

//Agregar, Editar y Eliminar Usuario
function agregarUsuario() {
    alert("Usuario Agregado Existosamente");
    header("Location: usuarios.html");
}

function editarUsuario(id) {


    $("#editid").val(id);
    $('#formularioEditarUsuario').submit();

}

function eliminarUsuario(id) {
    var r = confirm("¿Esta Seguro que desea eliminar este Usuario?");

    if (r == true) {
        $("#id").val(id);
        $('#formularioUsuario').submit();
    }
    else {
        header("Location: usuarios.html");
    }
}











