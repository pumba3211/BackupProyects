<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class GameHistory extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('game_history', function (Blueprint $table) {
            $table->increments('id');
            $table->integer('game_id');
            $table->integer('user_id');
            $table->string('positionid');
            $table->string('letter');

        });


    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('game_history');
    }
}
