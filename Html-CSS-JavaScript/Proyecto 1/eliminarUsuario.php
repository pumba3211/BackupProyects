<html>
<meta charset="utf-8">
<?php
	
	require_once('funciones.php');
	conectar('localhost','admin','12345','Proyecto');

	$id =  $_POST['id'];


	
	

	$query = @mysql_query("delete from usuario where id=$id");
	header("Location:usuario.php");


?>
</html>