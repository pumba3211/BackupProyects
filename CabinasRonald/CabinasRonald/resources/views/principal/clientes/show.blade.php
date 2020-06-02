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
                                <h3>Información del Cliente {{$cliente->id}}</h3>
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
                                    <label class="col-md-4 control-label">Número de Visitas:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->visitas}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Telefono:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$cliente->telefono}}</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-4 control-label">Empresa:</label>
                                    <div class="col-md-6">
                                        <label class="control-label">{{$empresa->nombre}}</label>
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
                            <h3>Imagenes</h3>
                            <input type="hidden" id="settabletype" value="4"/>
                            <div class="table-responsive" id="tablaimagenes">
                                <table class="table">
                                    @forelse($fotos_cliente as $foto)
                                        <tr class="click-row" data-id="{{$foto->id}}">
                                            <td data-id="{{$foto->id}}"><img src="{{$foto->imagenurlcompact}}"
                                                                             class="img img-responsive">
                                            </td>
                                        </tr>
                                    @empty
                                        <tr>
                                            <td colspan="3" style="text-align:center">No se han subidos fotos al
                                                cliente
                                            </td>
                                        </tr>
                                    @endforelse
                                </table>
                                {!! $fotos_cliente->render() !!}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        @extends('principal.compartidos.modalImage')
    </section>
@endsection






