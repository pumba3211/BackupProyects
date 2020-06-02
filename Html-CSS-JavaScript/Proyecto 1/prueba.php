
<?php  
    class conexion{
        //Funcion de traer los Datos de carrera de la base de datos
        function traerCarrera(){
    
$con=mysql_connect("localhost","admin","12345"); //conexion MySQl
mysql_select_db("Proyecto",$con); //Seleccionar base datos
$datos=mysql_query("select * from carrera"); //enviar código MySQL

if($datos == false){
    echo "No se encontro datos en la base de datos";
}
    
while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        echo "<tr>";
         $id = $row['id'];
       echo $codigo = "<td>".$row['codigo']."</td>";
       echo $nombre = "<td>".$row['nombre']."</td>";
       echo $sede = "<td>".$row['sede']."</td>";
       echo  $opciones = "<td><a href='javascript:editarCarrera(".$id.")'><img src='imagenes/edit.png'/></a>
        <a href='javascript:eliminarCarrera(".$id.")'><img class='opciones' src='imagenes/delete.png' /></a></td>";
          
      }
     
mysql_close($con);//cerrar conexion
}
    //Funcion de traer los Datos de carrera de la base de datos
     function traerUsuario(){
$con=mysql_connect("localhost","admin","12345"); //conexion MySQl
mysql_select_db("Proyecto",$con); //Seleccionar base datos
$sql=" select * from carrera"; //código MySQL
$datos=mysql_query("select * from usuario"); //enviar código MySQL

if($datos == false){
    echo "No se encontro datos en la base de datos";
}
      
while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        echo "<tr>";
        echo $id = "<td>".$row['id']."</td>";
        echo $nombre = "<td>".$row['nombre']."</td>";
        echo $usuario = "<td>".$row['usuario']."</td>";
        echo $contrasenna = "<td>".$row['contrasenna']."</td>";
        echo $role = "<td>".$row['role']."</td>";
        echo $opciones = "<td><a href='javascript:editarUsuario(".$row['id'].")'><img src='imagenes/edit.png'/></a>
        <a href='javascript:eliminarUsuario(".$row['id'].")' ><img class='opciones' src='imagenes/delete.png' /></a></td>";
            
      }
    
mysql_close($con);//cerrar conexion
}
    //Funcion de traer los Datos de carrera de la base de datos
     function traerEstudiante(){
$con=mysql_connect("localhost","admin","12345"); //conexion MySQl
mysql_select_db("Proyecto",$con); //Seleccionar base datos
$sql=" select * from carrera"; //código MySQL
$datos=mysql_query("select * from estudiante"); //enviar código MySQL

if($datos == false){
    echo "No se encontro datos en la base de datos";
}
   
while ($row=mysql_fetch_array($datos)) { //Bucle para ver todos los registros
        echo "<tr>";
        echo $foto = "<td><img src=".$row['foto']." class='imgTable'></td>";
        echo $cedula = "<td>".$row['cedula']."</td>";
        echo $nombre = "<td><a class='estudiante' href='javascript:verEstudiante(".$row['cedula'].")'>".$row['nombre']."</a></td>";
        echo $apellidos = "<td>".$row['apellidos']."</td>";
        echo $telefono = "<td>".$row['telefono']."</td>";
        echo $correo = "<td>".$row['correo']."</td>";   
        echo $carrera = "<td>".$row['carrera']."</td>";      
        echo $opciones = "<td><a href='javascript:editarEstudiante(".$row['cedula'].")'><img src='imagenes/edit.png'/></a>
        <a href='javascript:eliminarEstudiante(".$row['cedula'].")' ><img class='opciones' src='imagenes/delete.png' /></a></td>";
          
      }
     
mysql_close($con);//cerrar conexion
}
}
?>