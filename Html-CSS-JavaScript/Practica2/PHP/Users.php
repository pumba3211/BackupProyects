<?php
	require_once("conexion.php");
	class Users{
		public $First_name;
		public $Last_name;	
		public $Username;
		public $Email;
		function __construct($First_name,$Last_name,$Username,$Email){
			$this->First_name=$First_name;
			$this->Last_name=$Last_name;
			$this->Username=$Username;
			$this->Email=$Email;
		}
		function Save(){
			$conexionbd= ConectarseBd();
			$sql="INSERT INTO usuarios (firstname,lastname,nombre_usuario,email) VALUES ('$this->First_name','$this->Last_name','$this->Username','$this->Email')";	
			if ($result = $conexionbd->query($sql)) { 
				return $conexionbd->insert_id;
			}	
			$conexionbd->close();
		}
		static function Cargar_Usario($id){
			$conexion=ConectarseBd();
			$sql = "SELECT * FROM usuarios WHERE id_usuario='$id';";
	    	if ($result = $conexion->query($sql)) { 
	        $Usuario="";
		        while($obj = $result->fetch_object()){ 
		          $Usuario .="<label> Nombre: $obj->firstname</label></br>";
		          $Usuario .="<label> Apellido: $obj->lastname</label></br>";
		          $Usuario .="<label> Usuario: $obj->nombre_usuario</label></br>";
		          $Usuario .="<label> Email: $obj->email</label></br></br>";
		        	}   
				}
			$Usuario.="<h1>Amigos en </h1><br/>";
			$result->close();
			$conexion->close();
			return $Usuario;	
		}
	}
?>