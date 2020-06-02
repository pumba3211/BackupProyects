<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class Cliente extends Model
{
    protected $table = "cliente";

    protected $fillable = ['cedula', 'nombre', 'apellidos', 'visitas', 'telefono', 'id_empresa', 'primeravisita', 'ultimavisita'];

    public $timestamps = false;

    public function fotos_cliente()
    {
        return $this->hasMany('\app\Models\FotoCliente');
    }

    public function empresa()
    {
        return $this->hasMany('\app\Models\Empresa');
    }

    public static function buscarClientes($busqueda)
    {
        $clientes = DB::table('cliente')
            ->join('empresa', 'empresa.id', '=', 'cliente.id_empresa')
            ->select('cliente.id', 'cliente.cedula', 'cliente.nombre', 'cliente.apellidos', 'cliente.telefono',
                'cliente.visitas', 'empresa.id as id_empresa', 'empresa.nombre as empresanombre',
                'cliente.primeravisita', 'cliente.ultimavisita')
            ->where('cliente.nombre', 'LIKE', '%' . $busqueda . '%')
            ->orWhere('cliente.apellidos', 'LIKE', '%' . $busqueda . '%')
            ->orWhere('empresa.nombre', 'LIKE', '%' . $busqueda . '%');
        return $clientes->take(20)->get();
    }

    public static function ObtenerClientesTable()
    {
        $clientes = DB::table('cliente')
            ->join('empresa', 'empresa.id', '=', 'cliente.id_empresa')
            ->select('cliente.id', 'cliente.cedula', 'cliente.nombre', 'cliente.apellidos', 'cliente.telefono',
                'cliente.visitas', 'empresa.id as id_empresa', 'empresa.nombre as empresanombre',
                'cliente.primeravisita', 'cliente.ultimavisita')
            ->orderBy('cliente.visitas', 'DESC');
        return $clientes->take(20)->get();
    }

    public static function clientesFrecuentes($date)
    {
        $clientes = DB::Select('select c.id,c.cedula,c.nombre,c.apellidos,(select count(*) from reservacion
                    where id_cliente = c.id and fecha_reservacion like \'%' . $date . '%\')as visitas,
                    c.telefono,c.id_empresa, c.ultimavisita
                    from cliente as c where c.visitas != 0 ORDER BY visitas DESC');
        return $clientes;
    }
}
