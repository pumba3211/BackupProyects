<html>
<meta charset="utf-8">
<?php
 class conexion{
        function editarUsuario ($traer){
        
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
        $id = "<label>ID</label><br /><input type='texto' value=".$row['id']."><br /><br />";
        $usuario = "<label>Usuario</label><br /><input type='texto' value=".$row['usuario']."><br /><br />";
        $contrasenna = "<label>Contraseña</label><br /><input type='texto' value=".$row['contrasenna']."><br /><br />";
        $telefono = "<label>Telefono</label><br /><input type='texto' value=".$row['telefono']."><br /><br />";
        $correo = "<label>Correo</label><br /><input type='texto' value=".$row['correo']."><br /><br />";
        $direccion = "<label>Direccion</label><br /><input type='texto' value=".$row['direccion']."><br /><br />";
            echo $id,$usuario,$contrasenna,$telefono,$correo,$direccion;
      }
     // echo "</table";
mysql_close($con);//cerrar conexion
}
}
?>
</html>