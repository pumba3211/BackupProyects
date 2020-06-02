<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use DB;
class GameLetters extends Model
{
    protected $table = 'game_letters';
    protected $fillable = ['game_id','letter_id','letter_count'];
    public $timestamps = false;

    public static function getGameLetters($id){

        $game_Letters=DB::table('game_letters')
        ->join('count_of_letters', 'count_of_letters.id', '=', 'game_letters.letter_id')
        ->select('game_letters.letter_count','count_of_letters.letter','game_letters.letter_id')
        ->where('game_letters.game_id', '=',$id);
        return $game_Letters->get();
    }

    public static function updateGamesLetter($ArrayLetters,$game_id){
        foreach ($ArrayLetters as $letter) {
            DB::table('game_letters')
            ->where('letter_id', $letter->letter_id)
            ->where('game_id', $game_id)
            ->update(['letter_count' => $letter->letter_count]);
        }      
    }
}