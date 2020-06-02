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
                                <h3 style="text-align: center">Cabina {{$cabina->id}}</h3>
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

        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-default">
                        <div class="panel-body divstyle1">
                            <input type="hidden" id="settabletype" value="4"/>
                            <h3 style="text-align: center">Imagenes</h3>
                            <div class="table-responsive" id="tablaimagenes">
                                <table class="table">
                                    @forelse($fotos_cabina as $foto)
                                        <tr class="click-image" data-id="{{$foto->id}}">
                                            <td data-id="{{$foto->id}}"><img src="{{$foto->imagenurlcompact}}"
                                                                             class="img img-responsive">
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