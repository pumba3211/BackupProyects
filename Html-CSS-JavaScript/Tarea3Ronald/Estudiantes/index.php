<?php
	require("PHP/cargarestudiantes.php");
?>
<!Doctype>
<html lang="es">
	<head>
		<meta charset="utf-8"/>
		<script type="text/javascript" src="JavaScript/jquery-1.11.1.js"></script>
		<script type="text/javascript" src="JavaScript/estudiantes.js"></script>
	</head>
	<body>
		<h1> Selecciona una opción</h1>
		<a href="crearestudiante.php"><button>Crear Estudiante</button></a>
		<br/>
		<a href="http://localhost/Tarea3Ronald/"><button>Atras</button></a>
		<h1> Estudiantes </h1>
		<?php echo $estudiantes; ?>	
	</body>
	<script type="text/javascript">
		EventosBotonnes()
	</script>
</html>
