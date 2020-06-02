<?php

namespace App\Http\Controllers;

use App\Pilot;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Response;

class PilotController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return response()->json(['status' => 'ok', 'data' => Pilot::all()], 200);
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
        try {
            if (!$request->input('name') || !$request->input('license') || !$request->input('flying_hours')) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $newPilot = Pilot::create($request->all());
            $response = Response::make(json_encode(['data' => $newPilot]), 201)->header('Location', $request->root() . '/pilots/' . $newPilot->id)->header('Content-Type', 'application/json');
            return $response;
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to safe the Pilot.'])], 500);
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
        try {
            $pilot = Pilot::find($id);
            if (!$pilot) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The pilot you looking for does not exits.'])], 404);
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
        try {
            $pilot = Pilot::find($id);
            if (!$pilot) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The pilot you try to update  does not exits.'])], 404);
            }
            $name = $request->input('name');
            $license = $request->input('license');
            $flying_hours = $request->input('flying_hours');
            if ($request->method() === 'PATCH') {
                $flag = false;
                if ($name) {
                    $pilot->name = $name;
                    $flag = true;
                }
                if ($license) {
                    $pilot->license = $license;
                    $flag = true;
                }
                if ($flying_hours) {
                    $pilot->flying_hours = $flying_hours;
                    $flag = true;
                }
                if ($flag) {
                    $pilot->save();
                    return response()->json(['status' => 'ok', 'data' => $pilot], 200);
                } else {
                    return response()->json(['errors' => array(['code' => 200, 'message' => 'Nothing to update.'])], 200);
                }
            }
            if (!$name || !$license || !$flying_hours) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $pilot->name = $name;
            $pilot->license = $license;
            $pilot->flying_hours = $flying_hours;

            $pilot->save();
            return response()->json(['status' => 'ok', 'data' => $pilot], 200);

        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Pilot.'])], 500);
        }
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        try {
            $pilot = Pilot::find($id);
            if (!$pilot) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The pilot you try to delete  does not exits.'])], 404);
            }
            $programmings = $pilot->programmings;
            if (sizeof($programmings) > 0) {
                return response()->json(['code' => 409, 'message' => 'This is pilot have some programmings and can not be deleted.'], 409);
            }

            $pilot->delete();
            return response()->json(['code' => 200, 'message' => 'The pilot was deleted succesfully'], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Pilot.'])], 500);
        }
    }
}
