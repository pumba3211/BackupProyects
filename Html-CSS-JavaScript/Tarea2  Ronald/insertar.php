<?php
	$cedula=$_POST["cedula"];
	$nombre=$_POST["nombre"];
	$apellido=$_POST["apellido"];
	$genero=$_POST["genero"];
	$correo=$_POST["correo"];
	$telefono=$_POST["telefono"];
	mysql_connect("localhost","root","") or die("Error en la conexion en la base de datos");
	mysql_set_charset('utf8');
	mysql_select_db("tarea")or die("Error con la base de datos");
	mysql_query("INSERT INTO agenda VALUES ('$cedula','$nombre','$apellido','$genero','$correo','$telefono')");
	mysql_close();  
	header("Location: http://localhost/Tarea2/");
?>