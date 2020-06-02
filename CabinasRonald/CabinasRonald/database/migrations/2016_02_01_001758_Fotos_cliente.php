<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class FotosCliente extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('fotos_cliente',function(Blueprint $table){
            $table->increments('id');
            $table->integer('id_foto')->references('id')->on('fotos')->onDelete('cascade');
            $table->integer('id_cliente')->references('id')->on('cliente')->onDelete('cascade');;
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('fotos_cliente');
    }
}
