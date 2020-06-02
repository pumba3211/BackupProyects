<?php
	require("Users.php");
	require("Provinces.php");
	$nombre=$_REQUEST['first_name'];
	$last_name=$_REQUEST['last_name'];
	$nombre_usuario=$_REQUEST['nombre_usuario'];
	$email=$_REQUEST['email'];
	$provincias=$_REQUEST['provincias'];
	$USER=NEW Users($nombre,$last_name,$nombre_usuario,$email);
	$id=$USER->Save();
	foreach ($provincias as $value) {
			Provinces::InsertarRelacion($id,$value);
	}
	header("Location: http://localhost/practica2/PHP/cargarusuario.php?id_usuario=$id");
	
?>