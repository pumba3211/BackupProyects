<table class="table" id="tablacabinas">
    <tr>
        <th>Numero</th>
        <th>Televisor</th>
        <th>Abanico</th>
        <th>Ducha</th>
        <th>Cama</th>
        <th>Cama Matrimonial</th>
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
