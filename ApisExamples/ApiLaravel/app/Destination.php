<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Destination extends Model
{
    protected $table = "destinations";

    protected $fillable = ['name', 'description'];

    public function programmings()
    {
        return $this->hasMany('App\Programming');
    }
}
