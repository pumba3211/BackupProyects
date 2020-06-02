<?php

namespace App\Http\Controllers;

use App\AirPlane;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Response;
class AirPlaneController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return response()->json(['status' => 'ok', 'data' => AirPlane::all()], 200);
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
            if (!$request->input('name') || !$request->input('flying_hours')) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $newAirplane = AirPlane::create($request->all());
            $response = Response::make(json_encode(['data' => $newAirplane]), 201)->header('Location', $request->root() . '/airplanes/' . $newAirplane->id)->header('Content-Type', 'application/json');
            return $response;
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to safe the Airplane.'])], 500);
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
            $airplane = AirPlane::find($id);
            if (!$airplane) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The airplane you looking for does not exists.'])], 404);
            }
            return response()->json(['status' => 'ok', 'data' => $airplane], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the AirPlane.'])], 500);
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
            $airplane = AirPlane::find($id);
            if (!$airplane) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The airplane you try to update  does not exits.'])], 404);
            }
            $name = $request->input('name');
            $flying_hours = $request->input('flying_hours');
            if ($request->method() === 'PATCH') {
                $flag = false;
                if ($name) {
                    $airplane->name = $name;
                    $flag = true;
                }
                if ($flying_hours) {
                    $airplane->flying_hours = $flying_hours;
                    $flag = true;
                }
                if ($flag) {
                    $airplane->save();
                    return response()->json(['status' => 'ok', 'data' => $airplane], 200);
                } else {
                    return response()->json(['errors' => array(['code' => 200, 'message' => 'Nothing to update.'])], 200);
                }
            }
            if (!$name || !$flying_hours) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $airplane->name = $name;
            $airplane->flying_hours = $flying_hours;

            $airplane->save();
            return response()->json(['status' => 'ok', 'data' => $airplane], 200);

        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Airplane.'])], 500);
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
            $airplane = AirPlane::find($id);
            if (!$airplane) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The airplane you try to delete  does not exits.'])], 404);
            }
            $programmings = $airplane->programmings;
            if (sizeof($programmings) > 0) {
                return response()->json(['code' => 409, 'message' => 'This is airplane have some programmings and can not be deleted.'], 409);
            }

            $airplane->delete();
            return response()->json(['code' => 200, 'message' => 'The airplane was deleted succesfully'], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Airplane.'])], 500);
        }
    }
}
