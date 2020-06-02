function Compare_Word(word,arr_word,order){
	$.ajax({
		url: "/dictionary/" + word + "/compareword",
		type: "GET",
		success: function (data) {
			if(data == 1){
				if(order = 0){
					words_get_pointsh.push(arr_word);
				}
				else{
					words_get_pointsv.push(arr_word);
				}
			}
		}
	});
}

function Evaluate_words(){
	verify_horizontal();
	verify_vertical();
}


function verify_horizontal(){
	var word = "";
	var arr_word = [];

	//trae todas los id de los campos del tablero
	$(".board").each(function ()
	{
		var temp = '#'+ $(this).attr('id');

		if ( $(temp).val() == "" ) {
			word  = "";
			arr_word = [];
		}else{
			word += $(temp).val();
			var id = $(this).attr('id');
			arr_word.push({id: id});

			if (word.length >= 2) {
				if (verify_word_end(arr_word)) {
					Compare_Word(word,arr_word,0);
				}
			}
		}
	});
}

function verify_vertical(){
	for (var i = 0; i <= 14; i++) {
		for (var j = 0; j <= 14; j++) {
			var temp = '#c'+ j +"_" + i;

			if ( $(temp).val() == "" ) {
				word  = "";
				arr_word = [];
			}else{
				word += $(temp).val();
				var id = 'c' + j + "_" + i;
				arr_word.push({id: id});
				if (word.length >= 2) {
					if (verify_word_end(arr_word)) {
						Compare_Word(word,arr_word,1);
					}
				}
			}
		}
	}
}


function verify_word_end(arr_word){
	var bool = false;

	for (var i = 0; i < addhistory.length; i++) {
		for (var j = 0; j < arr_word.length; j++) {

			if (addhistory[i].positionid == arr_word[j].id) {
				bool = true;
				break;
			};
		}
		return bool;
	}
}

function calculate_points(array){
	var points = 0;
	for (var i = 0; i < array.length; i++) {
		points += calculate_points_word(array[i]);
	}
	return points;
}

function calculate_points_word(word){
	var wordpoints = 0;
	var red = false;
	var countred = 0;
	var pink = false;
	var countpink = 0;
	for (var i = 0; i < word.length; i++) {		
		var id_class = $("#" + word[i].id).attr("class");
		var letter_value = $("#" + word[i].id).data('value');
		var classes = id_class.split(" ");
		var color = classes[1];
		console.log(letter_value+" "+color);
		if(color == "red-background"){
			red = true;
			countred += 1;
			wordpoints += letter_value;
		}

		if(color == "pink-background"){
			pink = true;
			countpink += 1;
			wordpoints += letter_value;
		}	
		else{
			wordpoints += (color_points(letter_value,color));
		}
	}
	if(red){
		wordpoints = (wordpoints * (3 * countred));
	}
	if(pink){
		wordpoints = (wordpoints * (2 * countpink));
	}
	return wordpoints;
}

function color_points(letter_value,color){
	letter_points = 0;
	switch(color){
		case "green-background":
			letter_points = (letter_value * 1);
			break;
		case "blue-background":
			letter_points = (letter_value * 3);
			break;
		case "light_blue-background":
			letter_points = (letter_value * 2);
			break;
	}
	return letter_points;		
}

function endturn(){
    Evaluate_words();
    if(words_get_pointsv.length == 0 && words_get_pointsh.length == 0){
    
    }
    else{
    	var pointsv = calculate_points(words_get_pointsv);
    	var pointsh = calculate_points(words_get_pointsh);
    	update_Player_Points( pointsv + pointsh);
    	Regenerate_Letters();
    	Add_History();
    	Pass_turn();
    	getGameData();
    	words_get_pointsv=[];
    	words_get_pointsh=[];
    }
	
}


