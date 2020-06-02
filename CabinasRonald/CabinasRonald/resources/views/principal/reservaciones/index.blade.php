@extends('layouts.principal_master')
@extends('principal.navmantenimientos')
@section('content')
    <section>
        <br/>
        <input type="hidden" id="settabletype" value="3"/>
        <meta name="csrf-token" content="{{ csrf_token() }}"/>
        <div class="container divstyle1" id="">
            <h2>Reservaciones </h2>
            <div class="container">
                <button id="reservacioncrear" class="botonCrear botonTipo1">Crear Reservacion</button>
            </div>
            <br/>
            @if(count($errors) > 0)
                <div class="alert alert-danger">
                    <strong>Ocurrio un problema</strong>
                    <br>
                    <ul>
                        @foreach ($errors->all() as $error)
                            <li>{{ $error }}</li>
                        @endforeach
                    </ul>
                </div>
            @else
                @foreach($cabinas as $cabina)
                    <label class="control-label">Cabina {{$cabina->id}}:</label>
                    <label style="background: {{$cabina->color}}">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                @endforeach
                <div class="container">
                    <div id="calendar">

                    </div>
                </div>
            @endif
        </div>
    </section>
    <div class="modal" id="editarAcciones">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" id="closeModalReservacion">&times;</button>
                    <h4 class="modal-title">Acciones</h4>
                </div>
                <div class="modal-body">
                    <button id="reservacionver" class="botonCrear botonTipo1" data-id="">Ver</button>
                    <button id="reservacioneliminar" class="botonEliminar botonTipo1" data-id="">Eliminar</button>
                    <br/>
                    <label id="responseText"></label>
                </div>
            </div>
        </div>
    </div>
@endsection

