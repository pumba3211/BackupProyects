@extends('layouts.master2')


@section('content')
<div>
	<input type="hidden" id="gameid" value="{{{ $id }}}">

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
				<tbody id="score">
					<tr>
						<td>HELLO</td>
						<td>20</td>
					</tr>
					<tr>
						<td>CAT</td>
						<td>30</td>
					</tr>
					<tr>
						<td>DOG</td>
						<td>30</td>
					</tr>
				</tbody>
			</table>
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
@endsection