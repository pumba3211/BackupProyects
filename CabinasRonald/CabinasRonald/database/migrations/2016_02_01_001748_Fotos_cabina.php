<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class FotosCabina extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('fotos_cabina',function(Blueprint $table){
            $table->increments('id');
            $table->integer('id_foto')->references('id')->on('fotos')->onDelete('cascade');
            $table->integer('id_cabina')->references('id')->on('cabina')->onDelete('cascade');;
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('fotos_cabina');
    }
}
