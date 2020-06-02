<?php
	require('conexionbd.php');
	$cedula=$_POST['cedula'];
	$sql="DELETE FROM estudiantes WHERE cedula='$cedula'";
	$conexionbd= ConectarseBd();

	if ($result = $conexionbd->query($sql)) { 
		echo $conexionbd->insert_id;
	}

	$conexionbd->close();
	echo "Estudiante Eliminado :D";
	header("Location: http://localhost/Tarea3Ronald/Estudiantes/");
?>