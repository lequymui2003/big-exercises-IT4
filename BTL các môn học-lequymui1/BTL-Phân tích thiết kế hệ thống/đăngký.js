$(document).ready(function(){
   $('#mat').click(function(){
       $(this).toggleClass('open');
       $(this).children('i').toggleClass(' fa-eye-slash fa-eye ');
       if($(this).hasClass('open')){
           $(this).prev().attr('type', 'text');
       }else{
           $(this).prev().attr('type', 'password');
       }
   });
});
$(document).ready(function(){
    $('#mat2').click(function(){
        $(this).toggleClass('open');
        $(this).children('i').toggleClass(' fa-eye-slash fa-eye ');
        if($(this).hasClass('open')){
            $(this).prev().attr('type', 'text');
        }else{
            $(this).prev().attr('type', 'password');
        }
    });
 });
 
