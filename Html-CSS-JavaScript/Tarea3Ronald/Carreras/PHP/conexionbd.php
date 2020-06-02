<?php
	function ConectarseBd(){
		$conexion=new mysqli("localhost","root","","tarea3");

		if($conexion->connect_errno){
			 printf("Conexion Fallida: %s\n", $conexion->connect_error);
			 exit();
		} 
		return $conexion;
	}
?>	