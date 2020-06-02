<div class="table-responsive" id="tablaimagenes">
    <table class="table">
        @forelse($fotos_cabina as $foto)
            <tr class="click-row" data-id="{{$foto->id}}">
                <td data-id="{{$foto->id}}"><img src="{{$foto->imagenurlcompact}}"
                                                 class="img img-responsive">
                </td>
                <td>
                    <button class="eliminarFoto botonEliminar botonTipo1"
                            data-fotoid="{{$foto->id}}"
                            data-fotoidr="{{$foto->idr}}">Elminar Foto
                    </button>
                </td>
            </tr>
        @empty
            <tr>
                <td colspan="3" style="text-align:center">No se han subidos fotos a la Cabina
                    añade
                    alguna
                </td>
            </tr>
        @endforelse
    </table>
    {!! $fotos_cabina->render() !!}
</div>