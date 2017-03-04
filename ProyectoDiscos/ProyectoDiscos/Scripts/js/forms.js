var Formulario = null;

$(document).ready(function() {
    /*$("#Create").submit(function (ev) {
        if ($("nombre").val().length > 0 && $("password").val().length > 0) {

        }
        else {
            ev.preventDefault();
        }
    }
        )*/
            $("#dialog").dialog({
                autoOpen: false,
                width: 'auto', // overcomes width:'auto' and maxWidth bug
                maxWidth: 600,
                height: 'auto',
                modal: true,
                fluid: true, //new option
                show: {
                    effect: "drop",
                    duration: 1000
                },
                hide: {
                    effect: "drop",
                    duration: 1000
                },
                resizable: true
            });

            $("#dialog2").dialog({
                autoOpen: false,
                width: 'auto', // overcomes width:'auto' and maxWidth bug
                maxWidth: 600,
                height: 'auto',
                modal: true,
                fluid: true, //new option
                show: {
                    effect: "drop",
                    duration: 1000
                },
                hide: {
                    effect: "drop",
                    duration: 1000
                },
                resizable: true
            });
  
            $("#LogIn").click(function() {
                $("#dialog").dialog('open');
            });

            $("#Register").click(function () {
                $("#dialog2").dialog('open');
            });
            
            //passwordNumeros();

            

            Formulario = new Formulario();

    });




// on window resize run function
$(window).resize(function () {
    fluidDialog();
});

// catch dialog if opened within a viewport smaller than the dialog width
$(document).on("dialogopen", ".ui-dialog", function (event, ui) {
    fluidDialog();
});





Formulario = function () {


    this.cargarDom();
}


Formulario.prototype.cargarDom = function () {

    this.passwordNumeros(0);
    this.passwordNumeros(1);

}



function fluidDialog ()
{
    var $visible = $(".ui-dialog:visible");
    // each open dialog
    $visible.each(function () {
        var $this = $(this);
        var dialog = $this.find(".ui-dialog-content").data("ui-dialog");
        // if fluid option == true
        if (dialog.options.fluid) {
            var wWidth = $(window).width();
            // check window width against dialog width
            if (wWidth < (parseInt(dialog.options.maxWidth) + 50))  {
                // keep dialog from filling entire screen
                $this.css("max-width", "90%");
            } else {
                // fix maxWidth bug
                $this.css("max-width", dialog.options.maxWidth + "px");
            }
            //reposition dialog
            dialog.option("position", dialog.options.position);
        }
    });

}


Formulario.prototype.passwordNumeros = function(num)
{

    var arrayNumeros = ['0','1','2','3','4','5','6','7','8','9'];
    this.shuffle(arrayNumeros);
    var enlace = document.createElement("a");
    var enlaceTexto = document.createTextNode("Limpiar password");
    enlace.setAttribute("href","#");
    enlace.addEventListener("click", this.limpiarPassword);
    enlace.appendChild(enlaceTexto);
    
    for(var i = 0; i < arrayNumeros.length; i++){
        var botonNumero = document.createElement("input");
        botonNumero.setAttribute("type","button");
        botonNumero.setAttribute("value", arrayNumeros[i]);
        botonNumero.addEventListener("click", this.escribirNumero, false);
        var numero = document.createTextNode(arrayNumeros[i]+ "   ");
        botonNumero.appendChild(numero);
        //var currentDiv = document.getElementsByType("password");
        var currentDiv =  document.querySelectorAll("[type='password']");
        //$("[type=password]").parentNode.appendChild(botonNumero);
        currentDiv[num].parentNode.appendChild(botonNumero);

    }
    //$("[type=password]").parentNode.appendChild(enlace);
    currentDiv[num].parentNode.appendChild(enlace);

}

Formulario.prototype.limpiarPassword = function()
{
    //document.getElementById("password").value = "";
    var password = document.querySelectorAll("[type='password']");
    password[0].value = "";
    password[1].value = "";
}

Formulario.prototype.escribirNumero = function(numero)
{
    //var password = document.getElementById("password");
    var password = document.querySelectorAll("[type='password']");
    password[0].value += numero.target.defaultValue;
    password[1].value += numero.target.defaultValue;
}

Formulario.prototype.shuffle = function(arrayNumeros)
{
        for (let i = arrayNumeros.length; i>0; i--) {
        let j = Math.floor(Math.random() * i);
        [arrayNumeros[i - 1], arrayNumeros[j]] = [arrayNumeros[j], arrayNumeros[i - 1]];
    }
}



  





