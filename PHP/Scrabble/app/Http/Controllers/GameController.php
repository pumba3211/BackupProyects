<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Http\Requests;
use App\Http\Controllers\Controller;
use DB;
use App\Models\Game;
use App\Models\UserGame;
use App\Models\Letters;
use App\Models\GameLetters;
use App\Http\Controllers\GameController;
use App\Models\GameHistory;
use App\Models\UserLetters;

class GameController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return Response
     */
    public function index()
    {
        return view('games.index');
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return Response
     */
    public function create()
    {

    }

    public function start_game($id_game)
    {
        Game::change_State($id_game,'S');
        GameController::assignTurns($id_game);
        Game::passturn($id_game,"player1");
        return \Redirect::action('GameController@show',array('id' => $id_game));
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  Request  $request
     * @return Response
     */
    public function store(Request $request)
    {
        //create game
        $game = Game::create(\Input::all());

        $letters = Letters::all();
        foreach ($letters as $letter) {
            GameLetters::create(array('game_id' => $game->id , 
                'letter_id' => $letter->id ,'letter_count' => $letter->count));
        }
        UserGame::create(array('user_id' => \Auth::User()->id,'game_id' => $game->id, 'points' => 0,'user_class' => "",'ready' => "N"));
        GameController::generate_letters($game->id);

        return $game->id;
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return Response
     */
    public function show($id)
    {
        $game = Game::find($id);
        
        $userjoin = UserGame::user_in_game($id,\Auth::User()->id);
        $user_id = 0;

        if(\Auth::User() != null){
            $user_id = \Auth::User()->id;
        }
        $game_data = GameController::gameData($id,$user_id);
        return view('games.show',compact('game_data','game','userjoin'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  Request  $request
     * @param  int  $id
     * @return Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return Response
     */
    public function destroy($id)
    {
        //
    }

    //trae el id de jugadores asociados al juego
    public function users_game($gameid){
        return UserGame::getUsersGame($gameid);
    }

    public function gameData($id){
        $game_History = GameHistory::getGameHistory($id);
        $game_Letters = GameLetters::getGameLetters($id);
        $users_Game = UserGame::getUsersGame($id);
        $game = Game::find($id);
        $player = array();
        $user_letters = array();
        if(\Auth::User() != null){
            $user_letters = UserLetters::user_Letters($id,\Auth::User()->id);
            $player = UserGame::user_game($id,\Auth::User()->id);
        }
        return $gamedata = array('game'=>$game,'game_history'=>$game_History,'game_letters'=>$game_Letters,'users_game'=>$users_Game,'user_letters'=>$user_letters,'player' => $player);
    }

    public function start($game_id){

        if (UserGame::count_users_game($id)  > 2) {
           Game::starGame($game_id);
           GameController::assignTurns($game_id);
           return \Redirect::action('GameController@show',array('id' => $game_id));
           Game::change_State($game_id,'S');
       }else{
        return "No se puede iniciar con menos de dos jugadores";
    }
}     

public function generate_letters($game_id){
    if(UserLetters::alreadyLetters(\Auth::User()->id,$game_id) == 0){
        $array_user_letters = array();
        $game_Letters = GameLetters::getGameLetters($game_id);
        $max = count($game_Letters);
        for($i = 0 ;$i < 7; $i++){   
            $option = false;
            do{
                $random = rand ( 0 , $max -1);
                if($game_Letters[$random]->letter_count == 0) {
                    $option = true;
                }
                else{
                    $row = array('game_id'=>$game_id,'user_id'=> \Auth::User()->id, 'letterboard' => "letter".$i,'letter_id' => $game_Letters[$random]->letter_id);
                    UserLetters::create($row);
                    $game_Letters[$random]->letter_count=$game_Letters[$random]->letter_count-1;
                    $option = false;
                }

            }while($option);
        }
        GameLetters::updateGamesLetter($game_Letters,$game_id);
    }
}

public function re_generate_letters(Request $request){
    $game_Letters = GameLetters::getGameLetters($request->game_id);
    $max = count($game_Letters);
    foreach ($request->user_letters as $value) {
        if($value['letter'] == ""){
            $option = false;
            do{
                $random = rand ( 0 , $max -1);
                if($game_Letters[$random]->letter_count == 0) {
                    $option = true;
                }
                else{
                    UserLetters::update_user_letter($request->game_id,\Auth::User()->id,$value['letterboard'],$game_Letters[$random]->letter_id);
                    $game_Letters[$random]->letter_count=$game_Letters[$random]->letter_count-1;
                    $option = false;
                }
            }while($option);
        }
    }
}
public function InsertHistory(Request $request){
    $history = $request->history;
    GameHistory::insertNewHistory($history,\Auth::User()->id);
}

//retorna todos los juegos no iniciados
public function game_state(){
    return Game::game_stateless();   
}
//recibe game_id
public function join($id){
    $response = "";
    if(UserGame::count_users_game($id) < 4){
            //verifica q un usuario haga join dos veces
        if(UserGame::user_in_game($id,\Auth::User()->id) == 0){
                //asocia un jugador mas al juego
            UserGame::create(array('user_id' => \Auth::User()->id,'game_id' => $id, 'points' => 0,'user_class' => "",'ready' => "N"));
            $response = "You sucessfully join it";
            GameController::generate_letters($id);
        }   
        else{
            return "You have already join it to the game";
        }
    }
    else{
        $response = "The game is full";
    }
    return $response;
}


public function getgame($id){
    return Game::find($id);
}

public function assignTurns($game_id){
    $countplayers = UserGame::count_users_game($game_id);
    $players = UserGame::getUsersGame($game_id);
    $temarray = array();
    for($i = 1 ; $i <= $countplayers ; $i++){
        $random = rand ( 1 , $countplayers );
        $evaluate = false;
        do{
            if(GameController::validatenum($random ,$temarray)){
             $evaluate = true;
             $random = rand ( 1 , $countplayers );
         }
         else{
            $temarray[] = $random;
            $evaluate = false;
            UserGame::assignturn($game_id,$players[$i-1]->user_id,"player".$random);
        }
    }while($evaluate);
}
}

public function validatenum($num , $array){
    if($array != [] ){            
        foreach ($array as $index) {
            if($num == $index){
                return true;
            }
        }
    }
    return false;
}

public function pass_turn(Request $request){
    $users = UserGame::getUsersGame($request->gameid);
    $users_ready = UserGame::users_ready($request->gameid);
    $cant_turn=UserGame::count_users_game($request->gameid);
    $game=Game::find($request->gameid);
    $nextturn = "";
    $turn=intval(substr($game->user_playing, -1, 1));

    if($cant_turn == $users_ready){
        Game::change_State($request->gameid,'X');
    }
    else{   
        if($turn == $cant_turn){
            $nextturn = "player1";
            foreach ($users as $user) {
                UserGame::updateReady($request->gameid,$user->id,'N');
            }
        }
        else{
            $nextturn = "player".($turn+1);  
        }
        Game::passturn($request->gameid,$nextturn);
    }
}


public function jump(Request $request){
    UserGame::updateReady($request->gameid,\Auth::User()->id,'J');
    GameController::pass_turn($request);
}
public function increasePoints(Request $request){
     $user = UserGame::user_game($request->gameid,\Auth::User()->id);
     $points = $user[0]->points + $request->points;
     UserGame::updatePoints($request->gameid,\Auth::User()->id,$points);
}
}