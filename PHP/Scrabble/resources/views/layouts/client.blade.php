<html lang="es">
<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<script src="{{ asset('assets/js/jquery-2.1.4.js') }}" ></script>
	<script src="{{ asset('assets/js/songs.js') }}" ></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.2/themes/smoothness/jquery-ui.css">
    <script src="//code.jquery.com/ui/1.11.2/jquery-ui.js"></script>
	<title>Cyber Rocola</title>

	{!! Html::style('assets/css/bootstrap.css') !!}
	{!! Html::style('assets/css/page.css') !!}
	<link href='//fonts.googleapis.com/css?family=Roboto:400,300' rel='stylesheet' type='text/css'>
</head>
<body>
	<div class="principal">
		@yield('partial') 
	</div>
</div>

@yield('content') 
<!-- Scripts -->
{!! Html::script('assets/js/bootstrap.min.js') !!}	
{!! Html::script('assets/js/page.js') !!}	
</body>
<script>
	fnButtons();
</script>
</html>
