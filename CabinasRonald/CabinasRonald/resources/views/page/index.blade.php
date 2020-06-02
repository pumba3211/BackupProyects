@extends('layouts.page_master')
@extends('page.navbar')
@section('content')
    <section id="content">
        <br/>
        <div class="full-width-container block-2 " id="informacion">
            <div class="container divwhite divshadow">
                <div class="grid_12">
                    <header>
                        <h2><span>Cabinas Ronald</span></h2>
                    </header>
                    <img src="/assets/page/images/menu.jpg" class="img-responsive"/>
                </div>
                <br/>
                <div class="grid_12">
                    <header>
                        <h4><span>Pasillo</span></h4>
                    </header>
                    <img src="/assets/page/images/pasillo.jpg" class="img-responsive"/>
                </div>
                <br/>
                <div class="grid_12">
                    <header>
                        <h4><span>Recepcion</span></h4>
                    </header>
                    <img src="/assets/page/images/recepcion.jpg" class="img-responsive"/>
                    <br/>
                </div>
            </div>
        </div>
        <div class="full-width-container block-3 parallax-block divshadow" data-stellar-background-ratio="0.5"
             id="servicios">
            <div class="container">
                <div class="grid_12">
                    <header>
                        <h2><span>Servicios</span></h2>
                    </header>
                </div>
                <div class="grid_12">
                    <div class="element"><h3>Internet</h3><img
                                src="https://cdn0.iconfinder.com/data/icons/ie_Bright/512/internet_earth.png"
                                width="100" height="100"/></div>
                </div>
                <div class="grid_12">
                    <div class="element"><h3>Televisión por cable</h3>
                    </div>
                    <div class="grid_12">
                        <div class="element"><h3>Parqueo Privado</h3></div>
                    </div>
                    <div class="grid_12">
                        <div class="element">
                            <div class="container">
                                <img src="/assets/page/images/parqueo1.jpg" class="img-responsive"/>
                            </div>
                        </div>
                    </div>
                    <div class="grid_12">
                        <div class="element">
                            <div class="container">
                                <img src="/assets/page/images/parqueo2.jpg" class="img-responsive"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="full-width-container block-4" id="cabinas">
            <div class="container divwhite divshadow">
                <header>
                    <h2><span>Habitaciones</span></h2>
                </header>
                <ul class="list-group">
                    @foreach($cabinas as $cabina)
                        <li class="list-group-item">
                            <h3><a href="/infocabina/{{$cabina->id}}">Habitación {{$cabina->id}}</a>
                            </h3>
                        </li>
                    @endforeach
                </ul>
            </div>
        </div>
    </section>
@endsection