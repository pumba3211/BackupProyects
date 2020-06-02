<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| This file is where you may define all of the routes that are handled
| by your application. Just tell Laravel the URIs it should respond
| to using a Closure or controller method. Build something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});
Route::resource('airplanes','AirPlaneController');
Route::resource('destinations','DestinationController');
Route::resource('programmings','ProgrammingController');
Route::resource('pilots','PilotController');

Route::resource('pilots.programmings','PilotProgrammingController');
Route::resource('destinations.programmings','AirplaneProgrammingController');
Route::resource('airplanes.programmings','DestinationProgrammingController');