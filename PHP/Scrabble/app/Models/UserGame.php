<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use DB;
class UserGame extends Model
{
    protected $table = 'users_game';
    protected $fillable = ['user_id','game_id','points','user_class','ready'];
    public $timestamps = false;


    public static function getUsersGame($id){
        $users_game=DB::table('users_game')
        ->join('users', 'users.id', '=', 'users_game.user_id')
        ->select('users.id','users.name','users_game.points','users_game.user_class','users_game.user_id')
        ->where('users_game.game_id', '=',$id);
        return $users_game->get();
    }
    public static function count_users_game($game_id){
        $users_game = DB::table('users_game')
        ->select('*')
        ->where('game_id', '=',$game_id);
        return $users_game->count();
    }

//retorna cantidad de usuarios en un juego
    public  static function user_in_game($game_id,$user_id){
        $user = DB::table('users_game')
        ->select('*')
        ->where('game_id', '=',$game_id)
        ->where('user_id', '=',$user_id);
        return $user->count();
    }
    public  static function user_game($game_id,$user_id){
        $user = DB::table('users_game')
        ->select('*')
        ->where('game_id', '=',$game_id)
        ->where('user_id', '=',$user_id);
        return $user->get();
    }
    public  static function assignturn($game_id,$user_id,$class){
        DB::table('users_game')
        ->where('game_id', '=',$game_id)
        ->where('user_id', '=',$user_id)
        ->update(['user_class' => $class]);
    }

    public static function users_ready($game_id){
       $users_game=DB::table('users_game')
           ->select('*')
           ->where('game_id', '=',$game_id)
           ->where('ready', '=',"J");

        return $users_game->count();
    }
    public static function updateReady($game_id,$user_id,$ready){
        DB::table('users_game')
           ->where('game_id', '=',$game_id)
           ->where('user_id', '=',$user_id)
           ->update(['ready' => $ready]);
    }
    public static function updatePoints($game_id,$user_id,$points){
        DB::table('users_game')
           ->where('game_id', '=',$game_id)
           ->where('user_id', '=',$user_id)
           ->update(['points' => $points]);
    }
}