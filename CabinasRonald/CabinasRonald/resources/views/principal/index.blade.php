@extends('layouts.principal_master')
@section('content')
    <div id="page-top" class="index">
        @extends('principal.navmenu')
        <header>
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="intro-text">
                            <span class="name">Cabinas Ronald</span>

                        </div>
                    </div>
                </div>
            </div>
        </header>
        <section id="portfolio">
            <div class="container divstyle1">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h2>Mantenimientos</h2>

                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6 portfolio-item">
                        <h3>Cabinas</h3>
                        <a href="principal/cabinas" class="portfolio-link" data-toggle="modal">
                            <div class="caption">
                                <div class="caption-content">
                                    <i class="fa fa-search-plus fa-3x"></i>
                                </div>
                            </div>
                            <img src="assets/css/principal/img/portfolio/cabin.png" class="img-responsive" alt="">
                        </a>
                    </div>
                    <div class="col-sm-6 portfolio-item">
                        <h3>Clientes</h3>
                        <a href="principal/clientes" class="portfolio-link" data-toggle="modal">
                            <div class="caption">
                                <div class="caption-content">
                                    <i class="fa fa-search-plus fa-3x"></i>
                                </div>
                            </div>
                            <img src="assets/css/principal/img/portfolio/clientes.png" class="img-responsive" alt="">
                        </a>
                    </div>
                    <div class="col-sm-6 portfolio-item">
                        <h3>Empresas</h3>
                        <a href="principal/empresas" class="portfolio-link" data-toggle="modal">
                            <div class="caption">
                                <div class="caption-content">
                                    <i class="fa fa-search-plus fa-3x"></i>
                                </div>
                            </div>
                            <img src="assets/css/principal/img/portfolio/empresas.jpg" class="img-responsive"
                                 alt="">
                        </a>
                    </div>
                    <div class="col-sm-6 portfolio-item">
                        <h3>Reservaciones</h3>
                        <a href="principal/reservaciones" class="portfolio-link" data-toggle="modal">
                            <div class="caption">
                                <div class="caption-content">
                                    <i class="fa fa-search-plus fa-3x"></i>
                                </div>
                            </div>
                            <img src="assets/css/principal/img/portfolio/reservaciones.jpg" class="img-responsive"
                                 alt="">
                        </a>
                    </div>
                </div>
            </div>
            <br/>
            <div class="container divstyle1" id="consultas">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h2>Consultas</h2>
                        <div class="row">
                            <div class="col-sm-4 portfolio-item">
                                <h3>Clientes Frecuentes</h3>
                                <a href="principal/clientesfrecuentes" class="portfolio-link" data-toggle="modal">
                                    <div class="caption">
                                        <div class="caption-content">
                                            <i class="fa fa-search-plus fa-3x"></i>
                                        </div>
                                    </div>
                                    <img src="assets/css/principal/img/portfolio/cabin.png" class="img-responsive"
                                         alt="">
                                </a>
                            </div>
                            <div class="col-sm-4 portfolio-item">
                                <h3>Ingresos</h3>
                                <a href="principal/ingresos" class="portfolio-link" data-toggle="modal">
                                    <div class="caption">
                                        <div class="caption-content">
                                            <i class="fa fa-search-plus fa-3x"></i>
                                        </div>
                                    </div>
                                    <img src="assets/css/principal/img/portfolio/ingresos.png" class="img-responsive"
                                         alt="">
                                </a>
                            </div>
                            <div class="col-sm-4 portfolio-item">
                                <h3>Reservaciones</h3>
                                <a href="principal/reservaciones" class="portfolio-link" data-toggle="modal">
                                    <div class="caption">
                                        <div class="caption-content">
                                            <i class="fa fa-search-plus fa-3x"></i>
                                        </div>
                                    </div>
                                    <img src="assets/css/principal/img/portfolio/reservaciones.jpg"
                                         class="img-responsive" alt="">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Scroll to Top Button (Only visible on small and extra-small screen sizes) -->
        @extends('principal.modals')
    </div>
@endsection