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
    $edit = $_POST['edit'];
    $destino = "imagenes/".$foto;

    $insertar = @mysql_query("update estudiante set cedula='$cedula', nombre='$nombre', apellidos='$apellidos', telefono='$telefono',correo='$correo',direccion='$direccion', 
        foto='$destino', carrera='$carrera', ingles='$ingles', skill='$skill', curso='$curso', duracion='$duracion', tecnologia='$tecnologia', descripcion='$descripcion', fecha='$fecha', 
        calificacion='$calificacion', comentario='$comentario', proyecto='$proyecto' where cedula='$edit'");
    echo "<script>";
        echo "alert('Estudiante editado Exitosamente');";  
        echo "window.location = 'estudiante.php';";
        echo "</script>"; 
   

?>
</html>