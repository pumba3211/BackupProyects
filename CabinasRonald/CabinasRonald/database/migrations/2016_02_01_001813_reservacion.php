<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Reservacion extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('reservacion',function(Blueprint $table){
            $table->increments('id');
            $table->integer('id_cliente')->references('id')->on('cliente');
            $table->integer('id_cabina')->references('id')->on('cabina');
            $table->date('fecha_reservacion');
            $table->date('fecha_cancelacion');
            $table->integer('cant_personas');
            $table->integer('factura');
            $table->integer('ingresos')->nullable();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('reservacion');
    }
}
