<?php
require("PHP/cargarprovincias.php");
?>
<!Doctype>
<html lang="es">
<head>
    <meta charset="utf-8"/>

</head>
<body>
<form action="PHP/guardardatos.php" method="POST" onsubmit="guardarUsuario();">
    <label>Nombre: </label><input type="text" name="nombre_usuario"/></br>
    <label>Email: </label><input type="email" name="email"/></br>

    I have friends in
    <br/>

    <?php echo $checbox; ?>
    <input type="submit" value="Guardar"/>
</form>
</body>
</html>