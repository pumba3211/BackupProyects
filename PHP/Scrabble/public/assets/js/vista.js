$( document ).ready(function() {
    $('.letter').draggable({
        containmentBy: '.row',
        cursor : 'move',
        stop: drag_end,
        revert : true});

    $('td').droppable({
        drop: drop_detected,
    });
});

function drag_end(event, ui){
    var xPos = parseInt( ui.offset.left );
    var yPos = parseInt( ui.offset.top );
    //alert( "Drag stopped!\n\nOffset: (" + xPos + ", " + yPos + ")\n");
}

function drop_detected(event, ui ){
    ui.draggable.draggable( 'disable' );
    $(this).value = ui.draggable.text();
    $(this).droppable( 'disable' );
    ui.draggable.position( { of: $(this), my: 'left top', at: 'left top' } );
    ui.draggable.draggable( 'option', 'revert', false );
    var draggable = ui.draggable;
    //alert( 'The square with ID "' + draggable.attr('id') + '" was dropped onto me!' );
}

////////////

function generaLetras(){
    var tabla ='<tr>';
    for (var i = 0; i < 7; i++) {
        tabla += '<td class="letter" id="letter'+ i +'">k</td>'
    }
    $('#playerletters').append(tabla);
}


function generateGame() {
    var table = '<table id="game" border="1">';
    for (var x = 0; x < 15; x++) {
        table += '<tr>';
        for (var y = 0; y < 15; y++) {
           table += '<td class="yellow" id="c' + x + '_' + y + '"></td>';
       }
   }
   table += '</table>';
   document.getElementById("game").innerHTML=table;
   fillColors();
}


function getGameData(){
    var datos;
    var gameid = $("#gameid").val();
    $.ajax({
        url: "/games/"+gameid+"/gamedata",
        type: "GET",
        success: function (data) {
         var game_history=data.game_history;
         var game_letters=data.game_letters;
         var users_game=data.users_game;
         for (var i=0 ;i < game_history.length;i++) {
            $("#"+game_history[i].positionid).text(""+game_history[i].letter);
            $("#"+game_history[i].positionid).addClass("showletter");      
        }
    }
});
}
var reds=[{'x':0,'y':0},{'x':0,'y':7},{'x':0,'y':14},{'x':7,'y':0},{'x':7,'y':14},{'x':14,'y':0},{'x':14,'y':7},{'x':14,'y':14}];
var pinks=[{'x':1,'y':1},{'x':2,'y':2},{'x':3,'y':3},{'x':4,'y':4},{'x':4,'y':10},{'x':3,'y':11},{'x':2,'y':12},{'x':1,'y':13},{'x':13,'y':1},{'x':12,'y':2},{'x':11,'y':3},{'x':10,'y':4},{'x':13,'y':13},{'x':12,'y':12},{'x':11,'y':11},{'x':10,'y':10},{'x':7,'y':7}];
var blues=[{'x':5,'y':1},{'x':9,'y':1},{'x':5,'y':13},{'x':9,'y':13},{'x':1,'y':5},{'x':5,'y':5},{'x':9,'y':5},{'x':13,'y':5},{'x':1,'y':9},{'x':5,'y':9},{'x':9,'y':9},{'x':13,'y':9}];
var light_blues=[{'x':3,'y':0},{'x':11,'y':0},{'x':0,'y':3},{'x':0,'y':11},{'x':14,'y':3},{'x':14,'y':11},{'x':3,'y':14},{'x':11,'y':14},{'x':2,'y':6},{'x':3,'y':7},{'x':2,'y':8},{'x':6,'y':2},{'x':8,'y':2},{'x':7,'y':3},{'x':12,'y':6},{'x':11,'y':7},{'x':12,'y':8},{'x':7,'y':11},{'x':6,'y':12},{'x':8,'y':12},{'x':6,'y':6},{'x':8,'y':6},{'x':6,'y':8},{'x':8,'y':8}];

function fillColors(){

    for (var i = 0; i < reds.length; i++) {
        var id = "#c" + reds[i].x +"_" + reds[i].y;
        updateColortable(id,"red");
    }
    for (var i = 0; i < pinks.length; i++) {
        var id = "#c" + pinks[i].x + "_" + pinks[i].y;
        updateColortable(id,"pink");
    }
    for (var i = 0; i < blues.length; i++) {
        var id = "#c" + blues[i].x + "_" + blues[i].y;
        updateColortable(id,"blue");
    }
    for (var i = 0; i < light_blues.length; i++) {
        var id = "#c" + light_blues[i].x + "_" + light_blues[i].y;
        updateColortable(id,"light_blue");
    }
}

function updateColortable(id, classColor){
    $(id).removeClass("yellow");
    $(id).addClass(classColor);
}