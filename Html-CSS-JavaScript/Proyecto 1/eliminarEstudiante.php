<html>
<meta charset="utf-8">
<?php
	
	require_once('funciones.php');
	conectar('localhost','admin','12345','Proyecto');

	$cedula =  $_POST['id'];

	
	

	$query = @mysql_query("delete from estudiante where cedula='$cedula'");
	header("Location:estudiante.php");


?>
</html>