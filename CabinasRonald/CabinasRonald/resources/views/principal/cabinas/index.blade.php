@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <div id="dvCabinas">
            <br/>
            <meta name="csrf-token" content="{{ csrf_token() }}"/>
            <input type="hidden" id="settabletype" value="1"/>
            <div class="container divstyle1">
                <h2>Cabinas </h2>
                <div class="container">
                    <button id="cabinacrear" class="botonCrear botonTipo1">Crear Cabina</button>
                </div>
                <br/>
                <div class="container">
                    <div class="table-responsive">
                        <table class="table" id="tablacabinas">
                            <tr>
                                <th>Numero</th>
                                <th>Televisor</th>
                                <th>Abanico</th>
                                <th>Ducha</th>
                                <th>Cama</th>
                                <th>Cama Matrimonial</th>
                                <th>Refrigeradora</th>
                                <th>Color</th>
                                <th>Acciones</th>
                            </tr>
                            @foreach ($cabinas as $cabina)
                                <tr class="click-row" data-id="{{$cabina->id}}">
                                    <td data-id="{{$cabina->id}}"> {{$cabina->id}}</td>
                                    @if($cabina->televizor == 1)
                                        <td data-id="{{$cabina->id}}">Tiene</td>
                                    @else
                                        <td data-id="{{$cabina->id}}">No Tiene</td>
                                    @endif
                                    @if($cabina->abanico == 1)
                                        <td data-id="{{$cabina->id}}">Tiene</td>
                                    @else
                                        <td data-id="{{$cabina->id}}">No Tiene</td>
                                    @endif
                                    @if($cabina->ducha == 1)
                                        <td data-id="{{$cabina->id}}">Tiene</td>
                                    @else
                                        <td data-id="{{$cabina->id}}">No Tiene</td>
                                    @endif
                                    <td data-id="{{$cabina->id}}">{{$cabina->cama}}</td>
                                    @if($cabina->camamatrimonial == 1)
                                        <td data-id="{{$cabina->id}}">Tiene</td>
                                    @else
                                        <td data-id="{{$cabina->id}}">No Tiene</td>
                                    @endif
                                    @if($cabina->refrigeradora == 1)
                                        <td data-id="{{$cabina->id}}">Tiene</td>
                                    @else
                                        <td data-id="{{$cabina->id}}">No Tiene</td>
                                    @endif
                                    <td data-id="{{$cabina->id}}" style="background: {{$cabina->color}}">

                                    </td>
                                    <td>
                                        <button data-cabinaided="{{$cabina->id}}"
                                                class="cabinaeditar botonEditar botonTipo1">Editar
                                        </button>
                                    </td>
                                </tr>
                            @endforeach
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection


