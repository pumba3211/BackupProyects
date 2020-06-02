@extends('layouts.master')
@section('content')
<div class="login">
	@if (count($errors) > 0)
	<div>
		<strong>Whoops!</strong> There were some problems with your input.<br>
		<ul>
			@foreach ($errors->all() as $error)
			<li>{{ $error }}</li>
			@endforeach
		</ul>
	</div>
	@endif
	<div class="container log">
		<div></div>
		<form class="col s11" role="form" method="POST" action="{{ url('/auth/register') }}">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
			<h5>
				<p class="center-align">Register</p>
			</h5>

			<div class="row">
				<div class="input-field col s12">
					<i class="material-icons prefix">perm_identity</i>
					<input id="name" type="text" name="name" class="validate" value="{{ old('name') }}">
					<label class="col-md-4 control-label">Name</label>
				</div>

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

				<div class="input-field col s12">
					<i class="material-icons prefix">vpn_key</i>
					<input type="password" class="form-control" name="password_confirmation">
					<label for="password">Confirm Password</label>
				</div>

				<div class="col s7 offset-s4">
					<button class="btn waves-effect waves-light" type="submit" name="action">Register
						<i class="material-icons">send</i>
					</button>
				</div>
			</form>
		</div>
	</div>
	@endsection