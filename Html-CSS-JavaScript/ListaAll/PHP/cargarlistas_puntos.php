<?php
	require_once("conexion.php");
	require_once("listas/listas.php");
	$conexion=ConectarseBd();
	$resultado=Listas::CargarListas_puntos($conexion);
	echo json_encode($resultado);
?>