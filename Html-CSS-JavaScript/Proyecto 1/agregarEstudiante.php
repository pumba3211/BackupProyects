<html>
<meta charset="utf-8">
<?php

	require_once('funciones.php');
	conectar('localhost','admin','12345','Proyecto');

	$cedula =  $_POST['cedula'];
	$nombre =  $_POST['nombre'];
	$apellidos =  $_POST['apellidos'];
	$telefono =  $_POST['telefono'];
	$correo =  $_POST['correo'];
	$direccion =  $_POST['direccion'];
	$foto =  $_POST['foto'];
	$carrera =  $_POST['carrera'];
	$ingles =  $_POST['ingles'];
	$skill =  $_POST['skill'];
	$proyecto =  $_POST['proyecto'];
	$curso =  $_POST['curso'];
	$duracion =  $_POST['duracion'];
	$tecnologia =  $_POST['tecnologia'];
	$descripcion =  $_POST['descripcion'];
	$fecha =  $_POST['fecha'];
	$calificacion =  $_POST['calificacion'];
	$comentario =  $_POST['comentario'];


	  $archivo = $_FILES['foto']['tmp_name'];
        $destino = "imagenes/".$_FILES['foto']['name'];
        move_uploaded_file($archivo, $destino);

	$query = @mysql_query("select * from estudiante where cedula='$cedula'");
	if($existe = @mysql_fetch_object($query)){
		echo 'El estudiante'.$cedula.'ya existe.';
	}else{
		
	$insertar = @mysql_query("insert into estudiante (cedula,nombre,apellidos,telefono,correo,direccion,foto,carrera,ingles,skill,proyecto,curso,duracion,
		tecnologia,descripcion,fecha,calificacion,comentario)
		values( '$cedula','$nombre','$apellidos','$telefono','$correo','$direccion','$destino$foto','$carrera','$ingles','$skill','$proyecto','$curso','$duracion',
		'$tecnologia','$descripcion','$fecha','$calificacion','$comentario')");
	if($_REQUEST['agregarNuevo']==TRUE){
		echo "<script>";
		echo "alert('Estudiante agregado Exitosamente');";  
		echo "window.location = 'agregarestudiante.html';";
		echo "</script>";
} else {
		echo "<script>";
		echo "alert('Estudiante agregado Exitosamente');";  
		echo "window.location = 'estudiante.php';";
		echo "</script>"; 
	}	
}

?>
</html>