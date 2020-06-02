<?php
	require('conexionbd.php');
	$codigo_carrera=$_POST['carrera'];

	$sql="DELETE FROM carreras WHERE codigo_carrera='$codigo_carrera'";
	$conexionbd= ConectarseBd();

	if ($result = $conexionbd->query($sql)) { 
		echo $conexionbd->insert_id;
	}
	$conexionbd->close();
	echo "Carrera borrada :D";
?>