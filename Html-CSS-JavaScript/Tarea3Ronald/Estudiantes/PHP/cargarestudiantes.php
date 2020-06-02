<?php 

require('conexionbd.php');

$conexionbd= ConectarseBd();

$sql = "SELECT a.cedula,a.nombre,a.apellidos,a.email,a.codigo_carrera,b.nombre_carrera
        from estudiantes as a,carreras as b where a.codigo_carrera=b.codigo_carrera;";

if ($result = $conexionbd->query($sql)) { 
    $estudiantes = "<table id=\"estudiantes\"";
    $estudiantes.="<tr><td><strong>Cedula</td></strong><td><strong>Nombre</td></strong><td><strong>Apellidos</td></strong><td><strong>Email</td></strong><td><strong>Codigo Carrera</td></strong><td><strong>Nombre de carrera</td></strong><td><strong>Eliminar</td></strong><td><strong>Editar</td></strong></tr>";
    while($obj = $result->fetch_object()){ 
        $estudiantes.="<tr><td>$obj->cedula</td><td>$obj->nombre</td><td>$obj->apellidos</td><td>$obj->email</td><td>$obj->codigo_carrera</td><td>$obj->nombre_carrera</td><td><button class=\"eliminar\" data-eliminar=\"$obj->cedula\">Eliminar</button></td><td><button class=\"editar\" data-editar=\"$obj->cedula\">Editar</button></td></tr>";
    }
    $estudiantes.="</table>";
} 
$result->close();
$conexionbd->close();
?>