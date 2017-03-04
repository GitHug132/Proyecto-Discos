$(document).on('ready', function () {
    $('.input-1').rating({ min: 0, max: 10, step: 1, stars: 10 });

    $('.input-1').on('rating.change', function (event, value, caption) {

        var f = new Date();
        var fechaActual = "" + f.getFullYear() + "-" + (f.getMonth() + 1) + "-" + f.getDate() + " 00:00:00.000";

        //2013-06-05 00:00:00.000

        var puntuacion = {
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
                console.log(e.responseText)
            }
        });

        console.log(value);
        console.log(caption);
    });

});