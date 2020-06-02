<?php

namespace App\Console\Commands;

use App\Http\Funciones;
use App\Models\Reservacion;
use Illuminate\Console\Command;

class FinalizarReservaciones extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'FinalizarReservaciones';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Finaliza todas las reservaciones al dia de hoy';

    /**
     * Create a new command instance.
     *
     * @return void
     */
    public function __construct()
    {
        parent::__construct();
    }

    /**
     * Execute the console command.
     *
     * @return mixed
     */
    public function handle()
    {
        $date = Funciones::fechaActual();
        $reservaciones = Reservacion::obtenerReservacionesFechaFinalizar($date);
        foreach ($reservaciones as $reservacion) {
            $reservacion = Reservacion::find($reservacion->id);
            $reservacion->factura = 2;
            $reservacion->ingresos = Funciones::CalcularPrecio($reservacion);
            $reservacion->save();
        }
    }
}
