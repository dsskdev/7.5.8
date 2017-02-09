$(document).ready(function() {
    $('.search.form-group').click(function () {
        if($(this).hasClass("active"))
        {
            $("input").animate({
                width: '10%'
            }, 350);
            $(this).removeClass('active');
            return false;
        }
        else
        {
            $(this).addClass('active');
            $("input").animate({
                width:'100%'
            }, 350);
            return false;
        }       
    });
});