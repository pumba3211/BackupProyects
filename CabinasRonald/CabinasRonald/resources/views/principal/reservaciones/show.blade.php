@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <br/>
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <div class="form-horizontal">
                                <h3>Información Reservación {{$reservacion->id}}</h3>
                                </br>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Reservado Desde:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$reservacion->fecha_reservacion}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Reservado Hasta:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$reservacion->fecha_cancelacion}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Número de Personas:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$reservacion->cant_personas}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Estado:</label>
                                    <div class="col-md-6">
                                        @if($reservacion->factura == 0)
                                            <label class="control-label">Reservada y en uso</label>
                                        @elseif($reservacion->factura == 1)
                                            <label class="control-label">Cancelada y en uso</label>
                                        @else
                                            <label class="control-label">Cancelada</label>
                                        @endif
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Cliente:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->nombre}} {{$cliente->apellidos}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Cabina:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">Cabina {{$cabina->id}}</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <div class="form-horizontal">
                                <h3>Información del Cliente </h3>
                                </br>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Cedula:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->cedula}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Nombre Completo:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->nombre}} {{$cliente->apellidos}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Empresa:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$empresa->nombre}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Número de Visitas:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->visitas}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Primera Visita:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->primeravisita}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Última Visita:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->ultimavisita}}</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <div class="form-horizontal">
                                <h3 style="text-align: center">Información de la Cabina</h3>
                                </br>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Televizor:</label>
                                    <div class="col-md-6">
                                        @if($cabina->televizor == 1)
                                            <label class="control-label">Tiene</label>
                                        @else
                                            <label class="control-label">No tiene</label>
                                        @endif
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Abanico:</label>
                                    <div class="col-md-6">
                                        @if($cabina->abanico == 1)
                                            <label class="control-label">Tiene</label>
                                        @else
                                            <label class="control-label">No tiene</label>
                                        @endif
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Ducha:</label>
                                    <div class="col-md-6">
                                        @if($cabina->ducha == 1)
                                            <label class="control-label">Tiene</label>
                                        @else
                                            <label class="control-label">No tiene</label>
                                        @endif
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Camas:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cabina->cama}}:</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Cama Matrimonial:</label>
                                    <div class="col-md-6">
                                        @if($cabina->camamatrimonial == 1)
                                            <label class="control-label">Tiene</label>
                                        @else
                                            <label class="control-label">No tiene:</label>
                                        @endif
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Cama Matrimonial:</label>
                                    <div class="col-md-6">
                                        @if($cabina->refrigeradora == 1)
                                            <label class="control-label">Tiene</label>
                                        @else
                                            <label class="control-label">No tiene:</label>
                                        @endif
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Color:</label>
                                    <div class="col-md-6">
                                        <div style="width: 10%; height: 5%;background: {{$cabina->color}}"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        @extends('principal.compartidos.modalImage')
    </section>
@endsection

