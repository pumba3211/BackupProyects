<?php

namespace App\Http\Controllers;

use App\Destination;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Response;

class DestinationController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return response()->json(['status' => 'ok', 'data' => Destination::all()], 200);
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
            if (!$request->input('name') || !$request->input('description')) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $newDestination = Destination::create($request->all());
            $response = Response::make(json_encode(['data' => $newDestination]), 201)->header('Location', $request->root() . '/destinations/' . $newDestination->id)->header('Content-Type', 'application/json');
            return $response;
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to safe the Destination.'])], 500);
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
            $destination = Destination::find($id);
            if (!$destination) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The destination you looking for does not exits.'])], 404);
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
        try {
            $destination = Destination::find($id);
            if (!$destination) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The destination you try to update  does not exits.'])], 404);
            }
            $name = $request->input('name');
            $description = $request->input('description');
            if ($request->method() === 'PATCH') {
                $flag = false;
                if ($name) {
                    $destination->name = $name;
                    $flag = true;
                }
                if ($description) {
                    $destination->description = $description;
                    $flag = true;
                }
                if ($flag) {
                    $destination->save();
                    return response()->json(['status' => 'ok', 'data' => $destination], 200);
                } else {
                    return response()->json(['errors' => array(['code' => 200, 'message' => 'Nothing to update.'])], 200);
                }
            }
            if (!$name || !$description) {
                return response()->json(['errors' => array(['code' => 422, 'message' => 'Some data is necesary.'])], 422);
            }
            $destination->name = $name;
            $destination->description = $description;

            $destination->save();
            return response()->json(['status' => 'ok', 'data' => $destination], 200);

        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Destination.'])], 500);
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
            $destination = Destinations::find($id);
            if (!$destination) {
                return response()->json(['errors' => array(['code' => 404, 'message' => 'The destination you try to delete  does not exits.'])], 404);
            }
            $programmings = $destination->programmings;
            if (sizeof($programmings) > 0) {
                return response()->json(['code' => 409, 'message' => 'This is destination have some programmings and can not be deleted.'], 409);
            }

            $destination->delete();
            return response()->json(['code' => 200, 'message' => 'The destination was deleted succesfully'], 200);
        } catch (Exception $error) {
            return response()->json(['errors' => array(['code' => 500, 'message' => 'That was a problem trying to update the Destination.'])], 500);
        }
    }
}
