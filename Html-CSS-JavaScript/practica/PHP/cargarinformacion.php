<?php
	require("conexion.php");
	$conexion=ConectarseBd();
	$id_empresa=$_GET["id_empresa"];
	$sql = "SELECT * FROM empresar WHERE id_empresa='$id_empresa';";

if ($result = $conexion->query($sql)) { 
   $empresa="<h1>Empresa</h1>";
    while($obj = $result->fetch_object()){ 
        $empresa.="<label>Codigo: $obj->id_empresa Nombre:$obj->nombre_empresa</label>";
    } 
} 
$result->close(); 
$conexion->close();
?>
