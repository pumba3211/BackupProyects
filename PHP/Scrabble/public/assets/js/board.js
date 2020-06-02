function generateGame() {
    var table = '<table id="game" border="1">';
    for (var x = 0; x < 15; x++) {
        table += '<tr>';
        for (var y = 0; y < 15; y++) {
           table += '<td class="board green-background" data-value = "" id="c' + x + '_' + y + '"></td>';
       }
   }
   table += '</table>';
   document.getElementById("game").innerHTML=table;
   fillColors();
}

function fillColors(){

    for (var i = 0; i < reds.length; i++) {
        var id = "#c" + reds[i].x +"_" + reds[i].y;
        updateColortable(id,"red-background");
    }
    for (var i = 0; i < pinks.length; i++) {
        var id = "#c" + pinks[i].x + "_" + pinks[i].y;
        updateColortable(id,"pink-background");
    }
    for (var i = 0; i < blues.length; i++) {
        var id = "#c" + blues[i].x + "_" + blues[i].y;
        updateColortable(id,"blue-background");
    }
    for (var i = 0; i < light_blues.length; i++) {
        var id = "#c" + light_blues[i].x + "_" + light_blues[i].y;
        updateColortable(id,"light_blue-background");
    }
}

function updateColortable(id, classColor){
    $(id).removeClass("green-background");
    $(id).addClass(classColor);
}