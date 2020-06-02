<!DOCTYPE html>
<html>
<head>
    <!-- Importamos nuestros CSS -->
    <link rel="stylesheet" href="css/reveal.css"> 
    <link rel="stylesheet" type="text/css" href="css/tabmenu.css">
    
    <!-- Importamos los scripts necesarios -->
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.6.min.js"></script>
    <script type="text/javascript" src="js/jquery.reveal.js"></script>
    <script type="text/javascript" src="js/util.js"></script>
    <script type="text/javascript" src="js/jquery.min"></script>
<meta charset=utf-8 />
<title>Estudiantes</title>

</head>
<body>
<div class="conteiner">
        <img class="logo" src="imagenes/UTN.png">
        <p id="perfil">Perfiles</p>

        <p id="salir"> Hola Admin</p> 
        <a id="salir" href="index.html"><img src="imagenes/exitHover.png"></a>

           
            
            <a id="dashboard" href="admin.html">Dashboard <strong> > Busqueda</strong></a>
            
      <div id="myModal" class="reveal-modal">
             <form action="resultado.php" method="post" id="formularioBuscar">
            <a href="javascript:buscar()" class="close-reveal-modal"><img src="imagenes/buscar.png" class="Buscar"></a>
      <input type="texto" name="buscar" placeholder="Buscar" class="textoBuscar">
            </form>
      </div>
</div>    
</body>
</html>

