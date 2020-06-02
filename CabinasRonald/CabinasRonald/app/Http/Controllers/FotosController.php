<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Http\Requests;
use App\Http\Controllers\Controller;
use Illuminate\Support\Facades\Input;
use App\Models\Fotos;
use Illuminate\Support\Facades\File;
use App\Models\FotoCabina;
use App\Models\FotoCliente;
use Intervention\Image\ImageManagerStatic as Image;
use Mockery\CountValidator\Exception;

class FotosController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $files = $request->file('file');
        $path = public_path() . '/imagenes/';
        if ($files != null) {
            if (!File::exists($path)) {
                File::makeDirectory($path);
            }
            $imagenurl = "/imagenes/";
            if ($request->tipo == 1) {
                $destinationPath = $path . "cabinas/";
                $imagenurl = $imagenurl . "cabinas/";
            } else {
                $destinationPath = $path . "clientes/";
                $imagenurl = $imagenurl . "clientes/";
            }
            if (!File::exists($destinationPath)) {
                File::makeDirectory($destinationPath);
            }
            $destinationPath = $destinationPath . $request->idrelacion . "/";
            $imagenurl = $imagenurl . $request->idrelacion . "/";
            foreach ($files as $file) {
                $extencion = $file->getClientOriginalExtension();
                $nombre = $file->getClientOriginalName();
                if (!File::exists($destinationPath)) {
                    File::makeDirectory($destinationPath);
                }
                $foto = Fotos::create(["nombre" => $nombre, "extencion" => $extencion]);
                $foto->imagenurl = $imagenurl . $foto->id . '.' . $extencion;
                $foto->imagenurlcompact = $imagenurl . $foto->id . 'compact.png';
                $foto->save();
                $file->move($destinationPath, $foto->id . '.' . $extencion);
                if ($request->tipo == 1) {
                    FotoCabina::create(["id_foto" => $foto->id, "id_cabina" => $request->idrelacion]);
                } else {
                    FotoCliente::create(["id_foto" => $foto->id, "id_cliente" => $request->idrelacion]);
                }
                try {
                    $image = Image::make($destinationPath . $foto->id . '.' . $extencion)->resize(150, 100)->save($destinationPath . $foto->id . 'compact.png');
                } catch (Exception $error) {
                    return "¿Las imágenes se subieron correctamente, Desea subir más imágenes?";
                }
            }
            return "¿Las imágenes se subieron correctamente, Desea subir más imágenes?";
        } else {
            return "No se ha seleccionado ninguna imagen" . $request->cabinaid;
        }
    }

    /**
     * Display the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $foto = Fotos::find($id);
        return view('principal.fotos.show',compact('foto'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request $request
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
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

    public function borrarFoto(Request $request)
    {
        $fotor = null;
        if ($request->tipo == 1) {
            $fotor = FotoCabina::find($request->idr);
        } else {
            $fotor = FotoCliente::find($request->idr);
        }
        $foto = Fotos::find($request->id);
        if (File::exists(public_path() . $foto->imagenurl)) {
            File::delete(public_path() . $foto->imagenurl);
        }
        if (File::exists(public_path() . $foto->imagenurlcompact)) {
            File::delete(public_path() . $foto->imagenurlcompact);
        }
        $fotor->delete();
        $foto->delete();

    }
}
