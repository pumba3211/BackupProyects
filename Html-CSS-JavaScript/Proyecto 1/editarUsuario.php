<!DOCTYPE html>
<html>
<head>
    <!-- Importamos nuestros CSS -->
    <link rel="stylesheet" href="css/reveal.css"> 
    <link rel="stylesheet" type="text/css" href="css/carrera.css">
    
    <!-- Importamos los scripts necesarios -->
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.6.min.js"></script>
    <script type="text/javascript" src="js/jquery.reveal.js"></script>
    <script type="text/javascript" src="js/util.js"></script>
    <script type="text/javascript" src="js/jquery.min"></script>
<meta charset=utf-8 />
<title>Editar Usuario</title>
</head>
<body>
  <div class="Contenido">
    <form action="editarUsuarioFinal.php" method="post">
        <div id="myModal" class="reveal-modal">
       <?php
                $traer = $_POST['editid'];

                 $con=mysql_connect("localhost","admin","12345"); //conexion MySQl
    mysql_select_db("Proyecto",$con); //Seleccionar base datos
    $datos=mysql_query("select * from usuario where id='$traer'"); //enviar código MySQL
    //$prueba=mysql_result($datos, 0);
    //echo $prueba;
    if($datos == false){
    echo "No se encontro datos en la base de datos";
}
     //echo "<table border='1'><tr><td>Código</td><td>Nombre</td><td>Duración</td><td>Horario</td><td>Nivel de Titulo</td><td>Sedes</td></tr>";   
        while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        echo "<tr>";
        $id = "<label>ID</label><br /><input type='text' value=".$row['id']." name='id'><br /><br />";
        $nombre = "<label>Nombre</label><br /><input type='text' value=".$row['nombre']." name='nombre'><br /><br />";
        $usuario = "<label>Usuario</label><br /><input type='text' value=".$row['usuario']." name='usuario'><br /><br />";
        $contrasenna = "<label>Contraseña</label><br /><input type='password' value=".$row['contrasenna']." name='contrasenna'><br /><br />";
        $role = "<label>Role</label><br /><input type='text' value=".$row['role']." name='role'><br /><br />";
        $traer = "<input type='hidden' value=".$row['id']." name='edit'><br /><br />";
            echo $id,$nombre,$usuario,$contrasenna,$role,$traer;
      }
     // echo "</table";
mysql_close($con);//cerrar conexion

             ?>
    		

           <a href="" onclick="editarUsuario()"><input type="submit" id="editar" name="editar" value="Editar" target='_blank'></a><br /><br />

           <a href="usuario.php"><input type="button" id="cancelar" name="cancelar" value="Cancelar" target='_blank'></a><br /><br />
        </div>
  </div>
    </form>
</body>
</html>