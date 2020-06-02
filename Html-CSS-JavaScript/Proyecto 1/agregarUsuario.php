<html>
<meta charset="utf-8">
<?php

	require_once('funciones.php');
	conectar('localhost','admin','12345','Proyecto');

	$id =  $_POST['id'];
	$usuario =  $_POST['usuario'];
	$contrasenna =  $_POST['contrasenna'];
	$nombre =  $_POST['nombre'];
	$role =  $_POST['role'];

	

	$query = @mysql_query("select * from usuario where usuario='$usuario'");
	if($existe = @mysql_fetch_object($query)){
		echo 'El usuario'.$usuario.'ya existe.';
	}else{
		
	$insertar = @mysql_query("insert into usuario (id,usuario,contrasenna,nombre,role) values( '$id','$usuario','$contrasenna','$nombre','$role')");
	echo "<script>";
		echo "alert('Usuario agregado Exitosamente');";  
		echo "window.location = 'usuario.php';";
		echo "</script>"; 
}

?>
</html>