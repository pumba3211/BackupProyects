<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Cliente extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('cliente', function (Blueprint $table) {
            $table->increments('id');
            $table->string('cedula');
            $table->string('nombre');
            $table->string('apellidos');
            $table->integer('visitas')->nullable();
            $table->string('telefono');
            $table->integer('id_empresa')->references('id')->on('empresa')->onDelete('cascade');
            $table->date('primeravisita')->nullable();
            $table->date('ultimavisita')->nullable();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('cliente');
    }
}
