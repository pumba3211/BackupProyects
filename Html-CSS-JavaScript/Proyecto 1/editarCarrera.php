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
<title>Editar Carrera</title>
</head>
<body>
  <form action="editarCarreraFinal.php" method="post">
    <div class="Contenido">
      <div id="myModal" class="reveal-modal">
     <?php
                $traer = $_POST['edit'];

                 $con=mysql_connect("localhost","admin","12345"); //conexion MySQl
    mysql_select_db("Proyecto",$con); //Seleccionar base datos
    $datos=mysql_query("select * from carrera where id='$traer'"); //enviar código MySQL
    //$prueba=mysql_result($datos, 0);
    //echo $prueba;
    if($datos == false){
    echo "No se encontro datos en la base de datos";
}
     //echo "<table border='1'><tr><td>Código</td><td>Nombre</td><td>Duración</td><td>Horario</td><td>Nivel de Titulo</td><td>Sedes</td></tr>";   
        while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros


        $codigo = "<label>Codigo</label><br /><input type='text' value=".$row['codigo']." name='codigo'><br /><br />";
        $nombre = "<label>Nombre</label><br /><input type='text' value=".$row['nombre']." name='nombre'><br /><br />";
        $sede = "<label>sede</label><br /><input type='text' value=".$row['sede']." name='sede'><br /><br />";
        $id = "<input type='hidden' value=".$row['id']." name='edit'>";
            echo $codigo,$nombre,$sede,$id;
      }
     // echo "</table";
mysql_close($con);//cerrar conexion

             ?>
    		

           <a href="" onclick="editarCarrera()"><input type="submit" id="editar" name="editar" value="Editar" target='_blank'></a><br /><br />

           <a href="carrera.php"><input type="button" id="cancelar" name="cancelar" value="Cancelar" target='_blank'></a><br /><br />
      </div>
    </div>
  </form>  
</body>
</html>
