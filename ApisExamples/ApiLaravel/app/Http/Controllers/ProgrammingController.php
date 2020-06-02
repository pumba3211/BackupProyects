<?php

namespace App\Http\Controllers;

use App\Programming;
use Illuminate\Http\Request;
use League\Flysystem\Exception;
use Illuminate\Support\Facades\Response;

class ProgrammingController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        try {
            $programmings = Programming::all();
            foreach ($programmings as $programming) {
                $programming->airplane = $programming->airplane()->get();
                $programming->pilot = $programming->pilot()->get();
                $programming->destination = $programming->destination()->get();
            }
            return response()->json(['status' => 'ok', 'data' => $programmings], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Programmings.'])], 500);
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
        try {
            if (!$request->input('pilot_id') || !$request->input('destination_id') || !$request->input('airplane_id') || !$request->input('start') || !$request->input('end')) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $newProgramming = Programming::create($request->all());

            $response = Response::make(json_encode(['data' => $newProgramming]), 201)->header('Location', $request->root() . '/programmings/' . $newProgramming->id)->header('Content-Type', 'application/json');
            return $response;
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to safe the Programming.'])], 500);
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
            $programming = Programming::find($id);
            if (!$programming) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The programming you looking for does not exits.'])], 404);
            }
            $programming->airplane = $programming->airplane()->get();
            $programming->pilot = $programming->pilot()->get();
            $programming->destination = $programming->destination()->get();
            return response()->json(['status' => 'ok', 'data' => $programming], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to get the Programming.'])], 500);
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
            $programming = Programming::find($id);
            if (!$programming) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The programming you try to update  does not exits.'])], 404);
            }
            $airplane_id = $request->input('airplane_id');
            $destination_id = $request->input('destination_id');
            $pilot_id = $request->input('pilot_id');
            $start = $request->input('start');
            $end = $request->input('end');

            if ($request->method() === 'PATCH') {
                $flag = false;
                if ($airplane_id) {
                    $programming->airplane_id = $airplane_id;
                    $flag = true;
                }
                if ($destination_id) {
                    $programming->destination_id = $destination_id;
                    $flag = true;
                }
                if ($pilot_id) {
                    $programming->pilot_id = $pilot_id;
                    $flag = true;
                }
                if ($start) {
                    $programming->start = $start;
                    $flag = true;
                }
                if ($end) {
                    $programming->end = $end;
                    $flag = true;
                }
                if ($flag) {
                    $programming->save();
                    return response()->json(['status' => 'ok', 'data' => $programming], 200);
                } else {
                    return response()->json(['errors' => array(['code' => 200, 'message' => 'Nothing to update.'])], 200);
                }
            }
            if (!$airplane_id || !$destination_id || !$pilot_id || !$start || !$end) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $programming->airplane_id = $airplane_id;
            $programming->destination_id = $destination_id;
            $programming->pilot_id = $pilot_id;
            $programming->start = $start;
            $programming->end = $end;

            $programming->save();
            return response()->json(['status' => 'ok', 'data' => $programming], 200);

        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Programming.'])], 500);
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
            $programming = Programming::find($id);
            if (!$programming) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The programming you try to delete  does not exits.'])], 404);
            }
            $programming->delete();
            return response()->json(['code' => 200, 'message' => 'The programming was deleted succesfully'], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Programming.'])], 500);
        }
    }
}
