// Joen Tai
// UOW ID: 7432100
// SIM ID: 10237942 

$(document).ready(function() {
    var current = 0;
    var images = [];
    images[0]="images/img1.jpg";
    images[1]="images/img2.jpg";
    images[2]="images/img3.jpg";

    window.setInterval(function(){
        if (current == 0)
        {
            $('.changeImages').attr('src', images[current]);
            $('.changeImages').click(function() {
                window.location.href = 'img1.html';
            })
        }
        else if (current == 1)
        {
            $('.changeImages').attr('src', images[current]);
            $('.changeImages').click(function() {
                window.location.href = 'img2.html';
            })
        }
        else if (current == 2)
        {
            $('.changeImages').attr('src', images[current]);
            $('.changeImages').click(function() {
                window.location.href = 'img3.html';
            })
        }
        current++; 
        if (current == 3) {
            current = 0;
        }
    },3000);
});