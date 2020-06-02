function loguearse() {
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;
    var usuarios = JSON.parse(localStorage.getItem("usuario"));
    var usuariocorrecto = false;
    var usuarioON;
    if (username == "" || password == "" || username == " " || password == " ") {
        document.getElementById('mensaje').innerHTML = "<p class=col-md-offset-4 text-center id=mensaje>Escribe todos los datos por favor</p>";
    }

    else {
        for (var i = 0; i < usuarios.length; i++) {
            if ((username == usuarios[i].username) && (password == usuarios[i].password)) {
                usuariocorrecto = true;
                var usuarioON = usuarios[i].username;
            }
        }
        if (usuariocorrecto == true) {
            localStorage.setItem("usuarioOn", usuarioON);
            location.href = "AdminDashboard.html";
        }
        else {
            document.getElementById("mensaje").innerHTML = "<p class=col-md-offset-4 text-center id=mensaje>Usuario o contraseña incorrectos</p>";
        }
    }
}

function prepareBinding() {
    //$( "#test_button" ).bind( "click", function() { my_alert('text 2');});
    $("#loguearse").click(function () {
        loguearse();
    });
}