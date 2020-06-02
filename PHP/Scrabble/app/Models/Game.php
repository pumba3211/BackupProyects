<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use DB;

class Game extends Model
{
    protected $table = 'game';
    protected $fillable = ['state','user_playing','change'];
    public $timestamps = false;

    public static function updateTurn($user_playing){

    }
    public static function change_State($game_id,$state){
    	DB::table('game')
        ->where('id', '=',$game_id)
        ->update(['state' => $state]);
    }

    public static function game_stateless(){
       $games =  DB::table('game')->select('*')
       ->where('state', '=','N');
       return $games->get();
   }
   public static function passturn($game_id,$turn){
      DB::table('game')
        ->where('id', '=',$game_id)
        ->update(['user_playing' => $turn, 'change' => "S"]);
   }
}