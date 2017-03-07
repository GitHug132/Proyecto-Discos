/*Funcion para la respnsividad del menu de la web*/
$(document).ready(function () {

    var navoffeset = $(".header-bottom").offset().top;

           $(window).scroll(function(){
               var scrollpos=$(window).scrollTop();
               if(scrollpos >=navoffeset){
                   $(".header-bottom").addClass("fixed");
               }else{
                   $(".header-bottom").removeClass("fixed");
               }
           });

           $("span.menu").click(function () {
               $(".top-menu").slideToggle("slow", function () {
                   // Animation complete.
               });
           });

});
