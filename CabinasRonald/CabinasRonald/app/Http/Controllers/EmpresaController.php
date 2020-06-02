<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Http\Requests;
use App\Http\Controllers\Controller;
use App\Models\Empresa;
use App\Http\Requests\EmpresaRequest;
use Illuminate\Support\Facades\Input;

class EmpresaController extends Controller
{
    public function index()
    {
        $empresas = Empresa::all();
        return view('principal.empresas.index', compact('empresas'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('principal.empresas.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function store(EmpresaRequest $request)
    {
        Empresa::create(Input::all());
        $empresas = Empresa::all();
        return view('principal.empresas.index', compact('empresas'));
    }

    /**
     * Display the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {

    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $empresa = Empresa::find($id);
        return view('principal.empresas.edit', compact('empresa'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function update(EmpresaRequest $request, $id)
    {
        $empresa = Empresa::find($id);
        $empresa->nombre = $request->nombre;
        $empresa->save();
        $empresas = Empresa::all();
        return view('principal.empresas.index', compact('empresas'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {

    }
    public function busquedaEmpresaSelect($busqueda)
    {
        $empresas = Empresa::buscarEmpresas($busqueda);
        return view('principal.empresas.empresa_select', compact('empresas'));
    }
}
