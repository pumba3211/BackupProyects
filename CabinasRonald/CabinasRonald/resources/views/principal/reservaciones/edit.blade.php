@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <br/>
        <div id="dvcrearReservacion" class="container">
            <br/>
            <div class="container divstyle1 divsize1">
                {!!Form::open(array('url' => "/principal/reservaciones/$reservacion->id", 'method' => 'PUT','class'=>'form-horizontal','role'=>'form'))!!}
                <h3 style="text-align: center">Crear Reservacion</h3>
                </br>
                <div class="row">
                    <div class="col-sm-6 col-lg-4">
                        <div class="form-group">
                            <label for="cabina" class="col-md-4 control-label">Cabina:</label>
                            <div class="col-md-8">
                                <select id="id_cabina" name="id_cabina" class="form-control">
                                    @foreach($cabinas as $cabina)
                                        <option value="{{$cabina->id}}">{{"Cabina ".$cabina->id}}</option>
                                    @endforeach
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4">
                        <div class="form-group">
                            <label for="cabina" class="col-md-5 control-label">Buscar Cliente:</label>
                            <div class="col-md-7">
                                <input type="text" id="busqueda_cliente" onkeyup="SearchClienteSelect(this.value)"
                                       class="form-control">
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4">
                        <div class="form-group">
                            <label for="cabina" class="col-md-4 control-label">Cliente:</label>
                            <div class="col-md-8">
                                <select id="id_cliente" name="id_cliente" class="form-control">
                                    @foreach($clientes as $cliente)
                                        <option value="{{$cliente->id}}">{{$cliente->nombre." ".$cliente->apellidos}}</option>
                                    @endforeach
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4">
                        <div class="form-group">
                            <label for="fecha_reservacion" class="col-md-5 control-label">Reservar desde:</label>
                            <div class="col-md-7">
                                <input type="date" id="fecha_reservacion" name="fecha_reservacion" class="form-control"
                                       value="{{$reservacion->fecha_reservacion}}">
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4">
                        <div class="form-group">
                            <label for="fecha_cancelacion" class="col-md-5 control-label">Reservar Hasta:</label>
                            <div class="col-md-7">
                                <input type="date" id="fecha_cancelacion" name="fecha_cancelacion" class="form-control"
                                       value="{{$reservacion->fecha_cancelacion}}">
                            </div>
                        </div>
                    </div>
                    <div class=" col-sm-6 col-lg-4">
                        <div class="form-group">
                            <label for="cant_personas" class="col-md-5 control-label">Personas:</label>
                            <div class="col-md-7">
                                <input type="number" id="cant_personas" name="cant_personas"
                                       class="form-control" value="{{$reservacion->cant_personas}}">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-11 col-lg-11">
                        <div class="form-group">
                            <input type="submit" value="Crear Reservacion"
                                   class="botonCrear botonTipo1 col-md-offset-6"/>
                        </div>
                    </div>
                </div>
                {!!Form::close()!!}
                @if(count($errors) > 0)
                    <div class="alert alert-danger">
                        <strong>Ha Ocurido un problema!</strong> Los siguientes campos deben ser ingresados.<br>
                        <ul>
                            @foreach ($errors->all() as $error)
                                <li>{{ $error }}</li>
                            @endforeach
                        </ul>
                    </div>
                @endif
            </div>
        </div>
    </section>
@endsection