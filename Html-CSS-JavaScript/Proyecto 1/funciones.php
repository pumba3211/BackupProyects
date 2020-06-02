<?php
	function conectar ()

{
	$servidor = "localhost";
	$user = "admin";
	$pass = "12345";
	$name = "Proyecto";
	$con = @mysql_connect($servidor,$user,$pass) or die ("No se pudo conectar a la base de datos");
	@mysql_select_db($name,$con) or die ("no se pudo seleccionar la base de datos");

	return $con;
}


?>