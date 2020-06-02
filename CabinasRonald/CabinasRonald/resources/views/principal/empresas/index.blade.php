@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <div id="dvEmpresas">
            <br/>
            <meta name="csrf-token" content="{{ csrf_token() }}"/>
            <div class="container divstyle1">
                <h2>Empresas</h2>
                <div class="container">
                    <button id="crearempresa" class="botonCrear botonTipo1">Crear Empresa</button>
                </div>
                <br/>
                <div class="container">
                    <div class="table-responsive">
                        <table class="table" id="tablaempresas">
                            <tr>
                                <th>Nombre Empresa</th>
                                <th>Acciones</th>
                            </tr>
                            @foreach ($empresas as $empresa)
                                <tr class="click-row" data-id="{{$empresa->id}}">
                                    <td data-id="{{$empresa->id}}"> {{$empresa->nombre}}</td>
                                    <td>
                                        <button data-empresaided="{{$empresa->id}}"
                                                class="empresaeditar botonEditar botonTipo1">Editar
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