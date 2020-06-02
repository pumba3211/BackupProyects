<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class Empresa extends Model
{
    protected $table = "empresa";
    protected $fillable = ['nombre'];
    public $timestamps = false;

    public static function buscarEmpresas($busqueda)
    {
        $fotos = DB::table('empresa')
            ->select('*')
            ->where('empresa.nombre', 'LIKE', '%' . $busqueda . '%');
        return $fotos->get();
    }
}
