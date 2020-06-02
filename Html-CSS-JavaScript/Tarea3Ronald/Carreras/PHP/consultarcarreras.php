<?php
	require("conexionbd.php");
	$conexion=ConectarseBd();
	header('Content-Type: application/json; charset=utf-8');

	$rows = array();
	$index=0;

	if ($result = $conexion->query("SELECT * FROM `carreras`")) {

    while($row = $result->fetch_array(MYSQL_ASSOC)) {
            //$rows[]=$row;
    		$row['codigo_carrera']=utf8_encode($row['codigo_carrera']);
            $row['nombre_carrera']=utf8_encode($row['nombre_carrera']);
            array_push($rows,$row);           
    }
    
  	echo json_encode($rows,JSON_HEX_TAG | JSON_HEX_APOS | JSON_HEX_QUOT | JSON_HEX_AMP | JSON_UNESCAPED_UNICODE);
    //while ($row = mysql_fetch_array($result, MYSQL_ASSOC)) {  		
	//}
}
$result->close();
$conexion->close()	
?>
