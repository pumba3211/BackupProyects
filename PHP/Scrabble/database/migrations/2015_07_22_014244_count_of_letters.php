<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CountOfLetters extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
       Schema::create('count_of_letters', function (Blueprint $table) {
            $table->increments('id');
            $table->string('letter');
            $table->string('count');
            $table->integer('value');

        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
         Schema::drop('count_of_letters');
    }
}
