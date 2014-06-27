(function ($) {
    $.fn.dropdown = function () {
        var $selectElement = $(this).hide(),
            $options = $selectElement.children('option');

        var options = [],
            len = $options.length;

        for (var j = 0; j < len; j++) {
            options.push({
                text: $($options[j]).html(),
                value: $($options[j]).val()
            });
        }

        var $dropdownContainer = $('<div>').addClass('dropdown-list-container').css('display', 'inline-block');
        var $dropdownList = $('<ul>').addClass('dropdown-list');
        var $optionSelection = $('<li>')
            .addClass('dropdown-list-selection')
            .text('Choose option')
            .attr('data-value', 'not-selected')
            .appendTo($dropdownList);

        for (var i = 0; i < len; i++) {
            var $currentOption = $('<li>')
                .addClass('dropdown-list-option')
                .attr('data-value', options[i].value)
                .text(options[i].text)
                .on('click', function () {
                    var $target = $(this);
                    $('.dropdown-list-option[selected]').removeAttr('selected');
                    $target.attr('selected', 'selected');
                    $optionSelection.text($target.text());
                    $optionSelection.attr('data-value', $target.attr('data-value'));
                    $('.dropdown-list-option').slideUp('fast');
                });

            $dropdownList.append($currentOption);
        }

        $allOptions = $optionSelection.siblings().hide();

        $optionSelection.on('click', function () {
            $allOptions.slideToggle();
        });

        $selectElement.after($dropdownContainer.append($dropdownList));
    }
}(jQuery));