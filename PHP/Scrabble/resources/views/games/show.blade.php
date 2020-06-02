@extends('layouts.master')

@section('content')
<a class="waves-effect waves-light btn" id="logout_show" href="/auth/logout">Log Out</a>

<input type="hidden" id="gameid" value="{{{ $game->id }}}">
@if($userjoin === 1)
@if ($game->state === 'S')
<div>		
	<div class="row">
		<div id="playersscore" class="col s3">
			<table id="score" class="bordered">
				<thead>
					<tr>
						<th class="center" colspan="2" data-field="id">Score</th>
					</tr>
					<tr>
						<th>Player</th>  
						<th>Score</th>
					</tr> 					
				</thead>
				<tbody id="scorebody">

				</tbody>
			</table>
			<div id = "btns">
				<button class="btn waves-effect waves-light buttons" type="submit" onclick="jump();" name="action">JUMP
					<i class="material-icons">thumb_down</i>
				</button>
				<button class="btn waves-effect waves-light buttons" type="submit" onclick="endturn();" name="action">VERIFY
					<i class="material-icons">done</i>
				</button>
				<button class="btn waves-effect waves-light buttons" type="submit" onclick="give_up();" name="action">GIVE UP
					<i class="material-icons">thumb_down</i>
				</button>
				<button class="btn waves-effect waves-light buttons" type="submit" name="action">DICTIONARY
					<i class="material-icons">view_list</i>
				</button>	
			</div>
		</div>

		<div class="col s9">
			<div id="gameboard" > 
				<table id="game" border="1">
				</table>
			</div>
		</div>

		<div class="col s5 offset-s6">
			<table id="playerletters">
			</table>
		</div>
	</div>
</div>
@else
<h2> El juego aun no ha empezado</h2>
@endif
@else
<h3> Aun no estas en la partida unete </h3><button id="join" onclick="Join();">Join</button>
<label id="resultado"></label>
@endif
@endsection