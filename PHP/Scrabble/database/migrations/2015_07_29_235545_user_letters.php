<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class UserLetters extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
         Schema::create('user_letters', function (Blueprint $table) {
            $table->increments('id');
            $table->integer('game_id');
            $table->integer('user_id');
            $table->string('letterboard');
            $table->string('letter_id');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('user_letters');
    }
}
