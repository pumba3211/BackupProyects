<html>
<meta charset="utf-8">
<?php

	require_once('funciones.php');
	conectar('localhost','admin','12345','Proyecto');

	$codigo =  $_POST['codigo'];
	$nombre =  $_POST['nombre'];
	$sede =  $_POST['sede'];

	

	$query = @mysql_query("select * from carrera where codigo='$codigo'");
	if($existe = @mysql_fetch_object($query)){
		echo 'La carrera'.$codigo.'ya existe.';
	}else{
		
	$insertar = @mysql_query("insert into carrera (codigo,nombre,sede) values( '$codigo','$nombre','$sede')");
	echo "<script>";
		echo "alert('Carrera agregada Exitosamente');";  
		echo "window.location = 'carrera.php';";
		echo "</script>"; 
}

?>
</html>