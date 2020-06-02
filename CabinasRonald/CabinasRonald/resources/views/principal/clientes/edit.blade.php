@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <br/>
    <section>
        <div class="container" id="dvcrearCliente">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            {!!Form::open(array('url' => "/principal/clientes/$cliente->id", 'method' => 'PUT','class'=>'form-horizontal','role'=>'form'))!!}
                            <h3 style="text-align: center;">Editar Cliente</h3>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Cedula:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="cedula" id="cedula"
                                           value="{{$cliente->cedula}}">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Nombre:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="nombre" id="nombre"
                                           value="{{$cliente->nombre}}">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Apellidos:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="apellidos" id="apellidos"
                                           value="{{$cliente->apellidos}}">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Telefono:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="telefono" id="telefono"
                                           value="{{$cliente->telefono}}">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Buscar Empresa::</label>
                                <div class="col-md-6">
                                    <input type="text" id="busqueda_empresa"
                                           onkeyup="SearchEmpresaSelect(this.value)"
                                           class="form-control">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Empresa:</label>
                                <div class="col-md-6">
                                    <select id="id_empresa" name="id_empresa" class="form-control">
                                        @foreach($empresas as $value)
                                            @if($value->id == $empresa->id)
                                                <option value="{{$value->id}}"
                                                        selected="selected">{{$value->nombre}}</option>
                                            @else
                                                <option value="{{$value->id}}">{{$value->nombre}}</option>
                                            @endif
                                        @endforeach
                                    </select>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1">
                                        Editar Cliente
                                    </button>
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
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <meta name="csrf-token" content="{{ csrf_token() }}"/>
                            <input type="hidden" id="settabletype" value="4"/>
                            <h3 style="text-align: center">Imagenes</h3>
                            {!!Form::open(array('url' => "/principal/fotos",'files' => true,'id' => 'my-dropzone' ,'class' => 'dropzone dz-clickable','method' => 'POST'))!!}
                            <input type="hidden" value="2" name="tipo" id="tipo"/>
                            <input type="hidden" value="{{$cliente->id}}" id="idrelacion" name="idrelacion">
                            <div class="dz-message">
                                <label id="mensajeUpload" class="control-label">Seleccione las imagenes a subir.</label>
                            </div>
                            {!!Form::close()!!}
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1" id="submit">
                                        Subir Imagenes
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container" id="dvImagenes">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <div class="table-responsive" id="tablaimagenes">
                                <table class="table">
                                    @forelse($fotos_cliente as $foto)
                                        <tr class="click-row" data-id="{{$foto->id}}">
                                            <td data-id="{{$foto->id}}"><img src="{{$foto->imagenurlcompact}}"
                                                                             class="img img-responsive">
                                            </td>
                                            <td>
                                                <button class="eliminarFoto botonEliminar botonTipo1"
                                                        data-fotoid="{{$foto->id}}"
                                                        data-fotoidr="{{$foto->idr}}">Elminar Foto
                                                </button>
                                            </td>
                                        </tr>
                                    @empty
                                        <tr>
                                            <td colspan="3" style="text-align:center">No se han subidos fotos al cliente
                                                añade
                                                alguna
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
    </section>
    @extends('principal.compartidos.modalImage')
@endsection








