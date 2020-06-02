<?php
 
use Illuminate\Database\Seeder;
 
// Hace uso del modelo de User.
use App\User;
use Faker\Factory as Faker;

class UserSeeder extends Seeder {
 
	/**
	 * Run the database seeds.
	 *
	 * @return void
	 */
	public function run()	
	{
        $faker = Faker::create();
        for ($i=0; $i<100; $i++)
		{
            User::create(
                [
                    'name'=>$faker->word(),
                    'email'=>$faker->word().'@test.es',
                    'password'=> Hash::make('abc123')	//Cifrado de la contraseña abc123
                ]);
	    }
    }
}