window.onload = function(){
    var $inputColor = $('#color-input');
    $inputColor.on('change', changeBackgroundColor);

    function changeBackgroundColor() {
        var $backgroundColor = $('#color-input').val();
        $('body').css('background-color', $backgroundColor);
    }
}