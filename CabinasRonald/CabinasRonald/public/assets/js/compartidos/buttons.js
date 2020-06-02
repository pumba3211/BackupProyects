var localizacion = "http://" + location.host;
function fnButtons() {
    $("#cabinacrear").bind("click", function () {
        cambiarUrl(localizacion + "/principal/cabinas/create");
    });
    $(".cabinaeliminar").bind("click", function () {
        var id = $(this).data('cabinaidel');
        var answer = confirm("El proceso eliminará la cabina actual, Desea continuar?")
        if (answer) {
            borrarCabina(id);
        }
    });
    $(".cabinaeditar").bind("click", function () {
        cambiarUrl(localizacion + "/principal/cabinas/" + $(this).data('cabinaided') + "/edit");
    });
    $("#subirImagenes").bind("click", function () {
        subirImagenes("formImagenes", "subirImagenes");
    });
    $("#clientecrear").bind("click", function () {
        cambiarUrl(localizacion + "/principal/clientes/create");
    });
    $(".clienteeliminar").bind("click", function () {
        var id = $(this).data('clienteidel');
        var answer = confirm("El proceso eliminará el cliente actual, Desea continuar?")
        if (answer) {
            borrarCliente(id);
        }
    });
    $(".clienteeditar").bind("click", function () {
        cambiarUrl(localizacion + "/principal/clientes/" + $(this).data('clienteided') + "/edit");
    });
    $(".eliminarFoto").bind("click", function () {
        var tipo = $("#tipo").val();
        var id = $(this).attr("data-fotoid");
        var idr = $(this).attr("data-fotoidr");
        var answer = confirm("El proceso eliminará la foto, Desea continuar?")
        if (answer) {
            borrarFoto(id, idr, tipo);
        }
    });
    $("#reservacioncrear").bind("click", function () {
        cambiarUrl(localizacion + "/principal/reservaciones/create");
    });
    $("#reservacionver").bind("click", function () {
        cambiarUrlTab(localizacion + "/principal/reservaciones/" + $(this).data('id'));
    });
    $("#reservacioneliminar").bind("click", function () {
        var answer = confirm("El proceso eliminará la reservacion, Desea continuar?")
        if (answer) {
            borrarReservacion($(this).data('id'));
        }
    });
    $("#reservacioneditar").bind("click", function () {
        cambiarUrl(localizacion + "/principal/reservaciones/edit/" + $(this).data('id'));
    });
    $("#seleccionaranio").change(function () {
        tablesearchSelectEvent();
    });
    $("#seleccionarmes").change(function () {
        tablesearchSelectEvent();
    });
    $("#crearempresa").bind("click", function () {
        cambiarUrl(localizacion + "/principal/empresas/create");
    });
    $(".empresaeditar").bind("click", function () {
        cambiarUrl(localizacion + "/principal/empresas/" + $(this).data('empresaided') + "/edit");
    });
    $("#closeModalReservacion").bind("click", function () {
        $("#responseText").text("");
    });
    $('.page-scroll').removeClass("active");
}