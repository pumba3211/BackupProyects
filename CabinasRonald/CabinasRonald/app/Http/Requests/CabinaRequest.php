<?php

namespace App\Http\Requests;

use App\Http\Requests\Request;

class CabinaRequest extends Request
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
            'televizor' => 'required',
            'abanico' => 'required',
            'ducha' => 'required',
            'cama' => 'required',
            'camamatrimonial' => 'required',
            'color' => 'required'
        ];
    }
}
