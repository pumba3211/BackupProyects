@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <br/>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            {!!Form::open(array('url' => "/principal/empresas", 'method' => 'POST','class'=>'form-horizontal','role'=>'form'))!!}
                            {!! csrf_field() !!}
                            <h3 style="text-align: center;">Crear Empresa</h3>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Nombre:</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" name="nombre" id="nombre">
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1">
                                        Crear Empresa
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