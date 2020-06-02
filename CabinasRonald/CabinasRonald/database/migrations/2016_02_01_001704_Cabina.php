<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Cabina extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('cabina', function (Blueprint $table) {
            $table->increments('id');
            $table->integer('televizor');
            $table->integer('abanico');
            $table->integer('ducha');
            $table->integer('cama');
            $table->integer('camamatrimonial');
            $table->integer('refrigeradora');
            $table->string('color');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('cabina');
    }
}
