

<html>
<meta charset="utf-8">

<?

	session_start();
	 require_once('funciones.php');
	 conectar('localhost','admin','12345','Proyecto');

	 //Recibir
	 $user = $_POST['user'];
	 $pass = $_POST['pass'];

	 $query = "select * from usuario where usuario = '$user' and contrasenna= '$pass'";
		$comprobar = mysql_query($query);
	 if($existe = @mysql_fetch_object($comprobar)){
	 	$_session['logged'] = 'yes';
	 	$_session['user'] = $user;
	 	header("Location:admin.html");

	 }
	 else{
		 //echo "<script type='text/javascript'>alert('Error y/o contraseña incorrecta')
		 //header('Location:index.html');</script>";

		echo "<script>";
		echo "alert('Error y/o contraseña incorrecta');";  
		echo "window.location = 'index.html';";
		echo "</script>";  
		 
	}
		

	 
	 
?>

</html>
