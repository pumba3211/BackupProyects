<?php namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Letters extends Model
{
    protected $table = 'count_of_letters';
    protected $fillable = ['letter','count','value'];
    public $timestamps = false;
}