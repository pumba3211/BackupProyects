@extends('layouts.master')

@section('content')
<div class="login">
	<div class="container log">
		@if (count($errors) > 0)
		<div onchange='login' class="alert alert-danger">
			<strong>Whoops!</strong> There were some problems with your input.<br>
			<ul>
				@foreach ($errors->all() as $error)
				<li>{{ $error }}</li>
				@endforeach
			</ul>
		</div>
		@endif

		<div class="row">
				<h5>
					<p class="center-align">Lets Play Scrabble..!</p>
				</h5>
				<h6>
					<p class="center-align">Sign In or Register to Start</p>
				</h6>

			<form class="col s11" role="form" method="POST" action="{{ url('/auth/login') }}">
				<input type="hidden" name="_token" value="{{ csrf_token() }}">
				<div class="row">
					<div class="input-field col s12">
						<i class="material-icons prefix">email</i>
						<input id="email" type="email" name="email" class="validate" value="{{ old('email') }}">
						<label for="email">Email</label>
					</div>
					<div class="input-field col s12">
						<i class="material-icons prefix">vpn_key</i>
						<input id="password" type="password" name="password" class="validate">
						<label for="password">Password</label>
					</div>
				</div>
				<div class="row">
					<div class="col s12 offset-s3">
						<button type="submit" class="btn btn-primary">Login</button>
						<button type="button" class="btn btn-primary" onclick="location.href='/auth/register'">Register</button>
					</div>
				</div>
			</form>
		</div>
	</div>
</div>
@endsection
