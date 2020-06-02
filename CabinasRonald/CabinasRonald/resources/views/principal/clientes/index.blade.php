@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <div id="dvClientes">
            <br/>
            <meta name="csrf-token" content="{{ csrf_token() }}"/>
            <input type="hidden" id="settabletype" value="2"/>
            <div class="container divstyle1">
                <h2>Clientes </h2>
                <div class="container">
                    <button id="clientecrear" class="botonCrear botonTipo1">Crear Cliente</button>
                </div>
                <br/>
                <div class="row">
                    <div class="col-sm-6 col-lg-4 form-horizontal">
                        <div class="form-group">
                            <label for="cabina" class="col-md-5 control-label">Buscar Cliente:</label>
                            <div class="col-md-7">
                                <input type="text" id="busqueda_cliente"
                                       onkeyup="SearchClienteTable(this.value)"
                                       class="form-control">
                            </div>
                        </div>
                    </div>
                </div>
                <br/>
                <div class="container">
                    <div class="table-responsive">
                        <table class="table" id="tablaclientes">
                            <tr>
                                <th>Cedula</th>
                                <th>Nombre</th>
                                <th>Apellidos</th>
                                <th>Telefono</th>
                                <th>Empresa</th>
                                <th>Ultima Visita</th>
                                <th>Acciones</th>
                            </tr>
                            @forelse($clientes as $cliente)
                                <tr class="click-row" data-id="{{$cliente->id}}">
                                    <td data-id="{{$cliente->id}}">{{$cliente->cedula}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->nombre}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->apellidos}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->telefono}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->empresanombre}}</td>
                                    <td data-id="{{$cliente->id}}">{{$cliente->ultimavisita}}</td>
                                    <td>
                                        <button data-clienteidel="{{$cliente->id}}"
                                                class="clienteeliminar botonEliminar botonTipo1">Eliminar
                                        </button>
                                        <button data-clienteided="{{$cliente->id}}"
                                                class="clienteeditar botonEditar botonTipo1">Editar
                                        </button>
                                    </td>
                                </tr>
                            @empty
                                <tr>
                                    <td colspan="7" style="text-align:center">No se ha añadido ningun cliente añade alguno</td>
                                </tr>
                            @endforelse
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div id="modalborrar" class="modal">

            </div>
        </div>
    </section>
@endsection
