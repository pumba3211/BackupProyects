<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Programming extends Model
{
    protected $table = "programmings";

    protected $fillable = ['airplane_id', 'destination_id', 'pilot_id', 'start', 'end'];

    public function pilot()
    {
        return $this->belongsTo('App\Pilot');
    }

    public function destination()
    {
        return $this->belongsTo('App\Destination');
    }

    public function airplane()
    {
        return $this->belongsTo('App\Airplane');
    }
}
