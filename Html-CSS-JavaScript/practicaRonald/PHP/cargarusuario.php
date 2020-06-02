<?php
require("conexionbd.php");
$conexion = ConectarseBd();
$id_usuario = $_GET['id_usuario'];
$sql = "SELECT distinct c.nombre_usuario,c.email,a.id_provincia,a.nombre_provincia FROM provincias AS a,usuario_provincia AS b,usuarios as c WHERE b.id_usuario='$id_usuario' and c.id_usuario='$id_usuario' and b.id_provincia=a.id_provincia;";
if ($result = $conexion->query($sql)) {
    $obj = $result->fetch_object();
    $radom = "<label> Usuario: $obj->nombre_usuario</label><br/>";
    $radom .= "<label> Email: $obj->email</label><br/><br/><label>$obj->id_provincia $obj->nombre_provincia</label></br>";
    while ($obj2 = $result->fetch_object()) {
        $radom .= "<label>$obj2->id_provincia $obj2->nombre_provincia</label></br>";
    }

}
$result->close();
$conexion->close();
?>