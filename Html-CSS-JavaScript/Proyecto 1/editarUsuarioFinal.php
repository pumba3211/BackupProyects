<html>
<meta charset="utf-8">
<?php
    require_once('funciones.php');
    conectar('localhost','admin','12345','Proyecto');

    $id= $_POST['id'];
    $usuario= $_POST['usuario'];
    $contrasenna= $_POST['contrasenna'];
    $nombre= $_POST['nombre'];
    $role= $_POST['role'];
    $edit = $_POST['edit'];


    $insertar = @mysql_query("update usuario set id='$id', usuario='$usuario', contrasenna='$contrasenna', nombre ='$nombre',role ='$role' where id='$edit'");
    header("Location:usuario.php");
   

?>
</html>