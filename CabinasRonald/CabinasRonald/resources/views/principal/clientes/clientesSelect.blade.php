<select id="id_cliente" name="id_cliente" class="form-control">
    @foreach($clientes as $cliente)
        <option value="{{$cliente->id}}">{{$cliente->nombre." ".$cliente->apellidos}}</option>
    @endforeach
</select>