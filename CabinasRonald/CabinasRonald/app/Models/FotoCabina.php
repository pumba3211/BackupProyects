<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class FotoCabina extends Model
{
    protected $table = "fotos_cabina";

    protected $fillable = ['id_foto', 'id_cabina'];

    public $timestamps = false;

    public static function buscarFotosCabina($id)
    {
        $fotos = DB::table('fotos')
            ->join('fotos_cabina', 'fotos_cabina.id_foto', '=', 'fotos.id')
            ->select('fotos_cabina.id as idr', 'fotos.id', 'fotos.imagenurlcompact', 'fotos.imagenurl')
            ->where('fotos_cabina.id_cabina', '=', $id)
            ->orderBy('fotos.id', 'DESC');
        return $fotos->paginate(8);
        $fotos->setPath('/principal/cabinas' . $id . '/edit');
    }

    public static function buscarFotosCabinaGET($id)
    {
        $fotos = DB::table('fotos')
            ->join('fotos_cabina', 'fotos_cabina.id_foto', '=', 'fotos.id')
            ->select('fotos_cabina.id as id_t', 'fotos.id', 'fotos.imagenurlcompact')
            ->where('fotos_cabina.id_cabina', '=', $id)
            ->orderBy('fotos.id', 'DESC');
        return $fotos->paginate(8);

    }

}
