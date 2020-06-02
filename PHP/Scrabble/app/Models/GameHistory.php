<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use DB;
class GameHistory extends Model
{
    protected $table = 'game_history';
    protected $fillable = ['game_id','user_id','positionid','letter'];
    public $timestamps = false;

    public static function getGameHistory($id){
        $game_History=DB::table('game_history')
        ->join('count_of_letters', 'count_of_letters.letter', '=', 'game_history.letter')
        ->select('game_history.game_id','game_history.user_id','game_history.positionid','game_history.letter','count_of_letters.value as xxx' )
        ->where('game_history.game_id', '=',$id);

        return $game_History->get();
    }

    public static function insertNewHistory($newhistory,$user_id){
    	foreach ($newhistory as $row) {
    		$newrow = array('game_id' => $row['game_id'], 'user_id' => $user_id,'positionid' => $row['positionid'],'letter' => $row['letter']);
    		\App\Models\GameHistory::create($newrow);
    	}
    }
}