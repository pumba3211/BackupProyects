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
                            {!!Form::open(array('url' => "/principal/cabinas/$cabina->id", 'method' => 'PUT','class'=>'form-horizontal','role'=>'form'))!!}
                            <h3 style="text-align: center">Editar Cabina</h3>
                            </br>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Televizor:</label>
                                <div class="col-md-6">
                                    {!! Form::select('televizor', ['0' => 'No tiene', '1' => 'Tiene'], $cabina->televizor, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Abanico:</label>
                                <div class="col-md-6">
                                    {!! Form::select('abanico', ['0' => 'No tiene', '1' => 'Tiene'], $cabina->abanico, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Ducha:</label>
                                <div class="col-md-6">
                                    {!! Form::select('ducha', ['0' => 'No tiene', '1' => 'Tiene'], $cabina->ducha, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Camas:</label>
                                <div class="col-md-6">
                                    <input type="number" name="cama" id="cama" class="form-control"
                                           value="{{$cabina->cama}}">
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Cama Matrimonial:</label>
                                <div class="col-md-6">
                                    {!! Form::select('camamatrimonial', ['0' => 'No tiene', '1' => 'Tiene'], $cabina->camamatrimonial, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Refrigeradora:</label>
                                <div class="col-md-6">
                                    {!! Form::select('refrigeradora', ['0' => 'No tiene', '1' => 'Tiene'], $cabina->refrigeradora, ['class' => 'form-control']) !!}
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-4 control-label">Color:</label>
                                <div class="col-md-6">
                                    <input type="color" name="color" id="color" class="form-control"
                                           value="{{$cabina->color}}"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 col-md-offset-4">
                                    <button type="submit" class="botonCrear botonTipo1">
                                        Editar Cabina
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

        <div class="container" id="dvIMAGENES">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <meta name="csrf-token" content="{{ csrf_token() }}"/>
                            <input type="hidden" id="settabletype" value="4"/>
                            <h3 style="text-align: center">Imagenes</h3>
                            {!!Form::open(array('url' => "/principal/fotos",'files' => true,'id' => 'my-dropzone' ,'class' => 'dropzone dz-clickable','method' => 'POST'))!!}
                            <input type="hidden" value="1" name="tipo" id="tipo"/>
                            <input type="hidden" value="{{$cabina->id}}" id="idrelacion" name="idrelacion">
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

        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <div class="table-responsive" id="tablaimagenes">
                                <table class="table">
                                    @forelse($fotos_cabina as $foto)
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
                                            <td colspan="3" style="text-align:center">No se han subidos fotos a la
                                                Cabina
                                                añade
                                                alguna
                                            </td>
                                        </tr>
                                    @endforelse
                                </table>
                                {!! $fotos_cabina->render() !!}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        @extends('principal.compartidos.modalImage')
    </section>
@endsection

