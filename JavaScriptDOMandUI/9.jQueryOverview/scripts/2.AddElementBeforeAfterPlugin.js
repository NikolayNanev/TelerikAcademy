(function ($) {
    $.fn.addBeforeElement = function (element) {
        var $currentElement = $(this);
        $currentElement.before(element);
    }

    $.fn.addAfterElement = function (element) {
        var $currentElement = $(this);
        $currentElement.after(element);
    }
}(jQuery));