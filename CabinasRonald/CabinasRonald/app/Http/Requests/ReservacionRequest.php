<?php

namespace App\Http\Requests;

use App\Http\Requests\Request;

class ReservacionRequest extends Request
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array
     */
    public function rules()
    {
        return [
            'id_cabina' => 'required',
            'id_cliente' => 'required',
            'fecha_reservacion' => 'required|date',
            'fecha_cancelacion' => 'required|date',
            'cant_personas' => 'required'
        ];
    }
}
