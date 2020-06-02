<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class Reservacion extends Model
{
    protected $table = 'reservacion';

    protected $fillable = ['id_cabina', 'id_cliente', 'fecha_reservacion', 'fecha_cancelacion', 'factura', 'cant_personas', 'ingresos'];

    public $timestamps = false;

    public static function obtenerReservaciones()
    {
        $reservaciones = DB::table('reservacion')
            ->join('cliente', 'cliente.id', '=', 'reservacion.id_cliente')
            ->join('cabina', 'cabina.id', '=', 'reservacion.id_cabina')
            ->select('reservacion.id', 'reservacion.fecha_reservacion', 'reservacion.fecha_cancelacion', 'cabina.color'
                , 'cliente.nombre', 'cliente.apellidos')
            ->orderBy('reservacion.id', 'ASC');
        return $reservaciones->get();
    }


    public static function obtenerReservacionesFecha($date)
    {
        $reservaciones = DB::table('reservacion')
            ->join('cliente', 'cliente.id', '=', 'reservacion.id_cliente')
            ->select('reservacion.id', 'reservacion.fecha_reservacion', 'reservacion.fecha_cancelacion', 'reservacion.factura'
                , 'cliente.nombre', 'cliente.apellidos')
            ->where('reservacion.fecha_reservacion', '<=', $date)
            ->where('reservacion.fecha_cancelacion', '>=', $date);
        return $reservaciones->get();
    }

    public static function ValidarReservacion($id_cabina, $fecha_reservacion, $fecha_cancelacion)
    {
        $reservaciones = DB::table('reservacion')
            ->select('reservacion.id', 'reservacion.fecha_reservacion', 'reservacion.fecha_cancelacion', 'cabina.color'
                , 'cliente.nombre', 'cliente.apellidos')
            ->where('reservacion.id_cabina', '=', $id_cabina)
            ->whereBetween('fecha_reservacion', [$fecha_reservacion, $fecha_cancelacion]);
        return $reservaciones->count();
    }

    public static function ValidarReservacionCliente($id_cliente, $fecha_reservacion, $fecha_cancelacion)
    {
        $reservaciones = DB::table('reservacion')
            ->select('reservacion.id', 'reservacion.fecha_reservacion', 'reservacion.fecha_cancelacion', 'cabina.color'
                , 'cliente.nombre', 'cliente.apellidos')
            ->where('reservacion.id_cliente', '=', $id_cliente)
            ->whereBetween('fecha_reservacion', [$fecha_reservacion, $fecha_cancelacion]);
        return $reservaciones->count();

    }

    public static function reservacionesMes($date)
    {
        $reservaciones = DB::table('reservacion')
            ->select('reservacion.*')
            ->where('reservacion.fecha_reservacion', 'LIKE', '%' . $date . '%')
            ->orderBy('reservacion.id_cliente', 'ASC');
        return $reservaciones->get();
    }


    public static function obtenerReservacionesFechaFinalizar($date)
    {
        $reservaciones = DB::table('reservacion')
            ->select('*')
            ->where('reservacion.fecha_reservacion', '=', $date);
        return $reservaciones->get();
    }

    public static function ultimasReservaciones()
    {
        $reservaciones = DB::table('reservacion')
            ->join('cliente', 'cliente.id', '=', 'reservacion.id_cliente')
            ->select('reservacion.id', 'cliente.cedula', 'reservacion.fecha_reservacion',
                'reservacion.fecha_cancelacion', 'reservacion.factura'
                , 'cliente.nombre', 'cliente.apellidos', 'reservacion.ingresos')
            ->orderBy('reservacion.id', 'DESC');
        return $reservaciones->take(50)->get();
    }

    public static function obtenerReservacionesFechaIngresos($date)
    {
        $reservaciones = DB::table('reservacion')
            ->join('cliente', 'cliente.id', '=', 'reservacion.id_cliente')
            ->select('reservacion.id', 'reservacion.fecha_reservacion', 'cliente.cedula',
                  'reservacion.fecha_cancelacion', 'reservacion.factura'
                , 'cliente.nombre', 'cliente.apellidos', 'reservacion.ingresos')
            ->where('reservacion.fecha_reservacion', 'LIKE', '%' . $date . '%')
            ->orderBy('reservacion.id', 'DESC');
        return $reservaciones;
    }

}
