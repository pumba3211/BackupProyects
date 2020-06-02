<?php
    class conexion{
      function traerCarrera(){
    
$con=mysql_connect("localhost","admin","12345"); //conexion MySQl
mysql_select_db("Proyecto",$con); //Seleccionar base datos
$datos=mysql_query("select * from carrera"); //enviar código MySQL
//$prueba=mysql_result($datos, 0);
//echo $prueba;
if($datos == false){
    echo "No se encontro datos en la base de datos";
}
     //echo "<table border='1'><tr><td>Código</td><td>Nombre</td><td>Duración</td><td>Horario</td><td>Nivel de Titulo</td><td>Sedes</td></tr>";   
while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        echo "<tr>";
         $id = $row['id'];
       echo $codigo = "<td>".$row['codigo']."</td>";
       echo $nombre = "<td>".$row['nombre']."</td>";
       echo $sede = "<td>".$row['sede']."</td>";
       echo  $opciones = "<td><a href='javascript:editarCarrera(".$id.")'><img src='imagenes/edit.png'/></a>
        <a href='javascript:eliminarCarrera(".$id.")'><img class='opciones' src='imagenes/delete.png' /></a></td>";
           // echo "<td>$codigo</td><td>$nombre</td><td>$sede</td><td>$opciones</td></tr>";
      }
     // echo "</table";
mysql_close($con);//cerrar conexion
}
}
?>