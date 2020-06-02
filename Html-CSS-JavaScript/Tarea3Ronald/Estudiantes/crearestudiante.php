<?php
	require("PHP/cargarcarreras.php");
?>
<!Doctype>
<html lang="es">
	<head>
		<meta charset="utf-8"/>
	</head>
	<body>
		<h1> Crear Carrera</h1>
		<form action="PHP/guardarestudiante.php" method="post" accept-charset="utf-8">
			<label>Cedula</label>
			<br/>
			<input type="number" name="cedula" placeholder="Cedula"/>
			<br/> 
			<label>Nombre</label>
			<br/>
			<input type="text" name="nombre" placeholder="Nombre"/>
			<br/>
			<label>Apellidos</label>
			<br/>
			<input type="text" name="apellidos" placeholder="Apellidos"/>
			<br/>
			<label>Email</label>
			<br/>
			<input type="email" name="email" placeholder="Email"/>
			<br/>
			<label>Carrera</label>
			</br>
			<?php echo $carreras; ?>
			</br>
			<input type="submit"/>
		</form>
		<a href="http://localhost/Tarea3Ronald/Estudiantes/"><button>Atras</button></a>
	</body>
</html>