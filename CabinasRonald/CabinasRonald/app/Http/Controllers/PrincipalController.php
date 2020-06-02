<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Requests;
use App\Http\Controllers\Controller;
use App\Models\Cabina;

class PrincipalController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('principal.index');
    }

    public function modalborrar(Request $Request)
    {
        $titulo = $Request->titulo;
        $contenido = $Request->contenido;
        return view('principal.modalborrar', compact('titulo', 'contenido'));
    }
}
