<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use DB;

class UserLetters extends Model
{
    protected $table = 'user_letters';
    protected $fillable = ['game_id','user_id','letterboard','letter_id'];
    public $timestamps = false;

    public static function user_Letters($game_id,$user_id){
         $user_Letters=DB::table('user_letters')
            ->join('count_of_letters','count_of_letters.id','=','user_letters.letter_id')
            ->select('user_letters.letterboard','user_letters.letter_id','count_of_letters.letter','count_of_letters.value as xxx')
            ->where('user_letters.game_id', '=',$game_id)
            ->where('user_letters.user_id', '=',$user_id);
        return $user_Letters->get();
    }
    public static function alreadyLetters($user_id,$game_id){
        $user_Letters=DB::table('user_letters')      
            ->select('*')
            ->where('user_id', '=',$user_id)
            ->where('game_id', '=',$game_id);
        return $user_Letters->count();
    }
    public static function update_user_letter($game_id,$user_id,$letterboard,$letter_id){
        DB::table('user_letters')
        ->where('game_id', '=',$game_id)
        ->where('user_id', '=',$user_id)
        ->where('letterboard', '=',$letterboard)
        ->update(['letter_id' => $letter_id]);
    }
}
    