@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <br/>
    <section>
        <div class="container" id="dvcrearReservacion">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            {!!Form::open(array('url' => "/principal/reservaciones/", 'method' => 'POST','class'=>'form-horizontal','role'=>'form'))!!}
                            <h3 style="text-align: center">Crear Reservacion</h3>
                            </br>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Cabina:</label>
                                <div class="col-md-6">
                                    <select id="id_cabina" name="id_cabina" class="form-control">
                                        @foreach($cabinas as $cabina)
                                            <option value="{{$cabina->id}}">{{"Cabina ".$cabina->id}}</option>
                                        @endforeach
                                    </select>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Buscar Cliente::</label>
                                <div class="col-md-6">
                                    <input type="text" id="busqueda_cliente"
                                           onkeyup="SearchClienteSelect(this.value)"
                                           class="form-control">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Cliente:</label>
                                <div class="col-md-6">
                                    <select id="id_cliente" name="id_cliente" class="form-control">
                                        @foreach($clientes as $cliente)
                                            <option value="{{$cliente->id}}">{{$cliente->nombre." ".$cliente->apellidos}}</option>
                                        @endforeach
                                    </select>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Reservar desde:</label>
                                <div class="col-md-6">
                                    <input type="date" id="fecha_reservacion" name="fecha_reservacion"
                                           class="form-control">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Reservar hasta:</label>
                                <div class="col-md-6">
                                    <input type="date" id="fecha_cancelacion" name="fecha_cancelacion"
                                           class="form-control">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Personas:</label>
                                <div class="col-md-6">
                                    <input type="number" id="cant_personas" name="cant_personas"
                                           class="form-control">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Estado:</label>
                                <div class="col-md-6">
                                    <select id="factura" name="factura" class="form-control">
                                        <option value="0">Reservada y en uso</option>
                                        <option value="1">Cancelada y en uso</option>
                                    </select>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1">
                                        Crear Reservacion
                                    </button>
                                </div>
                            </div>
                            {!!Form::close()!!}
                            @if(count($errors) > 0)
                                <div class="alert alert-danger">
                                    <strong>Ha Ocurido un problema!</strong><br>
                                    <ul>
                                        @foreach ($errors->all() as $error)
                                            <li>{{ $error }}</li>
                                        @endforeach
                                    </ul>
                                </div>
                            @endif
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection