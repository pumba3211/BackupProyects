<?php
	require_once("conexion.php");
	class Provinces{
		static function get_all(){
			$conexion=ConectarseBd();
			$sql = "SELECT * FROM provincias;";

	    	if ($result = $conexion->query($sql)) { 
	        $checbox="";
		        while($obj = $result->fetch_object()){ 
		          $checbox .="<input type=\"checkbox\" name=\"provincias[]\" value=\"$obj->id_provincia\"/>$obj->nombre_provincia</input></br>";
		        	}   
				}
			$result->close();
			$conexion->close();
			return $checbox;
		}
		static function InsertarRelacion($id_usuario,$id_provincia){
			$conexionbd= ConectarseBd();
			$sql="INSERT INTO usuario_provincia(id_usuario,id_provincia) VALUES ('$id_usuario','$id_provincia')";		
			if ($result = $conexionbd->query($sql)) { 
				return $conexionbd->insert_id;
			}
			$conexionbd->close();	
		}
		static function CargarProvincias_Usuario($id){
			$conexion=ConectarseBd();
			$sql="SELECT DISTINCT a.id_provincia,a.nombre_provincia FROM provincias AS a,usuario_provincia AS b WHERE b.id_usuario='$id' AND a.id_provincia=b.id_provincia;";
			if ($result = $conexion->query($sql)) { 
	        $Provincias="";
		        while($obj = $result->fetch_object()){ 
		          		$Provincias.="<label>$obj->id_provincia $obj->nombre_provincia</label><br/>";
		        	}   
				}
			$result->close();
			$conexion->close();
			return $Provincias;	
		}
	}
?>