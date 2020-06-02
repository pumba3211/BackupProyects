<?php

namespace App\Http\Controllers;

use App\Models\Cabina;
use App\Models\FotoCabina;
use Illuminate\Http\Request;

use App\Http\Requests;
use App\Http\Controllers\Controller;

class PageController extends Controller
{
    public function index(){
        $cabinas = Cabina::all();
        return view('page.index',compact('cabinas'));
    }


    public function infocabina($id){
        $cabina = Cabina::find($id);
        $fotos_cabina = FotoCabina::buscarFotosCabina($id);
        return view('page.infocabina',compact('cabina','fotos_cabina'));
    }
}
