reservaciones = [];
function cambiarUrl(url) {
    window.location = url;
}
function cambiarUrlTab(url) {
    window.open(url, '_blank');
}
function borrarCabina(id) {
    var CSRF_TOKEN = $('meta[name="csrf-token"]').attr('content');
    $.ajax({
        url: '/principal/cabinas/' + id,
        type: 'DELETE',
        data: {_token: CSRF_TOKEN},
        dataType: 'JSON',
        success: function (data) {
        }
    });
    recargarCabinas();
}
function borrarCliente(id) {
    procesando("tablaclientes");
    var CSRF_TOKEN = $('meta[name="csrf-token"]').attr('content');
    $.ajax({
        url: '/principal/clientes/' + id,
        type: 'DELETE',
        data: {_token: CSRF_TOKEN},
        dataType: 'JSON',
        success: function (data) {
            ocultarProcesando();
        }
    });
    recargarClientes();
}
function borrarReservacion(id) {
    procesando("dvReservaciones");
    var CSRF_TOKEN = $('meta[name="csrf-token"]').attr('content');
    $.ajax({
        url: '/principal/reservaciones/' + id,
        type: 'DELETE',
        data: {_token: CSRF_TOKEN},
        success: function (r) {
        }
    }).done(function (r) {
        if (r.length > 0) {
            $("#responseText").text(r);
        }
        else {
            $('#editarAcciones').modal('hide');
            obtenerReservaciones(1);
        }
        ocultarProcesando();
    });
}
function borrarFoto(id, idr, tipo) {
    procesando("dvIMAGENES");
    var CSRF_TOKEN = $('meta[name="csrf-token"]').attr('content');
    $.ajax({
        url: '/deletefoto/',
        type: 'POST',
        data: {_token: CSRF_TOKEN, id: id, idr: idr, tipo: tipo},
        success: function (data) {
            ocultarProcesando();
        }
    });
    if (tipo == 1) {
        recargarFotosCabina();
    }
    else {
        recargarFotosCliente();
    }

}
function obtenerview(url, parametros, contenido) {
    var geturl = "/" + url + "?" + parametros
    $.get(geturl, function (data) {
        $("#" + contenido).html("ASdasdasd");
    });
}

function recargarCabinas() {
    procesando("tablacabinas");
    $.ajax({
        url: '/tabla_cabinas',
        type: 'GET',
        success: function (data) {
            $("#tablacabinas").html(data);
            fnButtons();
            setTableEvent();
            ocultarProcesando("tablacabinas");
        }
    });
}
function recargarClientes() {
    procesando("tablaclientes");
    $.ajax({
        url: '/tabla_clientes',
        type: 'GET',
        success: function (data) {
            $("#tablaclientes").html(data);
            fnButtons();
            setTableEvent();
            ocultarProcesando("tablaclientes");
        }
    });
}

function recargarFotosCabina() {
    var id = $("#idrelacion").val();
    $.ajax({
        url: '/Fotos_cabinas/' + id,
        type: 'GET',
        success: function (data) {
            $("#tablaimagenes").html(data);
            fnButtons();
            setTableEvent();
        }
    });
}
function recargarFotosCliente() {
    var id = $("#idrelacion").val();
    $.ajax({
        url: '/Fotos_clientes/' + id,
        type: 'GET',
        success: function (data) {
            $("#tablaimagenes").html(data);
            fnButtons();
            setTableEvent();
        }
    });
}


function setTableEvent() {
    $(".click-row td:not(:last-child)").click(function () {  //td:not(:last-child)
        var type = $("#settabletype").val();
        switch (type) {
            case "1":
                cambiarUrlTab("/principal/cabinas/" + $(this).data("id"));
                break;
            case "2":
                cambiarUrlTab("/principal/clientes/" + $(this).data("id"));
                break;
            case "3":
                cambiarUrlTab("/principal/reservaciones/" + $(this).data("id"));
                break;
            case "4":
                $.ajax({
                    url: '/principal/fotos/' + $(this).data("id"),
                    type: 'GET',
                    success: function (data) {
                        $("#divImage").html(data);
                        $('#imagemodal').modal('show');
                    }
                });
                break;
        }
    });
    $(".click-image").click(function () {  //td:not(:last-child)
        $.ajax({
            url: '/principal/fotos/' + $(this).data("id"),
            type: 'GET',
            success: function (data) {
                $("#divImage").html(data);
                $('#imagemodal').modal('show');
            }
        });
    });
}

function SetDropzone() {
    Dropzone.options.myDropzone = {
        autoProcessQueue: false,
        uploadMultiple: true,
        maxFilezise: 15,
        init: function () {
            var submitBtn = document.querySelector("#submit");
            myDropzone = this;

            submitBtn.addEventListener("click", function (e) {
                e.preventDefault();
                e.stopPropagation();
                myDropzone.processQueue();
            });
            this.on("addedfile", function (file) {

            });
            this.on("processing", function () {
                this.options.autoProcessQueue = true;
                procesando("dvIMAGENES");
            });
            this.on("complete", function (file) {
                myDropzone.removeFile(file);
                var tipo = $("#tipo").val();
                if (tipo == "1") {
                    recargarFotosCabina();
                }
                else {
                    recargarFotosCliente();
                }
            });
            this.on("success", function (file, responseText) {
                $("#mensajeUpload").text(responseText);
                ocultarProcesando();
            });
        }
    };
}
function setCalendar() {
    if (location.pathname == "/principal/reservaciones") {
        obtenerReservaciones();
    }
}
function obtenerReservaciones(refresh) {
    procesando("dvReservaciones");
    var utc = new Date().toJSON().slice(0, 10);
    $.ajax({
        url: '/obtenerReservaciones/',
        type: 'GET',
        success: function (data) {
            if (refresh == 1) {
                $('#calendar').fullCalendar('removeEvents');
                $('#calendar').fullCalendar('addEventSource', data);
                $('#calendar').fullCalendar('refetchEvents');
            }
            else {
                $('#calendar').fullCalendar({
                    defaultDate: utc,
                    editable: true,
                    lang: "es",
                    eventLimit: true, // allow "more" link when too many events
                    events: data,
                    dayClick: function (date, jsEvent, view) {
                        cambiarUrlTab(localizacion + "/principal/reservaciones/fecha/" + date.format());
                    },
                    eventClick: function (calEvent) {
                        console.log();
                        $("#reservacionver").attr("data-id", calEvent.id);
                        $("#reservacioneliminar").attr("data-id", calEvent.id);
                        $("#reservacioneditar").attr("data-id", calEvent.id);
                        $('#editarAcciones').modal('show');
                    }
                });
                ocultarProcesando("dvReservaciones");
            }

            reservaciones = data;
        }
    });
    ocultarProcesando("dvReservaciones");
}

function SearchClienteSelect(busqueda) {
    procesando("dvcrearReservacion");
    if (busqueda.length > 0) {
        $.ajax({
            url: "/busquedaClienteSelect/" + busqueda,
            type: "GET",
            success: function (data) {
                ocultarProcesando();
                $("#id_cliente").html(data);
            }
        });
    }
}
function SearchEmpresaSelect(busqueda) {
    procesando("dvcrearCliente");
    if (busqueda.length > 0) {
        $.ajax({
            url: "/busquedaEmpresaSelect/" + busqueda,
            type: "GET",
            success: function (data) {
                ocultarProcesando();
                $("#id_empresa").html(data);
            }
        });
    }
}
function SearchClienteTable(busqueda) {
    procesando("tablaclientes");
    if (busqueda.length > 0) {
        $.ajax({
            url: "/busquedaClienteTable/" + busqueda,
            type: "GET",
            success: function (data) {
                $("#tablaclientes").html(data);
                fnButtons();
                setTableEvent();
                ocultarProcesando();
            }
        });
    }
    else {
        recargarClientes();
    }
}

function tablesearchSelectEvent() {
    var type = $("#settabletype").val();
    switch (type) {
        case "2":
            busquedaClientesFrecuentesFecha();
            break;
        case "3":
            busquedaIngresosFecha();
            break;
    }
}


function busquedaClientesFrecuentesFecha() {
    $.ajax({
        url: '/clientesfrecuentes/' + $("#seleccionaranio").val() + "-" + $("#seleccionarmes").val(),
        type: 'GET',
        success: function (data) {
            $("#clientes").html(data);
            setTableEvent();
        }
    });
}

function busquedaIngresosFecha() {
    $.ajax({
        url: '/ingresos/' + $("#seleccionaranio").val() + "-" + $("#seleccionarmes").val(),
        type: 'GET',
        success: function (data) {
            $("#ingresos").html(data);
            setTableEvent();
        }
    });
}

function procesando(div) {
    $("#" + div).append("<div id='procesando' class='container loading-gif'>" +
        "<button class='btn btn-lg'><span class='glyphicon glyphicon-refresh glyphicon-refresh-animate'>" +
        "</span>Cargando</button></div>");
}
function ocultarProcesando() {
    $("#procesando").remove("");
}