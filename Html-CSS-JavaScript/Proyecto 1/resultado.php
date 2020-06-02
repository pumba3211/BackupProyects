<!DOCTYPE html>
<html>
<head>
    <!-- Importamos nuestros CSS -->
    <link rel="stylesheet" type="text/css" href="css/tabmenu.css">
<script type="text/javascript" src="js/util.js"></script>
<script type="text/javascript" src="js/jquery.min.js"></script>
    <title>Estudiantes</title>
    <meta charset="utf-8">
</head>
<body>
<div class="conteiner">
        <img class="logo" src="imagenes/UTN.png">
        <p id="perfil">Perfiles</p>

        <p id="salir"> Hola Admin</p> 
        <a id="salir" href="index.html"><img src="imagenes/exitHover.png"></a>

           
            
            <a id="dashboard" href="admin.html">Dashboard <strong> > Busqueda</strong></a>

    <div class="tabContent">
    
        <a href="buscar.php"><img src="imagenes/buscar.png" class="buscar"></a>
       <?php
            
               $con=mysql_connect("localhost","admin","12345"); //conexion MySQl
                mysql_select_db("Proyecto",$con); //Seleccionar base datos
                $sql=" select * from estudiante"; //código MySQL
                $buscar = $_POST['buscar'];
                $datos=mysql_query("select * from estudiante where cedula LIKE '%$buscar%' or nombre LIKE '%$buscar%' or apellidos LIKE '%$buscar%'
                or telefono LIKE '%$buscar%' or correo LIKE '%$buscar%' or direccion LIKE '%$buscar%' or foto LIKE '%$buscar%'
                or carrera LIKE '%$buscar%' or ingles LIKE '%$buscar%' or skill LIKE '%$buscar%' or curso LIKE '%$buscar%'
                or duracion LIKE '%$buscar%' or tecnologia LIKE '%$buscar%' or descripcion LIKE '%$buscar%' or fecha LIKE '%$buscar%'
                or calificacion LIKE '%$buscar%' or comentario LIKE '%$buscar%'"); //enviar código MySQL
            echo "<table border='1'><tr><td>Foto</td><td>Cedula</td><td>Nombre</td><td>Apellidos</td><td>Telefono</td><td>Correo</td><td>Carrera</td><td>Opciones</td></tr>";
                while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        echo "<tr>";
        echo $foto = "<td><img src=".$row['foto']." class='imgTable'></td>";
        echo $cedula = "<td>".$row['cedula']."</td>";
        echo $nombre = "<td><a class='estudiante' href='javascript:verEstudiante(".$row['cedula'].")'>".$row['nombre']."</a></td>";
        echo $apellidos = "<td>".$row['apellidos']."</td>";
        echo $telefono = "<td>".$row['telefono']."</td>";
        echo $correo = "<td>".$row['correo']."</td>"; 
        echo $carrera = "<td>".$row['carrera']."</td>";
        //echo $opciones = "<td><a href='javascript:verEstudiante(".$row['cedula'].")'><img class='verEstudiante' src='imagenes/ver.png' /></a></td>";
        echo "</table";
      }
      mysql_close($con);//cerrar conexion

        ?>
            <form action="datoEstudiante.php" method="post" id="formularioVerEstudiante">
                <input type="hidden" name="estudiante" id="estudiante">
           </form>
    </div>
</div>    
</body>
</html>