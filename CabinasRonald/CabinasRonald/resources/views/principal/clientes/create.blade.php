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
                            {!!Form::open(array('url' => "/principal/clientes", 'method' => 'POST','class'=>'form-horizontal','role'=>'form'))!!}
                            {!! csrf_field() !!}
                            <h3 style="text-align: center;">Crear Cliente</h3>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Cedula:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="cedula" id="cedula">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Nombre:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="nombre" id="nombre">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Apellidos:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="apellidos" id="apellidos">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Telefono:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="telefono" id="telefono">
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
                                        @foreach($empresas as $empresa)
                                            <option value="{{$empresa->id}}">{{$empresa->nombre}}</option>
                                        @endforeach
                                    </select>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1">
                                        Crear Cliente
                                    </button>
                                </div>
                            </div>
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
                            {!!Form::close()!!}
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection