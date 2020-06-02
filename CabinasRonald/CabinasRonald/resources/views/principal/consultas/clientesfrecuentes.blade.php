@extends('layouts.principal_master')
@extends('principal.navconsultas')
@section('content')
    <section>
        <div id="dvClientes">
            <br/>
            <div class="container divstyle1">
                <input type="hidden" id="settabletype" value="2"/>
                <div class="container ">
                    <h2>Clientes Frecuentes</h2>
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
                <div id="clientes">
                    <div class="row">
                        <div class="col-md-4">
                            <h4>Clientes Totales:</h4>
                        </div>
                        <div class="col-md-3">
                            <h4>{{$cantidadclientes}}</h4>
                        </div>
                    </div>
                    <div class="table-responsive">
                        <table class="table" id="tablaclientes">
                            <tr>
                                <th>Cedula</th>
                                <th>Nombre</th>
                                <th>Apellidos</th>
                                <th>Ultima Visita</th>
                                <th>Número de Visitas</th>
                            </tr>
                            @forelse($clientes as $cliente)
                                <tr class="click-row" data-id="{{$cliente->id}}">
                                    <td data-id="{{$cliente->id}}">{{$cliente->cedula}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->nombre}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->apellidos}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->ultimavisita}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->visitas}}</td>
                                </tr>
                            @empty
                                <tr>
                                    <td colspan="5" style="text-align:center">No hay datos que mostrar.
                                    </td>
                                </tr>
                            @endforelse
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection
