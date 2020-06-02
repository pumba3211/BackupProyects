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
    {!! Html::style('assets/css/principal/principal.css') !!}
    {!! Html::style('assets/css/principal/dropzone.css') !!}
    {!! Html::style('assets/css/font-awesome/css/font-awesome.min.css') !!}
    {!! Html::style('assets/css/font-awesome/italic.css') !!}
    {!! Html::style('assets/css/font-awesome/Monserrat.css') !!}
    {!! Html::style('assets/fullcalendar/fullcalendar.css') !!}
    <link href='../assets/fullcalendar/fullcalendar.print.css' rel='stylesheet' media='print'/>
    <!-- Scripts head-->
    {!! Html::script('assets/js/compartidos/html5shiv.js') !!}
    {!! Html::script('assets/js/compartidos/respond.min.js') !!}
</head>
<body>
@yield('content')
</body>
@extends('scripts.principalfooter')
</html>