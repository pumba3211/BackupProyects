<nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <div class="navbar-header page-scroll">
            <button type="button" class="navbar-toggle" data-toggle="collapse"
                    data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="/principal">Cabinas Ronald</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li class="page-scroll">
                    <a href="/principal/cabinas">Cabinas</a>
                </li>
                <li class="page-scroll">
                    <a href="/principal/empresas">Empresas</a>
                </li>
                <li class="page-scroll">
                    <a href="/principal/clientes">Clientes</a>
                </li>
                <li class="page-scroll">
                    <a href="/principal/reservaciones">Reservaciones</a>
                </li>
                @if (Auth::guest())
                @else
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">
                            {{ Auth::user()->name }} <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu" role="menu">
                            <li><a href="{{ url('/logout') }}"><i class="fa fa-btn fa-sign-out"></i>Desconectarse</a></li>
                        </ul>
                    </li>
                @endif
            </ul>
        </div>
    </div>
</nav>