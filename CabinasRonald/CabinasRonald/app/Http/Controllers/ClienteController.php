<?php

namespace App\Http\Controllers;

use App\Models\Empresa;
use Illuminate\Http\Request;
use App\Http\Requests;
use App\Http\Controllers\Controller;
use App\Models\Cliente;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\File;
use App\Http\Funciones;
use App\Models\FotoCliente;
use App\Http\Requests\ClienteRequest;

class ClienteController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $clientes = Cliente::ObtenerClientesTable();
        return view('principal.clientes.index', compact('clientes'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $empresas = Empresa::all();
        return view('principal.clientes.create', compact('empresas'));
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function store(ClienteRequest $request)
    {
        $date = Funciones::fechaActual();
        $cliente = Cliente::create(Input::all());
        $cliente->primeravisita = $date;
        $cliente->save();
        $clientes = Cliente::ObtenerClientesTable();
        return view('principal.clientes.index', compact('clientes'));
    }

    /**
     * Display the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $cliente = Cliente::find($id);
        $empresa = Empresa::find($cliente->id_empresa);
        $fotos_cliente = FotoCliente::buscarFotosCliente($id);
        return view('principal.clientes.show', compact('cliente', 'fotos_cliente', 'empresa'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $cliente = Cliente::find($id);
        $empresa = Empresa::find($cliente->id_empresa);
        $empresas = Empresa::all();
        $fotos_cliente = FotoCliente::buscarFotosCliente($id);
        return view('principal.clientes.edit', compact('cliente', 'fotos_cliente', 'empresa', 'empresas'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function update(ClienteRequest $request, $id)
    {
        $cliente = Cliente::find($id);
        $cliente->cedula = $request->cedula;
        $cliente->nombre = $request->nombre;
        $cliente->apellidos = $request->apellidos;
        $cliente->telefono = $request->telefono;
        $cliente->id_empresa = $request->id_empresa;
        $cliente->save();
        $clientes = Cliente::ObtenerClientesTable();
        $fotos_cliente = FotoCliente::buscarFotosCliente($id);
        return view('principal.clientes.index', compact('clientes', 'fotos_cliente'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $cliente = Cliente::find($id);
        try {
            if (File::deleteDirectory(public_path() . '/imagenes/clientes/' . $id)) {

            } else {

            }
        } catch (Exception $e) {

        }
        Funciones::BorrarFotosCliente($id);
        $cliente->delete();
    }

    public function tabla_clientes()
    {
        $clientes = Cliente::ObtenerClientesTable();
        return view('principal.clientes.tabla_clientes', compact('clientes'));
    }

    public function fotos_cliente($id)
    {
        $fotos_cliente = FotoCliente::buscarFotosCliente($id);
        return view('principal.clientes.fotos_cliente', compact('fotos_cliente'));
    }

    public function busquedaClienteSelect($busqueda)
    {
        $clientes = Cliente::buscarClientes($busqueda);
        return view('principal.clientes.clientesSelect', compact('clientes'));
    }

    public function busquedaClienteTable($busqueda)
    {
        $clientes = Cliente::buscarClientes($busqueda);
        return view('principal.clientes.tabla_cliente_busqueda', compact('clientes'));
    }
}
