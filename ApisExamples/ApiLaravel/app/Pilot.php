<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Pilot extends Model
{
    protected $table = "pilots";

    protected $fillable = ['license', 'name', 'flying_hours'];

    public function programmings()
    {
        return $this->hasMany('App\Programming');
    }
}
