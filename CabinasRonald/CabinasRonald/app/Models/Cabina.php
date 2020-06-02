<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Cabina extends Model
{
    protected $table = "cabina";
    protected $fillable = ['televizor', 'abanico', 'ducha', 'cama', 'camamatrimonial','refrigeradora','color'];
    public $timestamps = false;


    public function fotos_cabina()
    {
        return $this->hasMany('\app\Models\FotoCabina');
    }
}
