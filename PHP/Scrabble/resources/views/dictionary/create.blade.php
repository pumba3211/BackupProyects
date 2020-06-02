@extends('layouts.master')

@section('content')

    <br/>
    <div class="panel panel-info">
        <div class="panel-heading">
            <div class="panel-title">Create Singer</div>
        </div>
        <div style="padding-top:30px" class="panel-body">
            <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
            {!!Form::open(array('url' => '/Dictionary'))!!}

            <div style="margin-bottom: 25px" class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-music"></i></span>
                <input type="text" class="form-control" name="word" value="" placeholder="Singer Name">
            </div>
            <div style="margin-top:10px" class="form-group">
                <div class="col-sm-12 controls">
                    <button class="btn btn-success" type="submit">Create</button>
                </div>
            </div>
            {!!Form::close()!!}

        </div>
    </div>
@endsection