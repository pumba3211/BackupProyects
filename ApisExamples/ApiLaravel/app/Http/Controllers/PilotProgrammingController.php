<?php

namespace App\Http\Controllers;

use App\Pilot;
use Illuminate\Http\Request;

class PilotProgrammingController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        try {
            $pilots = Pilot::all();
            foreach ($pilots as $pilot) {
                $pilot->programmings = $pilot->programmings()->get();
                foreach ($pilot->programmings as $programming) {
                    $programming->destination = $programming->destination()->get();
                    $programming->airplane = $programming->airplane()->get();
                }
            }
            return response()->json(['status' => 'ok', 'data' => $pilots], 200);
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
     * @param  \Illuminate\Http\Request $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        try {
            $pilot = Pilot::find($id);
            if (!$pilot) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The pilot you looking for does not exits.'])], 404);
            }
            $pilot->programmings = $pilot->programmings()->get();
            foreach ($pilot->programmings as $programming) {
                $programming->airplane = $programming->airplane()->get();
                $programming->destination = $programming->destination()->get();
            }
            return response()->json(['status' => 'ok', 'data' => $pilot], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Pilot.'])], 500);
        }
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
        //
    }
}
