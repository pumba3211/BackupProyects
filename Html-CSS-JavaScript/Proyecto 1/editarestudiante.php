<!DOCTYPE html>
<html>
<head>
    <!-- Importamos nuestros CSS -->
    <link rel="stylesheet" href="css/reveal.css"> 
    <link rel="stylesheet" type="text/css" href="css/estudiante.css">
    
    <!-- Importamos los scripts necesarios -->
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.6.min.js"></script>
    <script type="text/javascript" src="js/jquery.reveal.js"></script>
    <script type="text/javascript" src="js/util.js"></script>
    <script type="text/javascript" src="js/jquery.min"></script>
<meta charset=utf-8 />
<title>Editar Estudiante</title>
</head>
<body> 
    <div class="conteiner">
        <div id="myModal" class="reveal-modal" style="width:31%; height:59%;">
    <form action="editarEstudianteFinal.php" method="post">
     <?php
                $traer = $_POST['edit'];

                 $con=mysql_connect("localhost","admin","12345"); //conexion MySQl
    mysql_select_db("Proyecto",$con); //Seleccionar base datos
    $datos=mysql_query("select * from estudiante where cedula='$traer'"); //enviar código MySQL

    if($datos == false){
    echo "No se encontro datos en la base de datos";
}
     //echo "<table border='1'><tr><td>Código</td><td>Nombre</td><td>Duración</td><td>Horario</td><td>Nivel de Titulo</td><td>Sedes</td></tr>";   
        while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        
        $imagen = "<img class='foto' src=".$row['foto']."><br /><br />";
        $cedula = "<div class='PositionEditar1'><label class='editar'>ID</label><input type='texto' value=".$row['cedula']." name='cedula'  class='PositionEditar1'><br /><br />";
        $nombre = "<label >nombre</label><input type='texto' value=".$row['nombre']." name='nombre' ><br / class='PositionEditar1'><br />";
        $apellidos = "<label >Apellidos</label><input type='texto' value=".$row['apellidos']." name='apellidos'  class='PositionEditar1'><br /><br />";
        $telefono = "<label >Telefono</label><input type='texto' value=".$row['telefono']." name='telefono'  class='PositionEditar1'><br /><br />";
        $correo = "<label >Correo</label><input type='email' value=".$row['correo']." name='correo'  class='PositionEditar1'><br /><br />";
        $direccion = "<label >Direccion</label><input type='texto' value=".$row['direccion']." name='direccion'  class='PositionEditar1'><br /><br />";
        $carrera = "<label >Carrera</label><input type='texto' value=".$row['carrera']." name='carrera'  class='PositionEditar1'><br /><br />";
        $ingles =  "<label >Ingles</label><input type='texto' value=".$row['ingles']." name='ingles'  class='PositionEditar1'><br /><br />";
        $skill =  "<label >Skill</label><input type='texto' value=".$row['skill']." name='skill'  class='PositionEditar1'><br /><br />";
        $proyecto =  "</div><div class='PositionEditar2'><label >Proyecto</label><input type='texto' value=".$row['proyecto']." name='proyecto'  class='PositionEditar2'><br /><br />";
        $curso =  "<label >Curso</label><input type='texto' value=".$row['curso']."  name='curso'  class='PositionEditar2'><br /><br />";
        $duracion = "<label >Duracion</label><input type='texto' value=".$row['duracion']." name='duracion'  class='PositionEditar2'><br /><br />";
        $tecnologia =  "<label >Tecnologias</label><input type='texto' value=".$row['tecnologia']." name='tecnologia'  class='PositionEditar2'><br /><br />";
        $descripcion =  "<label >Descripcion</label><input type='texto' value=".$row['descripcion']." name='descripcion'  class='PositionEditar2'><br /><br />";
        $fecha =  "<label >Fecha</label><input type='texto' value=".$row['fecha']." name='fecha'  class='PositionEditar2'><br /><br />";
        $calificacion =  "<label >Calificacion</label><input type='texto' value=".$row['calificacion']." name='calificacion'  class='PositionEditar2'><br /><br />";
        $comentario =  "<label >Comentario</label><input type='texto' value=".$row['comentario']." name='comentario'  class='PositionEditar2'><br /><br />";
        $foto =  "<label >Foto</label><input type='texto' value=".$row['foto']."  class='PositionEditar2'><br /><br />";
        $file =  "<label >File</label><input type='file' value=".$row['foto']." name='foto'  class='PositionEditar2'></div><br /><br /><br /><br />";
        $traer = "<input type='hidden' value=".$row['cedula']." name='edit' required><br /><br />";

        echo $imagen,$cedula,$nombre,$apellidos,$telefono,$correo,$direccion,$carrera,$ingles,$skill,$proyecto,$curso,$duracion,$tecnologia,$descripcion,$fecha,$calificacion,$comentario,$foto,$file,$traer;
      }
     // echo "</table";
mysql_close($con);//cerrar conexion
              
             ?>
    		
            
           <a href="" onclick="editarEstudiante()"><input type="submit" id="editar" name="editar" value="Editar" target='_blank'></a><br /><br />

           <a href="estudiante.php"><input type="button" id="cancelarEditar" name="cancelarEditar" value="Cancelar" target='_blank'></a><br /><br />
           
        </div>
    </div>
    </form>
</body>
</html>