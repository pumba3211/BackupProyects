<?php
require("conexionbd.php");
$conexion = ConectarseBd();
$sql = "SELECT * FROM provincias;";

if ($result = $conexion->query($sql)) {
    $checbox = "";
    while ($obj = $result->fetch_object()) {
        $checbox .= "<input type=\"checkbox\" name=\"provincias[]\" value=\"$obj->id_provincia\"/>$obj->nombre_provincia</input></br>";
    }
}
$result->close();
$conexion->close()
?>
