<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" type="text/css" href="css/tabmenu.css">
<script type="text/javascript" src="js/util.js"></script>
<script type="text/javascript" src="js/jquery.min.js"></script>
<meta charset=utf-8 />
<title>Usuarios</title>
</head>
<body>
<div class="conteiner">
        <img class="logo" src="imagenes/UTN.png">
        <p id="perfil">Perfiles</p>

        <p id="salir"> Hola Admin</p> 
        <a id="salir" href="index.html"><img src="imagenes/exitHover.png"></a>

           <a id="dashboard" href="admin.html">Dashboard <strong> > Usuario</strong></a>

  <div id="navbar">
    <div id="holder">
    <ul>
    <li><a href="admin.html">Dashboard</a></li>
    <li><a href="carrera.php">Carreras</a></li> 
    <li><a href="estudiante.php">Estudiantes</a></li> 
    <li><a href="usuario.php" id="onlink">Usuarios</a></li>            
    </ul>
    
    </div><!--end holder div-->
    </div><!--end navbar div-->

    <div class="tabContent">
        <p>Listado de Usuarios</p><hr />          
               
            <a href="agregarUsuarios.html"><img class="agregar" src="imagenes/agregar.png"/></a>         
            <table border="1px">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Nombre</td>
                    <td>Usuario</td>
                    <td>Contrasenna</td>
                    <td>Role</td>
                    <td>Opciones</td>
                </tr>
                </thead>
                 <?php
                include("prueba.php");
                $con = new conexion();
                $con->traerUsuario();
             ?>
            </table>
             <form  action="eliminarUsuario.php" method="post" id="formularioUsuario">
               <input type="hidden" name="id" id="id">
           </form>

            <form  action="editarUsuario.php" method="post" id="formularioEditarUsuario">
               <input type="hidden" name="editid" id="editid">
           </form>
    </div>
</div>    
</body>
</html>