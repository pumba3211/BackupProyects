@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <div id="dvReservaciones">
            <br/>
            <meta name="csrf-token" content="{{ csrf_token() }}"/>
            <input type="hidden" id="settabletype" value="3"/>
            <div class="container divstyle1">
                <h2>Reservaciones </h2>
                <div class="container">
                    <button id="reservacioncrear" class="botonCrear botonTipo1">Crear Reservacion</button>
                </div>
                <br/>
                <div class="container">
                    <div class="table-responsive">
                        <table class="table" id="tablacabinas">
                            <tr>
                                <th>Cliente</th>
                                <th>Fecha Inicio</th>
                                <th>Fecha Final</th>
                                <th>Estado</th>
                            </tr>
                            @foreach ($reservaciones as $reservacion)
                                <tr class="click-row" data-id="{{$reservacion->id}}">
                                    <td data-id="{{$reservacion->id}}">{{$reservacion->nombre." ".$reservacion->apellidos}}</td>
                                    <td data-id="{{$reservacion->id}}">{{$reservacion->fecha_reservacion}}</td>
                                    <td data-id="{{$reservacion->id}}">{{$reservacion->fecha_cancelacion}}</td>
                                    @if($reservacion->factura == 0)
                                        <td data-id="{{$reservacion->id}}">Reservada y en uso</td>
                                    @elseif($reservacion->factura == 1)
                                        <td data-id="{{$reservacion->id}}">Cancelada y en uso</td>
                                    @else
                                        <td data-id="{{$reservacion->id}}">Cancelada</td>
                                    @endif
                                </tr>
                            @endforeach
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection

