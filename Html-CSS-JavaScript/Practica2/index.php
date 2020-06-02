<?php
	require("PHP/Provinces.php");
?>
<!Doctype>
<html lang="es">
	<head>
		<meta charset="utf-8"/>

	</head>
	<body>	
		<form action="PHP/save.php" method="POST">
			<label>Nombre: </label><input type="text" name="first_name" /></br>
			<label>Apellido: </label><input type="text" name="last_name" /></br>
			<label>Nombre Usuario: </label><input type="text" name="nombre_usuario" /></br>
			<label>Email: </label><input type="email" name="email" /></br>

			I have friends in
			<br/>
			
			<?php echo Provinces::get_all() ; ?>
			<input type="submit" value="Guardar"/>
		</form>
	</body>
</html>