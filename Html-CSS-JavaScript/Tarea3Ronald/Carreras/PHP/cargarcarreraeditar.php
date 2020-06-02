<?php
	require("conexionbd.php");
	$conexion=ConectarseBd();

    $codigo_carrera=$_GET['codigo_carrera'];
	$sql = "SELECT * FROM carreras WHERE codigo_carrera=$codigo_carrera;";

    if ($result = $conexion->query($sql)) { 
        $form = "<form id=\"editar\" action=\"PHP/editarcarrera.php\" method=\"POST\" accept-charset=\"utf-8\">";
        while($obj = $result->fetch_object()){ 
           $form.="<label>Codigo Carrera</label><br/><input type=\"text\" name=\"codigo_carrera\" value=\"$obj->codigo_carrera\" readonly=\"readonly\"/>";
           $form.="<br/><label>Nombre Carrera</label><br/>";
           $form.="<input type=\"text\" name=\"nombre_carrera\" value=\"$obj->nombre_carrera\"/><br/><input type=\"submit\"/>";
        }
        $form.="</form>";
    
}
$result->close();
$conexion->close()	
?>
