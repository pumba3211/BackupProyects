<?php

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| Here is where you can register all of the routes for an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/
Route::controllers([
	'auth' => 'Auth\AuthController',
	'password' => 'Auth\PasswordController',
	]);
Route::get('/', function () {
	return view('auth.login');
});


Route::group(['middleware' => 'auth'], function () {
	

	Route::get('games/{id}/gamedata', 'GameController@gameData');
	Route::get('games/{id}/join', 'GameController@join');
	Route::get('games/{id}/getgame', 'GameController@getgame');
	Route::get('dictionary/{word}/compareword', 'DictionaryController@compareWord');
	Route::post('games/ready', 'GameController@ready');
	Route::post('games/notready', 'GameController@notready');
	Route::get('games/game_state', 'GameController@game_state');
	//traer usuarios del juego
	Route::post('games/regenerateletters','GameController@re_generate_letters');
	Route::post('games/passturn','GameController@pass_turn');
	Route::post('games/jump','GameController@jump');
	Route::post('games/increasePoints','GameController@increasePoints');
	
	Route::get('games/{id}/users_game', 'GameController@users_game');
	Route::post('games/{id}/start_game', 'GameController@start_game');
	Route::get('games/{id}/start_game', 'GameController@start_game');	
	Route::get('home', 'GameController@index');
	Route::resource('dictionary', 'DictionaryController');
	Route::resource('game_History', 'GameHistoryController');
	Route::resource('game_Letters', 'GameLettersController');
	Route::resource('user_Game', 'UserGameController');
	Route::resource('letters', 'LettersController');
	Route::resource('vista', 'VistaController');
	Route::resource('games', 'GameController');
	Route::post('games/addhistory', 'GameController@InsertHistory');
});



