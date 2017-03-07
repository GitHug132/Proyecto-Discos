$(document).on('ready', function () {
    $('.input-1').rating({ min: 0, max: 10, step: 1, stars: 10 });

    $('.input-1').on('rating.change', function (event, value, caption) {

        var f = new Date();
        var fechaActual = "" + f.getFullYear() + "-" + (f.getMonth() + 1) + "-" + f.getDate() + " 00:00:00.000";


        toastr.options.closeButton = true;
        toastr.options.positionClass = "toast-bottom-right";

        toastr.success('<strong>Gracias</strong> por su voto.', '<i>Éxito</i>');
        toastr.warning('<strong>Error</strong> al votar.', 'Peligro');

        //2013-06-05 00:00:00.000
        //notification('success', '<strong>Gracias</strong> por su voto.');
        
        //notification('error', '<strong>Error</strong> al votar.');
        
        /*var puntuacion = {
            Idcliente: $("#Idcliente").text(),
            iddisco: $("#iddisco").text(),
            Puntuacion: value,
            Fecha: fechaActual,
        };
        var request = $.ajax({
            url: "webresources/vuelos/",
            type: "POST",
            contentType: 'application/json',
            data: JSON.stringify(puntuacion),
            dataType: "json",
            success: function (puntuacion) {
                
            },
            error: function (e) {
                //console.log(e.responseText)
                
            }
        });*/

        //console.log(value);
       // console.log(caption);
    });

});

/*function notification(type, message) {
    if (type == 'success') {
        
    } else if (type == 'error') {
        toastr.error(message, 'Error');
    } else if (type == 'warning') {
        
    } else {
        toastr.info(message, 'Información');
    }
}*/