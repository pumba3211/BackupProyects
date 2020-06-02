<div id="clientes">
    <div class="row">
        <div class="col-md-4">
            <h4>Clientes Totales:</h4>
        </div>
        <div class="col-md-3">
            <h4>{{$cantidadclientes}}</h4>
        </div>
    </div>
    <div class="table-responsive">
        <table class="table" id="tablaclientes">
            <tr>
                <th>Cedula</th>
                <th>Nombre</th>
                <th>Apellidos</th>
                <th>Ultima Visita</th>
                <th>Número de Visitas</th>
            </tr>
            @forelse($clientes as $cliente)
                <tr class="click-row" data-id="{{$cliente->id}}">
                    <td data-id="{{$cliente->id}}">{{$cliente->cedula}}</td>
                    <td data-id="{{$cliente->id}}">{{$cliente->nombre}}</td>
                    <td data-id="{{$cliente->id}}">{{$cliente->apellidos}}</td>
                    <td data-id="{{$cliente->id}}">{{$cliente->ultimavisita}}</td>
                    <td data-id="{{$cliente->id}}">{{$cliente->visitas}}</td>
                </tr>
            @empty
                <tr>
                    <td colspan="5" style="text-align:center">No hay datos que mostrar.</td>
                </tr>
            @endforelse
        </table>
    </div>
</div>