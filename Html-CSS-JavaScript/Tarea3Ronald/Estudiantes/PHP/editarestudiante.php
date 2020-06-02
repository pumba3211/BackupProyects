<?php
	require('conexionbd.php');
	$cedula=$_POST['cedula'];
	$nombre=$_POST['nombre'];
	$apellidos=$_POST['apellidos'];
	$email=$_POST['email'];
	$codigo_carrera=$_POST['codigo_carrera'];
	echo($cedula.$nombre.$apellidos.$email.$codigo_carrera);
	$sql="UPDATE estudiantes SET nombre='$nombre',apellidos='$apellidos',email='$email',codigo_carrera='$codigo_carrera' WHERE cedula='$cedula'";
	$conexionbd= ConectarseBd();

	if ($result = $conexionbd->query($sql)) { 
		echo $conexionbd->insert_id;
	}

	$conexionbd->close();
	header("Location: http://localhost/Tarea3Ronald/Estudiantes/");
?>