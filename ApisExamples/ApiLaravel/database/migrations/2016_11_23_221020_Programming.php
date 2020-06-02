<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Programming extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('programmings', function (Blueprint $table) {
            $table->increments('id');


            $table->integer('destination_id')->unsigned();
            $table->foreign('destination_id')->references('id')->on('destinations');

            $table->integer('airplane_id')->unsigned();
            $table->foreign('airplane_id')->references('id')->on('airplanes');

            $table->integer('pilot_id')->unsigned();
            $table->foreign('pilot_id')->references('id')->on('pilots');

            $table->dateTime('start');
            $table->dateTime('end');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop("programmings");
    }
}
