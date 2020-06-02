<?php
	function ConectarseBd(){
		$conexion=new mysqli("localhost","root","","examen");
		$conexion->set_charset("utf8");
		if($conexion->connect_errno){
			 printf("Conexion Fallida: %s\n", $conexion->connect_error);
			 exit();
		} 
		return $conexion;
	}
?>	