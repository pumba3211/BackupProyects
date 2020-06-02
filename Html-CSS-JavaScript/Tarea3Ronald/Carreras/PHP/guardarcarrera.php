<?php
	require('conexionbd.php');

	$nombre_carrera=$_POST["nombre_carrera"];

	$sql="INSERT INTO carreras (nombre_carrera) VALUES ('$nombre_carrera')";
	$conexionbd= ConectarseBd();

	if ($result = $conexionbd->query($sql)) { 
		echo $conexionbd->insert_id;
	}

	$conexionbd->close();
	header("Location: http://localhost/Tarea3Ronald/Carreras/");
?>