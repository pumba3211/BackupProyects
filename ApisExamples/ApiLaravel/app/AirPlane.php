<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class AirPlane extends Model
{
    protected $table = "airplanes";

    protected $fillable = ['name', 'flying_hours'];


    public function programmings()
    {
        return $this->hasMany('App\Programming');
    }
}
