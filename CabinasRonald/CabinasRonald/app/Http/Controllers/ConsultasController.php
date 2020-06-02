<?php
namespace App\Http\Controllers;

use App\Http\Funciones;
use App\Models\Cliente;
use App\Models\Reservacion;

class ConsultasController extends Controller
{
    public function clientesFrecuentes()
    {
        $clientes = Cliente::ObtenerClientesTable();
        $cantidadclientes = count(Cliente::all());
        return view('principal.consultas.clientesfrecuentes', compact('clientes', 'cantidadclientes'));
    }

    public function clientesFrecuentesFecha($fecha)
    {
        $clientes = Cliente::clientesFrecuentes($fecha);
        $clientes = Funciones::limparCeros($clientes);
        $cantidadclientes = count($clientes);
        return view('principal.consultas.clientesfrecuentesfecha', compact('clientes', 'cantidadclientes'));
    }

    public static function Ingresos()
    {
        $ingresos = Reservacion::all()->sum('ingresos');
        $reservaciones = Reservacion::ultimasReservaciones();
        return view('principal.consultas.ingresos', compact('reservaciones', 'ingresos'));
    }

    public static function IngresosBusquedaFechas($date)
    {
        $reservacionesDB = Reservacion::obtenerReservacionesFechaIngresos($date);
        $ingresos = $reservacionesDB->sum('ingresos');
        $reservaciones = $reservacionesDB->get();
        return view('principal.consultas.table_ingresos', compact('reservaciones', 'ingresos'));
    }
}