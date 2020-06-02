<div id="ingresos">
    <div class="row">
        <div class="col-md-4">
            <h4>Ingresos Totales:</h4>
        </div>
        <div class="col-md-3">
            <h4>{{$ingresos}}</h4>
        </div>
    </div>
    <div class="table-responsive">
        <table class="table" id="tabla_ingresos">
            <tr>
                <th>#Reservacion</th>
                <th>Cliente</th>
                <th>Fecha Inicio</th>
                <th>Fecha Final</th>
                <th>Estado</th>
                <th>Ingresos</th>
            </tr>
            @forelse($reservaciones as $reservacion)
                <tr class="click-row" data-id="{{$reservacion->id}}">
                    <td data-id="{{$reservacion->id}}">{{$reservacion->id}}</td>
                    <td data-id="{{$reservacion->id}}">{{$reservacion->nombre." ".$reservacion->apellidos}}</td>
                    <td data-id="{{$reservacion->id}}">{{$reservacion->fecha_reservacion}}</td>
                    <td data-id="{{$reservacion->id}}">{{$reservacion->fecha_cancelacion}}</td>
                    @if($reservacion->factura == 0)
                        <td data-id="{{$reservacion->id}}">Reservada y en uso</td>
                    @elseif($reservacion->factura == 1)
                        <td data-id="{{$reservacion->id}}">Cancelada y en uso</td>
                    @else
                        <td data-id="{{$reservacion->id}}">Cancelada</td>
                    @endif
                    <td data-id="{{$reservacion->id}}">{{$reservacion->ingresos}}</td>
                </tr>
            @empty
                <tr>
                    <td colspan="6" style="text-align:center">No hay datos que mostrar.</td>
                </tr>
            @endforelse
        </table>
    </div>
</div>