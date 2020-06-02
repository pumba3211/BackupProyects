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
            <td colspan="7" style="text-align:center">No hay datos que mostrar.</td>
        </tr>
    @endforelse
</table>