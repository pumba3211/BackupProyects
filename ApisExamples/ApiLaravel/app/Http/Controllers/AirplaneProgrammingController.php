<?php

namespace App\Http\Controllers;

use App\AirPlane;
use Illuminate\Http\Request;

class AirplaneProgrammingController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        try {
            $airplanes = AirPlane::all();
            foreach ($airplanes as $airplane) {
                $airplane->programmings = $airplane->programmings()->get();
                foreach ($airplane->programmings as $programming) {
                    $programming->destination = $programming->destination()->get();
                    $programming->pilot = $programming->pilot()->get();
                }
            }
            return response()->json(['status' => 'ok', 'data' => $airplanes], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Airplanes.'])], 500);
        }
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
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        try {
            $airplane = AirPlane::find($id);
            if (!$airplane) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The airplane you looking for does not exits.'])], 404);
            }
            $airplane->programmings = $airplane->programmings()->get();
            foreach ($airplane->programmings as $programming) {
                $programming->destination = $programming->destination()->get();
                $programming->pilot = $programming->pilot()->get();
            }
            return response()->json(['status' => 'ok', 'data' => $airplane], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Airplane.'])], 500);
        }
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
