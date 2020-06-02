@extends('layouts.page_master')
@extends('page.navmenu')
@section('content')
    <section id="content">
        <br/>
        <div class="full-width-container block-2" id="servicios">
            <div class="container divwhite divshadow">
                <div class="grid_12">
                    <header>
                        <h2><span>Habitación {{$cabina->id}}</span></h2>
                    </header>
                </div>
                <div class="container">
                    <div class="grid_12">
                        <h3>Servicios Habitación</h3>
                    </div>
                </div>
                <br/>
                <div class="container">
                    <div class="grid_3  divinfocabina">
                        <img src="/assets/page/images/infocabina/televisor.png" class="img-responsive">
                        <h4>Televisor</h4>
                        <label>
                            @if($cabina->televizor == 1)
                                Tiene
                            @else
                                No tiene
                            @endif
                        </label>
                    </div>
                    <div class="col-md-1">

                    </div>
                    <div class="grid_3  divinfocabina">
                        <img src="/assets/page/images/infocabina/abanico.png" class="img-responsive">
                        <h4>Abanico</h4>
                        <label>
                            @if($cabina->abanico == 1)
                                Tiene
                            @else
                                No tiene
                            @endif
                        </label>
                    </div>
                    <div class="col-md-1">
                    </div>
                    <div class="grid_3  divinfocabina">
                        <img src="/assets/page/images/infocabina/ducha.jpg" class="img-responsive">
                        <h4>Ducha</h4>
                        <label>
                            @if($cabina->ducha == 1)
                                Tiene
                            @else
                                No tiene
                            @endif
                        </label>
                    </div>
                </div>
                <div class="container">
                    <br/>
                    <div class="grid_3  divinfocabina">
                        <img src="/assets/page/images/infocabina/camamatrimonial.jpg"
                             class="img-responsive divshadow">
                        <h4>Cama Matrimonial</h4>
                        <label>
                            @if($cabina->camamatrimonial == 1)
                                Tiene
                            @else
                                No tiene
                            @endif
                        </label>
                    </div>
                    <div class="col-md-1">

                    </div>
                    <div class="grid_3  divinfocabina">
                        <img src="/assets/page/images/infocabina/cama.jpg" class="img-responsive">
                        <h4>Camas Individuales</h4>
                        <label>
                            @if($cabina->camamatrimonial == 1 && $cabina->cama == 1)
                                No tiene
                            @elseif($cabina->camamatrimonial == 1 && $cabina->cama > 1)
                                Cuenta con {{$cabina->cama -1}} cama
                            @else
                                Cuenta con {{$cabina->cama}} camas
                            @endif
                        </label>
                    </div>
                    <div class="col-md-1">

                    </div>
                    <div class="grid_3  divinfocabina">
                        <img src="/assets/page/images/infocabina/refrigeradora.jpg"
                             class="img-responsive divshadow">
                        <h4>Refrigeradora</h4>
                        <label>
                            @if($cabina->refrigeradora == 1)
                                Tiene
                            @else
                                No tiene
                            @endif
                        </label>
                    </div>
                </div>
                <br/>
            </div>
        </div>
        <div class="container divwhite divshadow" id="imagenes">
            <div class="grid_12">
                <header>
                    <h2><span>Imagenes</span></h2>
                </header>
            </div>
            @forelse($fotos_cabina as $foto)
                <img src="{{$foto->imagenurl}}" class="img-responsive" width="100%" height="100%"/>
                <br/>
            @empty
                <div class="container">
                    <div class="grid_12">
                        <h4> Actualmente no contiene imagenes disponibles que mostrar</h4>
                    </div>
                </div>
            @endforelse
        </div>
        <br/>
    </section>
@endsection