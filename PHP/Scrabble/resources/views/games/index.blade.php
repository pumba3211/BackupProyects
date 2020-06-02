@extends('layouts.master')

@section('content')
<a class="waves-effect waves-light btn" id="logout" href="/auth/logout">Log Out</a>

<div class = "container">  
	<div class = "row">

		<div class="col s11 offset-s3">
			<p><h1>MAIN BOARD</h1></p>
		</div>

		<div class = "col s6 left z-depth-3">  
			<button id = "crear" class="btn waves-effect waves-light main_btn"  onclick="createGame();" type="submit" name="action">New Game
				<i class="material-icons">power_settings_new</i>
			</button>

			<div id = "new_game"></div>
			<div id = "players"></div>				

			<button id = "start_game" class="btn waves-effect waves-light main_btn"  onclick="startGame();" name="action">Start Game
				<i class="material-icons">power_settings_new</i>
			</button>
		</div>

		<div id = 'right' class = "col s5 select z-depth-3">
		</div>

		<div class="col s8 offset-s3"></div>
	</div>


	<div class="row" >
		<div id="join_players" class="col s4 z-depth-3">
			<div id = "players_on_game">
			</div>

			<button id = "start_join_game" class="btn waves-effect waves-light main_btn"  onclick="startGame();" name="action">Start Game
				<i class="material-icons">power_settings_new</i>
			</button>
		</div>
	</div>
</div>
@endsection