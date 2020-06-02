<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use DB;
class Dictionary extends Model
{
	protected $table = 'dictionary';
	protected $fillable = ['word'];
	public $timestamps = false;

	public static function CompareWord($word){

		$wordToCompare=DB::table('dictionary')      
		->select('*')
		->where('word', '=',$word);
		return $wordToCompare->count();
	}
}