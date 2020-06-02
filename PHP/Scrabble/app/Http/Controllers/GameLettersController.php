<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Http\Requests;
use App\Http\Controllers\Controller;

class GameLettersController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return Response
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     *
   
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  Request  $request
     * @return Response
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  Request  $request
     * @param  int  $id
     * @return Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return Response
     */
    public function destroy($id)
    {
        
    }
    public function updateLetterCount(Request $request){
        $array=$request->letters;
        foreach ($array as $letter) {
           \App\Models\GameLetters::updateGamesLetter($letter->game_id,$letter->letter_id,$letter->count);
        }  
    }
    public function user_Letters_by_game(Request $request){
        $array=$request->user_letters;
        if(\Auth::User()!= null){
             foreach ($array as $letter) {
                \App\Models\UserLetters::create(array('game_id' => $request->game_id,
                    'user_id'=>\Auth::User()->id,'letterboard'=>$letter->letterboard,
                    'letter_id' => $letter->letter_id);
            }  
        }   
    }
}
