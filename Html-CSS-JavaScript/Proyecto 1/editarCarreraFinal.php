<html>
<meta charset="utf-8">
<?php
    require_once('funciones.php');
    conectar('localhost','admin','12345','Proyecto');

    $id = $_POST['edit'];
    $codigo =  $_POST['codigo'];
    $nombre =  $_POST['nombre'];
    $sede =  $_POST['sede'];


    $insertar = @mysql_query("update carrera set codigo='$codigo', nombre='$nombre', sede='$sede' where id='$id'");
    echo "<script>";
        echo "alert('Carrera editada Exitosamente');";  
        echo "window.location = 'carrera.php';";
        echo "</script>"; 
   

?>
</html>