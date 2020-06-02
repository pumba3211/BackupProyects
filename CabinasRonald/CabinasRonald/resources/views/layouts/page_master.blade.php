<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Css -->
    <title>Cabinas Ronald</title>
    {!! Html::style('assets/css/bootstrap/bootstrap.min.css') !!}
    {!! Html::style('assets/page/css/grid.css') !!}
    {!! Html::style('assets/page/css/style.css') !!}
    {!! Html::style('assets/page/css/camera.css') !!}
    {!! Html::style('assets/page/css/owl.carousel.css') !!}
    {!! Html::style('assets/page/css/page.css') !!}

            <!-- Scripts head-->
</head>
<body id="pagetop" class="index">
@yield('content')

<footer id="footer" class="divwhite divshadow">
    <div class="container">
        <div class="row">
            <div class="grid_12 copyright">
                <h2><span>Contactenos</span></h2>
                <img src="/assets/page/images/infocabina/message.png" class="img-circle"
                     style="width: 10%;height: 15%"/>
                <img src="/assets/page/images/infocabina/call.png" class="img-circle"
                     style="width: 10%;height: 15%"/>
            </div>
        </div>
    </div>
</footer>
@extends('scripts.page')
@extends('scripts.principalfooter')
</body>
</html>
