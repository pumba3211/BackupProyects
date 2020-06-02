<?php

namespace App\Http\Middleware;

use Closure;

class Usernotnull
{
    /**
     * Handle an incoming request.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  \Closure  $next
     * @return mixed
     */
    public function handle($request, Closure $next)
    {
        return $next($request);
    }
    public static function userStatte(){
        $state=true;
        if(\Auth::User() == null){
            $state=false;
        }
    }
}
