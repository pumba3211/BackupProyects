<select id="id_empresa" name="id_empresa" class="form-control">
    @foreach($empresas as $empresa)
        <option value="{{$empresa->id}}">{{$empresa->nombre}}</option>
    @endforeach
</select>