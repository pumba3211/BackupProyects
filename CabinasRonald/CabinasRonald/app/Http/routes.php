<?php

/*
|--------------------------------------------------------------------------
| Routes File
|--------------------------------------------------------------------------
|
| Here is where you will register all of the routes in an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/

Route::get('/', function () {
    return view('welcome');
});

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| This route group applies the "web" middleware group to every route
| it contains. The "web" middleware group is defined in your HTTP
| kernel and includes session state, CSRF protection, and more.
|
*/

Route::group(['middleware' => ['web']], function () {

    Route::auth();
    Route::get('/', 'PageController@index');
    Route::get('/home', 'PageController@index');
    Route::get('/infocabina/{id}', 'PageController@infocabina');

    Route::group(['middleware' => 'auth'], function () {
        //Ruta principal
        Route::get('/principal', 'PrincipalController@index');

        //Rutas recursos
        Route::resource('principal/cabinas', 'CabinaController');
        Route::resource('principal/clientes', 'ClienteController');
        Route::resource('principal/reservaciones', 'ReservacionController');
        Route::resource('principal/fotos', 'FotosController');
        Route::resource('principal/empresas', 'EmpresaController');

        //Busqueda reservaciones
        Route::get('principal/reservaciones/fecha/{date}', 'ReservacionController@reservacionesPorFecha');
        Route::get('obtenerReservaciones', 'ReservacionController@obtenerRerservaciones');
        Route::get('busquedaClienteSelect/{busqueda}', 'ClienteController@busquedaClienteSelect');
        Route::get('busquedaClienteTable/{busqueda}', 'ClienteController@busquedaClienteTable');
        Route::get('showModalAccionesReservacion/{id}', 'ReservacionController@showModalAccionesReservacion');

        //Busqueda cabinas
        Route::get('principal/cabinasJson', 'CabinaController@cabinasJson');
        Route::get('tabla_cabinas', 'CabinaController@tabla_cabinas');
        Route::get('Fotos_cabinas/{id}', 'CabinaController@fotos_cabinas');

        //Busqueda clientes
        Route::get('tabla_clientes', 'ClienteController@tabla_clientes');
        Route::get('Fotos_clientes/{id}', 'ClienteController@fotos_cliente');

        //BusquedaEmpresas
        Route::get('busquedaEmpresaSelect/{busqueda}', 'EmpresaController@busquedaEmpresaSelect');

        //Borrar Foto
        Route::post('deletefoto', 'FotosController@borrarFoto');

        //Registro
        Route::get('/usuarios/register', 'HomeController@register');
        Route::get('/register', 'HomeController@register');

        //Consultas
        Route::get('principal/clientesfrecuentes', 'ConsultasController@clientesFrecuentes');
        Route::get('clientesfrecuentes/{fecha}', 'ConsultasController@clientesFrecuentesFecha');
        Route::get('principal/ingresos', 'ConsultasController@Ingresos');
        Route::get('ingresos/{fecha}', 'ConsultasController@IngresosBusquedaFechas');


        Route::get('pruebas', 'HomeController@pruebas');

        Route::get('/phpinfo', 'HomeController@phpinfo');
    });

});
