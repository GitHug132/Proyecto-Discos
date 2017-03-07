$(document).on('ready', function () {
    
    $("#togle").click(function () {
        $("#lista").toggleClass("mostrar");
        //$("#lista").slideToggle( "slow" );
        $("#top").toggleClass("mostrar");
       // $("#lista").slideToggle("slow");
    });

});