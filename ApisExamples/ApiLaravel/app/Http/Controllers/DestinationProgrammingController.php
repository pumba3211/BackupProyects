<?php

namespace App\Http\Controllers;

use App\Destination;
use Illuminate\Http\Request;

class DestinationProgrammingController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        try {
            $destinations = Destination::all();
            foreach ($destinations as $destination) {
                $destination->programmings = $destination->programmings()->get();
                foreach ($destination->programmings as $programming) {
                    $programming->airplane = $programming->airplane()->get();
                    $programming->pilot = $programming->pilot()->get();
                }
            }
            return response()->json(['status' => 'ok', 'data' => $destinations], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Destinations.'])], 500);
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
            $destination = Destination::find($id);
            if (!$destination) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The destination you looking for does not exits.'])], 404);
            }
            $destination->programmings = $destination->programmings()->get();
            foreach ($destination->programmings as $programming) {
                $programming->airplane = $programming->airplane()->get();
                $programming->pilot = $programming->pilot()->get();
            }
            return response()->json(['status' => 'ok', 'data' => $destination], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Destination.'])], 500);
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
