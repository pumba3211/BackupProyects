<?php
	require_once("listas/Listas.php");
	require_once("conexion.php");
	$conexion=ConectarseBd();

	$username=$_GET['username'];
	$titulo_lista=$_GET['titulo_lista'];
	$creat_at=$_GET['creat_at'];
	$categoria=$_GET['categoria'];
	echo $username;
	echo $titulo_lista;
	echo $creat_at;
	echo $categoria;
	$resultado=Listas::Insertar_Lista($username,$titulo_lista,$creat_at,$categoria,$conexion);
	return $resultado;
?>