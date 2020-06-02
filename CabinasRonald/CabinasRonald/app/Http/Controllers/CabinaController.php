<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Requests;
use App\Http\Controllers\Controller;
use App\Models\Cabina;
use Illuminate\Support\Facades\File;
use App\Http\Funciones;
use App\Models\FotoCabina;
use App\Http\Requests\CabinaRequest;
use Illuminate\Support\Facades\Input;

class CabinaController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $cabinas = Cabina::all();
        return view('principal.cabinas.index', Compact('cabinas'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('principal.cabinas.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function store(CabinaRequest $request)
    {
        $cabina = Cabina::create(Input::all());
        $cabinas = Cabina::all();
        return view('principal.cabinas.index', Compact('cabinas'));
    }

    /**
     * Display the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $cabina = Cabina::find($id);
        $fotos_cabina = FotoCabina::buscarFotosCabina($id);
        return view('principal.cabinas.show', Compact('cabina', 'fotos_cabina'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $cabina = Cabina::find($id);
        $fotos_cabina = FotoCabina::buscarFotosCabina($id);
        return view('principal.cabinas.edit', Compact('cabina', 'fotos_cabina'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function update(CabinaRequest $request, $id)
    {
        $cabina = Cabina::find($id);
        $cabina->televizor = $request->televizor;
        $cabina->abanico = $request->abanico;
        $cabina->cama = $request->cama;
        $cabina->ducha = $request->ducha;
        $cabina->camamatrimonial = $request->camamatrimonial;
        $cabina->color = $request->color;
        $cabina->refrigeradora = $request->refrigeradora;
        $cabina->save();
        $cabinas = Cabina::all();
        return view('principal.cabinas.index', Compact('cabinas'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $cabina = Cabina::find($id);
        try {
            if (File::deleteDirectory(public_path() . '/imagenes/cabinas/' . $id)) {

            } else {

            }
        } catch (Exception $e) {

        }
        Funciones::BorrarFotosCabina($id);
        $cabina->delete();
    }

    public function cabinasJson()
    {
        return Cabina::all();
    }

    public function tabla_cabinas()
    {
        $cabinas = Cabina::all();
        return view('principal.cabinas.tabla_cabinas', Compact('cabinas'));
    }

    public function fotos_cabinas($id)
    {
        $fotos_cabina = FotoCabina::buscarFotosCabina($id);
        return view('principal.cabinas.fotos_cabina', Compact('fotos_cabina'));
    }
}
