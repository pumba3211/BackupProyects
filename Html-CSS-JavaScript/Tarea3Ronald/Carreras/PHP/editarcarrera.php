<?php
	require('conexionbd.php');
	$codigo_carrera=$_POST['codigo_carrera'];
	$nombre_carrera=$_POST["nombre_carrera"];

	$sql="UPDATE carreras SET nombre_carrera='$nombre_carrera' WHERE codigo_carrera='$codigo_carrera'";
	$conexionbd= ConectarseBd();

	if ($result = $conexionbd->query($sql)) { 
		echo $conexionbd->insert_id;
	}

	$conexionbd->close();
	header("Location: http://localhost/Tarea3Ronald/Carreras/");
?>