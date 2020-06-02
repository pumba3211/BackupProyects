<?php
	require("Users.php");
	require("Provinces.php");
	$id=$_GET['id_usuario'];
	echo Users::Cargar_Usario($id);
	echo Provinces::CargarProvincias_Usuario($id);

?>