
$(document).ready(function () {
  
    $('.rateCalculator').keyup(function () {
        var hoursWorked = $(this).val();
        var rate = $(this).data("rate");
        var total = hoursWorked * rate;
        $("#amount" + $(this).data("id")).text(total); 
    });

 
 

});



 