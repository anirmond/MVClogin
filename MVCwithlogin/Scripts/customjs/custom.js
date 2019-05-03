$(document).ready(function () {

   $('.register').click(function(e){
       var textBox = $('.mandate').val();
       var len = textBox.length;
       if (len == 0) {
           e.preventDefault();
       }
   })

})