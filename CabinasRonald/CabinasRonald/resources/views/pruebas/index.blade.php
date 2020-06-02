{{$date = date("Y") . '-' . date('m') . '-' . date("d")}}

{{$date1= strtotime($date)}}
{{$date2 = strtotime('2016-03-11')}}
{{($date1 - $date2)/3600/24}}