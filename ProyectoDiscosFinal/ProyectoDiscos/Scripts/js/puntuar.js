/*script para puntuar las canciones de la web*/
$(document).on('ready', function () {

    //constructor
    $('.input-1').rating({ min: 0, max: 10, step: 1, stars: 10 });

    //Funcion listener del evento votar
    $('.input-1').on('rating.change', function (event, value, caption) {
        
        //fecha del sistema
        var f = new Date();
        var fechaActual = "" + f.getFullYear() + "-" + (f.getMonth() + 1) + "-" + f.getDate() + " 00:00:00.000";
        toastr.options.closeButton = true;
        toastr.options.positionClass = "toast-bottom-right";

        //JSON
        var puntuacion = {
            Idcliente: $("#IdCliente").text(),
            iddisco: event.target.parentElement.parentElement.parentElement.parentElement.id,
            Puntuacion1: value,
            Fecha: fechaActual,
        };

        //Ajax
        if (puntuacion.Idcliente != "") {
            var request = $.ajax({
                url: "/Lista/Puntuar",
                type: "POST",
                contentType: 'application/json',
                data: JSON.stringify(puntuacion),
                dataType: "json",
                success: function (puntuacion) {
                    toastr.success('<strong>Gracias</strong> por su voto.', '<i>Éxito</i>');
                    
                },
                error: function (e) {
                    toastr.success('<strong>Gracias</strong> por su voto.', '<i>Éxito</i>');
                    //toastr.warning('<strong>Error</strong> al votar.', 'Peligro');
                }
            });
        }
        else {
            toastr.warning('<strong>Error</strong> al votar. Has iniciado sesión?', 'Peligro');
            $('.input-1').rating('reset');
        }

    });

});