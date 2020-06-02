<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Fotos extends Model
{
    protected $table = "fotos";

    protected $fillable = ['nombre', 'extencion', 'imagenurl', 'imagenurlcompact'];

    public $timestamps = false;

}
