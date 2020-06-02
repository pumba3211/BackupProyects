<?php

namespace App\Http\Controllers;

use App\Http\Requests;
use Illuminate\Http\Request;
use App\Models\Reservacion;
use App\Http\Funciones;

class HomeController extends Controller
{
    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('auth');
    }

    /**
     * Show the application dashboard.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('home');
    }
    public function register()
    {
        return view('auth.register');
    }
    public function pruebas()
    {
        $date = date("Y") . '-' . date('m') . '-' . date("d");
        $reservaciones = Reservacion::obtenerReservacionesFechaFinalizar($date);
        foreach ($reservaciones as $reservacion) {
            $reservacion = Reservacion::find($reservacion->id);
            $reservacion->factura = 1;
            $reservacion->ingresos = Funciones::CalcularPrecio($reservacion);
            $reservacion->save();
        }
    }
    public function phpinfo()
    {
        return view('phpinfo');
    }
}
