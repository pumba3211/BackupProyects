<?php
	class Listas{
		static function CargarListas_fecha($conexion){
			$arrayListas=array();
			$sql="SELECT a.username,a.titulo_lista,a.id_lista,a.categoria,b.puntos FROM listas as a,puntos_lista as b,usuarios as c where a.id_lista=b.id_lista and a.username=c.username ORDER BY creat_at DESC;";
			if ($result = $conexion->query($sql)) { 
				while($obj = $result->fetch_object()){
					$array=array("username"=>$obj->username,"titulo"=>$obj->titulo_lista,"id_lista"=>$obj->id_lista,"categoria"=>$obj->categoria,"puntos"=>$obj->puntos);
						$arrayListas[]=$array;
					}
				}
			$result->close();
			$conexion->close();
			return $arrayListas;
		}
		static function CargarListas_puntos($conexion){
			$arrayListas=array();
			$sql="SELECT a.username,a.titulo_lista,a.id_lista,a.categoria,b.puntos FROM listas as a,puntos_lista as b where a.id_lista=b.id_lista ORDER BY puntos DESC;";
			if ($result = $conexion->query($sql)) { 
				while($obj = $result->fetch_object()){
					$array=array("username"=>$obj->username,"titulo"=>$obj->titulo_lista,"id_lista"=>$obj->id_lista,"categoria"=>$obj->categoria,"puntos"=>$obj->puntos);
					$arrayListas[]=$array;
				}
			}
			$result->close();
			$conexion->close();
			return $arrayListas;
		}
		static function Insertar_Lista($username,$titulo_lista,$creat_at,$categoria,$conexion){
			$resulado="";
			$sql="INSERT INTO listas (titulo_lista,username,creat_at,categoria) VALUES ('$titulo_lista','$username','$creat_at','$categoria');";
			if ($result = $conexion->query($sql)) { 
				$resulado="Se ha creado satisfactoriamente";
			}		
			else{
				$resulado="A ocurrido un error";
			}
			$conexion->close();
			return $resulado;
		}
		
	}
?>