function fnButtons() {
    $("#consultar").bind("click", function () {
        var datos = new Array();
        console.log(post(317));
        console.log(post(318));
    });
}

function convertirini() {
    var DateSplit = this['tcFechaInicio'].value.split("-");
    var Year = DateSplit[0];
    var Month = DateSplit[1];
    var Day = DateSplit[2];
    var NewDate = Day + '/' + Month + '/' + Year;
    return NewDate;
}

function convertirfin() {
    var DateSplit = this['tcFechaFinal'].value.split("-");
    var Year = DateSplit[0];
    var Month = DateSplit[1];
    var Day = DateSplit[2];
    var NewDate = Day + '/' + Month + '/' + Year;
    return NewDate;
}

function post(type) {
    var arrayresult = new Array();
    var url = "http://indicadoreseconomicos.bccr.fi.cr/indicadoreseconomicos/WebServices/wsIndicadoresEconomicos.asmx";
    var soap = '<?xml version="1.0" encoding="utf-8"?>' +
        '<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">' +
        '<soap:Body>' +
        '<ObtenerIndicadoresEconomicos  xmlns="http://ws.sdde.bccr.fi.cr">' +
        '<tcIndicador>' + type + '</tcIndicador>' +
        '<tcFechaInicio>' + convertirini() + '</tcFechaInicio>' +
        '<tcFechaFinal>' + convertirfin() + '</tcFechaFinal>' +
        '<tcNombre>' + "Ronald" + '</tcNombre>' +
        '<tnSubNiveles>N</tnSubNiveles>' +
        '</ObtenerIndicadoresEconomicos>' +
        '</soap:Body>' +
        '</soap:Envelope>';
    $.ajax({
        type: "POST",
        url: url,
        contentType: "text/xml",
        dataType: "xml",
        data: soap,
        type: "POST",
        success: function (data, status, req, xml, xmlHttpRequest, responseXML) {
            var myObj = new Array();
            $(req.responseXML)
                .find('Datos_de_INGC011_CAT_INDICADORECONOMIC').find('INGC011_CAT_INDICADORECONOMIC')
                .each(function () {
                    myObj.push($(this));
                });
            for (var i = 0; i < myObj.length; i++) {
                var arraynode = new Array();
                var fecha = myObj[i].find('DES_FECHA').text();
                var valor = myObj[i].find('NUM_VALOR').text();
                arraynode.push(fecha);
                arraynode.push(valor);
                arrayresult.push(arraynode);
                console.log(arrayresult);
            }
        },
        error: function (jqXHR, textStatus) {
            console.log(textStatus);
        }

    })
    return arrayresult;
}