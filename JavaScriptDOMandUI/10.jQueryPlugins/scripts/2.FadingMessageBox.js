(function ($) {
    $.fn.messageBox = function () {
        var $this = $(this);

        return {
            success: function (message) {
                func(message, 'green');
            },
            error: function (message) {
                func(message, 'red')
            }
        };

        function func(message, color) {
            $this
                .text(message)
                .css('color', color)
                .fadeIn(1000)
                .delay(3000)
                .fadeOut(1000);
            return $this;
        }
    };
}(jQuery));

var msgBox = $('#message-box').messageBox();
$('#success').click(function () {
    msgBox.success('Success message');
});
$('#error').click(function () {
    msgBox.error('Error message');
});