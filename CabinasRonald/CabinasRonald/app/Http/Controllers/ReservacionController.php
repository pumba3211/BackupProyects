<?php

namespace App\Http\Controllers;

use App\Models\Empresa;
use App\Models\Reservacion;
use Illuminate\Http\Request;
use App\Http\Requests;
use App\Http\Controllers\Controller;
use Psy\Util\Json;
use App\Http\Funciones;
use App\Models\Cabina;
use App\Models\Cliente;
use App\Http\Requests\ReservacionRequest;

class ReservacionController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $cabinas = Cabina::all();
        return view('principal.reservaciones.index', compact('cabinas'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $cabinas = Cabina::all();
        $clientes = Cliente::ObtenerClientesTable();
        if (count($cabinas) > 0 && count($clientes) > 0) {
            return view('principal.reservaciones.create', compact('cabinas', 'clientes'));
        } else {
            return view('principal.reservaciones.index', compact('cabinas'))->withErrors(["No se puede crear una reservación si no se han ingresado alguna cabina y cliente previamente, agrega una cabina y un cliente. "]);
        }
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function store(ReservacionRequest $request)
    {
        $message = " ";
        $cliente = Cliente::find($request->id_cliente);
        $cabina = Cabina::find($request->id_cabina);
        $date = Funciones::fechaActual();
        if ($request->fecha_reservacion >= $date) {
            if ($cabina != null && $cliente != null) {
                if (Reservacion::ValidarReservacion($request->id_cabina, $request->fecha_reservacion, $request->fecha_cancelacion) == 0
                ) {
                    if (Reservacion::ValidarReservacionCliente($request->id_cliente,
                            $request->fecha_reservacion, $request->fecha_cancelacion) == 0
                    ) {
                        if (Funciones::ValidarEspacio($cabina, $request->cant_personas)) {
                            $reservacion = Reservacion::create(['id_cabina' => $request->id_cabina, 'id_cliente' => $request->id_cliente,
                                'fecha_reservacion' => $request->fecha_reservacion, 'fecha_cancelacion' => $request->fecha_cancelacion,
                                'cant_personas' => $request->cant_personas, 'factura' => $request->factura]);
                            if ($request->factura == 1) {
                                $reservacion->ingresos = Funciones::CalcularPrecio($reservacion);
                                $reservacion->save();
                            }
                            $cliente->ultimavisita = $date;
                            $cliente->visitas = $cliente->visitas + 1;
                            $cliente->save();
                            $cabinas = Cabina::all();
                            return view('principal.reservaciones.index', compact('cabinas'));
                        } else {
                            return \Redirect::back()->withErrors(["La cantidad ingresada supera el espacio disponible."]);
                        }
                    } else {
                        return \Redirect::back()->withErrors(["El cliente " . $cliente->nombre . " " . $cliente->apeliidos . " ya se encuentra hospedado en otra cabina en dicha fecha."]);
                    }
                } else {
                    return \Redirect::back()->withErrors(["Ya se ha registrado una reservación para ese día o fecha, en la cabina."]);
                }
            } else {
                return \Redirect::back()->withErrors(["La cabina o el cliente no existen"]);
            }
        } else {
            return \Redirect::back()->withErrors(["No se pueden crear reservaciones con fechas anteriores."]);
        }
    }

    /**
     * Display the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $reservacion = Reservacion::find($id);
        $cabina = Cabina::find($reservacion->id_cabina);
        $cliente = Cliente::find($reservacion->id_cliente);
        $empresa = Empresa::find($cliente->id_empresa);
        return view('principal.reservaciones.show', compact('reservacion', 'cliente', 'cabina', 'empresa'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $cabinas = Cabina::all();
        $clientes = Cliente::all();
        $reservacion = Reservacion::find($id);
        return view('principal.reservaciones.edit', compact('cabinas', 'clientes', 'reservacion'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function update(ReservacionRequest $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $reservacion = Reservacion::find($id);
        if ($reservacion != null && $reservacion->factura == 0) {
            $cliente = Cliente::find($reservacion->id_cliente);
            $cliente->visitas = $cliente->visitas - 1;
            $cliente->save();
            $reservacion->delete();
        } else {
            return "La reservación ya se encuentra cancelada.";
        }
    }

    public function obtenerRerservaciones()
    {

        return Funciones::obtenerRerservaciones();
    }

    public function reservacionesPorFecha($date)
    {
        $reservaciones = Reservacion::obtenerReservacionesFecha($date);
        return view('principal.reservaciones.fecha', compact('reservaciones'));
    }

    public function showModalAccionesReservacion($id)
    {
        return view('principal.reservaciones.modalReservaciones', compact('id'));
    }
}