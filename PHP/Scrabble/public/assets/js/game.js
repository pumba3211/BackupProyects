var lock = false;


//traer los juegos que no han iniciado
$(document).ready(function(){
    joinable_games()
    refres_joinable_games();
    $("#start_game").hide();
    $("#start_join_game").hide();    
    $('select').material_select();
});

function updategame(tiempoEspera ) {
    $.ajax({
        url: "/games/" + gameid + "/getgame",
        type: "GET",
        success: function (data) {
            if(data.change == 'S' && data.user_playing != player[0].user_class){
                setTimeout("getGameData()", time);
            }
            else{
                reUpdateGame(time);
            }
        }
    });
}

function reUpdateGame(tiempoEspera){
    setTimeout("updategame()", tiempoEspera);
}

function drag_end(event, ui){
    var xPos = parseInt( ui.offset.left );
    var yPos = parseInt( ui.offset.top );
}

function drop_detected(event, ui ){
    ui.draggable.draggable( 'disable' );
    $(this).val(ui.draggable.text());
    $(this).droppable('disable');
    $(this).addClass('played');
    user_letters[ui.draggable.data('position')].letter="";
    $(this).attr('data-value',ui.draggable.data('value'));
    addhistory.push({'game_id':gameid,'positionid':$(this).attr('id'),'letter':ui.draggable.text()});
    ui.draggable.position( { of: $(this), my: 'left top', at: 'left top' } );
    ui.draggable.draggable( 'option', 'revert', false );
    var draggable = ui.draggable;
}

function users_info(users_game){
    $("#scorebody").empty();
    for(var i =0 ; i < users_game.length; i++){
        if(game.user_playing == users_game[i].user_class){
            var row ='<tr class="playing"><td>'+users_game[i].name+'</td><td>'+ users_game[i].points+'</td></tr>';
        }
        else{
            var row ='<tr><td>'+users_game[i].name+'</td><td>'+ users_game[i].points+'</td></tr>';
        }
        $('#scorebody').append(row);
    }
}

function letters_users(users_letters){
    $("#playerletters").empty();
    var tabla ='<tr>';
    for (var i = 0; i < 7; i++) {
        tabla += '<td class="letter" id="letter'+ i +'" data-position="'+ i +'" data-value="'+  user_letters[i].xxx +'">' + user_letters[i].letter + '</td>';
    }
    $('#playerletters').append(tabla);
    $('.letter').draggable({
        containment: '#gameboard',
        cursor : 'move',
        stop: drag_end,
        revert : true});
    $('td').droppable({
        drop: drop_detected,
    });
}

function getGameData(){
    var datos;
    $.ajax({
        url: "/games/" + gameid + "/gamedata",
        type: "GET",
        success: function (data) {
           var game_history = data.game_history;
           var game_letters = data.game_letters;
           var users_game = data.users_game;
           user_letters = data.user_letters;
           game=data.game;
           player=data.player;
           arrayletters = game_letters;
           for (var i = 0 ;i < game_history.length;i++) {
            $("#" + game_history[i].positionid).text("" + game_history[i].letter);
            $("#" + game_history[i].positionid).addClass("showletter");
            $("#" + game_history[i].positionid).addClass("data_letter"); 
            $("#" + game_history[i].positionid).val("" + game_history[i].letter);
            $("#" + game_history[i].positionid).attr('data-value',game_history[i].xxx);

        }
        letters_users(user_letters);
        users_info(users_game);
        $('.letter').draggable('enable');
        $('#btns').show();
        if(game.user_playing != player[0].user_class){
            $('.letter').draggable('disable');
            $('#btns').hide();            
        }
    }    
});
updategame(time);
}

function Join(){
    $.ajax({
        url: "/games/" + gameid + "/join",
        type: "GET",
        success: function (data) {
            $("#resultado").text(data);
        }
    });
}

//crea un nuevo juego
function createGame(){    
    $( "select" ).prop( "disabled", true );
    lock = true;
    console.log(lock);

    //limpiar los div
    $('#new_game').empty();
    $('#players').empty();

    var state = {'state':'N'};
    $.ajax({
        url: "/games",
        data:state,
        datatype:'json',
        type: "POST",
        success: function (data) {
            $("#new_game").append('<h5>Your Game Id: ' + data + '</h5>');

            sessionStorage.setItem('game_id', data);            
            //jugadores asociados al juego
            update_players(data);
            users_game(data);
        }
    });  
}

function startGame(){
  var game_id = sessionStorage.getItem('game_id');
  //alert('gameid' + game_id);

  $.ajax({
    url: "games/" + game_id + "/start_game",
    type: "POST",
    success: function (data) {
        verify_start_game();
    }
});
}

//trae los usuarios asociados a un juego
function users_game (gameid){
    if ($('#crear').is(':visible')) {
        setTimeout("update_players(" + gameid + ")", time);
    }  
}

function update_players(gameid){
  $.ajax({
    url: "/games/" + gameid + "/users_game",
    type: "GET",
    success: function (data) {
        $("#players").empty();

        for (var i = 0; i < data.length; i++) {
            $("#players").append('<h5>Player Name: ' + data[i].name + '</h5>');
        };

        if (data.length >= 2) {
            $("#start_game").show();
        };
    }
});
  users_game(gameid);
  verify_start_game();
}

//trae los usuarios asociados a un juego
function users_game_joined (gameid){
    if ($('select').is(':visible')) {
        setTimeout("update_players_join(" + gameid + ")", time);
    }  else{
        alert('select no visible');
    }
}

function update_players_join(gameid){

  $.ajax({
    url: "/games/" + gameid + "/users_game",
    type: "GET",
    success: function (data) {
        $("#players_on_game").empty();

        for (var i = 0; i < data.length; i++) {
            $("#players_on_game").append('<h5>Player Name: ' + data[i].name + '</h5>');
        }

        if (data.length >= 2) {
            $("#start_join_game").show();
        }
    }
});
  users_game_joined(gameid);
  verify_start_game();
}

//juegos disponibles para unirme
function joinable_games(){
    $.ajax({
        url: "games/game_state",
        datatype:'json',
        type: "GET",
        success: function (data) {
           $(".select").empty();
           var sentence = "<label>Join to Game ID:</label><select onclick='getval(this);' class='browser-default'>"

           for (var i = 0; i < data.length; i++) {
            sentence += "<option value='" + data[i].id + "'>" + data[i].id + "</option>";
        }
        sentence += "</select>";
        $(".select").append(sentence);
        $('select').prop("disabled", lock);
    }
});
    refres_joinable_games();
}


function refres_joinable_games(){
    setTimeout("joinable_games()", time);
}

function getval(sel) {
    $('#crear').prop( "disabled", true );

    $.ajax({
        url: "/games/" + sel.value + "/join",
        type: "GET",
        success: function (data) {
            $( "select" ).prop( "disabled", true );
            update_players_join(sel.value);
            sessionStorage.setItem('game_id', sel.value);
            users_game_joined(sel.value);
        }
    });
}


function Regenerate_Letters(){
    var data = {'game_id':gameid ,'user_letters':user_letters};
    $.ajax({
        url: "/games/regenerateletters",
        data:data,
        datatype:'json',
        type: "POST",
        success: function (data) {

        }
    });     
}

function Add_History(){
    var data = {'history':addhistory};
    $.ajax({
        url: "/games/addhistory",
        data:data,
        datatype:'json',
        type: "POST",
        success: function (data) {
        }
    });     
}

function Pass_turn(){
    var data = {'gameid':gameid};
    $.ajax({
        url: "/games/passturn",
        data:data,
        datatype:'json',
        type: "POST",
        success: function (data) {
        }
    });     
}

function endturn(){
    Regenerate_Letters();
    Add_History();
    Pass_turn();
    getGameData();
}


function jump(){
   var data = {'gameid':gameid};
   $.ajax({
    url: "/games/jump",
    data:data,
    datatype:'json',
    type: "POST",
    success: function (data) {
    }
});

}
//verifica si el juego no ha iniciado
function verify_start_game(){
    var game_id = sessionStorage.getItem('game_id');

    $.ajax({
        url: "/games/" + game_id + "/getgame",
        type: "GET",
        success: function (data) {

            if(data.state == 'S'){   
                reUpdate_start_game(true);    
                window.location.href = "http://" + location.host + "/games/" + game_id;
            }
            else{
                reUpdate_start_game(false);
            }
        }
    });  
}

function reUpdate_start_game(start){
    if (start == false) {
        setTimeout("verify_start_game()", time);
    };    
}


function give_up(){
    alert('giveup');
}
function update_Player_Points(points){
    var data = {'gameid':gameid, 'points':points};
    $.ajax({
        url: "/games/increasePoints",
        data:data,
        datatype:'json',
        type: "POST",
        success: function (data) {
        }
    });
}