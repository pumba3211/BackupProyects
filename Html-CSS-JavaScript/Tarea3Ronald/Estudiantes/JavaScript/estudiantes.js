function EventosBotonnes(){
	$( ".eliminar" ).click(function() { 
        var confirmacion=confirm("Desea Este estudiante?");
        if(confirmacion){
        	var cedula = $(this).data('eliminar');
        	$.post('PHP/eliminarestudiante.php',"cedula="+cedula, function(data){
        	     		
        	});
        }  
    });
    $( ".Editar" ).click(function() { 
       var cedula = $(this).data('editar');
       location.href="editarestudiante.php?cedula="+cedula;
    });
}
