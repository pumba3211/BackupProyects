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
                            {!!Form::open(array('url' => "/principal/cabinas/", 'method' => 'POST','class'=>'form-horizontal','role'=>'form'))!!}
                            <h3 style="text-align: center">Crear Cabina</h3>
                            </br>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Televizor:</label>
                                <div class="col-md-6">
                                    {!! Form::select('televizor', ['0' => 'No tiene', '1' => 'Tiene'], 0, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Abanico:</label>
                                <div class="col-md-6">
                                    {!! Form::select('abanico', ['0' => 'No tiene', '1' => 'Tiene'], 0, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Ducha:</label>
                                <div class="col-md-6">
                                    {!! Form::select('ducha', ['0' => 'No tiene', '1' => 'Tiene'], 0, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Camas:</label>
                                <div class="col-md-6">
                                    <input type="number" name="cama" id="cama" class="form-control">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Cama Matrimonial:</label>
                                <div class="col-md-6">
                                    {!! Form::select('camamatrimonial', ['0' => 'No tiene', '1' => 'Tiene'], 0, ['class' => 'form-control'],['id' => 'camamatrimonial']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Refrigeradora:</label>
                                <div class="col-md-6">
                                    {!! Form::select('refrigeradora', ['0' => 'No tiene', '1' => 'Tiene'], 0, ['class' => 'form-control'],['id' => 'refrigeradora']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Color:</label>
                                <div class="col-md-6">
                                    <input type="color" name="color" id="color" class="form-control"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1">
                                        Crear Cabina
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
    </section>
@endsection