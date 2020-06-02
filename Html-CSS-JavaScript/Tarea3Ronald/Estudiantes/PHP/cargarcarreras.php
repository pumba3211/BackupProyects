<?php 

require('conexionbd.php');

$conexionbd= ConectarseBd();

$sql = "SELECT * FROM carreras;";

if ($result = $conexionbd->query($sql)) { 
   $carreras="<select name=\"codigo_carrera\"/>";
    while($obj = $result->fetch_object()){ 
       $carreras.="<option value=\"$obj->codigo_carrera\">$obj->codigo_carrera $obj->nombre_carrera</option>";
    }
    $carreras.="</select>";
} 
$result->close();
$conexionbd->close();
?>