@extends('layouts.principal_master')
@extends('principal.navconsultas')
@section('content')
    <section>
        <div id="dvIngresos">
            <br/>
            <div class="container divstyle1">
                <input type="hidden" id="settabletype" value="3"/>
                <div class="container ">
                    <h2>Ingresos Totales</h2>
                    <div class="form-group form-horizontal">
                        <label class="col-md-1 control-label">Año:</label>
                        <div class="col-md-3">
                            <select id="seleccionaranio" class="form-control">
                                <option value="2016">2016</option>
                                <option value="2017">2017</option>
                            </select>
                        </div>
                        <label class="col-md-1 control-label">Mes:</label>
                        <div class="col-md-3">
                            <select id="seleccionarmes" class="form-control">
                                <option value="01">Enero</option>
                                <option value="02">Febrero</option>
                                <option value="03">Marzo</option>
                                <option value="04">Abril</option>
                                <option value="05">Mayo</option>
                                <option value="06">Junio</option>
                                <option value="07">Julio</option>
                                <option value="08">Agosto</option>
                                <option value="09">Septiembre</option>
                                <option value="10">Octubre</option>
                                <option value="11">Noviembre</option>
                                <option value="12">Diciembre</option>
                            </select>
                        </div>
                    </div>
                </div>
                <br/>
                <div id="ingresos">
                    <div class="row">
                        <div class="col-md-4">
                            <h4>Ingresos Totales:</h4>
                        </div>
                        <div class="col-md-3">
                            <h4>{{$ingresos}}</h4>
                        </div>
                    </div>
                    <div class="table-responsive">
                        <table class="table" id="tabla_ingresos">
                            <tr>
                                <th>#Reservacion</th>
                                <th>Cliente</th>
                                <th>Fecha Inicio</th>
                                <th>Fecha Final</th>
                                <th>Estado</th>
                                <th>Ingresos</th>
                            </tr>
                            @forelse($reservaciones as $reservacion)
                                <tr class="click-row" data-id="{{$reservacion->id}}">
                                    <td data-id="{{$reservacion->id}}">{{$reservacion->id}}</td>
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
                                    <td data-id="{{$reservacion->id}}">{{$reservacion->ingresos}}</td>
                                </tr>
                            @empty
                                <tr>
                                    <td colspan="6" style="text-align:center">No hay datos que mostrar.</td>
                                </tr>
                            @endforelse
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection
