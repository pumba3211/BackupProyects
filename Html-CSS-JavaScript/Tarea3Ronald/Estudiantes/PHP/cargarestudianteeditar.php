<?php
	require("conexionbd.php");
	$conexion=ConectarseBd();
	$cedula=$_GET['cedula'];
   	$sql2 = "SELECT * FROM carreras;";
    $carreras;
	if ($result = $conexion->query($sql2)) { 
   		$carreras="<select name=\"codigo_carrera\"/>";
    	while($obj = $result->fetch_object()){ 
      		 $carreras.="<option value=\"$obj->codigo_carrera\">$obj->codigo_carrera $obj->nombre_carrera</option>";
    	}
    	$carreras.="</select>";
	}
	$result->close(); 
	$sql = "SELECT * FROM estudiantes WHERE cedula=$cedula;";

    if ($result = $conexion->query($sql)) { 
        $form = "<form id=\"editar\" action=\"PHP/editarestudiante.php\" method=\"POST\" accept-charset=\"utf-8\">";
        while($obj = $result->fetch_object()){ 
           $form.="<label>Cedula</label><br/><input type=\"text\" name=\"cedula\" value=\"$obj->cedula\" readonly=\"readonly\"/>";
           $form.="<br/><label>Nombre</label><br/><input type=\"text\" name=\"nombre\" value=\"$obj->nombre\"/>";
           $form.="<br/><label>Apellidos</label><br/><input type=\"text\" name=\"apellidos\" value=\"$obj->apellidos\"/>";
           $form.="<br/><label>Email</label><br/><input type=\"text\" name=\"email\" value=\"$obj->email\"/>";
           $form.="<br/><label>Carreras</label><br/>$carreras<br/>";
           $form.="<input type=\"submit\"/>";
        }
        $form.="</form>";
    
}
$result->close();
$conexion->close()	
?>
	
