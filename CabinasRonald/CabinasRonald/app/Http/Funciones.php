<?php
/**
 * Created by PhpStorm.
 * User: Ronald
 * Date: 12/10/2015
 * Time: 21:20
 */

namespace App\Http;

use App\Models\Cliente;
use App\Models\Reservacion;
use App\Models\FotoCliente;
use App\Models\FotoCabina;
use App\Models\Fotos;
use Illuminate\Support\Facades\File;
use Intervention\Image\ImageManagerStatic as Image;
use Mockery\CountValidator\Exception;
use PhpParser\Node\Expr\Array_;

class Funciones
{
    public static function obtenerRerservaciones()
    {
        $reservaciones = Reservacion::obtenerReservaciones();
        $reseracionesjson = array();
        foreach ($reservaciones as $reservacion) {
            $reservaciondata = array('title' => $reservacion->nombre . " " . $reservacion->apellidos,
                'id' => $reservacion->id,
                'start' => $reservacion->fecha_reservacion, 'end' => $reservacion->fecha_cancelacion,
                'color' => $reservacion->color);
            array_push($reseracionesjson, $reservaciondata);
        }
        return $reseracionesjson;
    }

    public static function BorrarFotosCabina($id)
    {
        $fotos = FotoCabina::buscarFotosCabinaGET($id);
        foreach ($fotos as $foto) {
            $fotocabina = FotoCabina::find($foto->id_t);
            $fotocabina->delete();
            $picture = Fotos::find($foto->id);
            $picture->delete();
        }
    }

    public static function BorrarFotosCliente($id)
    {
        $fotos = FotoCliente::buscarFotosClienteGET($id);
        foreach ($fotos as $foto) {
            $fotocliente = FotoCliente::find($foto->id_t);
            $picture = Fotos::find($foto->id);
            $fotocliente->delete();
            $picture->delete();
        }
    }

    public static function GuardarFotos(Request $request)
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
                    return "Las imagenes se subieron correctamente, Desea subir mas imagenes?";
                }
            }
            return "Las imagenes se subieron correctamente, Desea subir mas imagenes?";
        } else {
            return "No se ha seleccionado ninguna imagen" . $request->cabinaid;
        }
    }

    public static function borrarFoto(Request $request)
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

    public static function ValidarEspacio($cabina, $cant_person)
    {
        $cant_personas = 0;
        if ($cabina->cama_matrimonial == 1 && $cabina->cama = 1) {
            $cant_personas = $cant_personas + 2;
        } else if ($cabina->cama_matrimonial == 1 && $cabina->cama > 1) {
            $cant_personas = $cant_personas + $cabina->cama - 1 + 2;;
        } else {
            $cant_personas = $cant_personas + $cabina->cama;
        }
        if ($cant_personas >= $cant_person) {
            return true;
        }
    }

    public static function CalcularPrecio($reservacion)
    {
        $precio = 0;
        $cantdias = ((strtotime($reservacion->fecha_cancelacion) - strtotime($reservacion->fecha_reservacion)) / 3600) / 24;
        if ($reservacion->cant_personas == 1) {
            $precio = 8000 * $cantdias;
        } else if ($reservacion->cant_personas = 2) {
            $precio = 10000 * $cantdias;
        } else {
            $precio = 12000 * $cantdias;
        }
        return $precio;
    }

    public static function clientesFrecuentes($reservaciones)
    {
        $clientes = array();
        $idCliente = null;
        $cliente = null;
        $again = false;
        foreach ($reservaciones as $reservacion) {
            do {
                if ($idCliente == null) {
                    $cliente = Cliente::find($reservacion->id_cliente);
                    $cliente->visitas = 0;
                    $idCliente = $cliente->id;
                    $again = false;
                }
                if ($reservacion->id_cliente == $idCliente) {
                    $cliente->visitas += 1;
                }
                if ($reservacion->id_cliente != $idCliente) {
                    $idCliente = null;
                    array_push($clientes, $cliente);
                    $cliente = null;
                    $again = true;
                }
            } while ($again);
        }
        return $clientes;
    }

    public static function fechaActual()
    {
        date_default_timezone_set('America/Costa_Rica');
        $date = date('Y') . '-' . date('m') . '-' . date('d');
        return $date;
    }

    public static function limparCeros($clientes)
    {
        $clientesFinales = array();
        foreach ($clientes as $cliente) {
            if ($cliente->visitas != 0) {
                array_push($clientesFinales, $cliente);
            }
        }
        return $clientesFinales;
    }
}
