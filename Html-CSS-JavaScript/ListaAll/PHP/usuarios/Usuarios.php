<?php
	class Usuarios{
		static function login($username,$pass,$conexion){
			$esta;
			$sql="SELECT * FROM usuarios;";
			if ($result = $conexion->query($sql)) { 
				while($obj = $result->fetch_object()){
					if($obj->username==$username && $obj->pass==$pass){
						$esta=1;
						break;
					}
					else{
						$esta=0;
					}
				}
			}
			$result->close();
			$conexion-close();
			return $esta;
		}

		static function RegistrarUsuario($username,$pass,$conexion){
			$esta;
			$resultado="";
			$sql="SELECT * FROM usuarios;";	
			if ($result = $conexion->query($sql)) { 
				while($obj = $result->fetch_object()){
					if($obj->username==$username){
						$esta=1;
						break;
					}
					else{
						$esta=0;
					}
				}
				$result->close();
			}
			if($esta==1){
				$resultado="El usuario nombre de usuario ya esta registrado";
			}
			else{
				$sql="INSERT INTO usuarios(username,pass) VALUES('$username','$pass');";	
				if ($result = $conexion->query($sql)) { 
					
				}
				$resultado="Usuario Registrado";	
			}
			$result->close();
			$conexion-close();
			return $resultado;
		}
		static function CambiarContrasena($username,$pass,$pass2,$pass3,$conexion){
			$resultado="";
			if($pass2!=$pass3){
				$resultado="La contraseñas no coincidan";
			}
			else{
				$sql="SELECT * FROM usuarios WHERE username='$username';";
				if ($result = $conexion->query($sql)) { 
					while($obj = $result->fetch_object()){
						if($obj->pass==$pass){

						}
						else{
							$resultado="Tu contraseña no concuerda";
						}
					}
					$result->close();
					$sql="UPDATE usuarios SET pass='$pass2' WHERE username='$username';";	
					if ($result = $conexion->query($sql)) { 
					
					}		
					$resultado="Contraseña cambiada correctamente";
					}
				else{
					$resultado="Ha ocurrido un error";
				}
			}
			return $resultado;
		}
	}
?>