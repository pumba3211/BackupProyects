  $(document).ready(function(){
  	$('.modal-trigger').leanModal();
  	$('#modal1').closeModal();
  });

  $(document).ready(function(){
  	$('.tooltipped').tooltip({delay: 50});
  });
///////////////////////////////////////////////////////////////////

//cuando le doy eliminar me traigo el id
function delete_click(param){
  //setear valor al si del modal
  $('#si').attr('data-value',param);
}

//me trae 
function delete_modal(){
	var value = $('#si').data('value');
	$('#delete'+ value).submit();
}
//editar
$("input[type=radio]").click(function() {

	if ($("#fc_editar").is(':checked')) {
		var div_contenedor = ($("#dias").has("input").length ? true : false);
		if (div_contenedor == false) {
			$('#dias').append(
				'<div id= "condicion">'+
				'<input id="dias" name="dias" placeholder="Numero de Dias" type="number" class="validate">' +
				'</div>'
				);
		};
	}
	else{
		$('#dias_cliente').remove();
	}
});



$("input[type=radio]").click(function() {

	var div_contenedor = ($("#dias").has("input").length ? true : false);
	if ($("#fc").is(':checked') && (div_contenedor == false)) {

		$('#dias').append(
			'<div id= "condicion">'+
			'<input id="dias" name="dias" placeholder="Numero de Dias" type="number" class="validate">' +
			'</div>'
			);
	}
	else{
		$('#condicion').remove();
	}
});