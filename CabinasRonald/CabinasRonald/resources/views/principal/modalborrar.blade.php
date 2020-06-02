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
    {!! Html::style('assets/css/font-awesome/css/font-awesome.min.css') !!}
    {!! Html::style('assets/css/font-awesome/italic.css') !!}
    {!! Html::style('assets/css/font-awesome/Monserrat.css') !!}
            <!-- Scripts head-->
    {!! Html::script('assets/js/compartidos/html5shiv.js') !!}
    {!! Html::script('assets/js/compartidos/respond.min.js') !!}
</head>
<body>
<div class="container">
    <div class="modald">
        <h2>{{$titulo}}</h2>
        <p>{{$contenido}}</p>
        <br/>
        <button id="Aceptar" class="botonCrear botonTipo1">Aceptar</button>
        <button id="Cancelar" class="botonEliminar botonTipo1">Cancelar</button>
        <div>
        </div>
    </div>
</div>
</body>
@extends('scripts.principalfooter')
</html>