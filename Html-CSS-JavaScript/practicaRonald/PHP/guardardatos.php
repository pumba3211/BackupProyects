<?php
require("conexionbd.php");
$nombre_usuario = $_POST['nombre_usuario'];
$email = $_POST['email'];
$provincias = $_POST['provincias'];
$id = guardarUsuario($nombre_usuario, $email);
function guardarUsuario($nombre_usuario, $email)
{
    $conexionbd = ConectarseBd();
    $sql = "INSERT INTO usuarios (nombre_usuario,email) VALUES ('$nombre_usuario','$email')";
    if ($result = $conexionbd->query($sql)) {
        return $conexionbd->insert_id;
    }
    $conexionbd->close();
}


function insertarRelacion($id_usuario, $id_provincia)
{
    $conexionbd = ConectarseBd();
    $sql = "INSERT INTO usuario_provincia(id_usuario,id_provincia) VALUES ('$id_usuario','$id_provincia')";
    if ($result = $conexionbd->query($sql)) {
        return $conexionbd->insert_id;
    }
    $conexionbd->close();
}

GurdarRelacion($id, $provincias);

function GurdarRelacion($id, $provincias)
{
    $conexionbd = ConectarseBd();
    foreach ($provincias as $value) {
        insertarRelacion($id, $value);
    }
    $conexionbd->close();
}

header("Location: http://localhost/practica/PHP/mostrarusuario.php?id_usuario=$id");

?>