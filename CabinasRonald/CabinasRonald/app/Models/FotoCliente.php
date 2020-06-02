<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class FotoCliente extends Model
{
    protected $table = 'fotos_cliente';

    protected $fillable = ['id_foto', 'id_cliente'];

    public $timestamps = false;

    public static function buscarFotosCliente($id)
    {
        $fotos = DB::table('fotos')
            ->join('fotos_cliente', 'fotos_cliente.id_foto', '=', 'fotos.id')
            ->select('fotos_cliente.id as idr', 'fotos.id', 'fotos.imagenurlcompact', 'fotos.imagenurl')
            ->where('fotos_cliente.id_cliente', '=', $id)
            ->orderBy('fotos.id', 'DESC');
        return $fotos->paginate(8);
    }

    public static function buscarFotosClienteGET($id)
    {
        $fotos = DB::table('fotos')
            ->join('fotos_cliente', 'fotos_cliente.id_foto', '=', 'fotos.id')
            ->select('fotos_cliente.id as id_t', 'fotos.id', 'fotos.imagenurlcompact')
            ->where('fotos_cliente.id_cliente', '=', $id)
            ->orderBy('fotos.id', 'DESC');
        return $fotos->get();
    }



}
