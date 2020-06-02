<tr class="click-row" data-id="{{$foto->id}}">
    <td data-id="{{$foto->id}}"><img src="{{$foto->imagenurlcompact}}"
                                     class="img img-responsive">
    </td>
    <td>
        <button class="eliminarFoto botonEliminar botonTipo1" data-fotoid="{{$foto->id}}"
                data-fotoidr="{{$foto->idr}}">Elminar Foto
        </button>
    </td>
</tr>