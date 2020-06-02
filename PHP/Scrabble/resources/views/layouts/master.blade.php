<!DOCTYPE html>
<html lang="es">
<head>
	<!--Import materialize.css-->
	<link type="text/css" rel="stylesheet" href="/assets/materialize/css/materialize.min.css"  media="screen,projection"/>
	<link type="text/css" rel="stylesheet" href="/assets/materialize/css/page.css"  media="screen,projection"/>
	<link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
	<!--Let browser know website is optimized for mobile-->
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	{!! Html::style('assets/css/game.css') !!}
	<title>Scrabble</title>
	<link rel="stylesheet" href="//code.jquery.com/ui/1.11.2/themes/smoothness/jquery-ui.css">

	<title>Scrabble</title>
</head>
<body>
	@yield('content')
	{!! Html::script('assets/js/jquery-2.1.4.js') !!}	
	{!! Html::script('//code.jquery.com/ui/1.11.2/jquery-ui.js') !!}	
	<script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>	<script type="text/javascript" src="/assets/materialize/js/materialize.min.js"></script>
	<script type="text/javascript" src="/assets/materialize/js/page.js"></script>
	{!! Html::script('assets/js/constants.js') !!}
	{!! Html::script('assets/js/board.js') !!}
	{!! Html::script('assets/js/game.js') !!}
	{!! Html::script('assets/js/word.js') !!}
</body>
<script>
	generateGame();
	getGameData();
	updategame(time);
</script>
</html>